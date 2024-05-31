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
    public partial class FRMGruposEstudiantes : Form
    {
        public Usuario usuario;

        public FRMGruposEstudiantes()
        {
            InitializeComponent();
            this.Load += FRMGruposEstudiantes_Load;
        }

        private void FRMGruposEstudiantes_Load(object sender, EventArgs e)
        {
            CargarGruposDelUsuario();
        }

        private void CargarGruposDelUsuario()
        {
            if (usuario == null)
            {
                MessageBox.Show("Usuario no asignado.");
                return;
            }

            GrupoDAO grupoDAO = new GrupoDAO("server=localhost;user=root;pwd=123456789;database=usuarios;"); 
            List<Grupo> grupos = grupoDAO.ObtenerGruposPorUsuario(usuario.Id_Usuario);

            listViewGrupos.Items.Clear();
            foreach (var grupo in grupos)
            {
                ListViewItem item = new ListViewItem(grupo.NombreGrupo);
                item.SubItems.Add(grupo.Descripcion);
                item.Tag = grupo; // Optional: store the entire object for later use
                listViewGrupos.Items.Add(item);
            }
        }

        private void listViewGrupos_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verificar si se ha seleccionado un elemento en el listView
            // Verificar si se ha seleccionado un elemento en el listView
            if (listViewGrupos.SelectedItems.Count > 0)
            {
                // Obtener el grupo seleccionado
                Grupo grupoSeleccionado = listViewGrupos.SelectedItems[0].Tag as Grupo;

                // Verificar que el grupo seleccionado no sea nulo
                if (grupoSeleccionado != null)
                {
                    // Crear una instancia de GrupoDAO
                    GrupoDAO grupoDAO = new GrupoDAO("server=localhost;user=root;pwd=123456789;database=usuarios;");

                    // Obtener los usuarios asignados al grupo seleccionado
                    List<KeyValuePair<int, string>> nombresUsuarios = grupoDAO.ObtenerNombresUsuariosPorGrupo(grupoSeleccionado.IdGrupo);

                    // Mostrar los nombres de los usuarios en algún lugar de tu formulario
                    MostrarNombresUsuarios(nombresUsuarios);
                }
            }
        }

        private void MostrarNombresUsuarios(List<KeyValuePair<int, string>> nombresUsuarios)
        {
            // Limpiar el control donde se mostrarán los nombres de usuarios (por ejemplo, un ListBox)
            listBoxNombresUsuarios.Items.Clear();

            // Agregar los nombres de usuarios al control (ListBox en este caso)
            foreach (var usuario in nombresUsuarios)
            {
                listBoxNombresUsuarios.Items.Add(usuario.Value);
            }
        }
    }
}
