using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoI
{
    public class Cursos
    {
        public int IdCurso { get; set; }
        public string NombreCurso { get; set; }
        public string Descripcion { get; set; }
        public string Horario { get; set; }

    }

    public class MaterialEducativo
    {
        public int ID_Material { get; set; }
        public int ID_Curso { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Archivo { get; set; }
        public string Categoria { get; set; }
    }
}
