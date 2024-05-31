using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;   

namespace ProyectoI.Clases
{
    internal class ProgresoCursoDao
    {
        private string connectionString = "server=localhost;user=root;password=123456789;database=usuarios;";

        // Método existente para obtener el progreso de un usuario
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


        public DataTable ObtenerCalificacionesPorCurso(int idUsuario, int idCurso)
        {
            DataTable calificaciones = new DataTable();

            // Implementación para obtener calificaciones de la base de datos
            // usando idUsuario y idCurso como filtros y llenar el DataTable.

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    string query = "SELECT * FROM calificaciones WHERE id_estudiante = @IdUsuario AND id_curso = @IdCurso";
                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@IdUsuario", idUsuario);
                        command.Parameters.AddWithValue("@IdCurso", idCurso);

                        connection.Open();
                        using (var reader = command.ExecuteReader())
                        {
                            calificaciones.Load(reader);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejo de errores
                Console.WriteLine("Error al obtener calificaciones: " + ex.Message);
            }

            return calificaciones;
        }
    }
}