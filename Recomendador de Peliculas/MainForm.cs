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

        //NOTE: autoscroll on main form is active, it´s for testing purposes
        public MainForm()
        {
            InitializeComponent();
            CollapseSubMenus();
            //Border buttons
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(5, 50);
            panelLateral.Controls.Add(leftBorderBtn);

            //Handle working area - resize
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
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

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {
                Point pos = new Point(m.LParam.ToInt32());
                pos = this.PointToClient(pos);
                if (pos.Y < cCaption)
                {
                    m.Result = (IntPtr)2;
                    return;
                }
                if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip)
                {
                    m.Result = (IntPtr)17;
                    return;
                }
            }
            base.WndProc(ref m);
        }



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

        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentButton = (IconButton)senderBtn; //IconButton has to be imported from (FontAwesome Library)
                currentButton.BackColor = RGBColors.MainButtonsActive;
                currentButton.ForeColor = color;
                currentButton.TextAlign = ContentAlignment.MiddleLeft;
                currentButton.IconColor = color;
                currentButton.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentButton.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentButton.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
            }
        }

        private void DisableButton()
        {
            if (currentButton != null)
            {
                currentButton.BackColor = RGBColors.MainButtonsDefault;
                currentButton.ForeColor = Color.Gainsboro;
                currentButton.TextAlign = ContentAlignment.MiddleLeft;
                currentButton.IconColor = Color.Gainsboro;
                currentButton.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentButton.ImageAlign = ContentAlignment.MiddleRight;
                leftBorderBtn.Visible = false; //Testing for piclogo click
            }
        }

        #endregion

        #region Child forms control
        private void OpenChildForm<MyForm>() where MyForm : Form, new()
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
            ActivateButton(sender, RGBColors.MainButtonsLettersActive);
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
            Application.Exit();
        }

        private void btnExitSecond_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            UCPelicula pelicula = new UCPelicula();
            pelicula.CambiarColorFondo(Color.FromArgb(70, 39, 117));
            pelicula.lblNombrePeli.Text = "Esta es mi peli";
            pelicula.Width = 200;
            pelicula.Height = 200;
            flowLayout_ultimaspeli.Controls.Add(pelicula);
        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
