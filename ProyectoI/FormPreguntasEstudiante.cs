using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoI.Clases
{
    public partial class FormPreguntasEstudiante : Form
    {
        private EvaluacionesDAO evaluacionesDAO;
        private List<Pregunta> preguntas;
        private int preguntaActual;

        public FormPreguntasEstudiante()
        {
            InitializeComponent();
            evaluacionesDAO = new EvaluacionesDAO();
            preguntas = new List<Pregunta>();
            preguntaActual = 0;
        }

        private void CargarEvaluaciones()
        {
            List<Evaluacion> evaluaciones = evaluacionesDAO.ObtenerEvaluaciones();
            foreach (var evaluacion in evaluaciones)
            {
                preguntas.AddRange(evaluacion.Preguntas);
            }
        }

        private void MostrarPregunta(int indice)
        {
            if (indice < 0 || indice >= preguntas.Count)
                return;

            Pregunta pregunta = preguntas[indice];

            flowLayoutPanelPreguntas.Controls.Clear();

            Panel panel = new Panel
            {
                Size = new Size(400, 150),
                BorderStyle = BorderStyle.FixedSingle
            };

            Label labelPregunta = new Label
            {
                Text = pregunta.Preguntas,
                Location = new Point(10, 10),
                Size = new Size(380, 60)
            };

            RadioButton radioButtonSi = new RadioButton
            {
                Text = "Sí",
                Location = new Point(10, 80),
                AutoSize = true
            };

            RadioButton radioButtonNo = new RadioButton
            {
                Text = "No",
                Location = new Point(70, 80),
                AutoSize = true
            };

            panel.Controls.Add(labelPregunta);
            panel.Controls.Add(radioButtonSi);
            panel.Controls.Add(radioButtonNo);
            flowLayoutPanelPreguntas.Controls.Add(panel);
        }

        private void btnComenzar_Click(object sender, EventArgs e)
        {
            CargarEvaluaciones();
            if (preguntas.Count > 0)
            {
                MostrarPregunta(preguntaActual);
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            preguntaActual++;
            if (preguntaActual < preguntas.Count)
            {
                MostrarPregunta(preguntaActual);
            }
            else
            {
                MessageBox.Show("Has completado todas las preguntas.");
            }
        }
    }
}
