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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        Sign__in Open = new Sign__in();
        MainForm open_mainForm = new MainForm();
        UserDAO Service_User = new UserDAO();

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
        #region Lock_Text
        private void TxtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                TxtPassword.UseSystemPasswordChar = true;
            }
            else
            {
                TxtPassword.UseSystemPasswordChar = false;
            }
        }

        private void TxtPassword_Enter(object sender, EventArgs e)
        {
            TxtPassword.UseSystemPasswordChar = false;
        }

        #endregion

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label18_Click(object sender, EventArgs e)
        {
            this.Hide();
            Open.ShowDialog();     
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Btn_Entrar_Click(object sender, EventArgs e)
        {
            if (TxtUser.Text.Equals("") || TxtPassword.Text.Equals(""))
            {
                MessageBox.Show("POR FAVOR INGRESE UN USUARIO Y UNA CONTRASEÑA", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (Service_User.Login(TxtUser.Text, TxtPassword.Text) == false)
            {
                TxtPassword.Text = "";
            }
            else
            {
                Service_User.ConectarUser(TxtUser.Text);
                this.Hide();
                open_mainForm.Show();
                open_mainForm.FormClosed += cerrarSesion;
            }         
        }

        private void cerrarSesion(object cerrar, FormClosedEventArgs e)
        {
            TxtUser.Text = "";
            TxtPassword.Text = "";
            this.Show();
        }  
    }
}
