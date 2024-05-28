using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProyectoI
{
    internal class EvaluacionesDAO
    {
        private string connectionString = "Server=localhost;database=usuarios;Uid=root;Pwd=aguapura02;";

        public bool RegistrarEvaluacion(string fecha, int puntos, string NombreEvaluacion, List<string> preguntas, int idCurso)
        {
            MySqlConnection conexion = new MySqlConnection(connectionString);

            try
            {
                conexion.Open();
                MySqlTransaction transaction = conexion.BeginTransaction();

                string consultaEvaluacion = "INSERT INTO evaluaciones (Fecha, puntos, id_curso, nombre_evaluacion) VALUES (@Fecha, @Puntos, @IdCurso, @NombreEvaluacion)";
                MySqlCommand comandoEvaluacion = new MySqlCommand(consultaEvaluacion, conexion, transaction);
                comandoEvaluacion.Parameters.AddWithValue("@Fecha", fecha);
                comandoEvaluacion.Parameters.AddWithValue("@Puntos", puntos);
                comandoEvaluacion.Parameters.AddWithValue("@IdCurso", idCurso);
                comandoEvaluacion.Parameters.AddWithValue("@NombreEvaluacion", NombreEvaluacion);
                comandoEvaluacion.ExecuteNonQuery();
                long idEvaluacion = comandoEvaluacion.LastInsertedId;

                string consultaPregunta = "INSERT INTO pregunta (id_evaluacion, preguntas) VALUES (@IdEvaluacion, @Preguntas)";
                MySqlCommand comandoPregunta = new MySqlCommand(consultaPregunta, conexion, transaction);

                foreach (string pregunta in preguntas)
                {
                    comandoPregunta.Parameters.Clear();
                    comandoPregunta.Parameters.AddWithValue("@IdEvaluacion", idEvaluacion);
                    comandoPregunta.Parameters.AddWithValue("@Preguntas", pregunta);
                    comandoPregunta.ExecuteNonQuery();
                }

                transaction.Commit();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar evaluación: " + ex.Message);
                return false;
            }
            finally
            {
                if (conexion.State == System.Data.ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
        }

        public List<Evaluacion> ObtenerEvaluaciones()
        {
            MySqlConnection conexion = new MySqlConnection(connectionString);
            List<Evaluacion> evaluaciones = new List<Evaluacion>();

            try
            {
                conexion.Open();
                string consulta = "SELECT e.id_evaluacion, e.Fecha, e.puntos, e.nombre_evaluacion, p.id_pregunta, p.preguntas " +
                                  "FROM evaluaciones e " +
                                  "JOIN pregunta p ON e.id_evaluacion = p.id_evaluacion";
                MySqlCommand comando = new MySqlCommand(consulta, conexion);
                MySqlDataReader reader = comando.ExecuteReader();

                Dictionary<int, Evaluacion> dictEvaluaciones = new Dictionary<int, Evaluacion>();

                while (reader.Read())
                {
                    int idEvaluacion = Convert.ToInt32(reader["id_evaluacion"]);
                    if (!dictEvaluaciones.ContainsKey(idEvaluacion))
                    {
                        Evaluacion evaluacion = new Evaluacion
                        {
                            Id_Evaluacion = idEvaluacion,
                            Fecha = reader["Fecha"].ToString(),
                            Puntos = Convert.ToInt32(reader["puntos"]),
                            Nombre_Evaluacion = reader["nombre_evaluacion"].ToString(),
                            Preguntas = new List<Pregunta>()
                        };
                        dictEvaluaciones[idEvaluacion] = evaluacion;
                    }

                    Pregunta pregunta = new Pregunta
                    {
                        Id_Pregunta = Convert.ToInt32(reader["id_pregunta"]),
                        Id_Evaluacion = idEvaluacion,
                        Preguntas = reader["preguntas"].ToString()

                    };
                    dictEvaluaciones[idEvaluacion].Preguntas.Add(pregunta);
                }

                evaluaciones.AddRange(dictEvaluaciones.Values);
                return evaluaciones;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener evaluaciones: " + ex.Message);
                return null;
            }
            finally
            {
                if (conexion.State == System.Data.ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
        }



        public bool GuardarRespuesta(int idPregunta, string respuesta)
        {
            MySqlConnection conexion = new MySqlConnection(connectionString);

            try
            {
                conexion.Open();
                string consulta = "UPDATE pregunta SET respuestas = @Respuesta WHERE id_pregunta = @IdPregunta";
                MySqlCommand comando = new MySqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@IdPregunta", idPregunta);
                comando.Parameters.AddWithValue("@Respuesta", respuesta);
                comando.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar la respuesta: " + ex.Message);
                return false;
            }
            finally
            {
                if (conexion.State == System.Data.ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
        }

        public int ObtenerIdPregunta(string pregunta)
        {
            MySqlConnection conexion = new MySqlConnection(connectionString);

            try
            {
                conexion.Open();
                string consulta = "SELECT id_pregunta FROM pregunta WHERE preguntas = @Preguntas";
                MySqlCommand comando = new MySqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@Preguntas", pregunta);
                object result = comando.ExecuteScalar();

                if (result != null)
                {
                    return Convert.ToInt32(result);
                }
                else
                {
                    return -1; // Indica que la pregunta no fue encontrada
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener ID de la pregunta: " + ex.Message);
                return -1;
            }
            finally
            {
                if (conexion.State == System.Data.ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
        }

        public bool InsertarPregunta(int idEvaluacion, string pregunta)
        {
            MySqlConnection conexion = new MySqlConnection(connectionString);

            try
            {
                conexion.Open();
                string consulta = "INSERT INTO pregunta (id_evaluacion, preguntas) VALUES (@IdEvaluacion, @Preguntas)";
                MySqlCommand comando = new MySqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@IdEvaluacion", idEvaluacion);
                comando.Parameters.AddWithValue("@Preguntas", pregunta);
                comando.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar la pregunta: " + ex.Message);
                return false;
            }
            finally
            {
                if (conexion.State == System.Data.ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
        }

        public bool GuardarRespuestaUsuario(int idUsuario, int idPregunta, string respuesta)
        {
            MySqlConnection conexion = new MySqlConnection(connectionString);

            try
            {
                conexion.Open();
                string consulta = "INSERT INTO RespuestasEvaluacionUsuario (IdUsuario, IdPregunta, Respuesta) VALUES (@IdUsuario, @IdPregunta, @Respuesta)";
                MySqlCommand comando = new MySqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@IdUsuario", idUsuario);
                comando.Parameters.AddWithValue("@IdPregunta", idPregunta);
                comando.Parameters.AddWithValue("@Respuesta", respuesta);
                comando.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar la respuesta del usuario: " + ex.Message);
                return false;
            }
            finally
            {
                if (conexion.State == System.Data.ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
        }

        public int ObtenerUltimoIdEvaluacion()
        {
            MySqlConnection conexion = new MySqlConnection(connectionString);

            try
            {
                conexion.Open();
                string consulta = "SELECT MAX(id_evaluacion) FROM evaluaciones";
                MySqlCommand comando = new MySqlCommand(consulta, conexion);
                object result = comando.ExecuteScalar();

                if (result != null)
                {
                    return Convert.ToInt32(result);
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el último ID de evaluación: " + ex.Message);
                return -1;
            }
            finally
            {
                if (conexion.State == System.Data.ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
        }
    }

    public class Evaluacion
    {
        public int Id_Evaluacion { get; set; }
        public string Fecha { get; set; }
        public int Puntos { get; set; }
        public string Nombre_Evaluacion { get; set; }
        public List<Pregunta> Preguntas { get; set; }
    }

    public class Pregunta
    {
        public int Id_Pregunta { get; set; }
        public int Id_Evaluacion { get; set; }
        public string Preguntas { get; set; }
        public List<string> Respuestas { get; set; }

        public Pregunta()
        {
            Respuestas = new List<string>();
        }
    }
}

