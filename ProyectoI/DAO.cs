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
            "password=123456789;" +
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

    }

}
