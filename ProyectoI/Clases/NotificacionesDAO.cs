using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoI.Clases
{
    internal class NotificacionesDAO
    {
        private string connectionString = "server=localhost;" +
                                          "user=root;" +
                                          "pwd=Umg$2023;" +
                                          "database=usuarios;";

        public void EnviarNotificacion(Notificacion notificacion)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO notificaciones (usuario_id, titulo, mensaje, fecha, leido) " +
                               "VALUES (@UsuarioId, @Titulo, @Mensaje, @Fecha, @Leido)";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UsuarioId", notificacion.UsuarioId);
                    cmd.Parameters.AddWithValue("@Titulo", notificacion.Titulo);
                    cmd.Parameters.AddWithValue("@Mensaje", notificacion.Mensaje);
                    cmd.Parameters.AddWithValue("@Fecha", notificacion.Fecha);
                    cmd.Parameters.AddWithValue("@Leido", notificacion.Leido);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<Notificacion> ObtenerNotificaciones(int usuarioId)
        {
            var notificaciones = new List<Notificacion>();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM notificaciones WHERE usuario_id = @UsuarioId";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UsuarioId", usuarioId);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var notificacion = new Notificacion
                            {
                                Id = reader.GetInt32("id"),
                                UsuarioId = reader.GetInt32("usuario_id"),
                                Titulo = reader.GetString("titulo"),
                                Mensaje = reader.GetString("mensaje"),
                                Fecha = reader.GetDateTime("fecha"),
                                Leido = reader.GetBoolean("leido")
                            };
                            notificaciones.Add(notificacion);
                        }
                    }
                }
            }

            return notificaciones;
        }

        public void MarcarComoLeida(int notificacionId)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE notificaciones SET leido = 1 WHERE id = @Id";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", notificacionId);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
