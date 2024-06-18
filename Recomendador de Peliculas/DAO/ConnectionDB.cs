using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recomendador_de_Peliculas.DAO
{
    public abstract class ConnectionDB
    {
        protected MySqlConnection connection = new MySqlConnection("Server=localhost;Database=dozc2; UserID=root; Password=$Dach.3012");
        //We can get the data for the connection to db from App.config file
        //private readonly string connectionString;
        //public ConnectionDB()
        //{
        //    connectionString = "Server=localhost;Database=sistemaventas; UserID=root; Password=$Dach.3012";
        //}
        //protected MySqlConnection GetConnection()
        //{
        //    return new MySqlConnection(connectionString);
        //}
    }
}
