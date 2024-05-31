using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProyectoI
{
    public partial class Evaluaciones : Form
    {
        private List<string> preguntasList = new List<string>();
        private int cursoSeleccionadoId = -1;
        private int evaluacionId = -1;

        public Evaluaciones()
        {
            InitializeComponent();
            LoadCursos();
        }

        private void Evaluaciones_Load(object sender, EventArgs e)
        {
            // Cargar datos iniciales si es necesario
        }

        private void comboBoxCursos_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Manejar el cambio de selección en el combo box de cursos
        }

        private void textBoxPuntos_TextChanged(object sender, EventArgs e)
        {
            // Manejar cambios en el texto de puntos
        }

        private void textBoxFecha_TextChanged(object sender, EventArgs e)
        {
            // Manejar cambios en el texto de la fecha
        }



        private void label6_Click(object sender, EventArgs e)
        {
            // Este evento parece no hacer nada
        }

        private void textBoxIngresarPreguntas_TextChanged(object sender, EventArgs e)
        {
            // Manejar cambios en el texto de la pregunta
        }


        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            string fecha = textBoxFecha.Text;
            int puntos;
            string Nombre_Evalucion = txtNombreEvaluacion.Text;

            if (!int.TryParse(textBoxPuntos.Text, out puntos))
            {
                MessageBox.Show("Por favor, ingresa un número válido de puntos.");
                return;
            }

            if (cursoSeleccionadoId == -1)
            {
                MessageBox.Show("Por favor, selecciona un curso válido.");
                return;
            }

            EvaluacionesDAO evaluacionesDAO = new EvaluacionesDAO();
            bool resultado = evaluacionesDAO.RegistrarEvaluacion(fecha, puntos, Nombre_Evalucion, preguntasList, cursoSeleccionadoId);

            if (resultado)
            {
                MessageBox.Show("Evaluación registrada correctamente.");
                preguntasList.Clear();

                // Obtener el ID de la evaluación registrada
                evaluacionId = evaluacionesDAO.ObtenerUltimoIdEvaluacion();
            }
            else
            {
                MessageBox.Show("Hubo un error al registrar la evaluación.");
            }
        }

        private void buttonEliminarpregunta_Click(object sender, EventArgs e)
        {
            if (listBoxPreguntas.SelectedItem != null)
            {
                string preguntaSeleccionada = listBoxPreguntas.SelectedItem.ToString();
                preguntasList.Remove(preguntaSeleccionada);
                listBoxPreguntas.Items.Remove(preguntaSeleccionada);
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una pregunta para eliminar.");
            }
        }

        private void comboBoxCursos_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboBoxCursos.SelectedItem != null)
            {
                Cursos cursoSeleccionado = comboBoxCursos.SelectedItem as Cursos;
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

            comboBoxCursos.DataSource = cursos;
            comboBoxCursos.DisplayMember = "NombreCurso";
            comboBoxCursos.ValueMember = "IdCurso";
        }



        private void buttonAgregarPregunta_Click(object sender, EventArgs e)
        {
            if (evaluacionId == -1)
            {
                MessageBox.Show("Por favor, registra primero una evaluación.");
                return;
            }

            string pregunta = textBoxIngresarPreguntas.Text;
            if (!string.IsNullOrEmpty(pregunta))
            {
                EvaluacionesDAO evaluacionesDAO = new EvaluacionesDAO();
                bool resultado = evaluacionesDAO.InsertarPregunta(evaluacionId, pregunta);

                if (resultado)
                {
                    preguntasList.Add(pregunta);
                    listBoxPreguntas.Items.Add(pregunta);
                    textBoxIngresarPreguntas.Clear();
                }
                else
                {
                    MessageBox.Show("Hubo un error al agregar la pregunta.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingresa una pregunta válida.");
            }
        }


        private void btnAgregarRespuesta_Click_1(object sender, EventArgs e)
        {
            if (listBoxPreguntas.SelectedItem != null)
            {
                // Obtener el índice de la pregunta seleccionada en el ListBox
                int index = listBoxPreguntas.SelectedIndex;

                // Verificar si el índice es válido y está dentro del rango de preguntas
                if (index >= 0 && index < preguntasList.Count)
                {
                    // Obtener la pregunta seleccionada
                    string preguntaSeleccionada = preguntasList[index];

                    // Obtener el ID de la pregunta seleccionada
                    EvaluacionesDAO evaluacionesDAO = new EvaluacionesDAO();
                    int idPregunta = evaluacionesDAO.ObtenerIdPregunta(preguntaSeleccionada);

                    if (idPregunta != -1)
                    {
                        string respuesta = txtRespuesta.Text;
                        if (!string.IsNullOrEmpty(respuesta))
                        {
                            // Guardar la respuesta en la base de datos
                            bool resultado = evaluacionesDAO.GuardarRespuesta(idPregunta, respuesta);

                            if (resultado)
                            {
                                MessageBox.Show("Respuesta agregada correctamente.");
                                txtRespuesta.Clear();
                            }
                            else
                            {
                                MessageBox.Show("Hubo un error al agregar la respuesta.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Por favor, ingresa una respuesta válida.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Pregunta no encontrada.");
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, selecciona una pregunta válida para agregar respuesta.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una pregunta para agregar respuesta.");
            }
        }

    }
}