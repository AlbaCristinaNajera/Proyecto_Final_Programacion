using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crmf;
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
    public partial class FrmMaterialesEstudiante : Form
    {
        public FrmMaterialesEstudiante()
        {
            InitializeComponent();
            this.comboBoxCursos.SelectedIndexChanged += new System.EventHandler(this.comboBoxCursos_SelectedIndexChanged);
            this.Load += new System.EventHandler(this.FrmMaterialesEstudiante_Load);
            this.TabMateriales.SelectedIndexChanged += new System.EventHandler(this.TabMateriales_SelectedIndexChanged);
            this.ListBoxDocumentos.SelectedIndexChanged += new System.EventHandler(this.ListBoxDocumentos_SelectedIndexChanged);
            this.ListBoxPresentaciones.SelectedIndexChanged += new System.EventHandler(this.ListBoxPresentaciones_SelectedIndexChanged);
            this.ListBoxVideos.SelectedIndexChanged += new System.EventHandler(this.ListBoxVideos_SelectedIndexChanged);
        }

        private void FrmMaterialesEstudiante_Load(object sender, EventArgs e)
        {
            CargarCursos();
        }

        private void CargarCursos()
        {
            MaterialesDAO materialesDAO = new MaterialesDAO();
            List<Cursos> cursos = materialesDAO.ObtenerCursos();

            comboBoxCursos.DataSource = cursos;
            comboBoxCursos.DisplayMember = "NombreCurso";
            comboBoxCursos.ValueMember = "IdCurso";
        }

        private void comboBoxCursos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxCursos.SelectedItem != null)
            {
                ConsultarMateriales(ObtenerIdCursoSeleccionado(), ObtenerCategoriaSeleccionada());
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
            // Aquí deberías definir cómo obtener la categoría seleccionada, por ejemplo:
            int index = TabMateriales.SelectedIndex;
            if (index == 0) return "documentos";
            if (index == 1) return "presentaciones";
            return "videos";
        }

        private void ConsultarMateriales(int id_curso, string categoria)
        {
            MaterialesDAO materialesDAO = new MaterialesDAO();
            List<MaterialEducativo> materiales = materialesDAO.ObtenerMaterialesEducativos(id_curso, categoria);

            if (categoria == "documentos")
            {
                ListBoxDocumentos.Items.Clear();
                foreach (MaterialEducativo material in materiales)
                {
                    ListBoxDocumentos.Items.Add(material.Archivo);
                }
            }
            else if (categoria == "presentaciones")
            {
                ListBoxPresentaciones.Items.Clear();
                foreach (MaterialEducativo material in materiales)
                {
                    ListBoxPresentaciones.Items.Add(material.Archivo);
                }
            }
            else if (categoria == "videos")
            {
                ListBoxVideos.Items.Clear();
                foreach (MaterialEducativo material in materiales)
                {
                    ListBoxVideos.Items.Add(material.Archivo);
                }
            }
        }

        private void TabMateriales_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConsultarMateriales(ObtenerIdCursoSeleccionado(), ObtenerCategoriaSeleccionada());
        }

        private void ListBoxDocumentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListBoxDocumentos.SelectedItem != null)
            {
                webBrowser1.Navigate(ListBoxDocumentos.SelectedItem.ToString());
            }
        }

        private void ListBoxPresentaciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListBoxPresentaciones.SelectedItem != null)
            {
                webBrowser1.Navigate(ListBoxPresentaciones.SelectedItem.ToString());
            }
        }

        private void ListBoxVideos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListBoxVideos.SelectedItem != null)
            {
                webBrowser1.Navigate(ListBoxVideos.SelectedItem.ToString());
            }
        }


    }
}
