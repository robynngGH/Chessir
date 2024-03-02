using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Chessir.dto;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Collections;
using System.Diagnostics;

namespace Chessir.dao
{
    internal class DAOUsuario
    {
        public int comprobarLogin(string username, string password)
        {
            //recibe un usuario y contraseña y comprueba si existe y está activo en la base de datos
            //devuelve 0 si algo es incorrecto, 1 si el login es correcto, 2 si además tiene permisos especiales

            Boolean es_admin = false;
            Boolean activo = false;
            int resultado = 0;

            try
            {
                //consulta para encontrar el usuario con la contraseña introducidos
                string query = "SELECT username, password, es_admin, activo FROM usuarios WHERE username = '" + username + "' AND password = '" + password + "';";

                ConexionDB objetoConexion = new ConexionDB();
                MySqlCommand myCommand = new MySqlCommand(query, objetoConexion.establecerConexion());
                MySqlDataReader reader = myCommand.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        es_admin = reader.GetBoolean(2);
                        activo = reader.GetBoolean(3);
                    }
                    if (activo) //solo se accede si está activo
                    {
                        if (es_admin)
                            resultado = 2;
                        else
                            resultado = 1;
                    }
                    else
                        resultado = 0;
                }
                else
                    resultado = 0;

                objetoConexion.cerrarConexion();
            }
            catch (Exception ex) {
                MessageBox.Show("Error inesperado al conectar: " + ex.ToString());
            }
            return resultado;
        }

        public int recibirIDUsuario(string username)
        {
            //se le pasa un nombre de usuario y se recibe su ID como resultado
            int id_resultado = 0;

            try
            {
                //consulta para encontrar el usuario y recibir su ID
                string query = "SELECT id FROM usuarios WHERE username = '" + username + "';";

                ConexionDB objetoConexion = new ConexionDB();
                MySqlCommand myCommand = new MySqlCommand(query, objetoConexion.establecerConexion());
                MySqlDataReader reader = myCommand.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        id_resultado = reader.GetInt32(0);
                    }
                }

                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado al conectar: " + ex.ToString());
            }
            return id_resultado;
        }

        public void registrarUsuario(DTOUsuario dtoUsuario)
        {
            try
            {
                //inserta el usuario en la base datos
                string query = "INSERT INTO usuarios(username, password, es_admin, creado_por_id, fecha_creacion, activo) VALUES ('"
                    + dtoUsuario.Username + "', '" + dtoUsuario.Password + "', " + dtoUsuario.Es_admin + ", " + dtoUsuario.Creado_por_ID
                    + ", '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "', " + dtoUsuario.Activo + ");";

                ConexionDB objetoConexion = new ConexionDB();
                MySqlCommand myCommand = new MySqlCommand(query, objetoConexion.establecerConexion());
                MySqlDataReader reader = myCommand.ExecuteReader();

                MessageBox.Show("¡Usuario registrado con éxito!");

                while (reader.Read()) { }
                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado al crear el usuario: " + ex.ToString());
            }
        }

        public Boolean existeUsuario(String username)
        {
            Boolean resultado = false;

            try
            {
                //consulta para comprobar si existe el usuario
                string query = "SELECT * FROM usuarios WHERE username = '" + username + "';";

                ConexionDB objetoConexion = new ConexionDB();
                MySqlCommand myCommand = new MySqlCommand(query, objetoConexion.establecerConexion());
                MySqlDataReader reader = myCommand.ExecuteReader();

                if (reader.HasRows)
                {
                    resultado = true;
                }
                else
                    resultado = false;

                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado al conectar: " + ex.ToString());
            }
            return resultado;
        }

        public ArrayList usernamesDesplegable()
        {
            //almacena todos los usernames registrados en un ArrayList y los devuelve

            ArrayList lista = new ArrayList();

            try
            {
                string query = "SELECT username FROM usuarios";
                ConexionDB objetoConexion = new ConexionDB();
                MySqlCommand myCommand = new MySqlCommand(query, objetoConexion.establecerConexion());
                MySqlDataReader reader = myCommand.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        lista.Add(reader.GetString(0));
                    }
                }
                else
                {
                    Console.WriteLine("No se han encontrado usernames.");
                }

                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo actualizar la lista. Error: " + ex.ToString());
            }
            return lista;
        }

        public DTOUsuario buscarUsername(string username)
        {
            //recibe un usuario y devuelve su nombre, contraseña y si es admin
            //utilizado en la gestión de usuarios

            string username_db, password;
            bool es_admin;
            DTOUsuario dtoUsuario = new DTOUsuario();

            try
            {
                string query = "SELECT username, password, es_admin FROM usuarios " +
                    "WHERE username = '" + username + "';";
                ConexionDB objetoConexion = new ConexionDB();
                MySqlCommand myCommand = new MySqlCommand(query, objetoConexion.establecerConexion());
                MySqlDataReader reader = myCommand.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        username_db = reader.GetString(0); dtoUsuario.Username = username_db;
                        password = reader.GetString(1); dtoUsuario.Password = password;
                        es_admin = reader.GetBoolean(2); dtoUsuario.Es_admin = es_admin;
                    }
                }
                else
                {
                    Console.WriteLine("No se encontró al usuario.");
                }
                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo realizar esta consulta. Error: " + ex.ToString());
            }

            return dtoUsuario;
        }

        public void modificarUsuario(DTOUsuario dtoUsuario, string username)
        {
            //recibe un username a modificar una nueva info de usuario a modificar

            try
            {
                string query = "UPDATE usuarios " +
                    "SET username = '" + dtoUsuario.Username + "', password = '" + dtoUsuario.Password +
                    "', es_admin = " + dtoUsuario.Es_admin + ", ultima_modificacion_id = " + dtoUsuario.Ultima_modificacion_ID +
                    ", fecha_actualizacion = '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "'" +
                    " WHERE username = '" + username + "';";

                ConexionDB objetoConexion = new ConexionDB();
                MySqlCommand myCommand = new MySqlCommand(query, objetoConexion.establecerConexion());
                MySqlDataReader reader = myCommand.ExecuteReader();

                MessageBox.Show("¡Usuario modificado con éxito!");
                while (reader.Read()) { }
                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron actualizar los datos del usuario. Error: " + ex.ToString());
            }
        }

        public bool buscarActividadUsuario(string username)
        {
            //recibe un usuario y devuelve si está activo o no
            bool resultado = false;

            try
            {
                string query = "SELECT activo FROM usuarios WHERE username = '" + username + "';";

                ConexionDB objetoConexion = new ConexionDB();
                MySqlCommand myCommand = new MySqlCommand(query, objetoConexion.establecerConexion());
                MySqlDataReader reader = myCommand.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        resultado = reader.GetBoolean(0);
                    }
                }
                else
                {
                    Console.WriteLine("No se encontró al usuario.");
                }
                objetoConexion.cerrarConexion();
            } 
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar: " + ex.ToString());
            }
            return resultado;
        }

        public void cambiarActividadUsuario(string username, bool activo, int id_modificacion)
        {
            //recibe un username y cambia su actividad correspondiente de la base de datos

            try
            {
                string query = "UPDATE usuarios SET activo = " + activo + ", ultima_modificacion_id = " + id_modificacion
                    + ", fecha_actualizacion = '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "' WHERE username = '" + username + "';";

                ConexionDB objetoConexion = new ConexionDB();
                MySqlCommand myCommand = new MySqlCommand(query, objetoConexion.establecerConexion());
                MySqlDataReader reader = myCommand.ExecuteReader();

                MessageBox.Show("¡Actividad modificada con éxito!");
                while (reader.Read()) { }
                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo modificar el usuario. Error: " + ex.ToString());
            }
        }
    }
}
