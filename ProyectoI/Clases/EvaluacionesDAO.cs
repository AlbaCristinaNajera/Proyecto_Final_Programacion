using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProyectoI
{
    internal class EvaluacionesDAO
    {
        private string connectionString = "Server=localhost;database=usuarios;Uid=root;Pwd=123456progra;";

        public bool RegistrarEvaluacion(string fecha, int puntos, string NombreEvaluacion, List<string> preguntas, int idCurso)
        {
            MySqlConnection conexion = new MySqlConnection(connectionString);

            try
            {
                conexion.Open();
                // Comenzamos una transacción para asegurar la integridad de los datos
                MySqlTransaction transaction = conexion.BeginTransaction();

                // Insertar en la tabla evaluaciones
                string consultaEvaluacion = "INSERT INTO evaluaciones (Fecha, puntos, id_curso, nombre_evaluacion) VALUES (@Fecha, @Puntos, @IdCurso, @NombreEvaluacion)";
                MySqlCommand comandoEvaluacion = new MySqlCommand(consultaEvaluacion, conexion, transaction);
                comandoEvaluacion.Parameters.AddWithValue("@Fecha", fecha);
                comandoEvaluacion.Parameters.AddWithValue("@Puntos", puntos);
                comandoEvaluacion.Parameters.AddWithValue("@IdCurso", idCurso);
                comandoEvaluacion.Parameters.AddWithValue("@NombreEvaluacion", NombreEvaluacion);
                comandoEvaluacion.ExecuteNonQuery();
                long idEvaluacion = comandoEvaluacion.LastInsertedId;

                // Insertar en la tabla pregunta
                string consultaPregunta = "INSERT INTO pregunta (id_evaluacion, preguntas) VALUES (@IdEvaluacion, @Preguntas)";
                MySqlCommand comandoPregunta = new MySqlCommand(consultaPregunta, conexion, transaction);

                foreach (string pregunta in preguntas)
                {
                    comandoPregunta.Parameters.Clear();
                    comandoPregunta.Parameters.AddWithValue("@IdEvaluacion", idEvaluacion);
                    comandoPregunta.Parameters.AddWithValue("@Preguntas", pregunta);
                    comandoPregunta.ExecuteNonQuery();
                }

                // Confirmamos la transacción
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
                string consulta = "SELECT e.id_evaluacion, e.Fecha, e.puntos, p.id_pregunta, p.preguntas " +
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
    }

    public class Evaluacion
    {
        public int Id_Evaluacion { get; set; }
        public string Fecha { get; set; }
        public int Puntos { get; set; }
        public int Nombre_Evaluacion { get; set; }
        public List<Pregunta> Preguntas { get; set; }
    }

    public class Pregunta
    {
        public int Id_Pregunta { get; set; }
        public int Id_Evaluacion { get; set; }
        public string Preguntas { get; set; }
    }
}

