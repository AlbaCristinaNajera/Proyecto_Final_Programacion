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
    public partial class Seguimiento : Form
    {
        private ProgresoCursoDao progresoCursoDao;

        public Seguimiento()
        {
            InitializeComponent();

            // Inicializar el DAO
            progresoCursoDao = new ProgresoCursoDao();
        }

        private void BtnGuardarProgreso_Click_1(object sender, EventArgs e)
        {
            // Suponiendo que tienes los datos del progreso del usuario disponibles en tu formulario
            int usuarioId = ObtenerUsuarioId();
            int cursoId = ObtenerCursoId();
            int progresoPorcentaje = ObtenerProgresoPorcentaje();

            // Crear una instancia de ProgresoCurso y asignar los valores
            ProgresoCurso progreso = new ProgresoCurso();
            progreso.UsuarioId = usuarioId;
            progreso.CursoId = cursoId;
            progreso.ProgresoPorcentaje = progresoPorcentaje;

            // Llamar al método del DAO para guardar el progreso
            progresoCursoDao.GuardarProgreso(progreso);

            // Mostrar mensaje de éxito
            MessageBox.Show("Progreso guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private int ObtenerUsuarioId()
        {
            // Implementar la lógica para obtener el ID del usuario
            return 1; // Solo como ejemplo, deberías obtener el ID del usuario de alguna manera
        }

        private int ObtenerCursoId()
        {
            // Implementar la lógica para obtener el ID del curso
            return 1; // Solo como ejemplo, deberías obtener el ID del curso de alguna manera
        }

        private int ObtenerProgresoPorcentaje()
        {
            // Implementar la lógica para obtener el progreso del usuario
            return 50; // Solo como ejemplo, deberías obtener el progreso del usuario de alguna manera
        }
    }
}
