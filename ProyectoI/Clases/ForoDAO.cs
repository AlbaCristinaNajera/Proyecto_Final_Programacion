using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoI.Clases
{
    internal class ForoDAO
    {
      
public class Mensaje
    {
        public int Id { get; set; }
        public string Contenido { get; set; }
        public string Autor { get; set; }
        public DateTime FechaPublicacion { get; set; }
    }
        private string connectionString;

        public ForoDAO(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void PublicarMensaje(Mensaje mensaje)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO Mensajes (Contenido, Autor, FechaPublicacion) VALUES (@contenido, @autor, @fecha)";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@contenido", mensaje.Contenido);
                    cmd.Parameters.AddWithValue("@autor", mensaje.Autor);
                    cmd.Parameters.AddWithValue("@fecha", mensaje.FechaPublicacion);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<Mensaje> ObtenerMensajes()
        {
            List<Mensaje> mensajes = new List<Mensaje>();
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT Id, Contenido, Autor, FechaPublicacion FROM Mensajes";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Mensaje mensaje = new Mensaje
                            {
                                Id = reader.GetInt32("Id"),
                                Contenido = reader.GetString("Contenido"),
                                Autor = reader.GetString("Autor"),
                                FechaPublicacion = reader.GetDateTime("FechaPublicacion")
                            };
                            mensajes.Add(mensaje);
                        }
                    }
                }
            }
            return mensajes;
        }
    }

}

