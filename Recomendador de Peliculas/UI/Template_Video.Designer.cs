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
            System.Windows.Forms.Panel panelDatos;
            this.web_video = new System.Windows.Forms.WebBrowser();
            this.btn_exit = new FontAwesome.Sharp.IconButton();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.picboxPelicula = new System.Windows.Forms.PictureBox();
            this.iconRecomendado = new FontAwesome.Sharp.IconPictureBox();
            this.panelLateral = new System.Windows.Forms.Panel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelMovie = new System.Windows.Forms.Panel();
            this.panelLatSuperior = new System.Windows.Forms.Panel();
            this.lblActores = new System.Windows.Forms.Label();
            panelDatos = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxPelicula)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconRecomendado)).BeginInit();
            this.panelLateral.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.panelMovie.SuspendLayout();
            this.panelLatSuperior.SuspendLayout();
            panelDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // web_video
            // 
            this.web_video.Dock = System.Windows.Forms.DockStyle.Fill;
            this.web_video.Location = new System.Drawing.Point(0, 0);
            this.web_video.MaximumSize = new System.Drawing.Size(1141, 674);
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
            this.btn_exit.Location = new System.Drawing.Point(9, 7);
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
            this.lblTitulo.Location = new System.Drawing.Point(6, 9);
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
            this.panel1.Location = new System.Drawing.Point(12, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(215, 250);
            this.panel1.TabIndex = 6;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDescripcion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDescripcion.Location = new System.Drawing.Point(0, 0);
            this.lblDescripcion.MaximumSize = new System.Drawing.Size(250, 0);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Padding = new System.Windows.Forms.Padding(9);
            this.lblDescripcion.Size = new System.Drawing.Size(236, 70);
            this.lblDescripcion.TabIndex = 7;
            this.lblDescripcion.Text = "Este es un texto largo de ejemplo sobre laaa descripción de la película\r\nSe ajsut" +
    "a conforme se escribe en el q loco\r\nAaaaaaaaaa q paso menorrrrrr\r\n";
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
            // panelLateral
            // 
            this.panelLateral.Controls.Add(panelDatos);
            this.panelLateral.Controls.Add(this.panelLatSuperior);
            this.panelLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLateral.Location = new System.Drawing.Point(0, 0);
            this.panelLateral.Name = "panelLateral";
            this.panelLateral.Size = new System.Drawing.Size(242, 788);
            this.panelLateral.TabIndex = 8;
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.lblTitulo);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(242, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1144, 59);
            this.panelTop.TabIndex = 9;
            // 
            // panelMovie
            // 
            this.panelMovie.Controls.Add(this.web_video);
            this.panelMovie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMovie.Location = new System.Drawing.Point(242, 59);
            this.panelMovie.Name = "panelMovie";
            this.panelMovie.Size = new System.Drawing.Size(1144, 729);
            this.panelMovie.TabIndex = 10;
            // 
            // panelLatSuperior
            // 
            this.panelLatSuperior.Controls.Add(this.panel1);
            this.panelLatSuperior.Controls.Add(this.btn_exit);
            this.panelLatSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLatSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelLatSuperior.Name = "panelLatSuperior";
            this.panelLatSuperior.Size = new System.Drawing.Size(242, 318);
            this.panelLatSuperior.TabIndex = 6;
            // 
            // panelDatos
            // 
            panelDatos.Controls.Add(this.lblActores);
            panelDatos.Controls.Add(this.lblDescripcion);
            panelDatos.Dock = System.Windows.Forms.DockStyle.Top;
            panelDatos.Location = new System.Drawing.Point(0, 318);
            panelDatos.Name = "panelDatos";
            panelDatos.Size = new System.Drawing.Size(242, 467);
            panelDatos.TabIndex = 7;
            // 
            // lblActores
            // 
            this.lblActores.AutoSize = true;
            this.lblActores.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblActores.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblActores.Location = new System.Drawing.Point(0, 70);
            this.lblActores.MaximumSize = new System.Drawing.Size(250, 0);
            this.lblActores.Name = "lblActores";
            this.lblActores.Padding = new System.Windows.Forms.Padding(9);
            this.lblActores.Size = new System.Drawing.Size(237, 44);
            this.lblActores.TabIndex = 8;
            this.lblActores.Text = "Este bloque contiene todos los actores de la pelicula";
            // 
            // Template_Video
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(6)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.panelMovie);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelLateral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Template_Video";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Template_Video";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picboxPelicula)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconRecomendado)).EndInit();
            this.panelLateral.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelMovie.ResumeLayout(false);
            this.panelLatSuperior.ResumeLayout(false);
            panelDatos.ResumeLayout(false);
            panelDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.WebBrowser web_video;
        private FontAwesome.Sharp.IconButton btn_exit;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.PictureBox picboxPelicula;
        public FontAwesome.Sharp.IconPictureBox iconRecomendado;
        private System.Windows.Forms.Panel panelLateral;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelMovie;
        private System.Windows.Forms.Panel panelLatSuperior;
        private System.Windows.Forms.Label lblActores;
    }
}