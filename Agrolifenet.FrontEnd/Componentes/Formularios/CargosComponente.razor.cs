using Agrolifenet.FrontEnd.Http;
using Agrolifenet.FrontEnd.Modelos;
using CurrieTechnologies.Razor.SweetAlert2;
using Microsoft.AspNetCore.Components;

namespace Agrolifenet.FrontEnd.Componentes.Formularios
{
    public partial class CargosComponente : ComponentBase
    {
        [Inject]
        IHttpConsumir HttpConsumir { get; set; } = default!;

        [Inject]
        SweetAlertService Swal { get; set; } = default!;
        [Inject]
        private NavigationManager Navigation { get; set; } = default!;

        private TipodeCargoGuardarActualizarDto tiposdeCargoGuardarActualizarDto = new();
        private IEnumerable<TipodeCargoListarDto> tipodeCargoListarDtos = default!;

        public async Task GuardarTiposdeCargo(TipodeCargoGuardarActualizarDto model)
        {
            if (tiposdeCargoGuardarActualizarDto.idTiposdecargo == 0)
            {
                var resultado = await HttpConsumir.PostAsync("/api/Tipodecargo/InsertarTiposdecargo", tiposdeCargoGuardarActualizarDto);
                if (resultado.Error)
                {
                    await Swal.FireAsync("Error", await resultado.ObetenerMensajeErrorAsync(), SweetAlertIcon.Error);
                }
                else
                {
                    await Swal.FireAsync("Exito", await resultado.ObetenerMensajeErrorAsync(), SweetAlertIcon.Success);
                    tipodeCargoListarDtos = await ObtenerListado();
                }
            }
            else
            {
                var resultado = await HttpConsumir.PutAsync("/api/Tipodecargo/ActualizarTiposdecargo", tiposdeCargoGuardarActualizarDto);
                if (resultado.Error)
                {
                    await Swal.FireAsync("Error", await resultado.ObetenerMensajeErrorAsync(), SweetAlertIcon.Error);
                }
                else
                {

                    await Swal.FireAsync("Exito", "Se Actualizo Con Exito", SweetAlertIcon.Success);


                    tipodeCargoListarDtos = await ObtenerListado();


                }
                tiposdeCargoGuardarActualizarDto = new();
            }

        }
        protected override async Task OnInitializedAsync()
        {
            try
            {

                tipodeCargoListarDtos = await ObtenerListado();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener los datos: {ex.Message}");
            }
        }
        public async Task<IEnumerable<TipodeCargoListarDto>> ObtenerListado()
        {
            var resultado = await HttpConsumir.GetAsync<IEnumerable<TipodeCargoListarDto>>("/api/Tipodecargo/ListarTiposdecargo");
            return resultado.Response;
        }
        public async Task ActualizarTipodecargo(int idTiposdecargo)
        {
            var resultado = await HttpConsumir.GetAsync<TipodeCargoGuardarActualizarDto>($"/api/Tipodecargo/BuscarTiposdecargo?idTiposdecargo={idTiposdecargo}");
            tiposdeCargoGuardarActualizarDto = resultado.Response;
            await Swal.FireAsync("Exito", "Se Busco Con Exito", SweetAlertIcon.Success);
        }
        public async Task EliminarTipodeCargo(int idTiposdecargo)
        {
            var resultado = await HttpConsumir.DeleleteAsync($"/api/Tipodecargo/EliminarTiposdecargo?idTiposdecargo={idTiposdecargo}");
            if (resultado.Error)
            {
                await Swal.FireAsync("Error", await resultado.ObetenerMensajeErrorAsync(), SweetAlertIcon.Error);
            }
            else
            {
                tipodeCargoListarDtos = tipodeCargoListarDtos.Where(p => p.idTiposdecargo != idTiposdecargo);
                await Swal.FireAsync("Exito", "Se Elimino Con Exito", SweetAlertIcon.Success);
            }
        }
    }
}
