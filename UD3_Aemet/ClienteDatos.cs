using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace UD3_Aemet
{
    public static class ClienteDatos
    {
        private static readonly HttpClient client = new HttpClient();
        public static string GetDatos(string uri)
        {
            Task<string> resp = client.GetStringAsync(uri);
            return resp.Result;
        }
    }
}
