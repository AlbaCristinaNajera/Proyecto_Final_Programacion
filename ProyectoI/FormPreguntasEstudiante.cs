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
            this.Load += FormPreguntasEstudiante_Load;
        }

        private void FormPreguntasEstudiante_Load(object sender, EventArgs e)
        {
            CargarEvaluacionesUsuario();
        }

        private void CargarEvaluacionesUsuario()
        {
            List<Evaluacion> evaluaciones = evaluacionesDAO.ObtenerEvaluaciones();

            if (evaluaciones != null)
            {
                comboBoxEvaluaciones.DisplayMember = "Nombre_Evaluacion";
                comboBoxEvaluaciones.ValueMember = "Id_Evaluacion";

                foreach (var evaluacion in evaluaciones)
                {
                    comboBoxEvaluaciones.Items.Add(evaluacion);
                }

                comboBoxEvaluaciones.SelectedIndexChanged += comboBoxEvaluaciones_SelectedIndexChanged;
            }
        }

        private void comboBoxEvaluaciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxEvaluaciones.SelectedItem is Evaluacion evaluacion)
            {
                preguntas = evaluacion.Preguntas;
                preguntaActual = 0;
                MostrarPregunta(preguntaActual);
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

        private void flowLayoutPanelPreguntas_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}