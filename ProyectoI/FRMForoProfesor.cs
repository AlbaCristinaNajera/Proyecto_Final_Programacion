using MySql.Data.MySqlClient;
using ProyectoI.Clases;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace ProyectoI
{
    public partial class FRMForoProfesor : Form
    {
        private ForoProfeDAO daoForoProfe;
       
        public FRMForoProfesor()
        {
            InitializeComponent();
            daoForoProfe = new ForoProfeDAO();
            CargarForos();
        }

        private void CargarForos()
        {
            comboBoxPregunta.Items.Clear();

            try
            {
                var foros = daoForoProfe.CargarForos();
                foreach (var foro in foros)
                {
                    comboBoxPregunta.Items.Add(foro);
                }
                comboBoxPregunta.DisplayMember = "Value";
                comboBoxPregunta.ValueMember = "Key";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar foros: " + ex.Message);
            }
        }

        private void comboBoxPregunta_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxMostrarRespuestas.Items.Clear();

            if (comboBoxPregunta.SelectedItem != null)
            {
                var foroSeleccionado = (KeyValuePair<int, string>)comboBoxPregunta.SelectedItem;

                try
                {
                    string descripcion = daoForoProfe.ObtenerDescripcionForo(foroSeleccionado.Key);
                    listBoxMostrarRespuestas.Items.Add(descripcion);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar la descripción del foro: " + ex.Message);
                }
            }
        }

        private void ButtonCrearForo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Presiona aceptar para crear este foro.");  // Mensaje para confirmar que el evento se dispara
            string nombreForo = txtNombre.Text;
            string descripcionForo = txtDescripcion.Text; 

            // Verificación básica antes de intentar crear el foro
            if (string.IsNullOrEmpty(nombreForo) || string.IsNullOrEmpty(descripcionForo))
            {
                MessageBox.Show("Por favor, completa todos los campos antes de crear el foro.");
                return;
            }

            try
            {
                daoForoProfe.CrearForo(nombreForo, descripcionForo);
                MessageBox.Show("Foro creado exitosamente.");
                CargarForos();

                // Limpieza de los campos después de la creación exitosa
                txtNombre.Clear();
                txtDescripcion.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear foro: " + ex.Message);
            }
        }

    }
}