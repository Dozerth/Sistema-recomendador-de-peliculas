namespace Recomendador_de_Peliculas.UI
{
    partial class UCPelicula
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCPelicula));
            this.lblNombrePeli = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblAnio = new System.Windows.Forms.Label();
            this.iconRecomendado = new FontAwesome.Sharp.IconPictureBox();
            this.pictureBox_impeli = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconRecomendado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_impeli)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombrePeli
            // 
            this.lblNombrePeli.AutoSize = true;
            this.lblNombrePeli.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombrePeli.Location = new System.Drawing.Point(3, 252);
            this.lblNombrePeli.MaximumSize = new System.Drawing.Size(210, 0);
            this.lblNombrePeli.MinimumSize = new System.Drawing.Size(210, 22);
            this.lblNombrePeli.Name = "lblNombrePeli";
            this.lblNombrePeli.Size = new System.Drawing.Size(210, 44);
            this.lblNombrePeli.TabIndex = 2;
            this.lblNombrePeli.Text = "Nombre de la peliaaaacul";
            this.lblNombrePeli.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(207)))), ((int)(((byte)(9)))));
            this.panel1.Controls.Add(this.lblAnio);
            this.panel1.Location = new System.Drawing.Point(152, 202);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(64, 32);
            this.panel1.TabIndex = 3;
            // 
            // lblAnio
            // 
            this.lblAnio.AutoSize = true;
            this.lblAnio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(207)))), ((int)(((byte)(9)))));
            this.lblAnio.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnio.ForeColor = System.Drawing.SystemColors.Window;
            this.lblAnio.Location = new System.Drawing.Point(9, 5);
            this.lblAnio.Name = "lblAnio";
            this.lblAnio.Size = new System.Drawing.Size(50, 22);
            this.lblAnio.TabIndex = 4;
            this.lblAnio.Text = "2024";
            // 
            // iconRecomendado
            // 
            this.iconRecomendado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iconRecomendado.BackColor = System.Drawing.Color.Orange;
            this.iconRecomendado.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("iconRecomendado.BackgroundImage")));
            this.iconRecomendado.ForeColor = System.Drawing.SystemColors.Window;
            this.iconRecomendado.IconChar = FontAwesome.Sharp.IconChar.Star;
            this.iconRecomendado.IconColor = System.Drawing.SystemColors.Window;
            this.iconRecomendado.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconRecomendado.Location = new System.Drawing.Point(184, 0);
            this.iconRecomendado.Name = "iconRecomendado";
            this.iconRecomendado.Size = new System.Drawing.Size(32, 32);
            this.iconRecomendado.TabIndex = 4;
            this.iconRecomendado.TabStop = false;
            // 
            // pictureBox_impeli
            // 
            this.pictureBox_impeli.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_impeli.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_impeli.Image")));
            this.pictureBox_impeli.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_impeli.Name = "pictureBox_impeli";
            this.pictureBox_impeli.Size = new System.Drawing.Size(216, 247);
            this.pictureBox_impeli.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_impeli.TabIndex = 5;
            this.pictureBox_impeli.TabStop = false;
            this.pictureBox_impeli.Click += new System.EventHandler(this.pictureBox_impeli_Click);
            // 
            // UCPelicula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.iconRecomendado);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblNombrePeli);
            this.Controls.Add(this.pictureBox_impeli);
            this.Name = "UCPelicula";
            this.Size = new System.Drawing.Size(216, 302);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconRecomendado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_impeli)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label lblNombrePeli;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label lblAnio;
        private System.Windows.Forms.PictureBox pictureBox_impeli;
        public FontAwesome.Sharp.IconPictureBox iconRecomendado;
    }
}
