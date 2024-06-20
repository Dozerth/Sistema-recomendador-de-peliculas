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
            this.button1 = new System.Windows.Forms.Button();
            this.lblNombrePeli = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(251, 99);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblNombrePeli
            // 
            this.lblNombrePeli.AutoSize = true;
            this.lblNombrePeli.Location = new System.Drawing.Point(43, 169);
            this.lblNombrePeli.Name = "lblNombrePeli";
            this.lblNombrePeli.Size = new System.Drawing.Size(89, 13);
            this.lblNombrePeli.TabIndex = 2;
            this.lblNombrePeli.Text = "Nombre de la peli";
            // 
            // UCPelicula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblNombrePeli);
            this.Controls.Add(this.button1);
            this.Name = "UCPelicula";
            this.Size = new System.Drawing.Size(377, 346);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label lblNombrePeli;
    }
}
