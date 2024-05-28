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
        private Dictionary<int, string> respuestasUsuario;
        private int preguntaActual;
        public Usuario usuario { get; set; }

        public FormPreguntasEstudiante()
        {
            InitializeComponent();
            evaluacionesDAO = new EvaluacionesDAO();
            preguntas = new List<Pregunta>();
            preguntaActual = 0;
            respuestasUsuario = new Dictionary<int, string>();
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
                Text = "Verdadero",
                Tag = "Verdadero",
                Location = new Point(10, 80),
                AutoSize = true
            };

            RadioButton radioButtonNo = new RadioButton
            {
                Text = "Falso",
                Tag = "Falso",
                Location = new Point(100, 80),
                AutoSize = true
            };

            panel.Controls.Add(labelPregunta);
            panel.Controls.Add(radioButtonSi);
            panel.Controls.Add(radioButtonNo);
            flowLayoutPanelPreguntas.Controls.Add(panel);
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (preguntaActual < preguntas.Count)
            {
                Pregunta preguntaActualObj = preguntas[preguntaActual];
                string respuesta = ObtenerRespuestaSeleccionada(preguntaActualObj);

                // Guarda la respuesta del usuario en el diccionario
                if (respuestasUsuario.ContainsKey(preguntaActualObj.Id_Pregunta))
                {
                    respuestasUsuario[preguntaActualObj.Id_Pregunta] = respuesta;
                }
                else
                {
                    respuestasUsuario.Add(preguntaActualObj.Id_Pregunta, respuesta);
                }

                preguntaActual++;
                if (preguntaActual < preguntas.Count)
                {
                    MostrarPregunta(preguntaActual);
                }
                else
                {
                    MessageBox.Show("Has completado todas las preguntas. Puedes revisar tus respuestas y hacer clic en 'Terminar' para guardar.");
                }
            }
        }

        private string ObtenerRespuestaSeleccionada(Pregunta pregunta)
        {
            foreach (Control control in flowLayoutPanelPreguntas.Controls)
            {
                if (control is Panel panel)
                {
                    Label labelPregunta = panel.Controls.OfType<Label>().FirstOrDefault();
                    if (labelPregunta != null && labelPregunta.Text == pregunta.Preguntas)
                    {
                        RadioButton radioButtonSeleccionado = panel.Controls.OfType<RadioButton>().FirstOrDefault(rb => rb.Checked);
                        if (radioButtonSeleccionado != null)
                        {
                            return radioButtonSeleccionado.Text;
                        }
                    }
                }
            }
            return ""; // Retorna una cadena vacía si no se encuentra ninguna respuesta seleccionada
        }

        private void btnTerminarEvaluacion_Click(object sender, EventArgs e)
        {
            if (usuario != null)
            {
                int idUsuario = usuario.Id_Usuario;

                foreach (var respuesta in respuestasUsuario)
                {
                    int idPregunta = respuesta.Key;
                    string respuestaTexto = respuesta.Value;

                    // Guardar la respuesta del usuario en la base de datos
                    bool resultado = evaluacionesDAO.GuardarRespuestaUsuario(idUsuario, idPregunta, respuestaTexto);

                    if (!resultado)
                    {
                        MessageBox.Show("Hubo un error al guardar las respuestas.");
                        return;
                    }
                }

                MessageBox.Show("Todas las respuestas han sido guardadas correctamente.");
            }
            else
            {
                MessageBox.Show("No se pudo obtener el ID del usuario actual.");
            }
        }
    }
}