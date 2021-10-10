using System;
using System.Collections.Generic;

namespace Hospitalizacion.App.Dominio
{
    public class SugerenciaCuidado
    {
          public int Id { get; set; }
        public string  FechaHora { get; set; } 
        public string Descripcion { get; set; }
        public Historia HistoriaPerteneciente { get; set; }
        
    }
}