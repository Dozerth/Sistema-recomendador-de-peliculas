using Recomendador_de_Peliculas.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recomendador_de_Peliculas.Common
{
    public static class MoviesDatabaseCache
    {
        static List<MoviesDTO> _Movies;
        static List<MoviesDTO> _MoviesCurrent;

        public static List<MoviesDTO> Movies { get => _Movies; set => _Movies = value; }
        public static List<MoviesDTO> MoviesCurrent { get => _MoviesCurrent; set => _MoviesCurrent = value; }
    }
}
