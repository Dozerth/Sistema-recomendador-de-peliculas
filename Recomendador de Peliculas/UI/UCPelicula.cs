using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Recomendador_de_Peliculas.UI;

namespace Recomendador_de_Peliculas.UI
{
    public partial class UCPelicula : UserControl
    {
        public UCPelicula()
        {
            InitializeComponent();
        }

        public void CambiarColorFondo(Color fondo)
        {
            this.BackColor = fondo;
        }

        public void button1_Click(object sender, EventArgs e)
        {
                       
        }

        private void pictureBox_impeli_Click(object sender, EventArgs e)
        {
            MainForm formPrincial = Application.OpenForms.OfType<MainForm>().FirstOrDefault();
            if (formPrincial != null)
            {
                formPrincial.OpenChildForm<Template_Video>();
            }
        }
    }
}
