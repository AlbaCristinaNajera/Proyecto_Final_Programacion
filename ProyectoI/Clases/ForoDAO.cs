using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace ProyectoI
{
    public class DaoForo
    {
        private string connectionString = "server=localhost;" +
        "user=root;" +
        "pwd=123456789;" +
        "database=usuarios;";

        private MySqlConnection ObtenerConexion()
        {
            var connection = new MySqlConnection(connectionString);
            connection.Open();
            return connection;
        }

        // Método para cargar foros desde la base de datos
        public List<KeyValuePair<int, string>> CargarForos()
        {
            var foros = new List<KeyValuePair<int, string>>();
            using (MySqlConnection conn = ObtenerConexion())
            {
                try
                {
                    string query = "SELECT id_foro, nombre_foro FROM foros";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                foros.Add(new KeyValuePair<int, string>(reader.GetInt32("id_foro"), reader.GetString("nombre_foro")));
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al cargar foros: " + ex.Message);
                }
            }
            return foros;
        }

        // Método para cargar la descripción de un foro específico
        public string CargarDescripcion(int idForo)
        {
            string descripcion = string.Empty;
            using (MySqlConnection conn = ObtenerConexion())
            {
                try
                {
                    string query = "SELECT descripcion FROM foros WHERE id_foro = @id_foro";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id_foro", idForo);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                descripcion = reader.GetString("descripcion");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al cargar la descripción: " + ex.Message);
                }
            }
            return descripcion;
        }

        // Método para crear una nueva respuesta en la base de datos
        public void CrearRespuesta(int idForo, int idUsuario, string respuesta)
        {
            using (MySqlConnection conn = ObtenerConexion())
            {
                try
                {
                    string query = "INSERT INTO foro_respuestas (id_foro, id_usuario, respuesta, fecha_respuesta) VALUES (@id_foro, @id_usuario, @respuesta, @fecha_respuesta)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id_foro", idForo);
                        cmd.Parameters.AddWithValue("@id_usuario", idUsuario);
                        cmd.Parameters.AddWithValue("@respuesta", respuesta);
                        cmd.Parameters.AddWithValue("@fecha_respuesta", DateTime.Now);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al crear respuesta: " + ex.Message);
                }
            }
        }

        public List<KeyValuePair<string, string>> CargarRespuestas(int idForo)
        {
            var respuestas = new List<KeyValuePair<string, string>>();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT u.nombre, r.respuesta FROM foro_respuestas r JOIN usuarios_Registrados u ON r.id_usuario = u.Id WHERE r.id_foro = @id_foro";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id_foro", idForo);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                respuestas.Add(new KeyValuePair<string, string>(reader.GetString("nombre"), reader.GetString("respuesta")));
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al obtener las respuestas del foro: " + ex.Message);
                }
            }

            return respuestas;
        }
    }
}