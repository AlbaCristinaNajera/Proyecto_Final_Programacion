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

        // Nuevo método para obtener las calificaciones de un curso
        public List<Calificacion> ObtenerCalificacionesPorCurso(int cursoId)
        {
            List<Calificacion> calificaciones = new List<Calificacion>();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT UsuarioId, CursoId, Calificacion FROM Calificaciones WHERE CursoId = @cursoId";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@cursoId", cursoId);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Calificacion calificacion = new Calificacion();
                            calificacion.UsuarioId = Convert.ToInt32(reader["UsuarioId"]);
                            calificacion.CursoId = Convert.ToInt32(reader["CursoId"]);
                            calificacion.CalificacionValor = Convert.ToInt32(reader["Calificacion"]);
                            calificaciones.Add(calificacion);
                        }
                    }
                }
            }

            return calificaciones;
        }
    }
}