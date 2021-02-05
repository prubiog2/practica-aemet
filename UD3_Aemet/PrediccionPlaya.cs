namespace UD3_Aemet
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class PrediccionPlaya
    {
        public class Playa
        {
            public DateTime elaborado { get; set; }
            public string nombre { get; set; }
            public int localidad { get; set; }
            public Prediccion prediccion { get; set; }
            public int id { get; set; }
        }

        public class Prediccion
        {
            public Dia[] dia { get; set; }
        }

        public class Dia
        {
            //public Estadocielo estadoCielo { get; set; }
            public Viento viento { get; set; }
            public Oleaje oleaje { get; set; }
            public Tmaxima tMaxima { get; set; }
            public Stermica sTermica { get; set; }
            public Tagua tAgua { get; set; }
            public Uvmax uvMax { get; set; }
            public int fecha { get; set; }
            public Tmaxima1 tmaxima { get; set; }
            public Stermica1 stermica { get; set; }
            public Tagua1 tagua { get; set; }
        }

        public class Estadocielo
        {
            public string value { get; set; }
            public int f1 { get; set; }
            public string descripcion1 { get; set; }
            public int f2 { get; set; }
            public string descripcion2 { get; set; }
        }

        public class Viento
        {
            public string value { get; set; }
            public int f1 { get; set; }
            public string descripcion1 { get; set; }
            public int f2 { get; set; }
            public string descripcion2 { get; set; }
        }

        public class Oleaje
        {
            public string value { get; set; }
            public int f1 { get; set; }
            public string descripcion1 { get; set; }
            public int f2 { get; set; }
            public string descripcion2 { get; set; }
        }

        public class Tmaxima
        {
            public string value { get; set; }
            public int valor1 { get; set; }
        }

        public class Stermica
        {
            public string value { get; set; }
            public int valor1 { get; set; }
            public string descripcion1 { get; set; }
        }

        public class Tagua
        {
            public string value { get; set; }
            public int valor1 { get; set; }
        }

        public class Uvmax
        {
            public string value { get; set; }
            public int valor1 { get; set; }
        }

        public class Tmaxima1
        {
            public string value { get; set; }
            public int valor1 { get; set; }
        }

        public class Stermica1
        {
            public string value { get; set; }
            public int valor1 { get; set; }
            public string descripcion1 { get; set; }
        }

        public class Tagua1
        {
            public string value { get; set; }
            public int valor1 { get; set; }
        }


        //    [JsonProperty("origen")]
        //    public Origen Origen { get; set; }

        //    [JsonProperty("elaborado")]
        //    public DateTimeOffset Elaborado { get; set; }

        //    [JsonProperty("nombre")]
        //    public string Nombre { get; set; }

        //    [JsonProperty("localidad")]
        //    public long Localidad { get; set; }

        //    [JsonProperty("prediccion")]
        //    public Prediccion Prediccion { get; set; }

        //    [JsonProperty("id")]
        //    public long Id { get; set; }
        //}

        //public partial class OrigenPlaya
        //{
        //    [JsonProperty("productor")]
        //    public string Productor { get; set; }

        //    [JsonProperty("web")]
        //    public Uri Web { get; set; }

        //    [JsonProperty("language")]
        //    public string Language { get; set; }

        //    [JsonProperty("copyright")]
        //    public string Copyright { get; set; }

        //    [JsonProperty("notaLegal")]
        //    public Uri NotaLegal { get; set; }
        //}

        //public partial class PrediccionPlaya
        //{
        //    [JsonProperty("dia")]
        //    public DiaPlaya[] Dia { get; set; }
        //}

        //public partial class DiaPlaya
        //{
        //    [JsonProperty("estadoCielo")]
        //    public EstadoCieloPlaya EstadoCieloPlaya { get; set; }

        //    [JsonProperty("viento")]
        //    public EstadoCieloPlaya Viento { get; set; }

        //    [JsonProperty("oleaje")]
        //    public EstadoCieloPlaya Oleaje { get; set; }

        //    [JsonProperty("tMaxima")]
        //    public TAgua TMaxima { get; set; }

        //    [JsonProperty("sTermica")]
        //    public Termica STermica { get; set; }

        //    [JsonProperty("tAgua")]
        //    public TAgua TAgua { get; set; }

        //    [JsonProperty("uvMax")]
        //    public TAgua UvMax { get; set; }

        //    [JsonProperty("fecha")]
        //    public long Fecha { get; set; }

        //    [JsonProperty("tmaxima")]
        //    public TAgua Tmaxima { get; set; }

        //    [JsonProperty("stermica")]
        //    public Termica Stermica { get; set; }

        //    [JsonProperty("tagua")]
        //    public TAgua Tagua { get; set; }
        //}

        //public partial class EstadoCieloPlaya
        //{
        //    [JsonProperty("value")]
        //    public string Value { get; set; }

        //    [JsonProperty("f1")]
        //    public long F1 { get; set; }

        //    [JsonProperty("descripcion1")]
        //    public string Descripcion1 { get; set; }

        //    [JsonProperty("f2")]
        //    public long F2 { get; set; }

        //    [JsonProperty("descripcion2")]
        //    public string Descripcion2 { get; set; }
        //}

        //public partial class Termica
        //{
        //    [JsonProperty("value")]
        //    public string Value { get; set; }

        //    [JsonProperty("valor1")]
        //    public long Valor1 { get; set; }

        //    [JsonProperty("descripcion1")]
        //    public string Descripcion1 { get; set; }
        //}

        //public partial class TAgua
        //{
        //    [JsonProperty("value")]
        //    public string Value { get; set; }

        //    [JsonProperty("valor1")]
        //    public long Valor1 { get; set; }
        //}

        //public partial class PrediccionPlaya
        //{
        //    public static PrediccionPlaya[] FromJson(string json) => JsonConvert.DeserializeObject<PrediccionPlaya[]>(json, UD3_Aemet.Converter.Settings);
        //}

        //public static class SerializePlaya
        //{
        //    public static string ToJson(this PrediccionPlaya[] self) => JsonConvert.SerializeObject(self, UD3_Aemet.Converter.Settings);
        //}
    }
}
