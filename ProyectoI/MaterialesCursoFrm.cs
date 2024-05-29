using ProyectoI.Clases;
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
    public partial class MaterialesCursoFrm : Form
    {
        private bool esNuevo = false;
        private MaterialesDAO materialesDAO = new MaterialesDAO();

        public MaterialesCursoFrm()
        {
            InitializeComponent();
            LoadCursos();
            comboBoxCursos.SelectedIndexChanged += comboBoxCursos_SelectedIndexChanged;
        }

        private void MaterialesCursoFrm_Load(object sender, EventArgs e)
        {
            // No es necesario cargar la categoría si no se usará.
        }

        private void HabilitarCampos(bool readOnly)
        {
            txtNombreMaterial.ReadOnly = readOnly;
            txtDescripcion.ReadOnly = readOnly;
            txtArchivo.ReadOnly = readOnly;
            // txtCategoria.ReadOnly = readOnly; // No se necesita si no usas categoría.
        }

        private void ListarMateriales(int idCurso)
        {
            List<MaterialEducativo> materiales = materialesDAO.ObtenerMaterialesEducativosPorCurso(idCurso);
            dgvMateriales.DataSource = materiales;
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
            HabilitarCampos(true);
            HabDeshabGuardarCancelar(false);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (esNuevo)
            {
                createMaterial();
                MessageBox.Show("Material creado correctamente.");
            }
            else
            {
                modifyMaterial();
                MessageBox.Show("Material actualizado correctamente.");
            }
            ListarMateriales(ObtenerIdCursoSeleccionado());
            limpiarCampos();
            HabDeshabGuardarCancelar(false);
        }

        private void createMaterial()
        {
            MaterialEducativo material = new MaterialEducativo
            {
                ID_Curso = ObtenerIdCursoSeleccionado(),
                Nombre = txtNombreMaterial.Text,
                Descripcion = txtDescripcion.Text,
                Archivo = txtArchivo.Text,
                Categoria = txtCategoria.Text
            };
            materialesDAO.InsertarMaterial(material);
            HabilitarCampos(true);
            ListarMateriales(ObtenerIdCursoSeleccionado());
        }

        private void modifyMaterial()
        {
            MaterialEducativo material = new MaterialEducativo
            {
                ID_Curso = ObtenerIdCursoSeleccionado(),
                Nombre = txtNombreMaterial.Text,
                Descripcion = txtDescripcion.Text,
                Archivo = txtArchivo.Text,
                Categoria = txtCategoria.Text,
                ID_Material = ObtenerIdMaterialSeleccionado()
            };
            materialesDAO.ActualizarMaterial(material);
            HabilitarCampos(true);
            ListarMateriales(ObtenerIdCursoSeleccionado());
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int idMaterial = ObtenerIdMaterialSeleccionado();
            materialesDAO.EliminarMaterial(idMaterial);
            ListarMateriales(ObtenerIdCursoSeleccionado());
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (dgvMateriales.SelectedRows.Count > 0)
            {
                DataGridViewRow fila = dgvMateriales.SelectedRows[0];
                txtNombreMaterial.Text = fila.Cells["Nombre"].Value.ToString();
                txtDescripcion.Text = fila.Cells["Descripcion"].Value.ToString();
                txtArchivo.Text = fila.Cells["Archivo"].Value.ToString();
                txtCategoria.Text = fila.Cells["categoria"].Value.ToString(); // No se necesita si no usas categoría.
            }
        }

        private void limpiarCampos()
        {
            txtNombreMaterial.Text = "";
            txtDescripcion.Text = "";
            txtArchivo.Text = "";
            txtCategoria.Text = "";
        }

        private void comboBoxCursos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxCursos.SelectedItem != null)
            {
                ListarMateriales(ObtenerIdCursoSeleccionado());
            }
        }

        private int ObtenerIdCursoSeleccionado()
        {
            if (comboBoxCursos.SelectedItem != null)
            {
                Cursos cursoSeleccionado = comboBoxCursos.SelectedItem as Cursos;
                return cursoSeleccionado.IdCurso;
            }
            return 0;
        }

        private int ObtenerIdMaterialSeleccionado()
        {
            if (dgvMateriales.SelectedRows.Count > 0)
            {
                DataGridViewRow fila = dgvMateriales.SelectedRows[0];
                return (int)fila.Cells["ID_Material"].Value;
            }
            return 0;
        }

        private void LoadCursos()
        {
            DAO cursosDAO = new DAO();
            List<Cursos> cursos = cursosDAO.ObtenerTodosLosCursos();

            comboBoxCursos.DataSource = cursos;
            comboBoxCursos.DisplayMember = "NombreCurso";
            comboBoxCursos.ValueMember = "IdCurso";
        }
    }
}
