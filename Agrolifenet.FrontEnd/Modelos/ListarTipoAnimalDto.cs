﻿namespace Agrolifenet.FrontEnd.Modelos
{
    public class ListarTipoAnimalDto
    {
        public int IdTipoAnimal { get; set; }
        public string TiposdeAnimal { get; set; }
        public DateTime FechadecreacionTipoAnimal { get; set; }
        public DateTime FechademodificacionTipoAnimal { get; set; }
        public bool EstadoTipoAnimal { get; set; }
    }
}