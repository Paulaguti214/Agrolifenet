using Agrolifenet.FrontEnd.Helpers;

namespace Agrolifenet.FrontEnd.Http
{
    public interface IHttpConsumir
    {
        Task<HttpResponse<object>> PostAsync<T>(string url, T enviar);
        Task<HttpResponse<TResponse>> PostAsync<T, TResponse>(string url, T enviar);
        Task<HttpResponse<TResponse>> GetAsync<TResponse>(string url);
    }
}
