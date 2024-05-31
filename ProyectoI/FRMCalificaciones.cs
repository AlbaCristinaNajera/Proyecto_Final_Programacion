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
    public partial class FRMCalificaciones : Form
    {
        private DAOCalificaciones daoCalificaciones;
        public FRMCalificaciones()
        {
            InitializeComponent();
            daoCalificaciones = new DAOCalificaciones();
            CargarDatos();
        }

        private void CargarDatos()
        {
            CargarEstudiantes();
            CargarCursos();
            CargarEvaluaciones();
        }

        private void CargarEstudiantes()
        {
            var estudiantes = daoCalificaciones.CargarEstudiantes();
            comboBoxEstudiante.DataSource = new BindingSource(estudiantes, null);
            comboBoxEstudiante.DisplayMember = "Value";
            comboBoxEstudiante.ValueMember = "Key";
        }

        private void CargarCursos()
        {
            var cursos = daoCalificaciones.CargarCursos();
            comboBoxCurso.DataSource = new BindingSource(cursos, null);
            comboBoxCurso.DisplayMember = "Value";
            comboBoxCurso.ValueMember = "Key";
        }

        private void CargarEvaluaciones()
        {
            var evaluaciones = daoCalificaciones.CargarEvaluaciones();
            comboBoxEvaluaciones.DataSource = new BindingSource(evaluaciones, null);
            comboBoxEvaluaciones.DisplayMember = "Value";
            comboBoxEvaluaciones.ValueMember = "Key";
        }
        private void MostrarCalificacion()
        {
            if (comboBoxEstudiante.SelectedItem == null || comboBoxCurso.SelectedItem == null || comboBoxEvaluaciones.SelectedItem == null)
                return;

            int idEstudiante = ((KeyValuePair<int, string>)comboBoxEstudiante.SelectedItem).Key;
            int idCurso = ((KeyValuePair<int, string>)comboBoxCurso.SelectedItem).Key;
            int idEvaluacion = ((KeyValuePair<int, string>)comboBoxEvaluaciones.SelectedItem).Key;

            Calificaciones calificacion = daoCalificaciones.ObtenerCalificacion(idEstudiante, idCurso, idEvaluacion);

            if (calificacion != null)
            {
                txtPunteo.Text = calificacion.CalificacionValor.ToString();
                richTextBoxRetroalimentacion.Text = calificacion.Retroalimentacion;
            }
            else
            {
                txtPunteo.Clear();
                richTextBoxRetroalimentacion.Clear();
            }
        }

        private void MostrarRespuestas()
        {
            if (comboBoxEstudiante.SelectedItem == null || comboBoxCurso.SelectedItem == null || comboBoxEvaluaciones.SelectedItem == null)
                return;

            int idEstudiante = ((KeyValuePair<int, string>)comboBoxEstudiante.SelectedItem).Key;
            int idCurso = ((KeyValuePair<int, string>)comboBoxCurso.SelectedItem).Key;
            int idEvaluacion = ((KeyValuePair<int, string>)comboBoxEvaluaciones.SelectedItem).Key;

            // Obtener las respuestas del estudiante para el curso y la evaluación seleccionados
            List<RespuestaEvaluacion> respuestas = daoCalificaciones.ObtenerRespuestas(idEstudiante, idCurso, idEvaluacion);

            // Mostrar las respuestas en el DataGridView
            dataGridViewRespuestasEvaluacion.DataSource = respuestas;
        }

        private void btnGuardarCalificacion_Click_1(object sender, EventArgs e)
        {
            try
            {
                int idEstudiante = ((KeyValuePair<int, string>)comboBoxEstudiante.SelectedItem).Key;
                int idCurso = ((KeyValuePair<int, string>)comboBoxCurso.SelectedItem).Key;
                int idEvaluacion = ((KeyValuePair<int, string>)comboBoxEvaluaciones.SelectedItem).Key;
                decimal calificacion = decimal.Parse(txtPunteo.Text);
                string retroalimentacion = richTextBoxRetroalimentacion.Text;
                DateTime fechaCalificacion = DateTime.Now;

                Calificaciones calificacionObj = new Calificaciones
                {
                    IdEstudiante = idEstudiante,
                    IdCurso = idCurso,
                    IdEvaluacion = idEvaluacion,
                    CalificacionValor = calificacion,
                    Retroalimentacion = retroalimentacion,
                    FechaCalificacion = fechaCalificacion
                };

                daoCalificaciones.InsertarCalificacion(calificacionObj);
                MessageBox.Show("Calificación guardada exitosamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar la calificación: " + ex.Message);
            }
        }

        private void comboBoxEstudiante_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarRespuestas();
        }

        private void comboBoxCurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarRespuestas();
        }

        private void comboBoxEvaluaciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarRespuestas();
        }

    }
}
