using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProyectoI
{
    public partial class Evaluaciones : Form
    {
        private List<string> preguntasList = new List<string>();

        public Evaluaciones()
        {
            InitializeComponent();
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
            if (!int.TryParse(textBoxPuntos.Text, out puntos))
            {
                MessageBox.Show("Por favor, ingresa un número válido de puntos.");
                return;
            }

            EvaluacionesDAO evaluacionesDAO = new EvaluacionesDAO();
            bool resultado = evaluacionesDAO.RegistrarEvaluacion(fecha, puntos, preguntasList);

            if (resultado)
            {
                MessageBox.Show("Evaluación registrada correctamente.");
                preguntasList.Clear();
                listBoxEvaluaciones.Items.Clear();
            }
            else
            {
                MessageBox.Show("Hubo un error al registrar la evaluación.");
            }
        }

        private void buttonGuardarpregunta_Click(object sender, EventArgs e)
        {
            string pregunta = textBoxIngresarPreguntas.Text;

            if (!string.IsNullOrEmpty(pregunta))
            {
                preguntasList.Add(pregunta);
                listBoxPreguntas.Items.Add(pregunta);
                textBoxIngresarPreguntas.Clear();
            }
            else
            {
                MessageBox.Show("Por favor, ingresa una pregunta válida.");
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
    }
}