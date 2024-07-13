using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recomendador_de_Peliculas.DTO
{
    public class UserDTO
    {
        int _ID;
        string _Email;
        string _Name;
        string _Password;

        public int ID { get => _ID; set => _ID = value; }
        public string Email { get => _Email; set => _Email = value; }
        public string Name { get => _Name; set => _Name = value; }
        public string Password { get => _Password; set => _Password = value; }
    }
}
