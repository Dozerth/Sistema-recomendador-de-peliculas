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
            this.Hide();
            Open.ShowDialog();
            this.Show();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Btn_Entrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            open_mainForm.ShowDialog();
            this.Show();
        }
    }
}
