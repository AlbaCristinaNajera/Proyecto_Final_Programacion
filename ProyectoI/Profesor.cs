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
        public Usuario usuario { get; set; }    

        public Profesor()
        {
            InitializeComponent();
            OcultarSubMenu();
        }
        private void OcultarSubMenu()
        {
            pnlSubMenuContenido.Visible = false;
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

        private void mostrarFormulario(Form formHijo)
        {
            formHijo.TopLevel = false; 
            formHijo.Dock= DockStyle.Fill;
            formHijo.FormBorderStyle = FormBorderStyle.None;

            pnlPrincipal.Controls.Add(formHijo);
            pnlPrincipal.Tag = formHijo;

            formHijo.BringToFront();
            formHijo.Show();
        }
        
        private void MostrarSubMenu(Panel SubMenu)
        {
            pnlSubMenuContenido.Visible = true;
            SubMenu.Visible = true;
        }

        private void btnGestionarPerfiles_Click(object sender, EventArgs e)
        {
            Perfiles form = new Perfiles();
            form.usuario = usuario;
            mostrarFormulario(form);
        }

        private void btnContenido_Click_1(object sender, EventArgs e)
        {
            MostrarSubMenu(pnlSubMenuContenido);
        }

        private void btnMaterialesCurso_Click(object sender, EventArgs e)
        {
            OcultarSubMenu();
            mostrarFormulario(new MaterialesCursoFrm());
            
        }

        private void btnCursos_Click(object sender, EventArgs e)
        {
            OcultarSubMenu();
            mostrarFormulario(new FrmGestionarCursos());
        }

        private void btnEvaluaciones_Click_1(object sender, EventArgs e)
        {
            mostrarFormulario(new Evaluaciones());
        }

        private void btnCalificaciones_Click(object sender, EventArgs e)
        {
            mostrarFormulario(new Calificaciones());
        }

        private void btnGestionGrupos_Click(object sender, EventArgs e)
        {
            mostrarFormulario(new Gestiones());
        }

        private void btnReportes_Click_1(object sender, EventArgs e)
        {
            mostrarFormulario(new Reportes());
        }
    }
}
