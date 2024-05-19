using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace ProyectoI
{
    public partial class Catalogo : Form
    {

        public Catalogo()
        {
            InitializeComponent();
        }

        public void Catalogo_Load(object sender, EventArgs e)
        {
            DAO dao = new DAO();

            List<Cursos> cursos = dao.ObtenerTodosLosCursos();

            // Cargar los datos en el DataGridView
            dataGridViewCursos.DataSource = cursos;

            dataGridViewCursos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

    }
}

