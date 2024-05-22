using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace ProyectoI
{
    public partial class Catalogo : Form
    {
        public Usuario usuario { get; set; }

        public Catalogo()
        {
            InitializeComponent();
        }

        public void Catalogo_Load(object sender, EventArgs e)
        {
            DAO dao = new DAO();
            List<Cursos> cursos = dao.ObtenerTodosLosCursos();
            dataGridViewCursos.DataSource = cursos;
            dataGridViewCursos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnRegistrarseCurso_Click(object sender, EventArgs e)
        {
            if (dataGridViewCursos.SelectedRows.Count > 0)
            {
                // Obtener el ID del curso seleccionado
                int idCurso = Convert.ToInt32(dataGridViewCursos.SelectedRows[0].Cells["IdCurso"].Value);

                // Obtener el ID del usuario
                int Idusuarios = int.Parse(usuario.Id_Usuario.ToString());

                // Crear una nueva asignación
                AsignacionCursos asignacion = new AsignacionCursos
                {
                    id_estudiante = Idusuarios,
                    id_curso = idCurso
                };

                // Registrar la asignación del curso
                DaoAsignacion daoAsignacion = new DaoAsignacion();
                daoAsignacion.AsignarCursoUsuario(asignacion);

                MessageBox.Show("Curso asignado correctamente.");
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un curso.");
            }
        }
    }
}
