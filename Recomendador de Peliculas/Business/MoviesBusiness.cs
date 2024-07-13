using Recomendador_de_Peliculas.DTO;
using Recomendador_de_Peliculas.UI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recomendador_de_Peliculas.Business
{
    public class MoviesBusiness
    {
        private string YOUTUBE_BASE_PATH = "https://www.youtube.com/watch?v";
        private string CURRENT_DIRECTORY = System.IO.Directory.GetCurrentDirectory();
        private string IMAGES_BASE_PATH = "../../../Recursos/Images/";

        public void LoadMoviesInPanel(FlowLayoutPanel panel, List<MoviesDTO> peliculas, bool recommended = false)
        {
            Random rnd = new Random();
            foreach (MoviesDTO pelicula in peliculas)
            {
                if (recommended == false && rnd.Next(0, 11) == rnd.Next(0, 11)) { recommended = true; }
                UCPelicula ucPelicula = new UCPelicula();
                ucPelicula.CambiarColorFondo(Color.FromArgb(70, 39, 117));
                ucPelicula.lblNombrePeli.Text = pelicula.Title;
                ucPelicula.lblAnio.Text = pelicula.Year;
                ucPelicula.CambiarImagen(CURRENT_DIRECTORY + IMAGES_BASE_PATH + pelicula.Image);
                ucPelicula.iconRecomendado.Visible = recommended;
                ucPelicula.iconRecomendado.BringToFront();
                ucPelicula.Width = 216;
                ucPelicula.Height = 291;
                ucPelicula.Margin = new Padding(12);
                panel.Controls.Add(ucPelicula);
            }
        }
    }
}
