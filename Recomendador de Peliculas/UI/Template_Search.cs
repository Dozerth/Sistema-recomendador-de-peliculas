using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Recomendador_de_Peliculas.DAO;
using Recomendador_de_Peliculas.DTO;
using Recomendador_de_Peliculas.Business;
using Recomendador_de_Peliculas.Common;
using System.Windows.Controls;

namespace Recomendador_de_Peliculas.UI
{
    public partial class Template_Search : Form
    {
        //PROPERTIES
        MoviesBusiness movies = new MoviesBusiness();

        public Template_Search()
        {
            InitializeComponent();
            movies.LoadMoviesOnCache();
            movies.SearchAndLoadMoviesInPanel(flowLayoutAnimacion, tboxBuscar.Text);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
            //this.Dispose();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            flowLayoutAnimacion.Controls.Clear();
            movies.SearchAndLoadMoviesInPanel(flowLayoutAnimacion, tboxBuscar.Text);
        }
    }
}
