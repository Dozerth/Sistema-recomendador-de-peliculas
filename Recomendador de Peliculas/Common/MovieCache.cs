using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recomendador_de_Peliculas.Common
{
    public static class MovieCache
    {
        static string _Title;
        static string _Year;
        static string _Trailer;
        static string _Image;
        static string _Actors;
        static string _Description;
        static bool _Recommended;

        public static string Title { get => _Title; set => _Title = value; }
        public static string Year { get => _Year; set => _Year = value; }
        public static string Trailer { get => _Trailer; set => _Trailer = value; }
        public static string Image { get => _Image; set => _Image = value; }
        public static string Actors { get => _Actors; set => _Actors = value; }
        public static string Description { get => _Description; set => _Description = value; }
        public static bool Recommended { get => _Recommended; set => _Recommended = value; }
    }
}
