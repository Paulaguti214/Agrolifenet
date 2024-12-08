using Agrolifenet.FrontEnd.Helpers;
using System.Text;
using System.Text.Json;

namespace Agrolifenet.FrontEnd.Http
{
    public class HttpConsumir : IHttpConsumir
    {
        private readonly HttpClient _httpClient;
        private JsonSerializerOptions OpcionesPorDefectoJSON => new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };

        public HttpConsumir(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<HttpResponse<TResponse>> PostAsync<T, TResponse>(string url, T enviar)
        {
            var enviarJSON = JsonSerializer.Serialize(enviar);
            var enviarContent = new StringContent(enviarJSON, Encoding.UTF8, "application/json");
            var responseHttp = await _httpClient.PostAsync(url, enviarContent);

            if (responseHttp.IsSuccessStatusCode)
            {
                var response = await DeserializarRespuesta<TResponse>(responseHttp,
                    OpcionesPorDefectoJSON);
                return new HttpResponse<TResponse>(response, error: false, responseHttp);
            }

            return new HttpResponse<TResponse>(default,
                !responseHttp.IsSuccessStatusCode, responseHttp);
        }

        public async Task<HttpResponse<object>> PostAsync<T>(string url, T enviar)
        {
            var respuesta = await _httpClient.PostAsync(url, new StringContent(JsonSerializer.Serialize(enviar), Encoding.UTF8, "application/json"));
            return new HttpResponse<object>(default!, !respuesta.IsSuccessStatusCode, respuesta);
        }

        private async Task<T> DeserializarRespuesta<T>(HttpResponseMessage httpResponse,
           JsonSerializerOptions jsonSerializerOptions)
        {
            var respuestaString = await httpResponse.Content.ReadAsByteArrayAsync();
            return JsonSerializer.Deserialize<T>(respuestaString, jsonSerializerOptions)!;
        }

        public async Task<HttpResponse<TResponse>> GetAsync<TResponse>(string url)
        {
            var respuesta = await _httpClient.GetAsync(url);
            if (respuesta.IsSuccessStatusCode)
            {
                var response = await DeserializarRespuesta<TResponse>(respuesta,
                    OpcionesPorDefectoJSON);
                return new HttpResponse<TResponse>(response, error: false, respuesta);
            }

            return new HttpResponse<TResponse>(default!, !respuesta.IsSuccessStatusCode, respuesta);
        }

        public async Task<HttpResponse<object>> DeleleteAsync(string url)
        {
            var respuesta = await _httpClient.DeleteAsync(url);
            return new HttpResponse<object>(default!, !respuesta.IsSuccessStatusCode, respuesta);


        }

        public async Task<HttpResponse<object>> PutAsync<T>(string url, T enviar)
        {
            var respuesta = await _httpClient.PutAsync(url, new StringContent(JsonSerializer.Serialize(enviar), Encoding.UTF8, "application/json"));
            return new HttpResponse<object>(default!, !respuesta.IsSuccessStatusCode, respuesta);
        }

        public async Task<HttpResponse<byte[]>> GetFileAsync<TRespuesta>(string url)
        {
            var respuesta = await _httpClient.GetAsync(url);
            if (respuesta.IsSuccessStatusCode)
            {
                return new HttpResponse<byte[]>(await respuesta.Content.ReadAsByteArrayAsync(), !respuesta.IsSuccessStatusCode, respuesta);
            }

            return default!;
        }
    }
}
