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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Template_Video));
            this.lb_descripcion = new System.Windows.Forms.Label();
            this.lb_generos = new System.Windows.Forms.Label();
            this.web_video = new System.Windows.Forms.WebBrowser();
            this.btn_exit = new FontAwesome.Sharp.IconButton();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconRecomendado = new FontAwesome.Sharp.IconPictureBox();
            this.picboxPelicula = new System.Windows.Forms.PictureBox();
            this.panelLateral = new System.Windows.Forms.Panel();
            this.panelLatSuperior = new System.Windows.Forms.Panel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelMovie = new System.Windows.Forms.Panel();
            this.lb_actores = new System.Windows.Forms.Label();
            panelDatos = new System.Windows.Forms.Panel();
            panelDatos.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconRecomendado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxPelicula)).BeginInit();
            this.panelLateral.SuspendLayout();
            this.panelLatSuperior.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.panelMovie.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDatos
            // 
            panelDatos.Controls.Add(this.lb_actores);
            panelDatos.Controls.Add(this.lb_descripcion);
            panelDatos.Controls.Add(this.lb_generos);
            panelDatos.Dock = System.Windows.Forms.DockStyle.Top;
            panelDatos.Location = new System.Drawing.Point(0, 388);
            panelDatos.Name = "panelDatos";
            panelDatos.Size = new System.Drawing.Size(284, 467);
            panelDatos.TabIndex = 7;
            // 
            // lb_descripcion
            // 
            this.lb_descripcion.AutoSize = true;
            this.lb_descripcion.Dock = System.Windows.Forms.DockStyle.Top;
            this.lb_descripcion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_descripcion.Location = new System.Drawing.Point(0, 98);
            this.lb_descripcion.MaximumSize = new System.Drawing.Size(280, 0);
            this.lb_descripcion.MinimumSize = new System.Drawing.Size(280, 0);
            this.lb_descripcion.Name = "lb_descripcion";
            this.lb_descripcion.Padding = new System.Windows.Forms.Padding(10);
            this.lb_descripcion.Size = new System.Drawing.Size(280, 33);
            this.lb_descripcion.TabIndex = 8;
            this.lb_descripcion.Text = "Este bloque contiene todos los actores de la pelicula";
            this.lb_descripcion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_generos
            // 
            this.lb_generos.AutoSize = true;
            this.lb_generos.Dock = System.Windows.Forms.DockStyle.Top;
            this.lb_generos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_generos.Location = new System.Drawing.Point(0, 0);
            this.lb_generos.MaximumSize = new System.Drawing.Size(280, 0);
            this.lb_generos.MinimumSize = new System.Drawing.Size(280, 0);
            this.lb_generos.Name = "lb_generos";
            this.lb_generos.Padding = new System.Windows.Forms.Padding(10);
            this.lb_generos.Size = new System.Drawing.Size(280, 98);
            this.lb_generos.TabIndex = 7;
            this.lb_generos.Text = resources.GetString("lb_generos.Text");
            this.lb_generos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // web_video
            // 
            this.web_video.Dock = System.Windows.Forms.DockStyle.Fill;
            this.web_video.Location = new System.Drawing.Point(0, 0);
            this.web_video.MinimumSize = new System.Drawing.Size(20, 20);
            this.web_video.Name = "web_video";
            this.web_video.Size = new System.Drawing.Size(1072, 679);
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
            this.btn_exit.Location = new System.Drawing.Point(24, 25);
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
            this.lblTitulo.Location = new System.Drawing.Point(6, 25);
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
            this.panel1.Location = new System.Drawing.Point(24, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(215, 261);
            this.panel1.TabIndex = 6;
            // 
            // iconRecomendado
            // 
            this.iconRecomendado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iconRecomendado.BackColor = System.Drawing.Color.Orange;
            this.iconRecomendado.ForeColor = System.Drawing.SystemColors.Window;
            this.iconRecomendado.IconChar = FontAwesome.Sharp.IconChar.Star;
            this.iconRecomendado.IconColor = System.Drawing.SystemColors.Window;
            this.iconRecomendado.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconRecomendado.Location = new System.Drawing.Point(183, 0);
            this.iconRecomendado.Name = "iconRecomendado";
            this.iconRecomendado.Size = new System.Drawing.Size(32, 32);
            this.iconRecomendado.TabIndex = 8;
            this.iconRecomendado.TabStop = false;
            // 
            // picboxPelicula
            // 
            this.picboxPelicula.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picboxPelicula.Location = new System.Drawing.Point(0, 0);
            this.picboxPelicula.Name = "picboxPelicula";
            this.picboxPelicula.Size = new System.Drawing.Size(215, 261);
            this.picboxPelicula.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxPelicula.TabIndex = 8;
            this.picboxPelicula.TabStop = false;
            this.picboxPelicula.Click += new System.EventHandler(this.picboxPelicula_Click);
            // 
            // panelLateral
            // 
            this.panelLateral.Controls.Add(panelDatos);
            this.panelLateral.Controls.Add(this.panelLatSuperior);
            this.panelLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLateral.Location = new System.Drawing.Point(0, 0);
            this.panelLateral.Name = "panelLateral";
            this.panelLateral.Size = new System.Drawing.Size(284, 788);
            this.panelLateral.TabIndex = 8;
            // 
            // panelLatSuperior
            // 
            this.panelLatSuperior.Controls.Add(this.panel1);
            this.panelLatSuperior.Controls.Add(this.btn_exit);
            this.panelLatSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLatSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelLatSuperior.Name = "panelLatSuperior";
            this.panelLatSuperior.Size = new System.Drawing.Size(284, 388);
            this.panelLatSuperior.TabIndex = 6;
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.lblTitulo);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(284, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1102, 89);
            this.panelTop.TabIndex = 9;
            // 
            // panelMovie
            // 
            this.panelMovie.Controls.Add(this.web_video);
            this.panelMovie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMovie.Location = new System.Drawing.Point(284, 89);
            this.panelMovie.Name = "panelMovie";
            this.panelMovie.Padding = new System.Windows.Forms.Padding(0, 0, 30, 20);
            this.panelMovie.Size = new System.Drawing.Size(1102, 699);
            this.panelMovie.TabIndex = 10;
            // 
            // lb_actores
            // 
            this.lb_actores.AutoSize = true;
            this.lb_actores.Dock = System.Windows.Forms.DockStyle.Top;
            this.lb_actores.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_actores.Location = new System.Drawing.Point(0, 131);
            this.lb_actores.MaximumSize = new System.Drawing.Size(280, 0);
            this.lb_actores.MinimumSize = new System.Drawing.Size(280, 0);
            this.lb_actores.Name = "lb_actores";
            this.lb_actores.Padding = new System.Windows.Forms.Padding(10);
            this.lb_actores.Size = new System.Drawing.Size(280, 33);
            this.lb_actores.TabIndex = 9;
            this.lb_actores.Text = "Año y los generos";
            this.lb_actores.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            panelDatos.ResumeLayout(false);
            panelDatos.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconRecomendado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxPelicula)).EndInit();
            this.panelLateral.ResumeLayout(false);
            this.panelLatSuperior.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelMovie.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.WebBrowser web_video;
        private FontAwesome.Sharp.IconButton btn_exit;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_generos;
        private System.Windows.Forms.PictureBox picboxPelicula;
        public FontAwesome.Sharp.IconPictureBox iconRecomendado;
        private System.Windows.Forms.Panel panelLateral;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelMovie;
        private System.Windows.Forms.Panel panelLatSuperior;
        private System.Windows.Forms.Label lb_descripcion;
        private System.Windows.Forms.Label lb_actores;
    }
}