using Agrolifenet.FrontEnd.Helpers;

namespace Agrolifenet.FrontEnd.Http
{
    public interface IHttpConsumir
    {
        Task<HttpResponse<object>> PostAsync<ElementoEnviar>(string url, ElementoEnviar enviar);
        Task<HttpResponse<TRespuesta>> PostAsync<ElementoEnviar, TRespuesta>(string url, ElementoEnviar enviar);
        Task<HttpResponse<TRespuesta>> GetAsync<TRespuesta>(string url);
        Task<HttpResponse<byte[]>> GetFileAsync<TRespuesta>(string url);
        Task<HttpResponse<object>> DeleleteAsync(string url);
        Task<HttpResponse<object>> PutAsync<ElementoEnviar>(string url, ElementoEnviar enviar);



    }
}
