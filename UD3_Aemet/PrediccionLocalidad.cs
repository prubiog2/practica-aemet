using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UD3_Aemet
{

    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class PrediccionLocalidad
    {
        [JsonProperty("origen")]
        public Origen Origen { get; set; }

        [JsonProperty("elaborado")]
        public DateTimeOffset Elaborado { get; set; }

        [JsonProperty("nombre")]
        public string Nombre { get; set; }

        [JsonProperty("provincia")]
        public string Provincia { get; set; }

        [JsonProperty("prediccion")]
        public Prediccion Prediccion { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("version")]
        public long Version { get; set; }
    }

    public partial class Origen
    {
        [JsonProperty("productor")]
        public string Productor { get; set; }

        [JsonProperty("web")]
        public Uri Web { get; set; }

        [JsonProperty("enlace")]
        public Uri Enlace { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("copyright")]
        public string Copyright { get; set; }

        [JsonProperty("notaLegal")]
        public Uri NotaLegal { get; set; }
    }

    public partial class Prediccion
    {
        [JsonProperty("dia")]
        public Dia[] Dia { get; set; }
    }

    public partial class Dia
    {
        [JsonProperty("probPrecipitacion")]
        public ProbPrecipitacion[] ProbPrecipitacion { get; set; }

        [JsonProperty("cotaNieveProv")]
        public CotaNieveProv[] CotaNieveProv { get; set; }

        [JsonProperty("estadoCielo")]
        public EstadoCielo[] EstadoCielo { get; set; }

        [JsonProperty("viento")]
        public Viento[] Viento { get; set; }

        [JsonProperty("rachaMax")]
        public CotaNieveProv[] RachaMax { get; set; }

        [JsonProperty("temperatura")]
        public HumedadRelativa Temperatura { get; set; }

        [JsonProperty("sensTermica")]
        public HumedadRelativa SensTermica { get; set; }

        [JsonProperty("humedadRelativa")]
        public HumedadRelativa HumedadRelativa { get; set; }

        [JsonProperty("uvMax", NullValueHandling = NullValueHandling.Ignore)]
        public long? UvMax { get; set; }

        [JsonProperty("fecha")]
        public DateTimeOffset Fecha { get; set; }
    }

    public partial class CotaNieveProv
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("periodo", NullValueHandling = NullValueHandling.Ignore)]
        public string Periodo { get; set; }
    }

    public partial class EstadoCielo
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("periodo", NullValueHandling = NullValueHandling.Ignore)]
        public string Periodo { get; set; }

        [JsonProperty("descripcion")]
        public string Descripcion { get; set; }
    }

    public partial class HumedadRelativa
    {
        [JsonProperty("maxima")]
        public long Maxima { get; set; }

        [JsonProperty("minima")]
        public long Minima { get; set; }

        [JsonProperty("dato")]
        public Dato[] Dato { get; set; }
    }

    public partial class Dato
    {
        [JsonProperty("value")]
        public long Value { get; set; }

        [JsonProperty("hora")]
        public long Hora { get; set; }
    }

    public partial class ProbPrecipitacion
    {
        [JsonProperty("value")]
        public long Value { get; set; }

        [JsonProperty("periodo", NullValueHandling = NullValueHandling.Ignore)]
        public string Periodo { get; set; }
    }

    public partial class Viento
    {
        [JsonProperty("direccion")]
        public string Direccion { get; set; }

        [JsonProperty("velocidad")]
        public long Velocidad { get; set; }

        [JsonProperty("periodo", NullValueHandling = NullValueHandling.Ignore)]
        public string Periodo { get; set; }
    }

    public partial class PrediccionLocalidad
    {
        public static PrediccionLocalidad[] FromJson(string json) => JsonConvert.DeserializeObject<PrediccionLocalidad[]>(json, UD3_Aemet.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this PrediccionLocalidad[] self) => JsonConvert.SerializeObject(self, UD3_Aemet.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
        {
            new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
        },
        };
    }
}

