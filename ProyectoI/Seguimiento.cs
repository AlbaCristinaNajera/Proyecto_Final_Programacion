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
            // Usar el DAO para obtener las calificaciones
            DataTable calificaciones = progresoCursoDao.ObtenerCalificacionesPorCurso(usuario.Id_Usuario, cursoId);

            // Asignar el DataTable como DataSource del DataGridView
            dataGridView.DataSource = calificaciones;

            // Calcular el promedio de calificaciones
            double Nota = 0;
            int contador = 0;

            foreach (DataRow row in calificaciones.Rows)
            {
                Nota += Convert.ToDouble(row["calificacion"]);
                contador++;
            }

            if (contador > 0)
            {
                MessageBox.Show("El porcentaje de progreso es: %" + (Nota / contador));
            }
            else
            {
                MessageBox.Show("No hay calificaciones disponibles para este curso.");
            }
        }
    }
}



