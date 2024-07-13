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
using Recomendador_de_Peliculas.Common;


namespace Recomendador_de_Peliculas.UI
{
    public partial class Sign__in : Form
    {
        public Sign__in()
        {
            InitializeComponent();
        }
        
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

        #region Controls_Windows
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

        private void cerrarSesion(object cerrar, FormClosedEventArgs e)
        {
            TxtUser.Text = "";
            TxtPassword.Text = "";
            txt_email.Text = "";
            this.Show();
        }
        #endregion

        #region Validations_Text

        private void TxtPassword_Enter(object sender, EventArgs e)
        {
            TxtPassword.UseSystemPasswordChar = false;
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

        private void txt_email_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_email_Validating(object sender, CancelEventArgs e)
        {
            if (!txt_email.Text.Contains("@"))
            {
                e.Cancel = true;
                MessageBox.Show("Correo Invalido", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        private void Btn_Entrar_Click(object sender, EventArgs e)
        {
            UserDAO Service_User = new UserDAO();
            MainForm Open = new MainForm();
            
            if (TxtUser.Text.Equals("") || TxtPassword.Text.Equals("") || txt_email.Text.Equals(""))
            {
                MessageBox.Show("POR FAVOR INGRESE SU CORREO ELECTRONICO, NOMBRE DE USUARIO Y UNA CONTRASEÑA A REGISTRAR", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (Service_User.ValidateExistence(TxtUser.Text, txt_email.Text) == true)
            {
                MessageBox.Show("ERROR: ACCESO INVALIDO EN LOS CAMPOS DE REGISTRO", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtUser.Text = "";
                TxtPassword.Text = "";
            }
            else
            {
                Service_User.CreateUser(TxtUser.Text, txt_email.Text, TxtPassword.Text);
                MessageBox.Show(">>> EL USUARIO A SIDO CREADO EXISTOSAMENTE <<<\n\n ! BIENVENIDO A MOVIE AI !\n\n" + TxtUser.Text, "", MessageBoxButtons.OK);
                this.Hide();
                Service_User.ConectarUser(TxtUser.Text);
                Open.Show();
                Open.FormClosed += cerrarSesion;
            }
        }
    }
}
