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

        
    }
}
