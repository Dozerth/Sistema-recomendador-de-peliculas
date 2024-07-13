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

namespace Recomendador_de_Peliculas.UI
{
    public partial class Template_Video : Form
    {
        public Template_Video()
        {
            InitializeComponent();
            //Load basic data from static Movie class
            this.picboxPelicula.Load(MovieCache.Image);
            LoadMovieTrailer(MovieCache.Trailer);
            this.lblTitulo.Text = MovieCache.Title;
            this.lblDescripcion.Text = MovieCache.Description;
            this.iconRecomendado.Visible = MovieCache.Recommended;
        }

        private void LoadMovieTrailer(string trailer)
        {
            string html = "<html><head>";
            html += "<meta content='IE=Edge' http-equiv='X-UA-Compatible'/>";
            html += "<iframe id='video' src='https://www.youtube.com/embed/{0}' width='1120' height='600' frameborder='0' allowfullscreen></iframe>";
            html += "</head></html>";
            this.web_video.DocumentText = string.Format(html, trailer);
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Template_Qualification Open = new Template_Qualification();
            Open.ShowDialog();
            this.Close();
        }
    }
}
