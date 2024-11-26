using Agrolifenet.FrontEnd.Http;
using CurrieTechnologies.Razor.SweetAlert2;
using Microsoft.AspNetCore.Components;

namespace Agrolifenet.FrontEnd.Componentes.Formularios
{
    public partial class CrearCuentaUsuarioComponente : ComponentBase
    {

        [Inject]
        IHttpConsumir HttpConsumir { get; set; } = default!;

        [Inject]
        SweetAlertService Swal { get; set; } = default!;
        [Inject]
        private NavigationManager Navigation { get; set; } = default!;
    }
}
