using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cine_Back.Entidades.Compras;
using Flurl.Http;

namespace CineFront.Servicios
{
    public class ClienteSingleton
    {
        private static ClienteSingleton instance;
        private HttpClient client;
        private ClienteSingleton()
        {
            client = new HttpClient();
        }

        public static ClienteSingleton getI()
        {
            if (instance == null)
            {
                instance = new ClienteSingleton();
            }
            return instance;
        }

        public async Task<string> GetAsync(string url)
        {
            var result = await client.GetAsync(url);
            var content = "";
            if (result.IsSuccessStatusCode)
            {
                content = await result.Content.ReadAsStringAsync();
            }
            return content;
        }

        public async Task<string> PostAsync(string urlPost)
        {
            //StringContent content = new StringContent(dataJson, Encoding.UTF8, "application/json");

            HttpResponseMessage responseHTTP = await client.PostAsync(urlPost, null);
            var response = "";
            if (responseHTTP.IsSuccessStatusCode)
            {
                response = await responseHTTP.Content.ReadAsStringAsync();
            }
            return response;
        }

        public async Task<string> PostAsync(string url, string data)
        {
            /*StringContent content = new StringContent(data, Encoding.UTF8,
            "application/json");*/
            StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
            Console.WriteLine("Request Content: " + data);
            var result = await client.PostAsync(url, content);

            var response = "";
            if (result.IsSuccessStatusCode)
                response = await result.Content.ReadAsStringAsync();
            return response;
        }

            public async Task<string> PostAsync(string urlPost, Compra com)
        {
            try
            {
                var response = await urlPost
                    .PostJsonAsync(com)
                    .ReceiveString();

                return response;
            }
            catch (FlurlHttpException ex)
            {
                // Puedes manejar las excepciones específicas de Flurl aquí, si es necesario
                // ex.Message contiene información sobre el error
                return $"Error: {ex.Message}";
            }
        }

        public async Task<string> PutAsync(string url, string data)
        {
            StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
            var result = await client.PutAsync(url, content);
            var response = "";
            if (result.IsSuccessStatusCode)
                response = await result.Content.ReadAsStringAsync();
            return response;
        }

        public async Task<string> DeleteAsync(string url)
        {

            var result = await client.DeleteAsync(url);
            var response = "";
            if (result.IsSuccessStatusCode)
                response = await result.Content.ReadAsStringAsync();
            return response;
        }

        public async Task<int> GetNextFuncionIdAsync()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    // Cambia la URL según tu configuración
                    string apiUrl = "https://localhost:7114/NextFuncionId";

                    HttpResponseMessage response = await client.GetAsync(apiUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        string content = await response.Content.ReadAsStringAsync();
                        if (int.TryParse(content, out int id))
                        {
                            return id;
                        }
                        else
                        {
                            // Manejar el error si la respuesta no es un entero
                            throw new Exception("La respuesta no es un entero válido.");
                        }
                    }
                    else
                    {
                        // Manejar el error según sea necesario
                        throw new Exception($"Error en la respuesta del servidor: {response.StatusCode}");
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al realizar la solicitud HTTP: {ex.Message}");
            }
        }
    }
}
