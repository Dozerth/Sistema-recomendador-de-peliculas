namespace Recomendador_de_Peliculas.UI
{
    partial class Template_Category
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
            this.flowLayoutAnimacion = new System.Windows.Forms.FlowLayoutPanel();
            this.lb_category_name = new System.Windows.Forms.Label();
            this.btn_exit = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // flowLayoutAnimacion
            // 
            this.flowLayoutAnimacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutAnimacion.AutoScroll = true;
            this.flowLayoutAnimacion.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutAnimacion.Location = new System.Drawing.Point(87, 95);
            this.flowLayoutAnimacion.Name = "flowLayoutAnimacion";
            this.flowLayoutAnimacion.Size = new System.Drawing.Size(1284, 549);
            this.flowLayoutAnimacion.TabIndex = 17;
            // 
            // lb_category_name
            // 
            this.lb_category_name.AutoSize = true;
            this.lb_category_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_category_name.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_category_name.Location = new System.Drawing.Point(117, 29);
            this.lb_category_name.Name = "lb_category_name";
            this.lb_category_name.Size = new System.Drawing.Size(273, 39);
            this.lb_category_name.TabIndex = 6;
            this.lb_category_name.Text = "Category Name";
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            this.btn_exit.FlatAppearance.BorderSize = 0;
            this.btn_exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(53)))), ((int)(((byte)(179)))));
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.btn_exit.IconColor = System.Drawing.SystemColors.Window;
            this.btn_exit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_exit.IconSize = 30;
            this.btn_exit.Location = new System.Drawing.Point(24, 29);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(59, 35);
            this.btn_exit.TabIndex = 18;
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // Template_Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(6)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(1386, 750);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.lb_category_name);
            this.Controls.Add(this.flowLayoutAnimacion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Template_Category";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Template_Category";
            this.Load += new System.EventHandler(this.Template_Category_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutAnimacion;
        private FontAwesome.Sharp.IconButton btn_exit;
        public System.Windows.Forms.Label lb_category_name;
    }
}