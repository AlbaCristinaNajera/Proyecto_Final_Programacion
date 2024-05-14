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
    public partial class Roles : Form
    {
        public Roles()
        {
            InitializeComponent();
        }

        private void btnProfesor_Click(object sender, EventArgs e)
        {
            Form formProfesor = new Profesor();
            
            formProfesor.Show();
            
            this.Hide();

        }

        private void btnEstudiante_Click(object sender, EventArgs e)
        {
            Form FormEstudiante = new Inicio();
            FormEstudiante.Show();
            this.Hide();
        }

    }
}
