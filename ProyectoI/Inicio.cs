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
    public partial class Inicio : Form
    {

        public Inicio()
        {
            InitializeComponent();
            lblBienvenida.Text = $"Hola Bienvenido";
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void maximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            maximizar.Visible = false;
            Restaurar.Visible = true;
        }

        private void Restaurar_Click(object sender, EventArgs e)
        {
            this.WindowState= FormWindowState.Normal;   
            Restaurar.Visible= false;
            maximizar.Visible= true;
        }

        private void minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void mostrarFormulario(Form formHijo)
        {
            formHijo.TopLevel = false;
            formHijo.Dock = DockStyle.Fill;
            formHijo.FormBorderStyle = FormBorderStyle.None;

            pnlOrigen.Controls.Add(formHijo);
            pnlOrigen.Tag = formHijo;

            formHijo.BringToFront();
            formHijo.Show();
        }


        private void btnCatalogo_Click(object sender, EventArgs e)
        {
            mostrarFormulario(new Catalogo());
        }

        private void btnPerfiless_Click(object sender, EventArgs e)
        {
            mostrarFormulario(new Perfiles());
        }

        private void btnMateriales_Click(object sender, EventArgs e)
        {
            mostrarFormulario(new Materiales());
        }

        private void btnContenido_Click(object sender, EventArgs e)
        {
            mostrarFormulario(new Contenido());
        }

        private void btnEvaluaciones_Click(object sender, EventArgs e)
        {
            mostrarFormulario(new Evaluaciones());
        }

        private void btnSeguimiento_Click(object sender, EventArgs e)
        {
            mostrarFormulario(new Seguimiento());   
        }

        private void btnForos_Click(object sender, EventArgs e)
        {
            mostrarFormulario(new Foros());
        }

        private void btnCalificacion_Click(object sender, EventArgs e)
        {
            mostrarFormulario(new Calificaciones());
        }

        private void btnNotificaciones_Click(object sender, EventArgs e)
        {
            mostrarFormulario(new Notificaciones());
        }

        private void btnGestiones_Click(object sender, EventArgs e)
        {
            mostrarFormulario(new Gestiones());
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            mostrarFormulario(new Reportes());
        }
    }
}
