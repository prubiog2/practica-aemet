﻿using RestSharp;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UD3_Aemet
{
    public class ClienteAemet
    {
        private const string DIR = "https://opendata.aemet.es/opendata";
        private const string API_KEY = @"/?api_key=";
        
        public static string ApiKey { get; set; }
        static ClienteAemet()
        {
            ApiKey = ConfigurationManager.AppSettings["Aemet_Key"];
        }

        public static Dictionary<string, string> GenerateCODCcaa()
        {
            Dictionary<string, string> diccaa = new Dictionary<string, string>();

            diccaa.Add("Andalucía","and");
            diccaa.Add("Aragón", "arn");
            diccaa.Add("Asturias", "ast");
            diccaa.Add("Ballears, Illes", "bal");
            diccaa.Add("Canarias", "coo");
            diccaa.Add("Cantabria", "can");
            diccaa.Add("Castilla y León", "cle");
            diccaa.Add("Castilla - La Mancha", "clm");
            diccaa.Add("Cataluña", "cat");
            diccaa.Add("Comunitat Valenciana", "val");
            diccaa.Add("Extremadura", "ext");
            diccaa.Add("Galicia", "gal");
            diccaa.Add("Madrid, Comunidad de", "mad");
            diccaa.Add("Murcia, Región de", "mur");
            diccaa.Add("Navarra, Comunidad Foral de", "nav");
            diccaa.Add("País Vasco", "pva");
            diccaa.Add("Rioja", "rio");

                        return diccaa;
        }

        public static List<Estacion> InventarioTodasEstaciones()
        {
            const string INVENTARIO = "/api/valores/climatologicos/inventarioestaciones/todasestaciones";
            string uri = DIR + INVENTARIO + API_KEY + ApiKey;

            var client = new RestClient(uri);
            var request = new RestRequest(Method.GET);
            request.AddHeader("cache-control", "no-cache");
            var response = client.Execute(request);
            if(response.ResponseStatus == ResponseStatus.Completed)
            {
                var resp = JsonSerializer.Deserialize<Respuesta>(response.Content);
                if(resp.estado == Respuesta.OK)
                {
                    string datos = ClienteDatos.GetDatos(resp.datos);
                    return JsonSerializer.Deserialize<List<Estacion>>(datos);
                }
                else
                {
                    throw new ApplicationException("Error: " + resp.estado.ToString() + " " + resp.descripcion);
                }
            }
            else
            {
                throw new ApplicationException("Error: " + response.StatusCode.ToString() + " " + response.StatusDescription);
            }
        }

        public static string ValoresPrediccionComunidad(string ccaa)
        {
            string COMUNIDAD = $"/api/prediccion/ccaa/hoy/{ccaa}";
            string uri = DIR + COMUNIDAD + API_KEY + ApiKey;

            var client = new RestClient(uri);
            var request = new RestRequest(Method.GET);
            request.AddHeader("cache-control", "no-cache");
            var response = client.Execute(request);
            if (response.ResponseStatus == ResponseStatus.Completed)
            {
                var resp = JsonSerializer.Deserialize<Respuesta>(response.Content);
                if (resp.estado == Respuesta.OK)
                {
                    string datos = ClienteDatos.GetDatos(resp.datos);
                    return datos;
                }
                else
                {
                    throw new ApplicationException("Error: " + resp.estado.ToString() + " " + resp.descripcion);
                }
            }
            else
            {
                throw new ApplicationException("Error: " + response.StatusCode.ToString() + " " + response.StatusDescription);
            }
        }

        public static string ValoresPrediccionEspana()
        {
            const string ESPANA = "/api/prediccion/nacional/hoy";
            string uri = DIR + ESPANA + API_KEY + ApiKey;

            var client = new RestClient(uri);
            var request = new RestRequest(Method.GET);
            request.AddHeader("cache-control", "no-cache");
            var response = client.Execute(request);
            if (response.ResponseStatus == ResponseStatus.Completed)
            {
                var resp = JsonSerializer.Deserialize<Respuesta>(response.Content);
                if (resp.estado == Respuesta.OK)
                {
                    string datos = ClienteDatos.GetDatos(resp.datos);
                    return datos;
                }
                else
                {
                    throw new ApplicationException("Error: " + resp.estado.ToString() + " " + resp.descripcion);
                }
            }
            else
            {
                throw new ApplicationException("Error: " + response.StatusCode.ToString() + " " + response.StatusDescription);
            }
        }

        public static ValoresDiarios[] ValoresClimaDiario(string fechaIni, string fechaFin, string idema)
        {
            string diario = $"/api/valores/climatologicos/diarios/datos/fechaini/{fechaIni}/fechafin/{fechaFin}/estacion/{idema}";
            string uri = DIR + diario + API_KEY + ApiKey;
            var client = new RestClient(uri);
            var request = new RestRequest(Method.GET);
            request.AddHeader("cache-control", "no-cache");
            var response = client.Execute(request);

            if (response.ResponseStatus == ResponseStatus.Completed)
            {
                var resp = JsonSerializer.Deserialize<Respuesta>(response.Content);
                if (resp.estado == Respuesta.OK)
                {
                    string datos = ClienteDatos.GetDatos(resp.datos);
                    return JsonSerializer.Deserialize<ValoresDiarios[]>(datos);
                }
                else
                {
                    throw new ApplicationException("Error: " + resp.estado.ToString() + " " + resp.descripcion);
                }
            }
            else
            {
                throw new ApplicationException("Error: " + response.StatusCode.ToString() + " " + response.StatusDescription);
            }
        }


        public static PrediccionLocalidad[] ValoresClimaLocalidad(string codLocalidad)
        {
            string diario = $"/api/prediccion/especifica/municipio/diaria/{codLocalidad}";
            string uri = DIR + diario + API_KEY + ApiKey;
            var client = new RestClient(uri);
            var request = new RestRequest(Method.GET);
            request.AddHeader("cache-control", "no-cache");
            var response = client.Execute(request);

            if (response.ResponseStatus == ResponseStatus.Completed)
            {
                var resp = JsonSerializer.Deserialize<Respuesta>(response.Content);
                if (resp.estado == Respuesta.OK)
                {
                    string datos = ClienteDatos.GetDatos(resp.datos);
                    return PrediccionLocalidad.FromJson(datos);
                }
                else
                {
                    throw new ApplicationException("Error: " + resp.estado.ToString() + " " + resp.descripcion);
                }
            }
            else
            {
                throw new ApplicationException("Error: " + response.StatusCode.ToString() + " " + response.StatusDescription);
            }
        }
    }
}
