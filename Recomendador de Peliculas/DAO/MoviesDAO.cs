using MySql.Data.MySqlClient;
using Recomendador_de_Peliculas.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Recomendador_de_Peliculas.DTO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Recomendador_de_Peliculas.DAO
{
    public class MoviesDAO : ConnectionDB
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

                string consult = "INSERT INTO usuarios (correo, nombre, passwd) VALUES (@Email, @Name, @Passwd)";

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

        public MoviesDTO RetrieveMoviesByID(int ID)
        {
            MoviesDTO movies = new MoviesDTO();
            try
            {
                connection.Open();

                string consult = "SELECT * FROM peliculas WHERE peliculas_ID=@ID";

                //CONFIGURING COMMAND
                cmd.Connection = connection;
                cmd.Parameters.Clear();
                cmd.CommandText = consult;
                cmd.Parameters.AddWithValue("@ID", ID);
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    movies.ID = reader.GetInt32(0);
                    movies.Title = reader.GetString(1);
                    movies.Year = reader.GetString(2);
                    movies.Link = reader.GetString(3);
                    movies.Image = reader.GetString(4);
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
            return movies;
        }

        public List<MoviesDTO> RetrieveMoviesByName(string name)
        {
            List<MoviesDTO> movies = new List<MoviesDTO>();
            try
            {
                connection.Open();

                string consult = "SELECT * FROM peliculas WHERE titulo LIKE @Title";

                //CONFIGURING COMMAND
                cmd.Connection = connection;
                cmd.Parameters.Clear();
                cmd.CommandText = consult;
                cmd.Parameters.AddWithValue("@Title", "%" + name + "%");
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        movies.Add(new MoviesDTO
                        {
                            ID = reader.GetInt32(0),
                            Title = reader.GetString(1),
                            Year = reader.GetString(2),
                            Link = reader.GetString(3),
                            Image = reader.GetString(4)
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
            return movies;
        }

        public List<MoviesDTO> RetrieveMoviesByGenre(int IDgenre, int limit)
        {
            List<MoviesDTO> movies = new List<MoviesDTO>();
            try
            {
                connection.Open();

                string consult = "SELECT p.peliculas_ID, p.titulo, p.fecha, p.link, p.imagen FROM peliculas p INNER JOIN peliculas_categorias c ON c.ID_pelicula = p.peliculas_ID  WHERE c.ID_categoria=@IDGenre GROUP BY p.peliculas_ID, p.titulo HAVING COUNT(distinct c.ID_categoria) = 1 LIMIT @Limit";

                //CONFIGURING COMMAND
                cmd.Connection = connection;
                cmd.Parameters.Clear();
                cmd.CommandText = consult;
                cmd.Parameters.AddWithValue("@IDGenre", IDgenre);
                cmd.Parameters.AddWithValue("@Limit", limit);
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        movies.Add(new MoviesDTO
                        {
                            ID = reader.GetInt32(0),
                            Title = reader.GetString(1),
                            Year = reader.GetString(2),
                            Link = reader.GetString(3),
                            Image = reader.GetString(4)
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
            return movies;
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

        public bool ValidateExistence(string email)
        {
            bool exist = false;
            try
            {
                connection.Open();

                string consult = "SELECT correo FROM usuarios WHERE correo=@Correo LIMIT 1";

                cmd.Connection = connection;
                cmd.Parameters.Clear();
                cmd.CommandText = consult;
                cmd.Parameters.AddWithValue("@Correo", email);
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    exist = true;
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
            return exist;
        }

        #endregion
    }
}
