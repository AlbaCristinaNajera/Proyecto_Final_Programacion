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
        }

        private void MaterialesCursoFrm_Load(object sender, EventArgs e)
        {
            ListarMateriales(1, "documentos");
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
            MaterialesDAO materialesDAO = new MaterialesDAO(); // Crear instancia de MaterialesDAO
            List<MaterialEducativo> materiales = materialesDAO.ObtenerMaterialesEducativos(idCurso, categoria);
            dgvMateriales.DataSource = materiales;
            dgvMateriales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
            }
            else
            {
                modifyMaterial();
            }
            ListarMateriales(1, "documentos");
            limpiarCampos();
            HabDeshabGuardarCancelar(false);
        }

        private void createMaterial()
        {
            MaterialesDAO materialesDAO = new MaterialesDAO(); // Crear instancia de MaterialesDAO
            MaterialEducativo material = new MaterialEducativo();
           // material.ID_Curso = ObtenerIdCurso(); // Debes implementar ObtenerIdCurso() según tu lógica
            material.Nombre = txtNombreMaterial.Text;
            material.Descripcion = txtDescripcion.Text;
            material.Archivo = txtArchivo.Text;
            materialesDAO.InsertarMaterial(material);
            HabilitarCampos(true);
            ListarMateriales(1 , "documentos");
        }

        private void modifyMaterial()
        {
            MaterialesDAO materialesDAO = new MaterialesDAO(); 
            MaterialEducativo material = new MaterialEducativo();

            //int idMaterial = ObtenerIdMaterialSeleccionado(); // Debes implementar ObtenerIdMaterialSeleccionado() según tu lógica
            //material.ID_Material = idMaterial;
           // material.ID_Curso = ObtenerIdCurso(); // Debes implementar ObtenerIdCurso() según tu lógica
            material.Nombre = txtNombreMaterial.Text;
            material.Descripcion = txtDescripcion.Text;
            material.Archivo = txtArchivo.Text;
            materialesDAO.ActualizarMaterial(material);
            HabilitarCampos(true);
            ListarMateriales(1, "documentos");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DataGridViewRow fila = dgvMateriales.SelectedRows[0];
            int idMaterial = (int)fila.Cells[0].Value; // Suponiendo que la primera celda contiene el ID del material educativo
            MaterialesDAO materialesDAO = new MaterialesDAO(); // Instancia de MaterialesDAO
            materialesDAO.EliminarMaterial(idMaterial);
            ListarMateriales(1, "documentos");
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            DataGridViewRow fila = dgvMateriales.SelectedRows[0];
            txtNombreMaterial.Text = (string)fila.Cells[1].Value; // Suponiendo que la segunda celda contiene el nombre del material educativo
            txtDescripcion.Text = (string)fila.Cells[2].Value; // Suponiendo que la tercera celda contiene la descripción del material educativo
            txtArchivo.Text = (string)fila.Cells[3].Value; // Suponiendo que la cuarta celda contiene el archivo del material educativo
            HabDeshabGuardarCancelar(true);
            esNuevo = false;
        }

        private void limpiarCampos()
        {
            txtNombreMaterial.Text = "";
            txtDescripcion.Text = "";
            txtArchivo.Text = "";
            txtCategoria.Text = "";
        }
    }
}
