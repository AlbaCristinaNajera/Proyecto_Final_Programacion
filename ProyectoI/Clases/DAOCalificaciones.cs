using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoI
{
    internal class DAOCalificaciones
    {
        private string connectionString = "server=localhost;" +
                                        "user=root;" +
                                        "pwd=Umg$2023;" +
                                        "database=usuarios;";


        public void InsertarCalificacion(Calificaciones calificacion)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string sql = "INSERT INTO calificaciones (id_estudiante, id_curso, id_evaluacion, calificacion, retroalimentacion, fecha_calificacion) VALUES (@idEstudiante, @idCurso, @idEvaluacion, @calificacion, @retroalimentacion, @fechaCalificacion)";
                MySqlCommand command = new MySqlCommand(sql, connection);
                command.Parameters.AddWithValue("@idEstudiante", calificacion.IdEstudiante);
                command.Parameters.AddWithValue("@idCurso", calificacion.IdCurso);
                command.Parameters.AddWithValue("@idEvaluacion", calificacion.IdEvaluacion);
                command.Parameters.AddWithValue("@calificacion", calificacion.CalificacionValor);
                command.Parameters.AddWithValue("@retroalimentacion", calificacion.Retroalimentacion);
                command.Parameters.AddWithValue("@fechaCalificacion", calificacion.FechaCalificacion);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public List<KeyValuePair<int, string>> CargarEstudiantes()
        {
            var estudiantes = new List<KeyValuePair<int, string>>();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT Id, Nombre FROM usuarios_Registrados";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                connection.Open();
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        estudiantes.Add(new KeyValuePair<int, string>(reader.GetInt32("Id"), reader.GetString("Nombre")));
                    }
                }
            }
            return estudiantes;
        }

        public List<KeyValuePair<int, string>> CargarCursos()
        {
            var cursos = new List<KeyValuePair<int, string>>();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT id_curso, nombre_curso FROM Catalogo_Cursos";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                connection.Open();
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        cursos.Add(new KeyValuePair<int, string>(reader.GetInt32("id_curso"), reader.GetString("nombre_curso")));
                    }
                }
            }
            return cursos;
        }

        public List<KeyValuePair<int, string>> CargarEvaluaciones()
        {
            var evaluaciones = new List<KeyValuePair<int, string>>();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT id_evaluacion, nombre_evaluacion FROM evaluaciones";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                connection.Open();
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int idEvaluacion = reader.IsDBNull(reader.GetOrdinal("id_evaluacion")) ? 0 : reader.GetInt32("id_evaluacion");
                        string nombreEvaluacion = reader.IsDBNull(reader.GetOrdinal("nombre_evaluacion")) ? string.Empty : reader.GetString("nombre_evaluacion");

                        evaluaciones.Add(new KeyValuePair<int, string>(idEvaluacion, nombreEvaluacion));
                    }
                }
            }
            return evaluaciones;
        }


        public Calificaciones ObtenerCalificacion(int idEstudiante, int idCurso, int idEvaluacion)
        {
            Calificaciones calificacion = null;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT * FROM calificaciones WHERE id_estudiante = @idEstudiante AND id_curso = @idCurso AND id_evaluacion = @idEvaluacion";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@idEstudiante", idEstudiante);
                cmd.Parameters.AddWithValue("@idCurso", idCurso);
                cmd.Parameters.AddWithValue("@idEvaluacion", idEvaluacion);

                connection.Open();
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        calificacion = new Calificaciones
                        {
                            IdCalificacion = reader.GetInt32("id_calificacion"),
                            IdEstudiante = reader.GetInt32("id_estudiante"),
                            IdCurso = reader.GetInt32("id_curso"),
                            IdEvaluacion = reader.GetInt32("id_evaluacion"),
                            CalificacionValor = reader.GetDecimal("calificacion"),
                            Retroalimentacion = reader.GetString("retroalimentacion"),
                            FechaCalificacion = reader.GetDateTime("fecha_calificacion")
                        };
                    }
                }
            }

            return calificacion;
        }

        public List<RespuestaEvaluacion> ObtenerRespuestas(int idEstudiante, int idCurso, int idEvaluacion)
        {
            List<RespuestaEvaluacion> respuestas = new List<RespuestaEvaluacion>();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = @"
                          SELECT IdRespuesta, IdPregunta, Respuesta 
                          FROM RespuestasEvaluacionUsuario 
                          WHERE IdUsuario = @idEstudiante";

                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@idEstudiante", idEstudiante);
                cmd.Parameters.AddWithValue("@idCurso", idCurso);
                cmd.Parameters.AddWithValue("@idEvaluacion", idEvaluacion);

                connection.Open();
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        RespuestaEvaluacion respuesta = new RespuestaEvaluacion
                        {
                            IdRespuesta = reader.GetInt32("IdRespuesta"),
                            IdPregunta = reader.GetInt32("IdPregunta"),
                            Respuesta = reader.GetString("Respuesta")
                        };
                        respuestas.Add(respuesta);
                    }
                }
            }

            return respuestas;
        }
    }

}

