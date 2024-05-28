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
        "pwd=aguapura02;" +
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

        public Cursos ObtenerCursoPorId(int id)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT id_curso, nombre_curso, descripcion, horario FROM Catalogo_Cursos WHERE id_curso = @id";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Cursos curso = new Cursos();
                            curso.IdCurso = Convert.ToInt32(reader["id_curso"]);
                            curso.NombreCurso = reader["nombre_curso"].ToString();
                            curso.Descripcion = reader["descripcion"].ToString();
                            curso.Horario = reader["horario"].ToString();

                            return curso;
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
            }
        }

        public void InsertarCurso(Cursos cursos)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = "INSERT INTO Catalogo_Cursos (nombre_curso, descripcion, horario) VALUES " +
                    "(@nombre_curso, @descripcion, @horario)";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nombre_curso", cursos.NombreCurso);
                    cmd.Parameters.AddWithValue("@descripcion", cursos.Descripcion);
                    cmd.Parameters.AddWithValue("@horario", cursos.Horario);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void ActualizarCurso(Cursos cursos)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = "UPDATE Catalogo_Cursos SET nombre_curso = @nombre_curso, descripcion = @descripcion, " +
                    "horario = @horario WHERE id_curso = @id";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nombre_curso", cursos.NombreCurso);
                    cmd.Parameters.AddWithValue("@descripcion", cursos.Descripcion);
                    cmd.Parameters.AddWithValue("@horario", cursos.Horario);
                    cmd.Parameters.AddWithValue("@id", cursos.IdCurso);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void EliminarCurso(int id)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = "DELETE FROM Catalogo_Cursos WHERE id_curso = @id";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    cmd.ExecuteNonQuery();
                }
            }
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
