namespace Recomendador_de_Peliculas.UI
{
    partial class Template_Video
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
            this.web_video = new System.Windows.Forms.WebBrowser();
            this.btn_exit = new FontAwesome.Sharp.IconButton();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.picboxPelicula = new System.Windows.Forms.PictureBox();
            this.iconRecomendado = new FontAwesome.Sharp.IconPictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxPelicula)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconRecomendado)).BeginInit();
            this.SuspendLayout();
            // 
            // web_video
            // 
            this.web_video.Location = new System.Drawing.Point(261, 75);
            this.web_video.MinimumSize = new System.Drawing.Size(20, 20);
            this.web_video.Name = "web_video";
            this.web_video.Size = new System.Drawing.Size(1141, 674);
            this.web_video.TabIndex = 3;
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            this.btn_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_exit.FlatAppearance.BorderSize = 0;
            this.btn_exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(53)))), ((int)(((byte)(179)))));
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.btn_exit.IconColor = System.Drawing.SystemColors.Window;
            this.btn_exit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_exit.IconSize = 30;
            this.btn_exit.Location = new System.Drawing.Point(27, 19);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(70, 35);
            this.btn_exit.TabIndex = 4;
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTitulo.Location = new System.Drawing.Point(815, 19);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(257, 39);
            this.lblTitulo.TabIndex = 5;
            this.lblTitulo.Text = "TRAILER PELI";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panel1.Controls.Add(this.iconRecomendado);
            this.panel1.Controls.Add(this.picboxPelicula);
            this.panel1.Location = new System.Drawing.Point(12, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(215, 250);
            this.panel1.TabIndex = 6;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDescripcion.Location = new System.Drawing.Point(12, 352);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(60, 13);
            this.lblDescripcion.TabIndex = 7;
            this.lblDescripcion.Text = "Description";
            // 
            // picboxPelicula
            // 
            this.picboxPelicula.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picboxPelicula.Location = new System.Drawing.Point(0, 0);
            this.picboxPelicula.Name = "picboxPelicula";
            this.picboxPelicula.Size = new System.Drawing.Size(215, 250);
            this.picboxPelicula.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxPelicula.TabIndex = 8;
            this.picboxPelicula.TabStop = false;
            // 
            // iconRecomendado
            // 
            this.iconRecomendado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iconRecomendado.BackColor = System.Drawing.Color.Orange;
            this.iconRecomendado.ForeColor = System.Drawing.SystemColors.Window;
            this.iconRecomendado.IconChar = FontAwesome.Sharp.IconChar.Sun;
            this.iconRecomendado.IconColor = System.Drawing.SystemColors.Window;
            this.iconRecomendado.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconRecomendado.Location = new System.Drawing.Point(183, 0);
            this.iconRecomendado.Name = "iconRecomendado";
            this.iconRecomendado.Size = new System.Drawing.Size(32, 32);
            this.iconRecomendado.TabIndex = 8;
            this.iconRecomendado.TabStop = false;
            // 
            // Template_Video
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(6)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.web_video);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Template_Video";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Template_Video";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picboxPelicula)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconRecomendado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.WebBrowser web_video;
        private FontAwesome.Sharp.IconButton btn_exit;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.PictureBox picboxPelicula;
        public FontAwesome.Sharp.IconPictureBox iconRecomendado;
    }
}