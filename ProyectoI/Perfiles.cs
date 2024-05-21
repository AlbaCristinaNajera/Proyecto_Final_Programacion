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

    public partial class Perfiles : Form
    {
        public Usuario usuario { get; set; }

        private string rutaFotoPerfil;
        public Perfiles()
        {
            InitializeComponent();
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener el ID del usuario ingresado por el usuario
                int idUsuario = int.Parse(txtId.Text);

                string nombre = txtNombre.Text;
                string apellido = txtApellido.Text;
                string correo = txtCorreo.Text;
                string contrasena = txtContraseña.Text; 

                // Actualizar los datos del usuario en la base de datos
                DAO dao = new DAO();
                bool actualizacionExitosa = dao.ActualizarDatosUsuario(idUsuario, nombre, apellido, correo, contrasena);

                if (actualizacionExitosa)
                {
                    MessageBox.Show("Los datos del usuario se actualizaron correctamente.");
                }
                else
                {
                    MessageBox.Show("Error al actualizar los datos del usuario. Por favor, inténtelo de nuevo.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnActualizarFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.gif";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                rutaFotoPerfil = openFileDialog.FileName;

                pictureBoxFotoPerfil.Image = Image.FromFile(rutaFotoPerfil);
            }
        }

        private void Perfiles_Load(object sender, EventArgs e)
        {
            txtId.Text=usuario.Id_Usuario.ToString();
            txtNombre.Text=usuario.Nombre.ToString();
            txtApellido.Text=usuario.Apellido.ToString();   
            txtCorreo.Text=usuario.Correo.ToString();   
            txtContraseña.Text=usuario.Contraseña.ToString();

        }
    }
}
