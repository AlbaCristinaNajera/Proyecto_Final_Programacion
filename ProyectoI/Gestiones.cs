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
    public partial class Gestiones : Form
    {
        private GrupoDAO grupoDAO;
        private string connectionString = "server=localhost;" + "user=root;" + "pwd=Umg$2023;" + "database=usuarios;";

        public Gestiones()
        {
            InitializeComponent();
            grupoDAO = new GrupoDAO(connectionString);
            CargarGrupos();
        }

        private void CargarGrupos()
        {
            List<Grupo> grupos = grupoDAO.ObtenerGrupos();
            lstGroups.DataSource = grupos;
            lstGroups.DisplayMember = "NombreGrupo";
            lstGroups.ValueMember = "IdGrupo";
        }

        private void btnAddGroup_Click(object sender, EventArgs e)
        {
            Grupo nuevoGrupo = new Grupo
            {
                NombreGrupo = txtGroupName.Text,
                Descripcion = txtGroupDescription.Text
            };
            grupoDAO.AgregarGrupo(nuevoGrupo);
            CargarGrupos();
        }

        private void btnDeleteGroup_Click(object sender, EventArgs e)
        {
            if(lstGroups.SelectedValue != null)
        {
                int idGrupo = (int)lstGroups.SelectedValue;
                grupoDAO.EliminarGrupo(idGrupo);
                CargarGrupos();
            }
        }

        private void btnEditGroup_Click(object sender, EventArgs e)
        {
            if (lstGroups.SelectedValue != null)
            {
                Grupo grupoSeleccionado = (Grupo)lstGroups.SelectedItem;
                grupoSeleccionado.NombreGrupo = txtGroupName.Text;
                grupoSeleccionado.Descripcion = txtGroupDescription.Text;
                grupoDAO.ActualizarGrupo(grupoSeleccionado);
                CargarGrupos();
            }
        }

        private void lstGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstGroups.SelectedItem != null)
            {
                Grupo grupoSeleccionado = (Grupo)lstGroups.SelectedItem;
                txtGroupName.Text = grupoSeleccionado.NombreGrupo;
                txtGroupDescription.Text = grupoSeleccionado.Descripcion;
            }
        }
    }
}
