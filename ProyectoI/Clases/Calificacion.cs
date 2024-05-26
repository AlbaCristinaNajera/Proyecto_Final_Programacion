using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoI.Clases
{
    internal class Calificacion
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public string CursoId { get; set; }
        public double Nota { get; set; }
        public string Retroalimentacion { get; set; }
        public DateTime Fecha { get; set; }
    }
}
