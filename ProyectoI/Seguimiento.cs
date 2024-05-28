using ProyectoI.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoI
{
    public partial class Seguimiento : Form
    {
        private List<string> preguntasList = new List<string>();
        private int cursoSeleccionadoId = -1;
        private int evaluacionId = -1;
        public Seguimiento()
        {
            InitializeComponent();
            LoadCursos();
        }

       
     

 

      

        private void ComBoxCursos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComBoxCursos.SelectedItem != null)
            {
                Cursos cursoSeleccionado = ComBoxCursos.SelectedItem as Cursos;
                if (cursoSeleccionado != null)
                {
                    cursoSeleccionadoId = cursoSeleccionado.IdCurso;
                }
            }
        }

        private void LoadCursos()
        {
            DAO cursosDAO = new DAO();
            List<Cursos> cursos = cursosDAO.ObtenerTodosLosCursos();

            ComBoxCursos.DataSource = cursos;
            ComBoxCursos.DisplayMember = "NombreCurso";
            ComBoxCursos.ValueMember = "IdCurso";
        }
    }
}
