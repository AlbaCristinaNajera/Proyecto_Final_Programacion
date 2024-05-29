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
        private string connectionString = "server=localhost;user=root;password=aguapura02;database=usuarios;";

        public ProgresoCurso ObtenerProgresoUsuario(int usuarioId)
        {
            ProgresoCurso progreso = null;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT UsuarioId, CursoId, ProgresoPorcentaje FROM ProgresoCurso WHERE UsuarioId = @usuarioId";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@usuarioId", usuarioId);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            progreso = new ProgresoCurso();
                            progreso.UsuarioId = Convert.ToInt32(reader["UsuarioId"]);
                            progreso.CursoId = Convert.ToInt32(reader["CursoId"]);
                            progreso.ProgresoPorcentaje = Convert.ToInt32(reader["ProgresoPorcentaje"]);
                        }
                    }
                }                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               
            }

            return progreso;
        }
    }
}
