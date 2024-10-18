namespace Agrolifenet.Dominio.Entidades
{
    public class HistorialClinico
    {
        public int IdHistorialClinico { get; set; }
        public DateTime FechadecreacionHistorialClinico { get; set; }
        public DateTime FechademodificacionHistorialClinico { get; set; }
        public bool EstadoHistorialClinico { get; set; }
        public string VacunaHistorialClinico { get; set; }
        public string TratamientoHistorialClinico { get; set; }
        public string EnfermedadesHistorialClinico { get; set; }
        public string ResultadodeExamenesHistorialClinico { get; set; }
        public string InformaciondesparacitacionHistorialClinico { get; set; }
        public int PesoalnacerHistorialClinico { get; set; }
        public int PesoactualHistorialClinico { get; set; }
        public int GananciadepesodiariaHistorialClinico { get; set; }
        public string ObservacionesHistorialClinico { get; set; }
        public string EstadodesaludHistorialClinico { get; set; }
        public int CostodeltratamientoHistorialClinico { get; set; }
        public int SeguimientoHistorialClinico { get; set; }
        public int NumerodepartosHistorialClinico { get; set; }
        public int IdGanado { get; set; }
        public int IdUsuario { get; set; }
        public int IdDatosdeReproduccion { get; set; }

        public HistorialClinico(
            int idHistorioalClinico,
            DateTime fechadecreacionHistorialClinico,
            DateTime fechademodificacionHistorialClinico,
            bool estadoHistorialClinico,
            string vacunaHistorialClinico,
            string tratamientoHistorialClinico,
            string enfermedadesHistorialClinico,
            string resultadodeExamenesHistorialClinico,
            string informaciondesparacitacionHistorialClinico,
            int pesoalnacerHistorialClinico,
            int pesoactualHistorialClinico,
            int gananciadepesodiariaHistorialClinico,
            string observacionesHistorialClinico,
            string estadodesaludHistorialClinico,
            int costodeltratamientoHistorialClinico,
            int seguimientoHistorialClinico,
            int numerodepartosHistorialClinico,
            int idGanado,
            int idUsuario,
            int idDatosdeReproduccion)
        {
            IdHistorialClinico = idHistorioalClinico;
            FechadecreacionHistorialClinico = fechadecreacionHistorialClinico;
            FechademodificacionHistorialClinico = fechademodificacionHistorialClinico;
            EstadoHistorialClinico = estadoHistorialClinico;
            VacunaHistorialClinico = vacunaHistorialClinico;
            TratamientoHistorialClinico = tratamientoHistorialClinico;
            EnfermedadesHistorialClinico = enfermedadesHistorialClinico;
            ResultadodeExamenesHistorialClinico = resultadodeExamenesHistorialClinico;
            InformaciondesparacitacionHistorialClinico = informaciondesparacitacionHistorialClinico;
            PesoalnacerHistorialClinico = pesoalnacerHistorialClinico;
            PesoactualHistorialClinico = pesoactualHistorialClinico;
            GananciadepesodiariaHistorialClinico = gananciadepesodiariaHistorialClinico;
            ObservacionesHistorialClinico = observacionesHistorialClinico;
            EstadodesaludHistorialClinico = estadodesaludHistorialClinico;
            CostodeltratamientoHistorialClinico = costodeltratamientoHistorialClinico;
            SeguimientoHistorialClinico = seguimientoHistorialClinico;
            NumerodepartosHistorialClinico = numerodepartosHistorialClinico;
            IdGanado = idGanado;
            IdUsuario = idUsuario;
            IdDatosdeReproduccion = idDatosdeReproduccion;
        }
        public int Guardar()
        {
            return 0;
        }
        public bool Actulizar()
        {
            return false;
        }
        public bool Eliminar()
        {
            return true;
        }
        public HistorialClinico Buscar()
        {
            return new HistorialClinico(
                default, default,
                default, default,
                default!, default!,
                default!, default!,
                default!, default,
                default, default,
                default!, default!,
                default, default,
                default, default,
                default, default);
        }
        public List<HistorialClinico> Listar(HistorialClinico historialClinico)
        {
            return new List<HistorialClinico>();
        }
    }
}
