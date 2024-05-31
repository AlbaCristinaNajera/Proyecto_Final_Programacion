using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoI.Clases
{
    internal class GrupoDAO
    {
        private string connectionString = "server=localhost;" +"user=root;" + "pwd=123456789;" + "database=usuarios;";

        public GrupoDAO(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public List<Grupo> ObtenerGrupos()
        {
            List<Grupo> grupos = new List<Grupo>();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM grupos", connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    grupos.Add(new Grupo
                    {
                        IdGrupo = reader.GetInt32("id_grupo"),
                        NombreGrupo = reader.GetString("nombre_grupo"),
                        Descripcion = reader.GetString("descripcion")
                    });
                }
            }
            return grupos;
        }

        public void AgregarGrupo(Grupo grupo)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO grupos (nombre_grupo, descripcion) VALUES (@NombreGrupo, @Descripcion)", connection);
                cmd.Parameters.AddWithValue("@NombreGrupo", grupo.NombreGrupo);
                cmd.Parameters.AddWithValue("@Descripcion", grupo.Descripcion);
                cmd.ExecuteNonQuery();
            }
        }

        public void ActualizarGrupo(Grupo grupo)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("UPDATE grupos SET nombre_grupo = @NombreGrupo, descripcion = @Descripcion WHERE id_grupo = @IdGrupo", connection);
                cmd.Parameters.AddWithValue("@NombreGrupo", grupo.NombreGrupo);
                cmd.Parameters.AddWithValue("@Descripcion", grupo.Descripcion);
                cmd.Parameters.AddWithValue("@IdGrupo", grupo.IdGrupo);
                cmd.ExecuteNonQuery();
            }
        }

        public void EliminarGrupo(int idGrupo)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("DELETE FROM grupos WHERE id_grupo = @IdGrupo", connection);
                cmd.Parameters.AddWithValue("@IdGrupo", idGrupo);
                cmd.ExecuteNonQuery();
            }
        }


        public void AsignarUsuarioAGrupo(int idUsuario, int idGrupo)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO usuarios_grupos (id_usuario, id_grupo) VALUES (@IdUsuario, @IdGrupo)", connection);
                cmd.Parameters.AddWithValue("@IdUsuario", idUsuario);
                cmd.Parameters.AddWithValue("@IdGrupo", idGrupo);
                cmd.ExecuteNonQuery();
            }
        }

        public List<KeyValuePair<int, string>> CargarNombresEstudiantes()
        {
            var nombresEstudiantes = new List<KeyValuePair<int, string>>();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT Id, CONCAT(nombre, ' ', apellido) AS NombreCompleto FROM usuarios_Registrados";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                connection.Open();
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        nombresEstudiantes.Add(new KeyValuePair<int, string>(reader.GetInt32("Id"), reader.GetString("NombreCompleto")));
                    }
                }
            }
            return nombresEstudiantes;
        }

        public List<Grupo> ObtenerGruposPorUsuario(int idUsuario)
        {
            List<Grupo> grupos = new List<Grupo>();

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    string query = @"
                        SELECT g.id_grupo, g.nombre_grupo, g.descripcion
                        FROM grupos g
                        INNER JOIN usuarios_grupos ug ON g.id_grupo = ug.id_grupo
                        WHERE ug.id_usuario = @IdUsuario";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@IdUsuario", idUsuario);
                        connection.Open();

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Grupo grupo = new Grupo
                                {
                                    IdGrupo = reader.GetInt32("id_grupo"),
                                    NombreGrupo = reader.GetString("nombre_grupo"),
                                    Descripcion = reader.GetString("descripcion")
                                };
                                grupos.Add(grupo);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejo de errores
                Console.WriteLine("Error al obtener los grupos del usuario: " + ex.Message);
            }

            return grupos;
        }

        public List<KeyValuePair<int, string>> ObtenerNombresUsuariosPorGrupo(int idGrupo)
        {
            List<KeyValuePair<int, string>> nombresUsuarios = new List<KeyValuePair<int, string>>();

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    string query = @"
                SELECT u.Id, CONCAT(u.nombre, ' ', u.apellido) AS NombreCompleto
                FROM usuarios_Registrados u
                INNER JOIN usuarios_grupos ug ON u.Id = ug.id_usuario
                WHERE ug.id_grupo = @IdGrupo";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@IdGrupo", idGrupo);
                        connection.Open();

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int idUsuario = reader.GetInt32("Id");
                                string nombreCompleto = reader.GetString("NombreCompleto");
                                nombresUsuarios.Add(new KeyValuePair<int, string>(idUsuario, nombreCompleto));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejo de errores
                Console.WriteLine("Error al obtener los nombres de usuarios del grupo: " + ex.Message);
            }

            return nombresUsuarios;
        }
    }
}
