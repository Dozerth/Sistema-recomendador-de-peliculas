using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recomendador_de_Peliculas.Common
{
    public static class UserLoginCache
    {
        static int _ID;
        static string _Email;
        static string _Name;

        public static int ID { get => _ID; set => _ID = value; }
        public static string Email { get => _Email; set => _Email = value; }
        public static string Name { get => _Name; set => _Name = value; }
    }
}
