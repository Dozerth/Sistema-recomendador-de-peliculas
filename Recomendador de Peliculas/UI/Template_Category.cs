using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Recomendador_de_Peliculas.Business;
using Recomendador_de_Peliculas.Common;
using Recomendador_de_Peliculas.DAO;
using Recomendador_de_Peliculas.DTO;


namespace Recomendador_de_Peliculas.UI
{
    public partial class Template_Category : Form
    {
        //Private fields for MySQL queries
        private MoviesDAO moviesDAO = new MoviesDAO();
        private MoviesBusiness movies = new MoviesBusiness();

        public Template_Category()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Template_Category_Load(object sender, EventArgs e)
        {
            List<MoviesDTO> categoryMovies = moviesDAO.RetrieveMoviesByGenre(MovieCache.CategorySearch, 100);
            movies.LoadMoviesInPanel(flowLayoutAnimacion, categoryMovies);
        }
    }
}
