using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaCaptchas
{
    class Seniat
    {
        public string RifEmpresa { get; set; }
        public string NombreEmpresa { get; set; }
        public string OcupacionEmpresa { get; set; }

        public string CodigoCaptcha { get; set; }

        public string Prueba { get; set; }

        public void BuscarNombre(string text)
        {
            var inicio = text.IndexOf(" ");
            var fin = text.Length;

            NombreEmpresa = text.Substring(inicio, fin - inicio).Trim();
        }

        public void BuscarOcupacion(string text)
        {
            var inicio = text.IndexOf("mica:") + 5;
            var fin = text.IndexOf("Condic");

            OcupacionEmpresa = text.Substring(inicio, fin - inicio).Trim();
        }

    }
}
