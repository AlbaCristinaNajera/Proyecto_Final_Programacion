using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoI.Clases
{
    internal class MaterialesDAO
    {
        private string connectionString = "server=localhost;" +
        "user=root;" +
        "pwd=123456789;" +
        "database=usuarios;";

        public List<MaterialEducativo> ObtenerMaterialesEducativos(int idCurso, string categoria)
        {
            List<MaterialEducativo> materiales = new List<MaterialEducativo>();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                // Abrir conexión
                connection.Open();
                // Diseñar la consulta
                string query = "SELECT * FROM materiales_educativos WHERE id_curso = @id_curso and categoria = @categoria";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id_curso", idCurso);
                    command.Parameters.AddWithValue("@categoria", categoria);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            MaterialEducativo material = new MaterialEducativo
                            {
                                ID_Material = Convert.ToInt32(reader["ID_Material"]),
                                ID_Curso = Convert.ToInt32(reader["ID_Curso"]),
                                Nombre = reader["Nombre"].ToString(),
                                Descripcion = reader["Descripcion"].ToString(),
                                Archivo = reader["Archivo"].ToString()
                            };
                            materiales.Add(material);
                        }
                    }
                }
            }

            return materiales;
        }

        public List<MaterialEducativo> ObtenerMaterialesEducativosPorCurso(int idCurso)
        {
            List<MaterialEducativo> materiales = new List<MaterialEducativo>();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT ID_Material, id_curso, Nombre, Descripcion, Archivo, categoria FROM materiales_educativos WHERE id_curso = @id_curso";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id_curso", idCurso);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            MaterialEducativo material = new MaterialEducativo
                            {
                                ID_Material = Convert.ToInt32(reader["ID_Material"]),
                                ID_Curso = Convert.ToInt32(reader["id_curso"]),
                                Nombre = reader["Nombre"].ToString(),
                                Descripcion = reader["Descripcion"].ToString(),
                                Archivo = reader["Archivo"].ToString(),
                                Categoria = reader["categoria"].ToString()
                            };
                            materiales.Add(material);
                        }
                    }
                }
            }

            return materiales;
        }

        public void InsertarMaterial(MaterialEducativo material)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = "INSERT INTO materiales_educativos (id_curso, Nombre, Descripcion, Archivo, categoria) VALUES " +
                    "(@id_curso, @Nombre, @Descripcion, @Archivo, @categoria)";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id_curso", material.ID_Curso);
                    cmd.Parameters.AddWithValue("@Nombre", material.Nombre);
                    cmd.Parameters.AddWithValue("@Descripcion", material.Descripcion);
                    cmd.Parameters.AddWithValue("@Archivo", material.Archivo);
                    cmd.Parameters.AddWithValue("@categoria", material.Categoria);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void ActualizarMaterial(MaterialEducativo material)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = "UPDATE materiales_educativos SET id_curso = @id_curso, Nombre = @Nombre, Descripcion = @Descripcion, " +
                    "Archivo = @Archivo, Categoria = @categoria WHERE ID_Material = @ID_Material";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id_curso", material.ID_Curso);
                    cmd.Parameters.AddWithValue("@Nombre", material.Nombre);
                    cmd.Parameters.AddWithValue("@Descripcion", material.Descripcion);
                    cmd.Parameters.AddWithValue("@Archivo", material.Archivo);
                    cmd.Parameters.AddWithValue("@categoria", material.Categoria);
                    cmd.Parameters.AddWithValue("@ID_Material", material.ID_Material);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void EliminarMaterial(int id)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = "DELETE FROM materiales_educativos WHERE ID_Material = @id";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<Cursos> ObtenerCursos()
        {
            List<Cursos> cursos = new List<Cursos>();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT id_curso, nombre_curso, descripcion, horario FROM Catalogo_Cursos";  // Ajusta la consulta según el nombre y estructura de tu tabla de cursos

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Cursos curso = new Cursos
                            {
                                IdCurso = Convert.ToInt32(reader["id_curso"]),
                                NombreCurso = reader["nombre_curso"].ToString(),
                                Descripcion = reader["descripcion"].ToString(),
                                Horario = reader["horario"].ToString()
                            };
                            cursos.Add(curso);
                        }
                    }
                }
            }

            return cursos;
        }
    }

}
