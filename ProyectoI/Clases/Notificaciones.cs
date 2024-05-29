using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoI.Clases
{
    
    
        public class Notificacion
        {
            public int Id { get; set; }
            public int UsuarioId { get; set; }
            public string Titulo { get; set; }
            public string Mensaje { get; set; }
            public DateTime Fecha { get; set; }
            public bool Leido { get; set; }
        }
    }

