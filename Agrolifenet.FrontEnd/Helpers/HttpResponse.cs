namespace Agrolifenet.FrontEnd.Helpers
{
    public class HttpResponse<T>
    {
        public bool Error { get; set; }
        public T? Response { get; set; }
        public HttpResponseMessage? HttpResponseMessage { get; set; }

        public HttpResponse(T? response, bool error, HttpResponseMessage? httpResponseMessage)
        {
            Response = response;
            Error = error;
            HttpResponseMessage = httpResponseMessage;
        }

        public async Task<string?> ObetenerMensajeErrorAsync()
        {
            if (!Error)
            {
                return default!;
            }

            var codigoEstado = HttpResponseMessage!.StatusCode;

            switch (codigoEstado)
            {
                case System.Net.HttpStatusCode.NotFound:
                    return "Recurso No Encontrado";

                case System.Net.HttpStatusCode.BadRequest:
                    return await HttpResponseMessage.Content.ReadAsStringAsync();

                case System.Net.HttpStatusCode.Unauthorized:
                    return "Usuario o Contraseña Inconrrectos";

                case System.Net.HttpStatusCode.Forbidden:
                    return "No Autorizado";

                default:
                    return "Error Inesperado";
            }
        }
    }
}
