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
       private AuthenticationDAO authenticationDAO;

        public Registrarse()
        {
            InitializeComponent();
            txtContraseñaU.UseSystemPasswordChar = true;
            txtContraseñaU.PasswordChar = '*';
            authenticationDAO = new AuthenticationDAO();
        }

        private void btnRegistroUsuario_Click(object sender, EventArgs e)
        {
            string usuario = txtNombreU.Text;
            string apellido = txtApellido.Text;    
            string correo = txtCorreo.Text;
            string contraseña = txtContraseñaU.Text;
            string rol = txtRol.Text;
            

          

            if (!string.IsNullOrWhiteSpace(txtNombreU.Text) && !string.IsNullOrWhiteSpace(txtApellido.Text) && !string.IsNullOrWhiteSpace(txtContraseñaU.Text) && !string.IsNullOrWhiteSpace(txtCorreo.Text))
            {
                try
                {
                   authenticationDAO.RegistrarUsuario(usuario, apellido, correo, contraseña, rol);

                    // Muestra un mensaje de éxito
                    MessageBox.Show("Usuario agregado correctamente a la base de datos.");

                    // Limpia los campos del formulario
                    LimpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar usuario: " + ex.Message);
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
            txtApellido.Text = "";
            txtContraseñaU.Text = "";
            txtCorreo.Text = "";
            txtRol.Text = "";
    
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Form entrar = new Form1();
            entrar.Show();
        }

        private void Registrarse_Load(object sender, EventArgs e)
        {

        }
    }
}
