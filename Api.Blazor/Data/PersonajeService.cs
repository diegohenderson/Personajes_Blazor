using Api.Blazor.Modelos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;

using System.Text.Unicode;
using System.Threading.Tasks;

namespace Api.Blazor.Data
{
    public class PersonajeServices
    {

        public async Task<Personaje> GetTaskByIdAsync()
        {
            HttpClient httpClient = new HttpClient();
            var personaje = await httpClient.GetAsync("https://localhost:44383/api/personajes/3");
            var response = personaje.Content.ReadAsStringAsync();
            Personaje personaje1 = JsonConvert.DeserializeObject<Personaje>(response.Result);
            return personaje1;
        }

        public async Task<Personaje> PostTaskByIdAsync()
        {
            HttpClient httpClient = new HttpClient();
            Personaje personaje = new Personaje();
            personaje.Id = 0;
            personaje.Nombre = "Ned";
            personaje.Apellido = "Flanders";
            personaje.Localizacion = "Sringfield";
            var objetojsoneado = new StringContent(JsonConvert.SerializeObject(personaje), System.Text.Encoding.UTF8, "application/json");
            var response = await httpClient.PostAsync("https://localhost:44383/api/personajes/", objetojsoneado);
            

            
            return personaje;
        }
    }
}
