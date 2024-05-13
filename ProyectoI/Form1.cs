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
    public partial class Form1 : Form
    {
        private string connectionString = "Server=localhost;database=usuarios;Uid=root;Pwd=aguapura02;";

        public Form1()
        {
            InitializeComponent();
            txtContraseña.UseSystemPasswordChar = true;
            txtContraseña.PasswordChar = '*'; 

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;

        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtUsuario.Text = string.Empty;
            txtContraseña.Text = string.Empty;

        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contraseña = txtContraseña.Text;

            MySqlConnection conexion = new MySqlConnection(connectionString);

            try
            {
                conexion.Open();

                string consulta = "SELECT * FROM Usuarios_Registrados WHERE nombre_usuario = @usuario AND contrasena = @contraseña";

                MySqlCommand comando = new MySqlCommand(consulta, conexion);

                comando.Parameters.AddWithValue("@usuario", usuario);
                comando.Parameters.AddWithValue("@contraseña", contraseña);

                MySqlDataReader reader = comando.ExecuteReader();

                if (reader.Read())
                {
                    Form inicio  = new Inicio();
                    inicio.Show();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos.");
                }
                reader.Close();
                conexion.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al conectar a la base de datos: " + ex.Message);
            }
            finally
            {
                if (conexion.State == System.Data.ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
        }
    }
}
