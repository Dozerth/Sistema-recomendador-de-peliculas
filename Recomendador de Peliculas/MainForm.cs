using FontAwesome.Sharp;
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
        private string YOUTUBE_BASE_PATH = "https://www.youtube.com/watch?v";
        private string CURRENT_DIRECTORY = System.IO.Directory.GetCurrentDirectory();
        private string IMAGES_BASE_PATH = "../../../Recursos/Images/";
        Template_Search open = new Template_Search();

        //Private fields for MySQL queries
        private MoviesDAO moviesDAO = new MoviesDAO();
        private MoviesBusiness movies = new MoviesBusiness();



        //NOTE: autoscroll on main form is active, it´s for testing purposes
        public MainForm()
        {
            InitializeComponent();
            CollapseSubMenus();
            //Border buttons
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(5, 50);
            //panelLateral.Controls.Add(leftBorderBtn);

            //Handle working area - resize
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            //Load movies per genre in the system
            LoadMainMovies();
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

        #region Desing Handlers

        private void CollapseSubMenus()
        {
            //TODO: Add each panel visible condition to false; panels from panelLateral controls
            //panelPayloads.Visible = false;            
        }

        private void HideSubMenu()
        {
            //TODO: Add to each panel a condition as this
            //if (panelPayloads.Visible == true) panelPayloads.Visible = false;
        }

        private void ShowSubMenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                HideSubMenu();
                submenu.Visible = true;
            }
            else
            {
                submenu.Visible = false;
            }
        }

        //private void ActivateButton(object senderBtn, Color color)
        //{
        //    if (senderBtn != null)
        //    {
        //        DisableButton();
        //        //Button
        //        currentButton = (IconButton)senderBtn; //IconButton has to be imported from (FontAwesome Library)
        //        currentButton.BackColor = RGBColors.MainButtonsActive;
        //        currentButton.ForeColor = color;
        //        currentButton.TextAlign = ContentAlignment.MiddleLeft;
        //        currentButton.IconColor = color;
        //        currentButton.TextImageRelation = TextImageRelation.TextBeforeImage;
        //        currentButton.ImageAlign = ContentAlignment.MiddleRight;
        //        //Left border button
        //        leftBorderBtn.BackColor = color;
        //        leftBorderBtn.Location = new Point(0, currentButton.Location.Y);
        //        leftBorderBtn.Visible = true;
        //        leftBorderBtn.BringToFront();
        //    }
        //}

        //private void DisableButton()
        //{
        //    if (currentButton != null)
        //    {
        //        currentButton.BackColor = RGBColors.MainButtonsDefault;
        //        currentButton.ForeColor = Color.Gainsboro;
        //        currentButton.TextAlign = ContentAlignment.MiddleLeft;
        //        currentButton.IconColor = Color.Gainsboro;
        //        currentButton.TextImageRelation = TextImageRelation.TextBeforeImage;
        //        currentButton.ImageAlign = ContentAlignment.MiddleRight;
        //        leftBorderBtn.Visible = false; //Testing for piclogo click
        //    }
        //}

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

        #region Main Panel Buttons

        private void ExampleToShowPanelsFromPanelLateral(object sender, EventArgs e)
        {
            //TODO: The code of this function is intended to be taken to each button which
            //      is a "container" of a panel, this collapses the SubMenu Panel, passed
            //      as an argument to ShowSubMenu() Function
            
            //CODE
            //ShowSubMenu(panelSessions);
            //ActivateButton(sender, RGBColors.MainButtonsLettersActive);
        }

        private void ExampleToCallForms(object sender, EventArgs e)
        {
            //TODO: The code of this function is intended to be taken to each button which
            //      invokes a new form form UI design

            // CODE
            // OpenChildForm<NombreDelForm>();
            HideSubMenu();
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
        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            UCPelicula pelicula = new UCPelicula();
            pelicula.CambiarColorFondo(Color.FromArgb(70, 39, 117));
            pelicula.lblNombrePeli.Text = "Intensamente 2";
            pelicula.Width = 216;
            pelicula.Height = 291;
            pelicula.Margin = new Padding(10);
            flowLayoutultimapelis.Controls.Add(pelicula);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            flowLayout_categorias.Margin = new Padding(10);
            string html = "<html><head>";
            html += "<meta content='IE=Edge' http-equiv='X-UA-Compatible'/>";
            html += "<iframe id='video' src='https://www.youtube.com/embed/{0}' width='975' height='360' frameborder='0' allowfullscreen></iframe>";
            html += "</head></html>";
            string video1 = "https://www.youtube.com/watch?v=I0_qFoptZ4Y";
            string video2 = "https://www.youtube.com/watch?v=xiC2iXTXHxw";
            this.web_video_Principal1.DocumentText = string.Format(html, video1.Split('=')[1]);
            //this.web_video_Principal2.DocumentText = string.Format(html, video2.Split('=')[1]);      
        }

        #region Buttons_Actions
        private void Btn_animacion_Click(object sender, EventArgs e)
        {
            OpenChildForm<Template_Category>();
            Template_Category formPrincial = Application.OpenForms.OfType<Template_Category>().FirstOrDefault();
            if (formPrincial != null)
            {
                formPrincial.lb_category_name.Text = "Peliculas de Animación";
            }
        }

        private void Btn_Aventura_Click(object sender, EventArgs e)
        {
            OpenChildForm<Template_Category>();
            Template_Category formPrincial = Application.OpenForms.OfType<Template_Category>().FirstOrDefault();
            if (formPrincial != null)
            {
                formPrincial.lb_category_name.Text = "Peliculas de Aventura";
            }
        }

        private void Btn_Accion_Click(object sender, EventArgs e)
        {
            OpenChildForm<Template_Category>();
            Template_Category formPrincial = Application.OpenForms.OfType<Template_Category>().FirstOrDefault();
            if (formPrincial != null)
            {
                formPrincial.lb_category_name.Text = "Peliculas de Acción";
            }
        }

        private void btn_comedia_Click(object sender, EventArgs e)
        {
            OpenChildForm<Template_Category>();
            Template_Category formPrincial = Application.OpenForms.OfType<Template_Category>().FirstOrDefault();
            if (formPrincial != null)
            {
                formPrincial.lb_category_name.Text = "Peliculas de Comedia";
            }
        }

        private void btn_cienciaficion_Click(object sender, EventArgs e)
        {
            OpenChildForm<Template_Category>();
            Template_Category formPrincial = Application.OpenForms.OfType<Template_Category>().FirstOrDefault();
            if (formPrincial != null)
            {
                formPrincial.lb_category_name.Text = "Peliculas de Ciencia Ficción";
            }
        }

        private void btn_fantasia_Click(object sender, EventArgs e)
        {
            OpenChildForm<Template_Category>();
            Template_Category formPrincial = Application.OpenForms.OfType<Template_Category>().FirstOrDefault();
            if (formPrincial != null)
            {
                formPrincial.lb_category_name.Text = "Peliculas de Fantasía";
            }
        }

        #endregion

        private void flowLayoutPeli_Paint(object sender, PaintEventArgs e)
        {
        }

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
