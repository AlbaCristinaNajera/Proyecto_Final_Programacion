using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProyectoI
{
    public partial class Foros : Form
    {
        private DaoForo daoForo;
        private string connectionString = "server=localhost;user=root;pwd=aguapura02;database=usuarios;";

        public Foros()
        {
            InitializeComponent();
            daoForo = new DaoForo(connectionString);
            CargarForos();
        }

        private void CargarForos()
        {
            comboBoxPregunta.Items.Clear();

            try
            {
                var foros = daoForo.CargarForos();
                foreach (var foro in foros)
                {
                    comboBoxPregunta.Items.Add(foro);
                }
                comboBoxPregunta.DisplayMember = "Value";
                comboBoxPregunta.ValueMember = "Key";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar foros: " + ex.Message);
            }
        }

        private void comboBoxPregunta_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxMensajes.Items.Clear();

            if (comboBoxPregunta.SelectedItem != null)
            {
                var foroSeleccionado = (KeyValuePair<int, string>)comboBoxPregunta.SelectedItem;

                try
                {
                    string descripcion = daoForo.ObtenerDescripcionForo(foroSeleccionado.Key);
                    listBoxMensajes.Items.Add(descripcion);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar la descripción del foro: " + ex.Message);
                }
            }
        }

        private void ButtonEnviar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Presiona aceptar para enviar el mensaje.");  // Mensaje para confirmar que el evento se dispara

            string nombreForo = comboBoxNombreForo.SelectedItem?.ToString();
            string pregunta = comboBoxPregunta.SelectedItem?.ToString();
            string respuesta = textBoxRespuesta.Text;

            // Verificación básica antes de intentar enviar el mensaje
            if (string.IsNullOrEmpty(nombreForo) || string.IsNullOrEmpty(pregunta) || string.IsNullOrEmpty(respuesta))
            {
                MessageBox.Show("Por favor, completa todos los campos antes de enviar el mensaje.");
                return;
            }

            try
            {
                daoForo.EnviarMensaje(nombreForo, pregunta, respuesta); 
                MessageBox.Show("Respuesta enviada exitosamente.");
                CargarForos();

                // Limpiar los campos después de enviar el mensaje
                comboBoxNombreForo.SelectedIndex = -1;
                comboBoxPregunta.SelectedIndex = -1;
                textBoxRespuesta.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al enviar mensaje: " + ex.Message);
            }
        }
    }
}
