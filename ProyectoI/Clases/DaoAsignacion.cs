using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoI
{
    public class DaoAsignacion
    {
        private string connectionString = "server=localhost;" +
            "user=root;" +
            "pwd=aguapura02;" +
            "database=usuarios;";

        public void AsignarCursoUsuario(AsignacionCursos asignacion)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO asignacion_cursos (id_estudiante, id_curso) VALUES (@idUsuario, @idCurso)";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@idUsuario", asignacion.id_estudiante);
                    cmd.Parameters.AddWithValue("@idCurso", asignacion.id_curso);
                    cmd.ExecuteNonQuery();
                }
            }

        }
    }
}
