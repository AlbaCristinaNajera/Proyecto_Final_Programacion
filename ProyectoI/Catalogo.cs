using System;
using System.Data;
using System.Windows.Forms;

namespace ProyectoI
{
    public partial class Catalogo : Form
    {
        DataTable table = new DataTable();
        DataGridView dataGridView1;
        Button btnDelete;

        public Catalogo()
        {
            InitializeComponent();
        }

        public void    Catalogo_Load(object sender, EventArgs e)
        {
            // Crear el control DataGridView
            dataGridView1 = new DataGridView();
            dataGridView1.Dock = DockStyle.Fill;
            Controls.Add(dataGridView1);

            // Crear el botón para eliminar filas
            btnDelete = new Button();
            btnDelete.Text = "Delete Row";
            btnDelete.Dock = DockStyle.Bottom;
            btnDelete.Click += btnDelete_Click;
            Controls.Add(btnDelete);

            // Configurar las columnas de la tabla DataTable
            table.Columns.Add("Id", typeof(int)); // Tipo de dato int
            table.Columns.Add("First Name", typeof(string)); // Tipo de dato string
            table.Columns.Add("Last Name", typeof(string)); // Tipo de dato string
            table.Columns.Add("Age", typeof(int)); // Tipo de dato int

            // Añadir filas a la tabla
            table.Rows.Add(1, "First A", "Last A", 10);
            table.Rows.Add(2, "First B", "Last B", 20);
            table.Rows.Add(3, "First C", "Last C", 30);
            table.Rows.Add(4, "First D", "Last D", 40);
            table.Rows.Add(5, "First E", "Last E", 50);
            table.Rows.Add(6, "First F", "Last F", 60);
            table.Rows.Add(7, "First G", "Last G", 70);
            table.Rows.Add(8, "First H", "Last H", 80);

            // Asignar la tabla como fuente de datos del control DataGridView
            dataGridView1.DataSource = table;
        }

        // Eliminar la fila seleccionada del DataGridView
        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Obtener el índice de la fila seleccionada en el DataGridView
            // y eliminar la fila correspondiente de la tabla DataTable
            // luego, volver a enlazar el DataGridView con la tabla
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int rowIndex = dataGridView1.SelectedCells[0].RowIndex;
                table.Rows.RemoveAt(rowIndex);
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una fila para eliminar.");
            }
        }
    }
}

