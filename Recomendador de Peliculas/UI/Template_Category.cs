using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recomendador_de_Peliculas.UI
{
    public partial class Template_Category : Form
    {
        public Template_Category()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            UCPelicula pelicula = new UCPelicula();
            pelicula.CambiarColorFondo(Color.FromArgb(70, 39, 117));
            pelicula.lblNombrePeli.Text = "Esta es mi peli";
            pelicula.Width = 220;
            pelicula.Height = 265;
            pelicula.Margin = new Padding(12);
            flowLayoutAnimacion.Controls.Add(pelicula);
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
