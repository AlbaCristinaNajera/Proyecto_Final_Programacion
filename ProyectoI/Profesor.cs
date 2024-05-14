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
    public partial class Profesor : Form
    {
        public Profesor()
        {
            InitializeComponent();
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Max_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            Max.Visible = false;
            Restaurar.Visible = true;
        }

        private void Restaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            Restaurar.Visible = false;
            Max.Visible = true;
        }

        private void Min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnPerfiless_Click(object sender, EventArgs e)
        {
            Form perfiles = new Perfiles();
            perfiles.Show();
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

        private void btnCalificacion_Click(object sender, EventArgs e)
        {
            Form calificacion = new Calificaciones();
            calificacion.Show();
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
