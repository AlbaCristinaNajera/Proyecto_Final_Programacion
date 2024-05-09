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

      

        private void btnCatalogo_Click(object sender, EventArgs e)
        {
            Form catalogo = new Catalogo();
            catalogo.Show();
        }

        private void btnPerfiless_Click(object sender, EventArgs e)
        {
            Form perfiles = new Perfiles();
            perfiles.Show();
        }

        private void btnMateriales_Click(object sender, EventArgs e)
        {
            Form materiales = new Materiales();
            materiales.Show();
        }

        private void btnContenido_Click(object sender, EventArgs e)
        {
            Form contenido = new Contenido();
            contenido.Show();
        }

        private void btnEvaluaciones_Click(object sender, EventArgs e)
        {
            Form evaluaciones = new Evaluaciones();
            evaluaciones.Show();
        }

        private void btnSeguimiento_Click(object sender, EventArgs e)
        {
            Form seguimiento = new Seguimiento();
            seguimiento.Show();
        }

        private void btnForos_Click(object sender, EventArgs e)
        {
            Form foros = new Foros();
            foros.Show();
        }

        private void btnCalificacion_Click(object sender, EventArgs e)
        {
            Form calificacion = new Calificaciones();
            calificacion.Show();
        }

        private void btnNotificaciones_Click(object sender, EventArgs e)
        {
            Form notificaciones = new Notificaciones();
            notificaciones.Show();
        }

        private void btnGestiones_Click(object sender, EventArgs e)
        {
            Form gestiones = new Gestiones();
            gestiones.Show();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            Form reportes = new Reportes();
            reportes.Show();
        }
    }
}
