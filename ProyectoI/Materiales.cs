using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crmf;
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
    public partial class Materiales : Form
    {
        public Materiales()
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

        private void Materiales_Load(object sender, EventArgs e)
        {
            //  Tendria que cargar los documentos
            ListBoxDocumentos.Items.Add("https://www.example.com/sample.pdf");
            ListBoxDocumentos.Items.Add("C:\\path\\to\\localfile.pdf");

            // Tendria que cargar las presentaciones
            ListBoxPresentaciones.Items.Add("https://www.example.com/sample.ppt");
            ListBoxPresentaciones.Items.Add("C:\\Users\\CELESTE ORE\\Documents\\Semestre 3\\PROCESO ADM");

            // Tendri que cargar los videos
            ListBoxVideos.Items.Add("https://youtu.be/wXhTHyIgQ_U?si=v2iexjjyBFtzqCTI");
            ListBoxVideos.Items.Add("C:\\Users\\CELESTE ORE\\Documents\\Semestre 3\\PROGRA I\\Videos");

        }

        private void MenuSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MenuPerfil_Click(object sender, EventArgs e)
        {
            Perfiles cursosForm = new Perfiles();
            cursosForm.Show();
        }

        private void MenuCurso_Click(object sender, EventArgs e)
        {
            Catalogo cursosForm = new Catalogo(); 
            cursosForm.Show();
        }

      
    }
}
