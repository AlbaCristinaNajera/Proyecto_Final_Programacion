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
    public partial class FrmGestionarCursos : Form
    {
        private bool esNuevo = false;
        public FrmGestionarCursos()
        {
            InitializeComponent();
        }

        private void FrmGestionarCursos_Load(object sender, EventArgs e)
        {
            ListarCursos();
        }

        private void HabilitarCampos(bool readOnly)
        {
            txtNombreCurso.ReadOnly = readOnly;
            txtDescripcionCurso.ReadOnly = readOnly;
            txtHorario.ReadOnly = readOnly; 
        }

        private void ListarCursos()
        {
            DAO dao = new DAO();
            List<Cursos> cursos = dao.ObtenerTodosLosCursos();
            dgvCursos.DataSource = cursos;
            dgvCursos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void HabDeshabGuardarCancelar(bool enable)
        {
            btnGuardar.Enabled = enable;
            btnCancelar.Enabled = enable;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            HabilitarCampos(false);
            HabDeshabGuardarCancelar(true);
            esNuevo = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
            HabilitarCampos (true);
            HabDeshabGuardarCancelar(false);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (esNuevo)
            {
                createCurso();
            }
            else
            {
                modifyCurso();
            }
            ListarCursos();
            limpiarCampos();
            HabDeshabGuardarCancelar(false);
        }

        private void modifyCurso()
        {
            DAO dao = new DAO();
            Cursos curso = new Cursos();

            DataGridViewRow Fila = dgvCursos .SelectedRows[0];
            int id = (int)Fila.Cells[0].Value;
            curso.IdCurso = id;
            curso.NombreCurso = txtNombreCurso.Text;
            curso.Descripcion = txtDescripcionCurso.Text;
            curso.Horario = txtHorario.Text;    
            dao.ActualizarCurso(curso);
            HabilitarCampos(true);
            ListarCursos();
        }

        private void createCurso()
        {
            DAO dao = new DAO();
            Cursos cursos = new Cursos();
            cursos.NombreCurso = txtNombreCurso.Text;
            cursos.Descripcion = txtDescripcionCurso.Text;
            cursos.Horario = txtHorario.Text;
            dao.InsertarCurso(cursos);
            HabilitarCampos (true);
            ListarCursos();
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DataGridViewRow Fila = dgvCursos.SelectedRows[0];
            int id = (int)Fila.Cells[0].Value;
            DAO dao = new DAO();
            dao.EliminarCurso(id);
            ListarCursos();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            DataGridViewRow Fila = dgvCursos.SelectedRows[0];
            txtNombreCurso.Text = (String)Fila.Cells[1].Value;
            txtDescripcionCurso.Text = (String)Fila.Cells[2].Value;
            txtHorario.Text = (string)Fila.Cells[3].Value.ToString();
            HabDeshabGuardarCancelar(true);
            esNuevo = false;
        }

        private void limpiarCampos()
        {
            txtNombreCurso.Text = "";
            txtDescripcionCurso.Text = "";
            txtHorario.Text = "";
        }

    }
}
