using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoI.Clases
{
    internal class ProgresoCursoDao
    {
        private string connectionString = "server=localhost;" +"user=root;" +"password=123456789;" +"database=usuarios;";

        public void GuardarProgreso(ProgresoCurso progreso)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO ProgresoCurso (UsuarioId, CursoId, ProgresoPorcentaje, UltimaActualizacion) " +
                               "VALUES (@usuarioId, @cursoId, @progresoPorcentaje, @ultimaActualizacion)";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@usuarioId", progreso.UsuarioId);
                    cmd.Parameters.AddWithValue("@cursoId", progreso.CursoId);
                    cmd.Parameters.AddWithValue("@progresoPorcentaje", progreso.ProgresoPorcentaje);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
