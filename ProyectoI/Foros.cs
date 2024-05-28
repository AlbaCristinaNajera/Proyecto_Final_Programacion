using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProyectoI
{
    public partial class Foros : Form
    {

        public Foros()
        {
            InitializeComponent();
            CargarTemas();
            CargarUsuarios();
        }

        private void CargarTemas()
        {
            try
            {

                {
                    string query = "SELECT id, nombre FROM temas";
                    MySqlCommand cmd = new MySqlCommand(query);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = reader.GetInt32("id");
                            string nombre = reader.GetString("nombre");
                            comboBoxForo.Items.Add(new Tema { Id = id, Nombre = nombre });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los temas: " + ex.Message);
            }
        }

        private void CargarUsuarios()
        {
            // Implementa la lógica para cargar los usuarios desde la base de datos
            // y agregarlos al ComboBox de usuarios
        }

        private void buttonEnviar_Click(object sender, EventArgs e)
        {
            EnviarMensaje();
        }

        private void EnviarMensaje()
        {
            try
            {
                Tema temaSeleccionado = (Tema)comboBoxForo.SelectedItem;
                string mensaje = textBoxMensaje.Text;
                Usuario usuarioSeleccionado = (Usuario)comboBoxPregunta.SelectedItem;

                if (temaSeleccionado == null || usuarioSeleccionado == null || string.IsNullOrEmpty(mensaje))
                {
                    MessageBox.Show("Por favor seleccione un tema, un usuario y escriba un mensaje.");
                    return;
                }


                {

                    string query = "INSERT INTO mensajes (tema_id, usuario_id, mensaje, fecha) " +
                                   "VALUES (@TemaId, @UsuarioId, @Mensaje, NOW())";
                    MySqlCommand cmd = new MySqlCommand(query);
                    cmd.Parameters.AddWithValue("@TemaId", temaSeleccionado.Id);
                    cmd.Parameters.AddWithValue("@UsuarioId", usuarioSeleccionado);
                    cmd.Parameters.AddWithValue("@Mensaje", mensaje);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Mensaje enviado correctamente.");

                // Actualizar el ListBox con los mensajes
                CargarMensajes(temaSeleccionado.Id);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al enviar el mensaje: " + ex.Message);
            }
        }

        private void comboBoxForo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Tema temaSeleccionado = (Tema)comboBoxForo.SelectedItem;
            if (temaSeleccionado != null)
            {
                CargarMensajes(temaSeleccionado.Id);
            }
        }

        private void CargarMensajes(int temaId)
        {
            listBoxMensajes.Items.Clear();
            try
            {

                {
                    string query = "SELECT u.nombre AS Usuario, m.mensaje AS Mensaje, m.fecha AS Fecha " +
                                   "FROM mensajes m " +
                                   "INNER JOIN usuarios u ON m.usuario_id = u.id " +
                                   "WHERE m.tema_id = @TemaId " +
                                   "ORDER BY m.fecha DESC";
                    MySqlCommand cmd = new MySqlCommand(query);
                    cmd.Parameters.AddWithValue("@TemaId", temaId);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string usuario = reader.GetString("Usuario");
                            string mensaje = reader.GetString("Mensaje");
                            DateTime fecha = reader.GetDateTime("Fecha");
                            listBoxMensajes.Items.Add($"{fecha.ToString("dd/MM/yyyy HH:mm:ss")} - {usuario}: {mensaje}");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los mensajes: " + ex.Message);
            }
        }
    }

    public class Tema
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public override string ToString()
        {
            return Nombre;
        }
    }

}
    

    

