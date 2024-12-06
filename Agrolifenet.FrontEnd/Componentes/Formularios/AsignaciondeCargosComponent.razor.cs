using Agrolifenet.FrontEnd.Http;
using Agrolifenet.FrontEnd.Modelos;
using CurrieTechnologies.Razor.SweetAlert2;
using Microsoft.AspNetCore.Components;

namespace Agrolifenet.FrontEnd.Componentes.Formularios
{
    public partial class AsignaciondeCargosComponent : ComponentBase
    {
        [Inject]
        IHttpConsumir HttpConsumir { get; set; } = default!;

        [Inject]
        SweetAlertService Swal { get; set; } = default!;

        private AsignaciondeCargosActualizarYGuardar asignaciondeCargosActualizarYGuardar = new();
        private IEnumerable<AsignaciondeCargosListar> asignaciondeCargosListars = default!;

        public async Task GuardarAsignaciondeCargo(AsignaciondeCargosActualizarYGuardar model)
        {

            // var resultado = await HttpConsumir.PostAsync()
            //if (resultado.Error)
            // {
            //     await Swal.FireAsync("Error", await resultado.ObetenerMensajeErrorAsync(), SweetAlertIcon.Error);
            // }
            // else
            // {
            //     await Swal.FireAsync("Exito", "Se Guardo Con Exito", SweetAlertIcon.Success);

            //     asignaciondeCargosListars = await ObtenerListado();
            // }




        }

    }
}
