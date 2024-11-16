using Microsoft.JSInterop;

namespace Agrolifenet.FrontEnd.Helpers
{
    public static class IJRuntaimeExtencionMetods
    {
        public static ValueTask<object> GuardarEnLocalStorage(this JSRuntime js, string llave, string contenido)
        {
            return js.InvokeAsync<object>("localStorage.setItem", llave, contenido);
        }

        public static ValueTask<object> ObtenerEnLocalStorage(this JSRuntime js, string llave)
        {
            return js.InvokeAsync<object>("localStorage.getItem", llave);
        }

        public static ValueTask<object> RemoverEnLocalStorage(this JSRuntime js, string llave)
        {
            return js.InvokeAsync<object>("localStorage.removeItem", llave);
        }
    }
}
