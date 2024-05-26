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
                webBrowser2.Navigate(ListBoxPresentaciones.SelectedItem.ToString());
            }

        }

        private void ListBoxVideos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListBoxVideos.SelectedItem != null)
            {
                webBrowser3.Navigate(ListBoxVideos.SelectedItem.ToString());
            }

        }

        private void TabMaterialesIndexChanged(object sender, EventArgs e)
        {
            ConsultarMateriales(1, "documentos");

        }

        private void ConsultarMateriales(int id_curso, string categoria)
        {
            int i = TabMateriales.SelectedIndex;
            MaterialesDAO materialesDAO = new MaterialesDAO();

            if (i==0)
            {
                categoria = "documentos";

                List<MaterialEducativo> materiales = materialesDAO.ObtenerMaterialesEducativos(1, categoria);

                ListBoxDocumentos.Items.Clear();

                foreach (MaterialEducativo material in materiales)
                {
                    ListBoxDocumentos.Items.Add(material.Archivo);
                }

            }
            else if (i == 1)
            {
                categoria = "presentaciones";

                List<MaterialEducativo> materiales = materialesDAO.ObtenerMaterialesEducativos(1, categoria);

                ListBoxPresentaciones.Items.Clear();

                foreach (MaterialEducativo material in materiales)
                {
                    ListBoxPresentaciones.Items.Add(material.Archivo);
                }
            }
            else
            {
                categoria = "videos";

                List<MaterialEducativo> materiales = materialesDAO.ObtenerMaterialesEducativos(1, categoria);

                ListBoxVideos.Items.Clear();
                foreach (MaterialEducativo material in materiales)
                {
                    ListBoxVideos.Items.Add(material.Archivo);
                }
            }

        }

        private void Materiales_Load(object sender, EventArgs e)
        {
            ConsultarMateriales(1, "documentos");
        }

        private void MenuSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MenuPerfil_Click(object sender, EventArgs e)
        {
            FrmGestionDePerfilesDeUsuarios cursosForm = new FrmGestionDePerfilesDeUsuarios();
            cursosForm.Show();
        }

        private void MenuCurso_Click(object sender, EventArgs e)
        {
            FrmCatalogoDeCursos cursosForm = new FrmCatalogoDeCursos(); 
            cursosForm.Show();
        }

      
    }
}
