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
        private ProgresoCursoDao progresoCursoDao = new ProgresoCursoDao();
        private int UsuarioId = 1;
        private int cursoSeleccionadoId = -1;
        private List<ProgresoCurso> cursosDisponibles = new List<ProgresoCurso>(); // Debes definir esta lista

        public Seguimiento()
        {
            InitializeComponent();
            LoadCursos();
        }

        private void Seguimiento_Load(object sender, EventArgs e)
        {
            MostrarProgresoUsuario();
            CargarCursosEnComboBox();
        }

        private void CargarCursosEnComboBox()
        {
            // Limpiar ComboBox antes de cargar los cursos para evitar duplicados
            ComBoxCursos.Items.Clear();

            // Agregar cada curso al ComboBox
            foreach (ProgresoCurso curso in cursosDisponibles)
            {
                ComBoxCursos.Items.Add(curso);
            }
        }

        private void MostrarProgresoUsuario()
        {
            // Suponiendo que tenemos el progreso del usuario 
            ProgresoCurso progreso = ObtenerProgresoUsuario();

            if (progreso != null)
            {
                LblCurso.Text = "Curso: " + progreso.CursoId;
                LblProgreso.Text = "Progreso: " + progreso.ProgresoPorcentaje + "%";
                progressBar1.Value = progreso.ProgresoPorcentaje;
            }
            else
            {
                MessageBox.Show("No se encontraron datos de progreso para este usuario.");
            }
        }

        private ProgresoCurso ObtenerProgresoUsuario()
        {
            // Aquí deberiamos llamar al DAO para obtener el progreso del usuario
            // Utilizar el ID del usuario para obtener el progreso correspondiente
            return progresoCursoDao.ObtenerProgresoUsuario(UsuarioId);
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
            ComBoxCursos.DisplayMember = "Curso";
            ComBoxCursos.ValueMember = "IdCurso";
        }
    }
}
