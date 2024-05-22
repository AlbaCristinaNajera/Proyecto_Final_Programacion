using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoI
{
    public class DAO
    {
        private string connectionString = "server=localhost;" +
            "user=root;" +
            "password=123456progra;" +
            "database=usuarios;";

        public List<Cursos> ObtenerTodosLosCursos()
        {
            List<Cursos> listaCursos = new List<Cursos>();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                // Abrir conexión
                conn.Open();
                // Diseñar la consulta
                string query = "SELECT id_curso, nombre_curso, descripcion, horario FROM Catalogo_Cursos";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Cursos curso = new Cursos();
                            curso.IdCurso = Convert.ToInt32(reader["id_curso"]);
                            curso.NombreCurso = reader["nombre_curso"].ToString();
                            curso.Descripcion = reader["descripcion"].ToString();
                            curso.Horario = reader["horario"].ToString();

                            listaCursos.Add(curso);
                        }
                    }
                }
            }

            return listaCursos;
        }

        public List<MaterialEducativo> ObtenerMaterialesEducativos(int idCurso, string categoria)
        {
            List<MaterialEducativo> materiales = new List<MaterialEducativo>();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                // Abrir conexión
                connection.Open();
                // Diseñar la consulta
                string query = "SELECT * FROM materiales_educativos WHERE id_curso = @id_curso and categoria = @categoria" ;

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

        public bool ActualizarDatosUsuario(int idUsuario, string nombre, string apellido, string correo, string contrasena)
        {
            bool actualizacionExitosa = false;

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    // Abrir conexión
                    conn.Open();

                    string query = "UPDATE Usuarios_Registrados SET nombre = @nombre, apellido = @apellido, correo = @correo, contrasena = @contrasena WHERE Id = @idUsuario";

                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    // Añadir parámetros a la consulta
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@apellido", apellido);
                    cmd.Parameters.AddWithValue("@correo", correo);
                    cmd.Parameters.AddWithValue("@contrasena", contrasena);
                    cmd.Parameters.AddWithValue("@idUsuario", idUsuario);

                    // Ejecutar la consulta
                    int filasActualizadas = cmd.ExecuteNonQuery();

                    // Verificar si se actualizaron filas
                    if (filasActualizadas > 0)
                    {
                        actualizacionExitosa = true;
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción que pueda ocurrir durante la actualización
                Console.WriteLine("Error al actualizar los datos del usuario: " + ex.Message);
            }

            return actualizacionExitosa;
        }
    }

}
