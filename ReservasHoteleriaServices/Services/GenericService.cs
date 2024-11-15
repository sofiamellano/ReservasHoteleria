using ReservasHoteleriaServices.Class;
using ReservasHoteleriaServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ReservasHoteleriaServices.Services
{
    public class GenericService<T>: IGenericService<T> where T : class
    {
        protected readonly HttpClient client;
        protected readonly JsonSerializerOptions options;
        protected readonly string _endpoint;

        public GenericService()
        {
            this.client = new HttpClient();
            this.options = new JsonSerializerOptions() { PropertyNameCaseInsensitive = true };
            var urlApi = Properties.Resources.UrlApi;
            this._endpoint = urlApi + ApiEndpoints.GetEndpoint(typeof(T).Name);
        }

        public async Task<List<T>?> GetAllAsync()
        {
            var response = await client.GetAsync(_endpoint);
            var content = await response.Content.ReadAsStringAsync();
            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException(content?.ToString());
            }
            return JsonSerializer.Deserialize<List<T>>(content, options); ;
        }

        public async Task<T?> GetByIdAsync(int id)
        {
            var response = await client.GetAsync($"{_endpoint}/{id}");
            var content = await response.Content.ReadAsStreamAsync();
            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException(content?.ToString());
            }
            return JsonSerializer.Deserialize<T>(content, options);
        }

        public async Task<T?> AddAsync(T? entity)
        {
            var response = await client.PostAsJsonAsync(_endpoint, entity);
            var content = await response.Content.ReadAsStringAsync();
            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException($"Error al hacer la solicitud: {response.StatusCode} - {content}");
            }
            return JsonSerializer.Deserialize<T>(content, options);
        }


        public async Task UpdateAsync(T? entity)
        {

            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity), "Entity cannot be null");
            }

            var idProperty = entity.GetType().GetProperty("ID"); // Cambiado de "Id" a "ID"
            if (idProperty == null)
            {
                throw new InvalidOperationException("La entidad no tiene una propiedad 'ID'");
            }

            var idValue = idProperty.GetValue(entity);
            if (idValue == null || (int)idValue == 0)
            {
                throw new InvalidOperationException("El valor de la propiedad 'ID' no puede ser null o 0");
            }

            var response = await client.PutAsJsonAsync($"{_endpoint}/{idValue}", entity);
            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException(response?.ToString());
            }
            //var idValue = entity.GetType().GetProperty("Id").GetValue(entity);

            //var response = await client.PutAsJsonAsync($"{_endpoint}/{idValue}", entity);
            //if (!response.IsSuccessStatusCode)
            //{
            //    throw new ApplicationException(response?.ToString());
            //}
        }

        public async Task DeleteAsync(int id)
        {
            var response = await client.DeleteAsync($"{_endpoint}/{id}");
            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException(response.ToString());
            }
        }
    }
}
