using Agrolifenet.FrontEnd.Http;
using Agrolifenet.FrontEnd.Modelos;
using CurrieTechnologies.Razor.SweetAlert2;
using Microsoft.AspNetCore.Components;

namespace Agrolifenet.FrontEnd.Componentes.Formularios
{
    public partial class HistorialClinicoComponente : ComponentBase
    {
        [Inject]
        IHttpConsumir HttpConsumir { get; set; } = default!;

        [Inject]
        SweetAlertService Swal { get; set; } = default!;
        public  HistorialClinicoGuardar_Actualizar historialClinicoGuardar_Actualizar = new();

        public async Task GuardarHistorialClinico(HistorialClinicoGuardar_Actualizar model)
        {
            var resultado = await HttpConsumir.PostAsync("/api/HistorialClinico/AgregarHistorialClinico\r\n", historialClinicoGuardar_Actualizar);
            if (resultado.Error)
            {
                await Swal.FireAsync("Error", await resultado.ObetenerMensajeErrorAsync(), SweetAlertIcon.Error);
            }
            else
            {

                await Swal.FireAsync("Exito", "Se Guardo Con Exito", SweetAlertIcon.Success);

                
            }
        }
    }
}
