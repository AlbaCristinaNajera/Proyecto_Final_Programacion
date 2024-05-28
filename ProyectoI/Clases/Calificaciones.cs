using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoI
{
    internal class Calificaciones
    {
        public int IdCalificacion { get; set; }
        public int IdEstudiante { get; set; }
        public int IdCurso { get; set; }
        public int IdEvaluacion { get; set; }
        public decimal CalificacionValor { get; set; }
        public string Retroalimentacion { get; set; }
        public DateTime FechaCalificacion { get; set; }
    }
}
