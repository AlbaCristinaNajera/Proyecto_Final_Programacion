using MySql.Data.MySqlClient;
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
    public partial class Registrarse : Form
    {
        private string connectionString = "Server=localhost;database=usuarios;Uid=root;Pwd=123456789;";

        public Registrarse()
        {
            InitializeComponent();
            txtContraseñaU.UseSystemPasswordChar = true;
            txtContraseñaU.PasswordChar = '*';
        }

        private void btnRegistroUsuario_Click(object sender, EventArgs e)
        {
            string usuario = txtNombreU.Text;
            string correo = txtCorreo.Text;
            string contraseña = txtContraseñaU.Text;

            MySqlConnection conexion = new MySqlConnection(connectionString);

            if (!string.IsNullOrWhiteSpace(txtNombreU.Text) && !string.IsNullOrWhiteSpace(txtContraseñaU.Text) && !string.IsNullOrWhiteSpace(txtCorreo.Text))
            {
                try
                {
                    // Abre la conexión a la base de datos
                    conexion.Open();

                    // Prepara la consulta SQL para insertar un nuevo usuario
                    string consulta = "INSERT INTO Usuarios_Registrados (nombre_usuario, contrasena, Correo) VALUES (@nombre, @contrasena, @correo)";

                    // Crea un nuevo comando SQL
                    MySqlCommand comando = new MySqlCommand(consulta, conexion); // Cambia a MySqlCommand


                    // Añade parámetros a la consulta
                    comando.Parameters.AddWithValue("@nombre", txtNombreU.Text);
                    comando.Parameters.AddWithValue("@contrasena", txtContraseñaU.Text);
                    comando.Parameters.AddWithValue("@correo", txtCorreo.Text);

                    // Ejecuta la consulta
                    comando.ExecuteNonQuery();

                    // Cierra la conexión
                    conexion.Close();

                    // Muestra un mensaje de éxito
                    MessageBox.Show("Usuario agregado correctamente a la base de datos.");

                    // Limpia los campos del formulario
                    LimpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar usuario: " + ex.Message);
                }
                finally
                {
                    if (conexion.State == System.Data.ConnectionState.Open)
                    {
                        conexion.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, complete todos los campos.");
            }
        }

        private void LimpiarCampos()
        {
            // Limpia los campos de texto del formulario
            txtNombreU.Text = "";
            txtContraseñaU.Text = "";
            txtCorreo.Text = "";
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Form entrar = new Form1();
            entrar.Show();
        }
    }
}
