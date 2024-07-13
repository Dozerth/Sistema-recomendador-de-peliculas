using Recomendador_de_Peliculas.DTO;
using Recomendador_de_Peliculas.UI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Recomendador_de_Peliculas.Common;
using Recomendador_de_Peliculas.DAO;

namespace Recomendador_de_Peliculas.Business
{
    public class MoviesBusiness
    {
        //PROPERTIES
        private static string _YOUTUBE_BASE_PATH = "https://www.youtube.com/watch?v=";
        private static string _CURRENT_DIRECTORY = System.IO.Directory.GetCurrentDirectory();
        private static string _IMAGES_BASE_PATH = "../../../Recursos/Images/";
        MoviesDAO moviesDAO = new MoviesDAO();

        public static string YOUTUBE_BASE_PATH { get => _YOUTUBE_BASE_PATH; }
        public static string CURRENT_DIRECTORY { get => _CURRENT_DIRECTORY; }
        public static string IMAGES_BASE_PATH { get => _IMAGES_BASE_PATH;  }

        public void LoadMoviesInPanel(FlowLayoutPanel panel, List<MoviesDTO> peliculas, bool recommended = false)
        {
            //Random rnd = new Random();
            foreach (MoviesDTO pelicula in peliculas)
            {
                //if (recommended == false && rnd.Next(0, 11) == rnd.Next(0, 11)) { recommended = true; }
                UCPelicula ucPelicula = new UCPelicula();
                //Graphical modifications
                ucPelicula.CambiarColorFondo(Color.FromArgb(70, 39, 117));
                ucPelicula.lblNombrePeli.Text = pelicula.Title;
                ucPelicula.lblAnio.Text = pelicula.Year;
                ucPelicula.CambiarImagen(CURRENT_DIRECTORY + IMAGES_BASE_PATH + pelicula.Image);
                ucPelicula.iconRecomendado.Visible = recommended;
                ucPelicula.iconRecomendado.BringToFront();
                ucPelicula.Width = 216;
                ucPelicula.Height = 302;
                ucPelicula.Margin = new Padding(12);
                //Internal modifiers for video template
                ucPelicula.Title = pelicula.Title;
                ucPelicula.Year = pelicula.Year;
                ucPelicula.Trailer = pelicula.Link;
                ucPelicula.Image = pelicula.Image;
                ucPelicula.Actors = pelicula.Actors;
                ucPelicula.Description = pelicula.Description;
                ucPelicula.Recommended = recommended;

                panel.Controls.Add(ucPelicula);
            }
        }

        public void LoadMoviesOnCache()
        {
            MoviesDatabaseCache.Movies = moviesDAO.RetrieveMoviesByName("");
        }


        public void SearchAndLoadMoviesInPanel(FlowLayoutPanel panel, string titulo = "")
        {
            var peliculas = MoviesDatabaseCache.Movies.Where(x => x.Title.StartsWith(titulo)).Take(15).ToList();

            foreach (MoviesDTO pelicula in peliculas)
            {
                UCPelicula ucPelicula = new UCPelicula();
                //Graphical modifications
                ucPelicula.CambiarColorFondo(Color.FromArgb(70, 39, 117));
                ucPelicula.lblNombrePeli.Text = pelicula.Title;
                ucPelicula.lblAnio.Text = pelicula.Year;
                ucPelicula.CambiarImagen(CURRENT_DIRECTORY + IMAGES_BASE_PATH + pelicula.Image);
                ucPelicula.iconRecomendado.Visible = false;
                ucPelicula.Width = 216;
                ucPelicula.Height = 291;
                ucPelicula.Margin = new Padding(12);
                //Internal modifiers for video template
                ucPelicula.Title = pelicula.Title;
                ucPelicula.Year = pelicula.Year;
                ucPelicula.Trailer = pelicula.Link;
                ucPelicula.Image = pelicula.Image;
                ucPelicula.Actors = pelicula.Actors;
                ucPelicula.Description = pelicula.Description;
                ucPelicula.Recommended = false;

                panel.Controls.Add(ucPelicula);
            }
        }


        public List<MoviesDTO> SearchMovies(string title)
        {
            List<MoviesDTO> movies = new List<MoviesDTO>();



            return movies;
        }

    }
}
