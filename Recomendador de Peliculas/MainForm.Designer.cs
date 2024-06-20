namespace Recomendador_de_Peliculas
{
    partial class MainForm
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
            this.panelLateral = new System.Windows.Forms.Panel();
            this.btnExitSecond = new FontAwesome.Sharp.IconButton();
            this.panelDivisorTop = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.lb_buscar = new System.Windows.Forms.Label();
            this.btn_buscar = new FontAwesome.Sharp.IconButton();
            this.lb_name_user = new System.Windows.Forms.Label();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnMaximize = new FontAwesome.Sharp.IconButton();
            this.btnMinimize = new FontAwesome.Sharp.IconButton();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.flowLayoutPeli = new System.Windows.Forms.FlowLayoutPanel();
            this.lb_seccion_name = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.flowLayoutRecomed = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayout_ultimaspeli = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutanimation = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.flowLayoutfamily = new System.Windows.Forms.FlowLayoutPanel();
            this.panelLateral.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.panelContainer.SuspendLayout();
            this.flowLayoutPeli.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLateral
            // 
            this.panelLateral.AutoScroll = true;
            this.panelLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(14)))), ((int)(((byte)(38)))));
            this.panelLateral.Controls.Add(this.btnExitSecond);
            this.panelLateral.Controls.Add(this.panelDivisorTop);
            this.panelLateral.Controls.Add(this.panelLogo);
            this.panelLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLateral.Location = new System.Drawing.Point(0, 0);
            this.panelLateral.Name = "panelLateral";
            this.panelLateral.Size = new System.Drawing.Size(180, 689);
            this.panelLateral.TabIndex = 0;
            // 
            // btnExitSecond
            // 
            this.btnExitSecond.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(39)))), ((int)(((byte)(117)))));
            this.btnExitSecond.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExitSecond.FlatAppearance.BorderSize = 0;
            this.btnExitSecond.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitSecond.IconChar = FontAwesome.Sharp.IconChar.ArrowRightFromBracket;
            this.btnExitSecond.IconColor = System.Drawing.Color.Gainsboro;
            this.btnExitSecond.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExitSecond.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExitSecond.Location = new System.Drawing.Point(0, 639);
            this.btnExitSecond.Name = "btnExitSecond";
            this.btnExitSecond.Padding = new System.Windows.Forms.Padding(10, 0, 5, 0);
            this.btnExitSecond.Size = new System.Drawing.Size(180, 50);
            this.btnExitSecond.TabIndex = 2;
            this.btnExitSecond.Text = "Cerrar sesión";
            this.btnExitSecond.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExitSecond.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnExitSecond.UseVisualStyleBackColor = false;
            this.btnExitSecond.Click += new System.EventHandler(this.btnExitSecond_Click);
            // 
            // panelDivisorTop
            // 
            this.panelDivisorTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(233)))), ((int)(((byte)(209)))));
            this.panelDivisorTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDivisorTop.Location = new System.Drawing.Point(0, 60);
            this.panelDivisorTop.Name = "panelDivisorTop";
            this.panelDivisorTop.Size = new System.Drawing.Size(180, 5);
            this.panelDivisorTop.TabIndex = 1;
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(14)))), ((int)(((byte)(38)))));
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(180, 60);
            this.panelLogo.TabIndex = 0;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(14)))), ((int)(((byte)(38)))));
            this.panelTop.Controls.Add(this.lb_name_user);
            this.panelTop.Controls.Add(this.btnExit);
            this.panelTop.Controls.Add(this.btnMaximize);
            this.panelTop.Controls.Add(this.btnMinimize);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(180, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1141, 60);
            this.panelTop.TabIndex = 1;
            this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseDown);
            // 
            // lb_buscar
            // 
            this.lb_buscar.AutoSize = true;
            this.lb_buscar.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_buscar.Location = new System.Drawing.Point(27, 19);
            this.lb_buscar.Name = "lb_buscar";
            this.lb_buscar.Size = new System.Drawing.Size(74, 23);
            this.lb_buscar.TabIndex = 5;
            this.lb_buscar.Text = "Buscar:";
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(39)))), ((int)(((byte)(117)))));
            this.btn_buscar.FlatAppearance.BorderSize = 0;
            this.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar.ForeColor = System.Drawing.Color.Fuchsia;
            this.btn_buscar.IconChar = FontAwesome.Sharp.IconChar.Sistrix;
            this.btn_buscar.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btn_buscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_buscar.IconSize = 30;
            this.btn_buscar.Location = new System.Drawing.Point(677, 16);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(36, 31);
            this.btn_buscar.TabIndex = 4;
            this.btn_buscar.UseVisualStyleBackColor = false;
            // 
            // lb_name_user
            // 
            this.lb_name_user.AutoSize = true;
            this.lb_name_user.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_name_user.Location = new System.Drawing.Point(892, 15);
            this.lb_name_user.Name = "lb_name_user";
            this.lb_name_user.Size = new System.Drawing.Size(107, 23);
            this.lb_name_user.TabIndex = 3;
            this.lb_name_user.Text = "Name User";
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(39)))), ((int)(((byte)(117)))));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.btnExit.IconColor = System.Drawing.Color.Gainsboro;
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExit.IconSize = 25;
            this.btnExit.Location = new System.Drawing.Point(1111, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(25, 25);
            this.btnExit.TabIndex = 2;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(107, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(564, 26);
            this.textBox1.TabIndex = 2;
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(39)))), ((int)(((byte)(117)))));
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.IconChar = FontAwesome.Sharp.IconChar.UpRightFromSquare;
            this.btnMaximize.IconColor = System.Drawing.Color.Gainsboro;
            this.btnMaximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMaximize.IconSize = 25;
            this.btnMaximize.Location = new System.Drawing.Point(1080, 5);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(25, 25);
            this.btnMaximize.TabIndex = 1;
            this.btnMaximize.UseVisualStyleBackColor = false;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(39)))), ((int)(((byte)(117)))));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinimize.IconColor = System.Drawing.Color.Gainsboro;
            this.btnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimize.IconSize = 25;
            this.btnMinimize.Location = new System.Drawing.Point(1049, 5);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(25, 25);
            this.btnMinimize.TabIndex = 0;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(22)))), ((int)(((byte)(58)))));
            this.panelContainer.Controls.Add(this.btn_buscar);
            this.panelContainer.Controls.Add(this.lb_buscar);
            this.panelContainer.Controls.Add(this.flowLayoutPeli);
            this.panelContainer.Controls.Add(this.button1);
            this.panelContainer.Controls.Add(this.textBox1);
            this.panelContainer.Location = new System.Drawing.Point(185, 65);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1131, 619);
            this.panelContainer.TabIndex = 2;
            this.panelContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContainer_Paint);
            // 
            // flowLayoutPeli
            // 
            this.flowLayoutPeli.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPeli.AutoScroll = true;
            this.flowLayoutPeli.BackColor = System.Drawing.Color.Aqua;
            this.flowLayoutPeli.Controls.Add(this.lb_seccion_name);
            this.flowLayoutPeli.Controls.Add(this.flowLayout_ultimaspeli);
            this.flowLayoutPeli.Controls.Add(this.label1);
            this.flowLayoutPeli.Controls.Add(this.flowLayoutRecomed);
            this.flowLayoutPeli.Controls.Add(this.label2);
            this.flowLayoutPeli.Controls.Add(this.flowLayoutanimation);
            this.flowLayoutPeli.Controls.Add(this.label3);
            this.flowLayoutPeli.Controls.Add(this.flowLayoutfamily);
            this.flowLayoutPeli.Location = new System.Drawing.Point(20, 68);
            this.flowLayoutPeli.Name = "flowLayoutPeli";
            this.flowLayoutPeli.Size = new System.Drawing.Size(1091, 514);
            this.flowLayoutPeli.TabIndex = 3;
            // 
            // lb_seccion_name
            // 
            this.lb_seccion_name.AutoSize = true;
            this.lb_seccion_name.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_seccion_name.ForeColor = System.Drawing.Color.Black;
            this.lb_seccion_name.Location = new System.Drawing.Point(3, 0);
            this.lb_seccion_name.Name = "lb_seccion_name";
            this.lb_seccion_name.Size = new System.Drawing.Size(158, 23);
            this.lb_seccion_name.TabIndex = 4;
            this.lb_seccion_name.Text = "Ultimos Estrenos";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 588);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // flowLayoutRecomed
            // 
            this.flowLayoutRecomed.AutoScroll = true;
            this.flowLayoutRecomed.BackColor = System.Drawing.Color.AntiqueWhite;
            this.flowLayoutRecomed.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutRecomed.Location = new System.Drawing.Point(3, 286);
            this.flowLayoutRecomed.Name = "flowLayoutRecomed";
            this.flowLayoutRecomed.Size = new System.Drawing.Size(1077, 231);
            this.flowLayoutRecomed.TabIndex = 0;
            // 
            // flowLayout_ultimaspeli
            // 
            this.flowLayout_ultimaspeli.AutoScroll = true;
            this.flowLayout_ultimaspeli.BackColor = System.Drawing.Color.AntiqueWhite;
            this.flowLayout_ultimaspeli.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayout_ultimaspeli.Location = new System.Drawing.Point(3, 26);
            this.flowLayout_ultimaspeli.Name = "flowLayout_ultimaspeli";
            this.flowLayout_ultimaspeli.Size = new System.Drawing.Size(1077, 231);
            this.flowLayout_ultimaspeli.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tambien te Recomendamos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(3, 520);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Animacion";
            // 
            // flowLayoutanimation
            // 
            this.flowLayoutanimation.AutoScroll = true;
            this.flowLayoutanimation.BackColor = System.Drawing.Color.AntiqueWhite;
            this.flowLayoutanimation.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutanimation.Location = new System.Drawing.Point(3, 546);
            this.flowLayoutanimation.Name = "flowLayoutanimation";
            this.flowLayoutanimation.Size = new System.Drawing.Size(1077, 231);
            this.flowLayoutanimation.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(3, 780);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Para ver en Familia";
            // 
            // flowLayoutfamily
            // 
            this.flowLayoutfamily.AutoScroll = true;
            this.flowLayoutfamily.BackColor = System.Drawing.Color.AntiqueWhite;
            this.flowLayoutfamily.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutfamily.Location = new System.Drawing.Point(3, 806);
            this.flowLayoutfamily.Name = "flowLayoutfamily";
            this.flowLayoutfamily.Size = new System.Drawing.Size(1077, 231);
            this.flowLayoutfamily.TabIndex = 8;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(233)))), ((int)(((byte)(209)))));
            this.ClientSize = new System.Drawing.Size(1321, 689);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelLateral);
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(850, 500);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Recomendador de Películas";
            this.panelLateral.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelContainer.ResumeLayout(false);
            this.panelContainer.PerformLayout();
            this.flowLayoutPeli.ResumeLayout(false);
            this.flowLayoutPeli.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLateral;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Panel panelDivisorTop;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton btnMinimize;
        private FontAwesome.Sharp.IconButton btnExit;
        private FontAwesome.Sharp.IconButton btnMaximize;
        private FontAwesome.Sharp.IconButton btnExitSecond;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPeli;
        private System.Windows.Forms.Label lb_buscar;
        private FontAwesome.Sharp.IconButton btn_buscar;
        private System.Windows.Forms.Label lb_name_user;
        public System.Windows.Forms.Label lb_seccion_name;
        private System.Windows.Forms.FlowLayoutPanel flowLayout_ultimaspeli;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutRecomed;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutanimation;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutfamily;
    }
}

