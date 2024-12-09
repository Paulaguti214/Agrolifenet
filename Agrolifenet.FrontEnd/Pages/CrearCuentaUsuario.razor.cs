using Agrolifenet.FrontEnd.Http;
using Agrolifenet.FrontEnd.Modelos;
using CurrieTechnologies.Razor.SweetAlert2;
using Microsoft.AspNetCore.Components;

namespace Agrolifenet.FrontEnd.Pages
{
    public partial class CrearCuentaUsuario : ComponentBase
    {
        [Inject]
        IHttpConsumir HttpConsumir { get; set; } = default!;

        [Inject]
        SweetAlertService Swal { get; set; } = default!;

        [Inject]
        private NavigationManager Navigation { get; set; } = default!;

        private UsuarioDto Usuario = new();

        private async Task OnValidSubmit()
        {
            var resultado = await HttpConsumir.PostAsync("/api/Cuenta/CrearCuenta", Usuario);

            if (resultado.Error)
            {
                await Swal.FireAsync("Error", await resultado.ObetenerMensajeErrorAsync(), SweetAlertIcon.Error);
            }
            else
            {
                await Swal.FireAsync("Usuario Creado. ahora iniciar sesión", "Se Autentico Correctamente", SweetAlertIcon.Success);
                Navigation.NavigateTo("/", true);
            }
        }

    }
}
