using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoI
{
    internal class AuthenticationDAO
    {
        private string connectionString = "Server=localhost;database=usuarios;Uid=root;Pwd=Umg$2023;";

        public bool RegistrarUsuario(string nombre, string apellido, string correo, string contrasena, string rol)
        {
            MySqlConnection conexion = new MySqlConnection(connectionString);

            try
            {
                conexion.Open();
                string consulta = "INSERT INTO Usuarios_Registrados (nombre, apellido, contrasena, correo, Rol) VALUES (@nombre, @apellido, @contrasena, @correo, @Rol)";
                MySqlCommand comando = new MySqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@nombre", nombre);
                comando.Parameters.AddWithValue("@apellido", apellido);
                comando.Parameters.AddWithValue("@contrasena", contrasena);
                comando.Parameters.AddWithValue("@correo", correo);
                comando.Parameters.AddWithValue("@Rol", rol);
                comando.ExecuteNonQuery();
                MessageBox.Show("Usuario agregado correctamente a la base de datos.");
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar usuario: " + ex.Message);
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

        public Usuario AutenticarUsuario(string usuario, string contrasena)
        {
            MySqlConnection conexion = new MySqlConnection(connectionString);

            try
            {
                conexion.Open();
                string consulta = "SELECT * FROM usuarios_Registrados WHERE nombre = @usuario AND contrasena = @contrasena";
                MySqlCommand comando = new MySqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@usuario", usuario);
                comando.Parameters.AddWithValue("@contrasena", contrasena);
                MySqlDataReader reader = comando.ExecuteReader();

                if (reader.Read())
                {
                    Usuario usuario1 = new Usuario
                    {
                        Id_Usuario = Convert.ToInt32(reader["Id"]),
                        Nombre = reader["nombre"].ToString(),
                        Apellido = reader["apellido"].ToString(),
                        Correo = reader["correo"].ToString(),
                        Contraseña = reader["contrasena"].ToString(),
                        Rol = reader["rol"].ToString()
                    };
                    return usuario1;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al autenticar usuario: " + ex.Message);
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
}
