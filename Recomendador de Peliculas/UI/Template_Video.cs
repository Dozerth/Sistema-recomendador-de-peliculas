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
            this.lb_generos.Text = MovieCache.Description;
            this.iconRecomendado.Visible = MovieCache.Recommended;
            this.lb_descripcion.Text = "Actores: " + MovieCache.Actors;
        }

        private void LoadMovieTrailer(string trailer)
        {
            string html = "<html><head>";
            html += "<meta content='IE=Edge' http-equiv='X-UA-Compatible'/>";
            html += @"<style type='text/css'> body, html {width: 100%; height: 100%; margin: 0; padding: 0}
                    .row-container {display: flex; width: 100%; height: 100%; flex-direction: column; overflow: hidden;}
                    .second-row {position: absolute; top: 0px; left: 0; right: 0; bottom: 0; background-color: red }
                    .second-row iframe {display: block; position: absolute; width: 100%; height: 100%; border: none;}</style>";
            html += "<div class='second-row'>";
            html += string.Format("<iframe id='video' src='https://www.youtube.com/embed/{0}' allowfullscreen></iframe>", trailer);
            html += "</div></head></html>";
            this.web_video.DocumentText = html;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Template_Qualification Open = new Template_Qualification();
            Open.ShowDialog();
            this.Close();
        }

        private void picboxPelicula_Click(object sender, EventArgs e)
        {

        }
    }
}
