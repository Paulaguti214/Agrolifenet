using Agrolifenet.Dominio.Dto;
using Agrolifenet.Dominio.Entidades;
using Agrolifenet.Dominio.Servicios;
using Agrolifenet.Infraestructura.Adaptador.BaseRepositorio;
using DinkToPdf;
using DinkToPdf.Contracts;
using System.Data;
using static Agrolifenet.Dominio.Puerto.BaseRepositorio.IRepositorioLectura;

namespace Agrolifenet.Infraestructura.Adaptador
{
    public class FacturaServicio : RepositorioLectura<DetalleFacturaDto>, IRepositorioLectura<DetalleFacturaDto>, IFacturaServicio
    {
        private readonly IVentaServicio _ventaServicio;
        private readonly IConverter _converter;
        private readonly string NombreProcedimientoDetalleFactura = "DetalleFactura";

        public FacturaServicio(
            IDbConnection baseDeDatos,
            IVentaServicio ventaServicio,
            IConverter converter) : base(baseDeDatos)
        {
            _ventaServicio = ventaServicio;
            _converter = converter;
        }

        public async Task<byte[]> GenerarFacturaAsync(Guid consecutivoFactura)
        {
            var factrua = new FacturaDto
            {
                Venta = await _ventaServicio.SeleccionarVenta(consecutivoFactura),
                DetalledeVenta = await ListarAsync(NombreProcedimientoDetalleFactura, new { consecutivoFactura })
            };

            var templeateVenta = @"<tr>
                                    <th># Chip</th>
                                    <th>Tipo Animal</th>
                                    <th>Raza</th>
                                    <th>Valor</th>
                                  </tr>";
            foreach (var detalle in factrua.DetalledeVenta)
            {
                templeateVenta += $@"<tr>
                                        <td>{@detalle.NumeridechipGanado}</td>
                                        <td>{@detalle.Tiposdeanimal}</td>
                                        <td>{detalle.Tipoderaza}</td>
                                        <td>{String.Format("{0:$ #,##0.00;($ #,##0.00);0}", @detalle.Valor)}</td>                                        
                                    </tr>";
            }

            var templateContent = $@"<!DOCTYPE html>
<html lang=""en"">
<head>
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <title>Offer Letter</title>
    <style>
        body {{
            font-family: Arial, sans-serif;
            margin: 0;
            padding: 20px;
            background-color: #f4f4f4;
        }}
        .container {{
            background-color: #fff;
            padding: 20px;
            margin: 0 auto;
            border-radius: 5px;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
            max-width: 800px;
        }}
        .header, .footer {{
            text-align: center;
        }}
        .header h1, .footer p {{
            margin: 0;
        }}
        .content {{
            margin: 20px 0;
        }}
        .content p {{
            line-height: 1.6;
        }}
        .details {{
            margin: 20px 0;
        }}
        .details td {{
            padding: 5px 0;
        }}
    </style>
</head>
<body>
    <div class=""container"">
        <div class=""header"">
            <h1>Factura Agro Life Net</h1>
        </div>
        <div class=""content"">
            <p>Sr. {factrua.Venta.NombredelcompradorVenta.ToUpper()},</p>
            <p>Factura de venta</p>
            <div class=""details"">
                <table>
                    <tr>
                        <td><strong>Fecha Generacion:</strong></td>
                        <td>{factrua.Venta.FechaDeLaVenta.ToString("yyyy-MM-dd hh:mm")}</td>
                    </tr>
                    <tr>
                        <td><strong>Valor Factura:</strong></td>
                        <td>{@String.Format("{0:#,##0.00;(#,##0.00);0}", factrua.Venta.PrecioVenta)}</td>
                    </tr>  
                    <tr>
                        <td><strong>Envio:</strong></td>
                        <td>{factrua.Venta.DestinoVenta}</td>
                    </tr>  
                    <tr>
                        <td><strong>Observaciones:</strong></td>
                        <td>{factrua.Venta.CondicionesdeVenta}</td>
                    </tr>  
                </table>
            </div>
            <p>A continuacion se genera el detalle de la factura</p>
            <br>
            <br>    
            <table>
             {templeateVenta}
            </table>
        </div>
        <div class=""footer"">
            <p>&copy; {DateTime.Now.Year} Agro Life Net. All rights reserved.</p>
        </div>
    </div>
</body>
</html>
";

            var globalSettings = new GlobalSettings
            {
                ColorMode = ColorMode.Color,
                Orientation = Orientation.Portrait,
                PaperSize = PaperKind.A4,
                Margins = new MarginSettings { Top = 10, Bottom = 10, Left = 10, Right = 10 }
            };

            var objectSettings = new ObjectSettings
            {
                PagesCount = true,
                HtmlContent = templateContent,
                WebSettings = { DefaultEncoding = "utf-8" },
                HeaderSettings = { FontName = "Arial", FontSize = 9, Right = "Pagina [page] De [toPage]", Line = true, Spacing = 2.812 },
                FooterSettings = { FontName = "Arial", FontSize = 9, Line = true, Center = "Reporte Agro Life Net" }
            };

            var pdf = new HtmlToPdfDocument()
            {
                GlobalSettings = globalSettings,
                Objects = { objectSettings }
            };

            return _converter.Convert(pdf);
        }

        public Task<IEnumerable<Ventas>> VerFacturaAsync()
        {
            return _ventaServicio.ListarVentas();
        }
    }
}
