using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoI.Clases
{
    public class ForoProfeDAO
    {
        private string connectionString = "server=localhost;" +
        "user=root;" +
        "pwd=aguapura02;" +
        "database=usuarios;";

       
        // Método para cargar foros desde la base de datos
        public List<KeyValuePair<int, string>> CargarForos()
        {
            var foros = new List<KeyValuePair<int, string>>();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
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

        // Método para obtener la descripción de un foro específico
        public string ObtenerDescripcionForo(int idForo)
        {
            string descripcion = string.Empty;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
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
                    throw new Exception("Error al obtener la descripción del foro: " + ex.Message);
                }
            }

            return descripcion;
        }

        // Método para crear un nuevo foro en la base de datos
        public void CrearForo(string nombreForo, string descripcion)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO foros (nombre_foro, descripcion) VALUES (@nombre_foro, @descripcion)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nombre_foro", nombreForo);
                        cmd.Parameters.AddWithValue("@descripcion", descripcion);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al crear foro: " + ex.Message);
                }
            }

        }
      

        }
    }

