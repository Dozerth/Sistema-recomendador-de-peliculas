namespace Recomendador_de_Peliculas.UI
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.btnMinimize = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.TxtUser = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.Btn_Entrar = new FontAwesome.Sharp.IconButton();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label22 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(14)))), ((int)(((byte)(38)))));
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnMinimize);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1012, 52);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(53)))), ((int)(((byte)(179)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.btnExit.IconColor = System.Drawing.Color.Gainsboro;
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExit.IconSize = 25;
            this.btnExit.Location = new System.Drawing.Point(954, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(36, 25);
            this.btnExit.TabIndex = 5;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(53)))), ((int)(((byte)(179)))));
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinimize.IconColor = System.Drawing.Color.Gainsboro;
            this.btnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimize.IconSize = 25;
            this.btnMinimize.Location = new System.Drawing.Point(912, 12);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(36, 25);
            this.btnMinimize.TabIndex = 3;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(546, 74);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(431, 213);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(2, 58);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1010, 687);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(6)))), ((int)(((byte)(61)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.TxtPassword);
            this.panel2.Controls.Add(this.TxtUser);
            this.panel2.Controls.Add(this.checkBox1);
            this.panel2.Controls.Add(this.label19);
            this.panel2.Controls.Add(this.label20);
            this.panel2.Controls.Add(this.label21);
            this.panel2.Controls.Add(this.Btn_Entrar);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.label22);
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Location = new System.Drawing.Point(535, 74);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(456, 655);
            this.panel2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(121, 598);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 16);
            this.label1.TabIndex = 209;
            this.label1.Text = "No tengo Cuenta";
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.Window;
            this.label18.Location = new System.Drawing.Point(230, 594);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(94, 21);
            this.label18.TabIndex = 208;
            this.label18.Text = "Registrarse";
            this.label18.Click += new System.EventHandler(this.label18_Click);
            // 
            // TxtPassword
            // 
            this.TxtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(185)))), ((int)(((byte)(185)))));
            this.TxtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPassword.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TxtPassword.Location = new System.Drawing.Point(124, 440);
            this.TxtPassword.Multiline = true;
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.PasswordChar = '•';
            this.TxtPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtPassword.Size = new System.Drawing.Size(231, 32);
            this.TxtPassword.TabIndex = 199;
            this.TxtPassword.UseSystemPasswordChar = true;
            // 
            // TxtUser
            // 
            this.TxtUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(185)))), ((int)(((byte)(185)))));
            this.TxtUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUser.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TxtUser.Location = new System.Drawing.Point(124, 341);
            this.TxtUser.Multiline = true;
            this.TxtUser.Name = "TxtUser";
            this.TxtUser.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtUser.Size = new System.Drawing.Size(231, 32);
            this.TxtUser.TabIndex = 204;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.checkBox1.Location = new System.Drawing.Point(124, 494);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(99, 17);
            this.checkBox1.TabIndex = 206;
            this.checkBox1.Text = "Ver Contraseña";
            this.checkBox1.UseVisualStyleBackColor = false;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.Window;
            this.label19.Location = new System.Drawing.Point(121, 392);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(77, 16);
            this.label19.TabIndex = 203;
            this.label19.Text = "Contraseña";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.Window;
            this.label20.Location = new System.Drawing.Point(121, 298);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(126, 16);
            this.label20.TabIndex = 202;
            this.label20.Text = "Nombre de Usuario";
            // 
            // label21
            // 
            this.label21.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(268, 545);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(0, 13);
            this.label21.TabIndex = 201;
            // 
            // Btn_Entrar
            // 
            this.Btn_Entrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_Entrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            this.Btn_Entrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Entrar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Btn_Entrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(53)))), ((int)(((byte)(179)))));
            this.Btn_Entrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Entrar.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold);
            this.Btn_Entrar.ForeColor = System.Drawing.SystemColors.Window;
            this.Btn_Entrar.IconChar = FontAwesome.Sharp.IconChar.CircleArrowRight;
            this.Btn_Entrar.IconColor = System.Drawing.Color.White;
            this.Btn_Entrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Btn_Entrar.IconSize = 25;
            this.Btn_Entrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Entrar.Location = new System.Drawing.Point(167, 543);
            this.Btn_Entrar.Name = "Btn_Entrar";
            this.Btn_Entrar.Size = new System.Drawing.Size(137, 38);
            this.Btn_Entrar.TabIndex = 200;
            this.Btn_Entrar.Text = "ENTRAR";
            this.Btn_Entrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Entrar.UseVisualStyleBackColor = false;
            this.Btn_Entrar.Click += new System.EventHandler(this.Btn_Entrar_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(70, 305);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(327, 111);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 205;
            this.pictureBox3.TabStop = false;
            // 
            // label22
            // 
            this.label22.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Font = new System.Drawing.Font("Iron Fist", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.SystemColors.Window;
            this.label22.Location = new System.Drawing.Point(153, 243);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(171, 22);
            this.label22.TabIndex = 198;
            this.label22.Text = "Iniciar Sesion";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(70, 404);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(327, 111);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 207;
            this.pictureBox4.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(6)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(1013, 741);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1013, 741);
            this.MinimumSize = new System.Drawing.Size(1013, 741);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnExit;
        private FontAwesome.Sharp.IconButton btnMinimize;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.TextBox TxtUser;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private FontAwesome.Sharp.IconButton Btn_Entrar;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label1;
    }
}