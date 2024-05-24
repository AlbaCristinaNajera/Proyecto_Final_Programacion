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
        private AuthenticationDAO authenticationDAO;

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


        private void PanelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contraseña = txtContraseña.Text;



            try
            {
               

                AuthenticationDAO authDao = new AuthenticationDAO();
                Usuario usuario1 = authDao.AutenticarUsuario(usuario, contraseña);

                if (usuario1 != null)
                {
                    if (usuario1.Rol == "profesor")
                    {
                        Profesor form = new Profesor();
                        form.usuario = usuario1;
                        form.Show();
                    }
                    else
                    {
                        Inicio form = new Inicio();
                        form.usuario = usuario1;
                        form.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar a la base de datos: " + ex.Message);
            }
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            Form registrarse = new Registrarse();
            registrarse.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BarraTitulo_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
