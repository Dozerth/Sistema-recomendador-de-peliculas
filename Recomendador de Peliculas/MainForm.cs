﻿using FontAwesome.Sharp;
using Recomendador_de_Peliculas.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using Recomendador_de_Peliculas.UI;
using Recomendador_de_Peliculas.DAO;
using Recomendador_de_Peliculas.DTO;
using Recomendador_de_Peliculas.Common;
using Recomendador_de_Peliculas.Business;

namespace Recomendador_de_Peliculas
{
    public partial class MainForm : Form
    {
        //Private fields
        private IconButton currentButton; //NOTE: NEED TO BE IMPORTED (FontAwesome Library)
        private Panel leftBorderBtn;
        private Form currentChildForm = null;
        private const int cGrip = 16;
        private const int cCaption = 32;
        Template_Search open = new Template_Search();

        //Private fields for MySQL queries
        private MoviesDAO moviesDAO = new MoviesDAO();
        private MoviesBusiness movies = new MoviesBusiness();



        //NOTE: autoscroll on main form is active, it´s for testing purposes
        public MainForm()
        {
            InitializeComponent();
            //Handle working area - resize
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            //Load movies per genre in the system
            LoadMainMovies();
            movies.LoadMoviesOnCache();
        }        

        #region Structures
        private struct RGBColors
        {
            //public static Color MainButtonsDefault = Color.FromArgb(52, 52, 52);
            public static Color MainButtonsDefault = Color.FromArgb(70, 39, 117);
            public static Color MainButtonsActive = Color.FromArgb(0, 37, 62);
            public static Color MainButtonsLettersActive = Color.Gainsboro;
            public static Color MainContainetForm = Color.FromArgb(6, 22, 58);
            public static Color MainTopPanel = Color.FromArgb(67, 149, 173);
        }
        #endregion

        #region Drag From Handler
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        //protected override void WndProc(ref Message m)
        //{
        //    if (m.Msg == 0x84)
        //    {
        //        Point pos = new Point(m.LParam.ToInt32());
        //        pos = this.PointToClient(pos);
        //        if (pos.Y < cCaption)
        //        {
        //            m.Result = (IntPtr)2;
        //            return;
        //        }
        //        if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip)
        //        {
        //            m.Result = (IntPtr)17;
        //            return;
        //        }
        //    }
        //    base.WndProc(ref m);
        //}

        #endregion

        #region Panels
        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        #region Child forms control
        public void OpenChildForm<MyForm>() where MyForm : Form, new()
        {
            Form externalChildForm;
            externalChildForm = panelContainer.Controls.OfType<MyForm>().FirstOrDefault();
            if (externalChildForm == null)
            {
                panelContainer.Visible = true;
                externalChildForm = new MyForm();
                externalChildForm.TopLevel = false;
                externalChildForm.FormBorderStyle = FormBorderStyle.None;
                externalChildForm.Dock = DockStyle.Fill;
                panelContainer.Controls.Add(externalChildForm);
                panelContainer.Tag = externalChildForm;
                externalChildForm.Show();
                externalChildForm.BringToFront();
            }
            else
            {
                if (panelContainer.Visible == false) { panelContainer.Visible = true; }
                externalChildForm.BringToFront();
            }
        }
        #endregion

        #region Control Buttons
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            this.Close();
        }

        private void btnExitSecond_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        private void MainForm_Load(object sender, EventArgs e)
        {
            lb_user.Text = UserLoginCache.Username;
            flowLayout_categorias.Margin = new Padding(10);
            string html = "<html><head>";
            html += "<meta content='IE=Edge' http-equiv='X-UA-Compatible'/>";
            html += @"<style type='text/css'> body, html {width: 100%; height: 100%; margin: 0; padding: 0}
                    .row-container {display: flex; width: 100%; height: 100%; flex-direction: column; overflow: hidden;}
                    .second-row {position: absolute; top: 0px; left: 0; right: 0; bottom: 0; background-color: red }
                    .second-row iframe {display: block; position: absolute; width: 100%; height: 100%; border: none;}</style>";
            html += "<div class='second-row'>";
            html += string.Format("<iframe id='video' src='https://www.youtube.com/embed/{0}' allowfullscreen></iframe>", "I0_qFoptZ4Y");
            html += "</div></head></html>";
            this.web_video_Principal1.DocumentText = html;     
        }

        #region Buttons_Actions
        private void Btn_animacion_Click(object sender, EventArgs e)
        {
            MovieCache.CategorySearch = 1;
            OpenChildForm<Template_Category>();
            Template_Category formPrincial = Application.OpenForms.OfType<Template_Category>().FirstOrDefault();
            if (formPrincial != null)
            {
                formPrincial.lb_category_name.Text = "Peliculas de Animación";
            }
        }

        private void Btn_Aventura_Click(object sender, EventArgs e)
        {
            MovieCache.CategorySearch = 4;
            OpenChildForm<Template_Category>();
            Template_Category formPrincial = Application.OpenForms.OfType<Template_Category>().FirstOrDefault();
            if (formPrincial != null)
            {
                formPrincial.lb_category_name.Text = "Peliculas de Aventura";
            }
        }

        private void Btn_Accion_Click(object sender, EventArgs e)
        {
            MovieCache.CategorySearch = 7;
            OpenChildForm<Template_Category>();
            Template_Category formPrincial = Application.OpenForms.OfType<Template_Category>().FirstOrDefault();
            if (formPrincial != null)
            {
                formPrincial.lb_category_name.Text = "Peliculas de Acción";
            }
        }

        private void btn_comedia_Click(object sender, EventArgs e)
        {
            MovieCache.CategorySearch = 5;
            OpenChildForm<Template_Category>();
            Template_Category formPrincial = Application.OpenForms.OfType<Template_Category>().FirstOrDefault();
            if (formPrincial != null)
            {
                formPrincial.lb_category_name.Text = "Peliculas de Comedia";
            }
        }

        private void btn_cienciaficion_Click(object sender, EventArgs e)
        {
            MovieCache.CategorySearch = 6;
            OpenChildForm<Template_Category>();
            Template_Category formPrincial = Application.OpenForms.OfType<Template_Category>().FirstOrDefault();
            if (formPrincial != null)
            {
                formPrincial.lb_category_name.Text = "Peliculas de Ciencia Ficción";
            }
        }

        private void btn_fantasia_Click(object sender, EventArgs e)
        {
            MovieCache.CategorySearch = 8;
            OpenChildForm<Template_Category>();            
            Template_Category formPrincial = Application.OpenForms.OfType<Template_Category>().FirstOrDefault();
            if (formPrincial != null)
            {
                formPrincial.lb_category_name.Text = "Peliculas de Fantasía";
            }
        }

        #endregion

        private void LoadMainMovies()
        {
            List<MoviesDTO> peliculas = moviesDAO.RetrieveMoviesByYear(2024, 10);
            movies.LoadMoviesInPanel(flowLayoutultimapelis, peliculas);
            peliculas = moviesDAO.RetrieveMoviesByGenre(4, 10);
            movies.LoadMoviesInPanel(panelRecomendados, peliculas, true);
            peliculas = moviesDAO.RetrieveMoviesByGenre(1, 10);
            movies.LoadMoviesInPanel(panelAnimacion, peliculas);
            peliculas = moviesDAO.RetrieveMoviesByGenre(2, 10);
            movies.LoadMoviesInPanel(panelFamilia, peliculas);
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            this.Hide();
            open.ShowDialog();
            this.Show();
        }

        private void btn_cerrar_sesion_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
