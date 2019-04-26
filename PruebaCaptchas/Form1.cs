using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tesseract;
using ImageMagick;
using mshtml;
using System.IO;
using System.Threading;

namespace PruebaCaptchas
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

            comboBoxLetra.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            var continuar = true;

            var htmlLink = @"http://contribuyente.seniat.gob.ve/BuscaRif/BuscaRif.jsp";
            Seniat seniat = new Seniat();

            int conteoInicio = int.Parse(numericUpDownInicio.Value.ToString());
            int conteoFin = int.Parse(numericUpDownFin.Value.ToString());

            for (int i = conteoInicio; i <= conteoFin; i++)
            {
                continuar = true;
                var rifActual = comboBoxLetra.SelectedItem + i.ToString("D9");

                while (continuar)
                {
                    try
                    {
                        if (!webBrowser1.Document.Body.InnerText.Contains("webpage was canceled") && !webBrowser1.Document.Body.InnerText.Contains("reach this page"))
                        {
                            toolStripStatusLabel1.Text = "RIF ACTUAL: " + rifActual + " - CONECTADO!";

                            WaitNSeconds(1000);

                            CreateImageCaptcha();

                            var testImagePath = TransformCaptcha();

                            //using (var engine = new TesseractEngine(@"C:\Users\arman\OneDrive\Documentos\Visual Studio 2019\Projects\PruebaCaptchas\PruebaCaptchas\tessdata", "eng", EngineMode.Default))
                            using (var engine = new TesseractEngine(@"tessdata", "eng", EngineMode.Default))
                            {
                                using (var img = Pix.LoadFromFile(testImagePath))
                                {
                                    using (var page = engine.Process(img))
                                    {
                                        var text = page.GetText();

                                        textBoxConfidence.Text = page.GetMeanConfidence().ToString();

                                        seniat.CodigoCaptcha = text.ToString().Replace("  ", "").Replace(" ", "");
                                        textBoxCodeImage.Text = seniat.CodigoCaptcha;
                                    }
                                }
                            }

                            webBrowser1.Document.GetElementsByTagName("input").Cast<HtmlElement>().FirstOrDefault(m => m.GetAttribute("id") == "p_rif").SetAttribute("value", rifActual);
                            webBrowser1.Document.GetElementsByTagName("input").Cast<HtmlElement>().FirstOrDefault(m => m.GetAttribute("id") == "codigo").SetAttribute("value", seniat.CodigoCaptcha);

                            var button = webBrowser1.Document.GetElementsByTagName("input").Cast<HtmlElement>().FirstOrDefault(m => m.GetAttribute("name") == "busca");

                            if (button != null)
                            {
                                button.InvokeMember("click");
                            }

                            WaitNSeconds(1000);

                            var captchaIncorrecto = true;
                            while (captchaIncorrecto)
                            {
                                try
                                {
                                    var resultado = webBrowser1.Document.Body.GetElementsByTagName("font")[1].InnerText;

                                    if (resultado.Contains("No existe"))
                                    {
                                        continuar = false;
                                    }
                                    else if(resultado.Contains(rifActual))
                                    {
                                        var ocupacion = webBrowser1.Document.Body.GetElementsByTagName("font")[2].InnerText;

                                        seniat.RifEmpresa = rifActual;
                                        seniat.BuscarOcupacion(ocupacion);
                                        seniat.BuscarNombre(resultado);

                                        dataGridViewDatosEmpresa.Rows.Add(seniat.RifEmpresa, seniat.NombreEmpresa, seniat.OcupacionEmpresa);


                                        continuar = false;
                                    }
                                    else if(resultado == " ")
                                    {
                                        throw new System.NullReferenceException(null);
                                    }
                                    else
                                    {
                                        continuar = true;
                                    }

                                    captchaIncorrecto = false;
                                }
                                catch (NullReferenceException ex)
                                {
                                    throw new System.NullReferenceException(null);
                                }
                                catch(Exception ex)
                                {
                                    captchaIncorrecto = false;
                                    //intentos++;
                                }
                            }
                        }
                        else
                        {
                            throw new System.NullReferenceException(null);
                        }
                    }
                    catch(NullReferenceException ex)
                    {
                        webBrowser1.Navigate(htmlLink);

                         DateTime _desired = DateTime.Now.AddMilliseconds(3000);
                         while (webBrowser1.ReadyState != WebBrowserReadyState.Complete && DateTime.Now < _desired)
                         {
                             toolStripStatusLabel1.Text = "RIF ACTUAL: " + rifActual + " - Conectando a la pagina. . .";
                             Application.DoEvents();
                         }

                        continuar = true;
                    }
                }
            }

            toolStripStatusLabel1.Text = "Numero de Rif: " + seniat.RifEmpresa + " - Scrapeo Terminado!";
        }

        private void WebBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void WaitNSeconds(int milisegundos)
        {
            if (milisegundos < 1) return;
            DateTime _desired = DateTime.Now.AddMilliseconds(milisegundos);
            while (DateTime.Now < _desired)
            {
                System.Windows.Forms.Application.DoEvents();
            }
        }

        public void CreateImageCaptcha()
        {
            IHTMLElement2 doc = (IHTMLElement2)webBrowser1.Document.Body.DomElement;
            var controlRange = (IHTMLControlRange)((HTMLBody)doc).createControlRange();
            foreach (IHTMLImgElement img in doc.getElementsByTagName("img"))
            {
                controlRange.add((IHTMLControlElement)img);
                controlRange.execCommand("Copy", false, null);
                pictureBoxCaptcha.Image = (Bitmap)Clipboard.GetDataObject().GetData(DataFormats.Bitmap);

                if(pictureBoxCaptcha.Image != null)
                {
                    // si quieres lo puedes salvar asi     
                    using (Bitmap bmp = (Bitmap)Clipboard.GetDataObject().GetData(DataFormats.Bitmap))
                    {
                        bmp.Save("CaptchaWebBrowser.bmp");
                    }

                    // Read first frame of gif image
                    using (MagickImage image = new MagickImage("CaptchaWebBrowser.bmp"))
                    {
                        // Save frame as jpg
                        image.Write("CaptchaConvertido.jpg");
                    }
                }
            }
            
        }

        public string TransformCaptcha()
        {

            //var testImagePath = @"C:\Users\arman\OneDrive\Documentos\Visual Studio 2019\Projects\PruebaCaptchas\PruebaCaptchas\bin\Debug\CaptchaConvertido.jpg";
            var testImagePath = @"CaptchaConvertido.jpg";
            using (MagickImage image = new MagickImage(testImagePath))
            {
                image.Negate();
                image.ColorSpace = ColorSpace.Gray;
                image.Threshold(new Percentage(70));
                image.Write("resultado.png");
            }

            //testImagePath = @"C:\Users\arman\OneDrive\Documentos\Visual Studio 2019\Projects\PruebaCaptchas\PruebaCaptchas\bin\Debug\resultado.png";
            testImagePath = @"resultado.png";
            using (MagickImage image = new MagickImage(testImagePath))
            {
                image.Negate();
                image.Morphology(MorphologyMethod.Erode, Kernel.Diamond); // Kernel.Diamond o Kernel.Rectangle
                image.Negate();
                image.Write("resultado2.png");
            }


            //testImagePath = @"C:\Users\arman\OneDrive\Documentos\Visual Studio 2019\Projects\PruebaCaptchas\PruebaCaptchas\bin\Debug\resultado2.png";
            testImagePath = @"resultado2.png";
            using (MagickImage image = new MagickImage(testImagePath))
            {
                image.Morphology(MorphologyMethod.Erode, Kernel.Square); // Kernet.Square
                image.Write("resultado3.png");
            }
            //testImagePath = @"C:\Users\arman\OneDrive\Documentos\Visual Studio 2019\Projects\PruebaCaptchas\PruebaCaptchas\bin\Debug\resultado3.png";
            testImagePath = @"resultado3.png";

            return testImagePath;
        }
        
    }
}
