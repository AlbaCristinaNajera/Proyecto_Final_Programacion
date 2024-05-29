using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoI.Clases
{
    // internal class CalificacionDAO

    internal class CalificacionDAO
    {
        private string connectionString = "server=localhost;" +
                                          "user=root;" +
                                          "pwd=123456789;" +
                                          "database=usuarios;";

        public void AsignarCalificacion(Calificacion calificacion)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO calificaciones (usuario_id, curso_id, nota, retroalimentacion, fecha) " +
                               "VALUES (@UsuarioId, @CursoId, @Nota, @Retroalimentacion, @Fecha)";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UsuarioId", calificacion.UsuarioId);
                    cmd.Parameters.AddWithValue("@CursoId", calificacion.CursoId);
                    cmd.Parameters.AddWithValue("@Nota", calificacion.Nota);
                    cmd.Parameters.AddWithValue("@Retroalimentacion", calificacion.Retroalimentacion);
                    cmd.Parameters.AddWithValue("@Fecha", calificacion.Fecha);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<Calificacion> ObtenerCalificaciones(int usuarioId)
        {
            var calificaciones = new List<Calificacion>();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM calificaciones WHERE id_estudiante = @UsuarioId";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UsuarioId", usuarioId);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var calificacion = new Calificacion
                            {
                                Id = reader.GetInt32("id_calificacion"),
                                UsuarioId = reader.GetInt32("id_estudiante"),
                                //CursoId = reader.GetInt32("curso_id"),
                                Nota = reader.GetDouble("calificacion"),
                                Fecha = reader.GetDateTime("fecha_calificacion")
                            };
                            calificaciones.Add(calificacion);
                        }
                    }
                }
            }
            return calificaciones;
        }

        public void ActualizarCalificacion(Calificacion calificacion)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE calificaciones SET nota = @Nota, retroalimentacion = @Retroalimentacion, fecha = @Fecha " +
                               "WHERE id = @Id";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Nota", calificacion.Nota);
                    cmd.Parameters.AddWithValue("@Retroalimentacion", calificacion.Retroalimentacion);
                    cmd.Parameters.AddWithValue("@Fecha", calificacion.Fecha);
                    cmd.Parameters.AddWithValue("@Id", calificacion.Id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
