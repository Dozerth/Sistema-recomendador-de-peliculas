using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Recomendador_de_Peliculas.UI;
using Recomendador_de_Peliculas.DAO;


namespace Recomendador_de_Peliculas.UI
{
    public partial class Sign__in : Form
    {
        public Sign__in()
        {
            InitializeComponent();
        }
        UserDAO Service_userDAO = new UserDAO();
        Login Open = new Login();
        #region Mover_Panel
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #endregion

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label18_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Btn_Entrar_Click(object sender, EventArgs e)
        {
            if (TxtUser.Text.Equals("") || TxtPassword.Text.Equals("") || txt_email.Text.Equals(""))
            {
                MessageBox.Show("POR FAVOR INGRESE SU CORREO ELECTRONICO, NOMBRE DE USUARIO Y UNA CONTRASEÑA A REGISTRAR", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (Service_userDAO.ValidateExistence(TxtUser.Text, txt_email.Text) == false)
            {
                TxtUser.Text = "";
            }
            else
            {
                Service_userDAO.CreateUser(TxtUser.Text, txt_email.Text, TxtPassword.Text);
                MessageBox.Show("EL USUARIO A SIDO CREADO EXISTOSAMENTE, BIENVEIDO A MOVIAI "+TxtUser+"", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Service_userDAO.ConectarUser(TxtUser.Text);
                this.Hide();
                Open.ShowDialog();       
            }
        }
    }
}
