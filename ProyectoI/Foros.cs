using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProyectoI
{
    public partial class Foros : Form
    {
        private DaoForo daoForo;
        private int idEstudianteActual = 2; // Cambia esto al ID del estudiante actual

        // Constructor que inicializa DaoForo
        public Foros()
        {
            InitializeComponent();
            daoForo = new DaoForo();
            CargarForos();
        }

        private void CargarForos()
        {
            comboBoxNombreForo.Items.Clear();
            comboBoxPregunta.Items.Clear();

            try
            {
                var foros = daoForo.CargarForos();
                MessageBox.Show($"Foros cargados: {foros.Count}");
                foreach (var foro in foros)
                {
                    comboBoxNombreForo.Items.Add(foro);
                }
                comboBoxNombreForo.DisplayMember = "Value";
                comboBoxNombreForo.ValueMember = "Key";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar foros: " + ex.Message);
            }
        }

        private void comboBoxNombreForo_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxPregunta.Items.Clear();
            MessageBox.Show("Evento SelectedIndexChanged activado.");

            if (comboBoxNombreForo.SelectedItem != null)
            {
                var foroSeleccionado = (KeyValuePair<int, string>)comboBoxNombreForo.SelectedItem;
                MessageBox.Show($"ID del foro seleccionado: {foroSeleccionado.Key}");

                try
                {
                    string descripcion = daoForo.CargarDescripcion(foroSeleccionado.Key);
                    MessageBox.Show($"Descripción cargada: {descripcion}");
                    comboBoxPregunta.Items.Add(new KeyValuePair<int, string>(foroSeleccionado.Key, descripcion));
                    comboBoxPregunta.DisplayMember = "Value";
                    comboBoxPregunta.ValueMember = "Key";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar la descripción del foro: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("No hay foro seleccionado.");
            }
        }

        private void ButtonEnviar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Presiona aceptar para enviar el mensaje.");  // Mensaje para confirmar que el evento se dispara

            if (comboBoxNombreForo.SelectedItem == null || comboBoxPregunta.SelectedItem == null || string.IsNullOrEmpty(textBoxRespuesta.Text))
            {
                MessageBox.Show("Por favor, completa todos los campos antes de enviar el mensaje.");
                return;
            }

            var foroSeleccionado = (KeyValuePair<int, string>)comboBoxNombreForo.SelectedItem;
            var preguntaSeleccionada = (KeyValuePair<int, string>)comboBoxPregunta.SelectedItem;
            string respuesta = textBoxRespuesta.Text;
            MessageBox.Show($"Enviando respuesta: ForoID={foroSeleccionado.Key}, UsuarioID={idEstudianteActual}, Respuesta={respuesta}");

            try
            {
                daoForo.EnviarRespuesta(foroSeleccionado.Key, idEstudianteActual, respuesta);
                MessageBox.Show("Respuesta enviada exitosamente.");
                textBoxRespuesta.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al enviar mensaje: " + ex.Message);
            }
        }

      
    }
}