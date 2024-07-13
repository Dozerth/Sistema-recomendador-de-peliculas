using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Recomendador_de_Peliculas.Common;
using Recomendador_de_Peliculas.UI;

namespace Recomendador_de_Peliculas.UI
{
    public partial class UCPelicula : UserControl
    {
        #region Private-Public Modifiers
        //Needed to transform Template_Video
        string _Title;
        string _Year;
        string _Trailer;
        string _Image;
        string _Actors;
        string _Description;
        bool _Recommended;
        //Public modifiers to transfer data between forms
        public string Title { get => _Title; set => _Title = value; }
        public string Year { get => _Year; set => _Year = value; }
        public string Trailer { get => _Trailer; set => _Trailer = value; }
        public string Image { get => _Image; set => _Image = value; }
        public string Actors { get => _Actors; set => _Actors = value; }
        public string Description { get => _Description; set => _Description = value; }
        public bool Recommended { get => _Recommended; set => _Recommended = value; }
        #endregion

        public UCPelicula()
        {
            InitializeComponent();
        }

        public void CambiarColorFondo(Color fondo)
        {
            this.BackColor = fondo;
        }

        public void CambiarImagen(string ruta)
        {
            this.pictureBox_impeli.Load(ruta);
        }

        public void button1_Click(object sender, EventArgs e)
        {
                       
        }

        private void pictureBox_impeli_Click(object sender, EventArgs e)
        {
            MainForm formPrincial = Application.OpenForms.OfType<MainForm>().FirstOrDefault();
            if (formPrincial != null)
            {
                //Updating data in cache
                MovieCache.Title = this.Title;
                MovieCache.Year = this.Year;
                MovieCache.Trailer = this.Trailer;
                MovieCache.Image = this.pictureBox_impeli.ImageLocation;
                MovieCache.Actors = this.Actors;
                MovieCache.Description = this.Description;
                MovieCache.Recommended = this.Recommended;
                

                //Open child form only when MovieCache is updated
                formPrincial.OpenChildForm<Template_Video>();
            }
        }
    }
}
