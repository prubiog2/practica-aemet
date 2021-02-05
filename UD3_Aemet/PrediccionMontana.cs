namespace UD3_Aemet
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class PrediccionMontana
    {
        [JsonProperty("origen")]
        public Origen Origen { get; set; }

        [JsonProperty("seccion")]
        public Seccion[] Seccion { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("nombre")]
        public string Nombre { get; set; }
    }

    public partial class OrigenMontana
    {
        [JsonProperty("productor")]
        public string Productor { get; set; }

        [JsonProperty("web")]
        public Uri Web { get; set; }

        [JsonProperty("tipo")]
        public string Tipo { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("copyright")]
        public string Copyright { get; set; }

        [JsonProperty("notaLegal")]
        public Uri NotaLegal { get; set; }
    }

    public partial class Seccion
    {
        [JsonProperty("apartado")]
        public Apartado[] Apartado { get; set; }

        [JsonProperty("lugar")]
        public Lugar[] Lugar { get; set; }

        [JsonProperty("parrafo")]
        public object[] Parrafo { get; set; }

        [JsonProperty("nombre")]
        public string Nombre { get; set; }
    }

    public partial class Apartado
    {
        [JsonProperty("cabecera")]
        public string Cabecera { get; set; }

        [JsonProperty("texto")]
        public string Texto { get; set; }

        [JsonProperty("nombre")]
        public string Nombre { get; set; }
    }

    public partial class Lugar
    {
        [JsonProperty("minima")]
        public long Minima { get; set; }

        [JsonProperty("stminima")]
        public long Stminima { get; set; }

        [JsonProperty("maxima")]
        public long Maxima { get; set; }

        [JsonProperty("stmaxima")]
        public long Stmaxima { get; set; }

        [JsonProperty("nombre")]
        public string Nombre { get; set; }

        [JsonProperty("altitud")]
        public string Altitud { get; set; }
    }

    public partial class PrediccionMontana
    {
        public static PrediccionMontana[] FromJson(string json) => JsonConvert.DeserializeObject<PrediccionMontana[]>(json, UD3_Aemet.Converter.Settings);
    }

    public static class SerializeMontana
    {
        public static string ToJson(this PrediccionMontana[] self) => JsonConvert.SerializeObject(self, UD3_Aemet.Converter.Settings);
    }

}
