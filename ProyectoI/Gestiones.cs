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
        private string connectionString = "server=localhost;" + "user=root;" + "pwd=123456789;" + "database=usuarios;";

        public Gestiones()
        {
            InitializeComponent();
            grupoDAO = new GrupoDAO(connectionString);
            CargarGrupos();
            CargarEstudiantesDisponibles();    
        }

        private void CargarGrupos()
        {
            List<Grupo> grupos = grupoDAO.ObtenerGrupos();
            comboBoxGrupos.DataSource = grupos;
            comboBoxGrupos.DisplayMember = "NombreGrupo";
            comboBoxGrupos.ValueMember = "IdGrupo";
        }

        private void CargarEstudiantesDisponibles()
        {
            List<KeyValuePair<int, string>> estudiantes = grupoDAO.CargarNombresEstudiantes();
            lstEstudiantesDisponibles.DataSource = estudiantes;
            lstEstudiantesDisponibles.DisplayMember = "Value"; // Muestra el nombre del estudiante
            lstEstudiantesDisponibles.ValueMember = "Key"; // Guarda el ID del estudiante
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

            MessageBox.Show("Grupo creadoo correctamente");
        }


        private void comboBoxCurso_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstEstudiantesDisponibles_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstEstudiantesAsignados_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            if (lstEstudiantesDisponibles.SelectedItem != null && comboBoxGrupos.SelectedItem != null)
            {
                // Obtener el ID del estudiante seleccionado y el ID del grupo seleccionado
                int idEstudiante = (int)lstEstudiantesDisponibles.SelectedValue;
                int idGrupo = (int)comboBoxGrupos.SelectedValue;

                // Llamar al método para asignar el estudiante al grupo en la base de datos
                grupoDAO.AsignarUsuarioAGrupo(idEstudiante, idGrupo);

                // Agregar el estudiante a la lista de estudiantes asignados
                KeyValuePair<int, string> estudianteAsignado = new KeyValuePair<int, string>(idEstudiante, lstEstudiantesDisponibles.Text);
                lstEstudiantesAsignados.Items.Add(estudianteAsignado);

                MessageBox.Show("Estudiante asigando al grupo");

            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lstEstudiantesAsignados.Items.Clear();
        }

    }
}
