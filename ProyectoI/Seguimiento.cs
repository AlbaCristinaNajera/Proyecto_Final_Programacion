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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProyectoI
{
    public partial class Seguimiento : Form
    {
        private ProgresoCursoDao progresoCursoDao; // DAO para interactuar con la base de datos
        private List<Calificacion> calificaciones;
        public Usuario usuario;
        private List<string> preguntasList = new List<string>();
        private int cursoSeleccionadoId = -1;
        private int evaluacionId = -1;

        public Seguimiento()
        {
            InitializeComponent();
            progresoCursoDao = new ProgresoCursoDao(); // Inicializar el DAO
            LoadCursos(); // Llenar el ComboBox con los cursos disponibles
            ComBoxCursos.SelectedIndexChanged += ComBoxCursos_SelectedIndexChanged;
        }

        private void LoadCursos()
        {
            DAO cursosDAO = new DAO();
            List<Cursos> cursos = cursosDAO.ObtenerTodosLosCursos();

            ComBoxCursos.DataSource = cursos;
            ComBoxCursos.DisplayMember = "NombreCurso";
            ComBoxCursos.ValueMember = "IdCurso";
        }

        private void ComBoxCursos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComBoxCursos.SelectedItem != null)
            {
                Cursos cursoSeleccionado = ComBoxCursos.SelectedItem as Cursos;

                if (cursoSeleccionado != null)
                {
                    cursoSeleccionadoId = cursoSeleccionado.IdCurso;
                    CargarCalificaciones(cursoSeleccionadoId);
                }
            }
        }

        private void CargarCalificaciones(int cursoId)
        {
            // Limpiar las calificaciones existentes en el DataGridView
            dataGridView.Rows.Clear();

            // Verificar si el DataGridView tiene columnas, si no, agregar las columnas necesarias
            if (dataGridView.Columns.Count == 0)
            {
                dataGridView.Columns.Add("Curso", "Nombre Del Curso");
                dataGridView.Columns.Add("UsuarioId", "Usuario ID");
                dataGridView.Columns.Add("CursoId", "Curso ID");
                dataGridView.Columns.Add("CalificacionValor", "Calificación");
            }

            CalificacionDAO calificacionDAO = new CalificacionDAO();
            DAO dAO = new DAO();
            // Obtener las calificaciones del curso seleccionado desde la base de datos
            var calificaciones = calificacionDAO.ObtenerCalificaciones(usuario.Id_Usuario);
            double Nota = 0;
            int contador = 0;

            // Agregar las calificaciones al DataGridView
            foreach (var calificacion in calificaciones)
            {
                Nota += calificacion.Nota;
                contador++;
                dataGridView.Rows.Add(dAO.ObtenerCursoPorId(cursoId).NombreCurso,usuario.Id_Usuario, cursoId, calificacion.Nota);

            }
            MessageBox.Show("El porcentaje de progreso es: %"+(Nota / contador));
        }
    }
}

