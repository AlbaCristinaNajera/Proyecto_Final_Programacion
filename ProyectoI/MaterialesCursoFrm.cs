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
            comboBoxCategoria.SelectedIndexChanged += comboBoxCategoria_SelectedIndexChanged;
        }

        private void MaterialesCursoFrm_Load(object sender, EventArgs e)
        {
            comboBoxCategoria.Items.Add("Videos");
            comboBoxCategoria.Items.Add("Presentaciones");
            comboBoxCategoria.Items.Add("Documentos");
            comboBoxCategoria.SelectedIndex = 0; // Selecciona el primer elemento por defecto
        }

        private void HabilitarCampos(bool readOnly)
        {
            txtNombreMaterial.ReadOnly = readOnly;
            txtDescripcion.ReadOnly = readOnly;
            txtArchivo.ReadOnly = readOnly;
            txtCategoria.ReadOnly = readOnly;
        }

        private void ListarMateriales(int idCurso, string categoria)
        {

            List<MaterialEducativo> materiales = materialesDAO.ObtenerMaterialesEducativos(idCurso, categoria);
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
            ListarMateriales(ObtenerIdCursoSeleccionado(), ObtenerCategoriaSeleccionada());
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
            ListarMateriales(ObtenerIdCursoSeleccionado(), ObtenerCategoriaSeleccionada());
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
            ListarMateriales(ObtenerIdCursoSeleccionado(), ObtenerCategoriaSeleccionada());
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int idMaterial = ObtenerIdMaterialSeleccionado();
            materialesDAO.EliminarMaterial(idMaterial);
            ListarMateriales(ObtenerIdCursoSeleccionado(), ObtenerCategoriaSeleccionada());
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (dgvMateriales.SelectedRows.Count > 0)
            {
                DataGridViewRow fila = dgvMateriales.SelectedRows[0];
                txtNombreMaterial.Text = fila.Cells["Nombre"].Value.ToString();
                txtDescripcion.Text = fila.Cells["Descripcion"].Value.ToString();
                txtArchivo.Text = fila.Cells["Archivo"].Value.ToString();
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
                ListarMateriales(ObtenerIdCursoSeleccionado(), ObtenerCategoriaSeleccionada());
            }
        }

        private void comboBoxCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxCursos.SelectedItem != null)
            {
                ListarMateriales(ObtenerIdCursoSeleccionado(), ObtenerCategoriaSeleccionada());
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

        private string ObtenerCategoriaSeleccionada()
        {
            if (comboBoxCategoria.SelectedItem != null)
            {
                return comboBoxCategoria.SelectedItem.ToString();
            }
            return string.Empty;
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

        private void comboBoxCursos_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
