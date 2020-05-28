using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Api.Blazor.Data
{
    public class GenericServices<T> where T : class
    {
        


        public static async Task<List<T>> GetAllAsync(string Url)
        {
            HttpClient httpClient = new HttpClient();
            var request = await httpClient.GetAsync(Url);
            var response = request.Content.ReadAsStringAsync();
            List<T> Salida = JsonConvert.DeserializeObject<List<T>>(response.Result);
            return Salida;
        }
        public static async Task<T> GetTaskByIdAsync(int Id, string Url)
        {
            HttpClient httpClient = new HttpClient();
            var request = await httpClient.GetAsync(Url + Id.ToString());
            var response = request.Content.ReadAsStringAsync();
            T Salida = JsonConvert.DeserializeObject<T>(response.Result);
            return Salida;
        }

        public static async Task<bool> PostAsync(string Url, T objeto)
        {
            HttpClient httpClient = new HttpClient();
            var objetojsoneado = new StringContent(JsonConvert.SerializeObject(objeto), System.Text.Encoding.UTF8, "application/json");
            var response = await httpClient.PostAsync(Url, objetojsoneado);
            return true;
        }
    }


}

