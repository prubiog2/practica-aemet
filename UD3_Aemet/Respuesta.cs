using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UD3_Aemet
{
    public class Respuesta
    {
        public const int OK = 200;
        public string descripcion { get; set; }
        public int estado { get; set; }
        public string datos { get; set; }
        public string metadatos { get; set; }
    }

    public class Estacion
    {
        public string latitud { get; set; }
        public string provincia { get; set; }
        public string altitud { get; set; }
        public string indicativo { get; set; }
        public string nombre { get; set; }
        public string indsinop { get; set; }
        public string longitud { get; set; }
    }


    public class ValoresDiarios
    {
        public string fecha { get; set; }
        public string indicativo { get; set; }
        public string nombre { get; set; }
        public string provincia { get; set; }
        public string altitud { get; set; }
        public string tmed { get; set; }
        public string prec { get; set; }
        public string tmin { get; set; }
        public string horatmin { get; set; }
        public string tmax { get; set; }
        public string horatmax { get; set; }
        public string dir { get; set; }
        public string velmedia { get; set; }
        public string racha { get; set; }
        public string horaracha { get; set; }
        public string sol { get; set; }
        public string presMax { get; set; }
        public string horaPresMax { get; set; }
        public string presMin { get; set; }
        public string horaPresMin { get; set; }
    }
}

