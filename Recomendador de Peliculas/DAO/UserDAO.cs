using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Recomendador_de_Peliculas.DTO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using Recomendador_de_Peliculas.Common;
using System.Windows.Forms;


namespace Recomendador_de_Peliculas.DAO
{
    public class UserDAO : ConnectionDB
    {
        //Private fields
        MySqlDataReader reader;
        MySqlCommand cmd = new MySqlCommand();

        #region Create

        public void CreateUser(string email, string name, string passwd)
        {
            try
            {
                connection.Open();

                string consult = "INSERT INTO usuarios (correo, username, passwd) VALUES (@Email, @Name, @Passwd)";

                //CONFIGURING COMMAND
                cmd.Connection = connection;
                cmd.Parameters.Clear();
                cmd.CommandText = consult;
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Passwd", passwd);
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        #endregion

        #region Retrieve

        public List<UserDTO> RetrieveUsersByUsername(string username)
        {
            List<UserDTO> users = new List<UserDTO>();
            try
            {
                connection.Open();

                string consult = "SELECT id, username, rol, email FROM users WHERE username=@User";

                //CONFIGURING COMMAND
                cmd.Connection = connection;
                cmd.Parameters.Clear();
                cmd.CommandText = consult;
                cmd.Parameters.AddWithValue("@User", "%" + username + "%");
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        users.Add(new UserDTO
                        {
                            ID = reader.GetInt32(0),
                            Email = reader.GetString(1),
                            Name = reader.GetString(2),
                            Password = reader.GetString(3)
                        });
                    }
                }
                reader.Close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return users;
        }

        public UserDTO RetrieveUser(string email)
        {
            UserDTO user = new UserDTO();
            try
            {
                connection.Open();

                string consult = "SELECT usuario_ID, correo, nombre FROM usuarios WHERE correo=@Email LIMIT 1";

                //CONFIGURING COMMAND
                cmd.Connection = connection;
                cmd.Parameters.Clear();
                cmd.CommandText = consult;
                cmd.Parameters.AddWithValue("@Email", email);
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    user.ID = reader.GetInt32(0);
                    user.Email = reader.GetString(1);
                    user.Name = reader.GetString(2);
                }
                reader.Close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return user;
        }

        #endregion

        #region Update

        public void UpdateGeneral(string username, string rol, string email)
        {
            try
            {
                connection.Open();

                if (rol == "") rol = "user";

                string consult = "UPDATE users SET rol=@Rol, email=@Email WHERE username=@User";

                //CONFIGURING COMMAND
                cmd.Connection = connection;
                cmd.Parameters.Clear();
                cmd.CommandText = consult;
                cmd.Parameters.AddWithValue("@User", username);
                cmd.Parameters.AddWithValue("@Rol", rol);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public void UpdateUsername(string username, string newUsername)
        {
            try
            {
                connection.Open();

                string consult = "UPDATE users SET username=@NewUsername WHERE username=@User";

                //CONFIGURING COMMAND
                cmd.Connection = connection;
                cmd.Parameters.Clear();
                cmd.CommandText = consult;
                cmd.Parameters.AddWithValue("@User", username);
                cmd.Parameters.AddWithValue("@NewUsername", newUsername);
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public void UpdatePassword(string username, string passwd)
        {
            try
            {
                connection.Open();

                string consult = "UPDATE users SET passwd=@Password WHERE username=@User";

                //CONFIGURING COMMAND
                cmd.Connection = connection;
                cmd.Parameters.Clear();
                cmd.CommandText = consult;
                cmd.Parameters.AddWithValue("@User", username);
                cmd.Parameters.AddWithValue("@Password", passwd);
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        #endregion

        #region Delete

        public void DeleteUser(string username)
        {
            try
            {
                connection.Open();

                string consult = "DETELE FROM users WHERE username=@User";

                //CONFIGURING COMMAND
                cmd.Connection = connection;
                cmd.Parameters.Clear();
                cmd.CommandText = consult;
                cmd.Parameters.AddWithValue("@User", username);
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        #endregion

        #region Validations

        public bool Login(string username, string password)
        {
            bool logged = false;
            try
            {
                connection.Open();

                string consult = "SELECT username, passwd FROM usuarios WHERE username=@Usermane AND passwd=@Pass LIMIT 1";

                cmd.Connection = connection;
                cmd.Parameters.Clear();
                cmd.CommandText = consult;
                cmd.Parameters.AddWithValue("@Usermane", username);
                cmd.Parameters.AddWithValue("@Pass", password);
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    logged = true;
                }
                else if (logged == false)
                {
                    MessageBox.Show("ERROR: ACCESO INVALIDO", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                reader.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error en Validar User" + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return logged;
        }

        public bool ConectarUser(string user)
        {
            bool exist = false;

            try
            {
                connection.Open();

                string conect = "SELECT *FROM usuarios WHERE username= '" + user + "'";

                cmd.Connection = connection;
                cmd.Parameters.Clear();
                cmd.CommandText = conect;
                cmd.Parameters.AddWithValue("@user", user);
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        UserLoginCache.ID = reader.GetInt32(0);
                        UserLoginCache.Username = reader.GetString(1);
                    }
                    exist = true;
                }

                reader.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error en Conectar a la Base de Datos" + ex.StackTrace);
            }
            finally
            {
                connection.Close();
            }
            return exist;
        }

        public bool ValidateExistence(string username, string email)
        {
            bool exist = false;
            try
            {
                connection.Open();

                string consult = "SELECT username, correo FROM usuarios WHERE username=@Usermane AND correo=@Correo LIMIT 1";

                cmd.Connection = connection;
                cmd.Parameters.Clear();
                cmd.CommandText = consult;
                cmd.Parameters.AddWithValue("@Usermane", username);
                cmd.Parameters.AddWithValue("@Correo", email);
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    exist = true;
                }
                else if (exist == false)
                {
                    MessageBox.Show("ERROR: ACCESO INVALIDO EN LOS CAMPOS DE REGISTRO", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                reader.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error en Validar User y email" + ex.StackTrace);
            }
            finally
            {
                connection.Close();
            }
            return exist;
        }

        #endregion
    }
}
