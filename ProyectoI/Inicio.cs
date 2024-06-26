﻿using ProyectoI.Clases;
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
        public Usuario usuario { get; set; } 

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
           // formHijo.Owner = this;

            pnlOrigen.Controls.Add(formHijo);
            pnlOrigen.Tag = formHijo;

            formHijo.BringToFront();
            formHijo.Show();
        }


        private void btnCatalogo_Click(object sender, EventArgs e)
        {
            FrmCatalogoDeCursos form = new FrmCatalogoDeCursos(); 
            form.usuario = usuario;
            mostrarFormulario(form);
            
        }

        private void btnPerfiless_Click(object sender, EventArgs e)
        {
            FrmGestionDePerfilesDeUsuarios form = new FrmGestionDePerfilesDeUsuarios();
            form.usuario = usuario;
            mostrarFormulario(form);
        }

        private void btnMateriales_Click(object sender, EventArgs e)
        {
            mostrarFormulario(new FrmMaterialesEstudiante());
        }

        private void btnContenido_Click(object sender, EventArgs e)
        {
            mostrarFormulario(new MaterialesCursoFrm());
        }

        private void btnEvaluaciones_Click(object sender, EventArgs e)
        {
            FormPreguntasEstudiante form = new FormPreguntasEstudiante();
            form.usuario = usuario;
            mostrarFormulario(form);
        }

        private void btnSeguimiento_Click(object sender, EventArgs e)
        {
            Seguimiento Form = new Seguimiento();
            Form.usuario = usuario;
            mostrarFormulario(Form);   
        }

        private void btnForos_Click(object sender, EventArgs e)
        {
            Foros form = new Foros();
            form.usuario = usuario;
            mostrarFormulario(form);
        }

        private void btnCalificacion_Click(object sender, EventArgs e)
        {
            mostrarFormulario(new FRMCalificaciones());
        }

        private void btnGestiones_Click(object sender, EventArgs e)
        {
            mostrarFormulario(new Gestiones());
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            mostrarFormulario(new Reportes());
        }

        private void pnlOrigen_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnGrupos_Click(object sender, EventArgs e)
        {
            FRMGruposEstudiantes Form = new FRMGruposEstudiantes();
            Form.usuario = usuario;
            mostrarFormulario(Form);
        }
    }
}
