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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelTop = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lb_name_user = new System.Windows.Forms.Label();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.btnMaximize = new FontAwesome.Sharp.IconButton();
            this.btnMinimize = new FontAwesome.Sharp.IconButton();
            this.lb_buscar = new System.Windows.Forms.Label();
            this.btn_buscar = new FontAwesome.Sharp.IconButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.flowLayoutPeli = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.web_video_Principal1 = new System.Windows.Forms.WebBrowser();
            this.web_video_Principal2 = new System.Windows.Forms.WebBrowser();
            this.lb_seccion_name = new System.Windows.Forms.Label();
            this.flowLayout_categorias = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_animacion = new FontAwesome.Sharp.IconButton();
            this.btn_aventura = new FontAwesome.Sharp.IconButton();
            this.Btn_accion = new FontAwesome.Sharp.IconButton();
            this.btn_comedia = new FontAwesome.Sharp.IconButton();
            this.btn_cienciaficion = new FontAwesome.Sharp.IconButton();
            this.btn_fantasia = new FontAwesome.Sharp.IconButton();
            this.btn_familia = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutultimapelis = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelContainer.SuspendLayout();
            this.flowLayoutPeli.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayout_categorias.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(14)))), ((int)(((byte)(38)))));
            this.panelTop.Controls.Add(this.pictureBox1);
            this.panelTop.Controls.Add(this.lb_name_user);
            this.panelTop.Controls.Add(this.btnExit);
            this.panelTop.Controls.Add(this.btnMaximize);
            this.panelTop.Controls.Add(this.btnMinimize);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1386, 99);
            this.panelTop.TabIndex = 1;
            this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(269, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // lb_name_user
            // 
            this.lb_name_user.AutoSize = true;
            this.lb_name_user.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_name_user.Location = new System.Drawing.Point(1111, 38);
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
            this.btnExit.Location = new System.Drawing.Point(1356, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(25, 25);
            this.btnExit.TabIndex = 2;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
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
            this.btnMaximize.Location = new System.Drawing.Point(1325, 5);
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
            this.btnMinimize.Location = new System.Drawing.Point(1294, 5);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(25, 25);
            this.btnMinimize.TabIndex = 0;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // lb_buscar
            // 
            this.lb_buscar.AutoSize = true;
            this.lb_buscar.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_buscar.Location = new System.Drawing.Point(349, 24);
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
            this.btn_buscar.Location = new System.Drawing.Point(999, 21);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(36, 31);
            this.btn_buscar.TabIndex = 4;
            this.btn_buscar.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(429, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(564, 26);
            this.textBox1.TabIndex = 2;
            // 
            // panelContainer
            // 
            this.panelContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContainer.AutoScroll = true;
            this.panelContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(22)))), ((int)(((byte)(58)))));
            this.panelContainer.Controls.Add(this.iconButton1);
            this.panelContainer.Controls.Add(this.btn_buscar);
            this.panelContainer.Controls.Add(this.lb_buscar);
            this.panelContainer.Controls.Add(this.flowLayoutPeli);
            this.panelContainer.Controls.Add(this.textBox1);
            this.panelContainer.Location = new System.Drawing.Point(5, 105);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1376, 678);
            this.panelContainer.TabIndex = 2;
            this.panelContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContainer_Paint);
            // 
            // iconButton1
            // 
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(1089, 23);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(75, 23);
            this.iconButton1.TabIndex = 6;
            this.iconButton1.Text = "iconButton1";
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // flowLayoutPeli
            // 
            this.flowLayoutPeli.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPeli.AutoScroll = true;
            this.flowLayoutPeli.BackColor = System.Drawing.Color.Aqua;
            this.flowLayoutPeli.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPeli.Controls.Add(this.lb_seccion_name);
            this.flowLayoutPeli.Controls.Add(this.flowLayout_categorias);
            this.flowLayoutPeli.Controls.Add(this.label1);
            this.flowLayoutPeli.Controls.Add(this.flowLayoutultimapelis);
            this.flowLayoutPeli.Controls.Add(this.label2);
            this.flowLayoutPeli.Controls.Add(this.flowLayoutPanel1);
            this.flowLayoutPeli.Controls.Add(this.label3);
            this.flowLayoutPeli.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPeli.Controls.Add(this.label4);
            this.flowLayoutPeli.Controls.Add(this.flowLayoutPanel4);
            this.flowLayoutPeli.Location = new System.Drawing.Point(43, 76);
            this.flowLayoutPeli.Name = "flowLayoutPeli";
            this.flowLayoutPeli.Size = new System.Drawing.Size(1302, 561);
            this.flowLayoutPeli.TabIndex = 3;
            this.flowLayoutPeli.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPeli_Paint);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel3.AutoScroll = true;
            this.flowLayoutPanel3.BackColor = System.Drawing.Color.AntiqueWhite;
            this.flowLayoutPanel3.Controls.Add(this.web_video_Principal1);
            this.flowLayoutPanel3.Controls.Add(this.web_video_Principal2);
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel3.MaximumSize = new System.Drawing.Size(1334, 521);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(1334, 409);
            this.flowLayoutPanel3.TabIndex = 9;
            // 
            // web_video_Principal1
            // 
            this.web_video_Principal1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.web_video_Principal1.Location = new System.Drawing.Point(3, 3);
            this.web_video_Principal1.MinimumSize = new System.Drawing.Size(1003, 380);
            this.web_video_Principal1.Name = "web_video_Principal1";
            this.web_video_Principal1.Size = new System.Drawing.Size(1003, 380);
            this.web_video_Principal1.TabIndex = 7;
            // 
            // web_video_Principal2
            // 
            this.web_video_Principal2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.web_video_Principal2.Location = new System.Drawing.Point(1012, 3);
            this.web_video_Principal2.MinimumSize = new System.Drawing.Size(1003, 380);
            this.web_video_Principal2.Name = "web_video_Principal2";
            this.web_video_Principal2.Size = new System.Drawing.Size(1003, 380);
            this.web_video_Principal2.TabIndex = 9;
            // 
            // lb_seccion_name
            // 
            this.lb_seccion_name.AutoSize = true;
            this.lb_seccion_name.Dock = System.Windows.Forms.DockStyle.Top;
            this.lb_seccion_name.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_seccion_name.ForeColor = System.Drawing.Color.Black;
            this.lb_seccion_name.Location = new System.Drawing.Point(3, 425);
            this.lb_seccion_name.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.lb_seccion_name.Name = "lb_seccion_name";
            this.lb_seccion_name.Size = new System.Drawing.Size(135, 31);
            this.lb_seccion_name.TabIndex = 4;
            this.lb_seccion_name.Text = "Categorias";
            // 
            // flowLayout_categorias
            // 
            this.flowLayout_categorias.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayout_categorias.AutoScroll = true;
            this.flowLayout_categorias.BackColor = System.Drawing.Color.AntiqueWhite;
            this.flowLayout_categorias.Controls.Add(this.btn_animacion);
            this.flowLayout_categorias.Controls.Add(this.btn_aventura);
            this.flowLayout_categorias.Controls.Add(this.Btn_accion);
            this.flowLayout_categorias.Controls.Add(this.btn_comedia);
            this.flowLayout_categorias.Controls.Add(this.btn_cienciaficion);
            this.flowLayout_categorias.Controls.Add(this.btn_fantasia);
            this.flowLayout_categorias.Controls.Add(this.btn_familia);
            this.flowLayout_categorias.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayout_categorias.Location = new System.Drawing.Point(3, 469);
            this.flowLayout_categorias.Name = "flowLayout_categorias";
            this.flowLayout_categorias.Size = new System.Drawing.Size(1334, 52);
            this.flowLayout_categorias.TabIndex = 1;
            // 
            // btn_animacion
            // 
            this.btn_animacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(39)))), ((int)(((byte)(117)))));
            this.btn_animacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_animacion.FlatAppearance.BorderSize = 0;
            this.btn_animacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_animacion.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_animacion.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_animacion.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_animacion.IconColor = System.Drawing.Color.Black;
            this.btn_animacion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_animacion.Location = new System.Drawing.Point(40, 0);
            this.btn_animacion.Margin = new System.Windows.Forms.Padding(40, 0, 50, 0);
            this.btn_animacion.Name = "btn_animacion";
            this.btn_animacion.Size = new System.Drawing.Size(127, 43);
            this.btn_animacion.TabIndex = 0;
            this.btn_animacion.Text = "Animación";
            this.btn_animacion.UseVisualStyleBackColor = false;
            this.btn_animacion.Click += new System.EventHandler(this.Btn_animacion_Click);
            // 
            // btn_aventura
            // 
            this.btn_aventura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(39)))), ((int)(((byte)(117)))));
            this.btn_aventura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_aventura.FlatAppearance.BorderSize = 0;
            this.btn_aventura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_aventura.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_aventura.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_aventura.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_aventura.IconColor = System.Drawing.Color.Black;
            this.btn_aventura.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_aventura.Location = new System.Drawing.Point(257, 0);
            this.btn_aventura.Margin = new System.Windows.Forms.Padding(40, 0, 50, 0);
            this.btn_aventura.Name = "btn_aventura";
            this.btn_aventura.Size = new System.Drawing.Size(127, 43);
            this.btn_aventura.TabIndex = 5;
            this.btn_aventura.Text = "Aventura";
            this.btn_aventura.UseVisualStyleBackColor = false;
            this.btn_aventura.Click += new System.EventHandler(this.Btn_Aventura_Click);
            // 
            // Btn_accion
            // 
            this.Btn_accion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(39)))), ((int)(((byte)(117)))));
            this.Btn_accion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_accion.FlatAppearance.BorderSize = 0;
            this.Btn_accion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_accion.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_accion.ForeColor = System.Drawing.SystemColors.Window;
            this.Btn_accion.IconChar = FontAwesome.Sharp.IconChar.None;
            this.Btn_accion.IconColor = System.Drawing.Color.Black;
            this.Btn_accion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Btn_accion.Location = new System.Drawing.Point(474, 0);
            this.Btn_accion.Margin = new System.Windows.Forms.Padding(40, 0, 50, 0);
            this.Btn_accion.Name = "Btn_accion";
            this.Btn_accion.Size = new System.Drawing.Size(127, 43);
            this.Btn_accion.TabIndex = 1;
            this.Btn_accion.Text = "Acción";
            this.Btn_accion.UseVisualStyleBackColor = false;
            this.Btn_accion.Click += new System.EventHandler(this.Btn_Accion_Click);
            // 
            // btn_comedia
            // 
            this.btn_comedia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(39)))), ((int)(((byte)(117)))));
            this.btn_comedia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_comedia.FlatAppearance.BorderSize = 0;
            this.btn_comedia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_comedia.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_comedia.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_comedia.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_comedia.IconColor = System.Drawing.Color.Black;
            this.btn_comedia.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_comedia.Location = new System.Drawing.Point(691, 0);
            this.btn_comedia.Margin = new System.Windows.Forms.Padding(40, 0, 50, 0);
            this.btn_comedia.Name = "btn_comedia";
            this.btn_comedia.Size = new System.Drawing.Size(127, 43);
            this.btn_comedia.TabIndex = 6;
            this.btn_comedia.Text = "Comedia";
            this.btn_comedia.UseVisualStyleBackColor = false;
            this.btn_comedia.Click += new System.EventHandler(this.btn_comedia_Click);
            // 
            // btn_cienciaficion
            // 
            this.btn_cienciaficion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(39)))), ((int)(((byte)(117)))));
            this.btn_cienciaficion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cienciaficion.FlatAppearance.BorderSize = 0;
            this.btn_cienciaficion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cienciaficion.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cienciaficion.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_cienciaficion.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_cienciaficion.IconColor = System.Drawing.Color.Black;
            this.btn_cienciaficion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_cienciaficion.Location = new System.Drawing.Point(908, 0);
            this.btn_cienciaficion.Margin = new System.Windows.Forms.Padding(40, 0, 50, 0);
            this.btn_cienciaficion.Name = "btn_cienciaficion";
            this.btn_cienciaficion.Size = new System.Drawing.Size(127, 43);
            this.btn_cienciaficion.TabIndex = 7;
            this.btn_cienciaficion.Text = "Ciencia Ficción";
            this.btn_cienciaficion.UseVisualStyleBackColor = false;
            this.btn_cienciaficion.Click += new System.EventHandler(this.btn_cienciaficion_Click);
            // 
            // btn_fantasia
            // 
            this.btn_fantasia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(39)))), ((int)(((byte)(117)))));
            this.btn_fantasia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_fantasia.FlatAppearance.BorderSize = 0;
            this.btn_fantasia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_fantasia.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_fantasia.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_fantasia.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_fantasia.IconColor = System.Drawing.Color.Black;
            this.btn_fantasia.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_fantasia.Location = new System.Drawing.Point(1125, 0);
            this.btn_fantasia.Margin = new System.Windows.Forms.Padding(40, 0, 50, 0);
            this.btn_fantasia.Name = "btn_fantasia";
            this.btn_fantasia.Size = new System.Drawing.Size(127, 43);
            this.btn_fantasia.TabIndex = 8;
            this.btn_fantasia.Text = "Fantasía";
            this.btn_fantasia.UseVisualStyleBackColor = false;
            this.btn_fantasia.Click += new System.EventHandler(this.btn_fantasia_Click);
            // 
            // btn_familia
            // 
            this.btn_familia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_familia.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_familia.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_familia.IconColor = System.Drawing.Color.Black;
            this.btn_familia.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_familia.Location = new System.Drawing.Point(1305, 3);
            this.btn_familia.Name = "btn_familia";
            this.btn_familia.Size = new System.Drawing.Size(0, 43);
            this.btn_familia.TabIndex = 9;
            this.btn_familia.Text = "Familia";
            this.btn_familia.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 534);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ultimos Estrenos";
            // 
            // flowLayoutultimapelis
            // 
            this.flowLayoutultimapelis.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutultimapelis.AutoScroll = true;
            this.flowLayoutultimapelis.BackColor = System.Drawing.Color.AntiqueWhite;
            this.flowLayoutultimapelis.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutultimapelis.Location = new System.Drawing.Point(3, 578);
            this.flowLayoutultimapelis.Name = "flowLayoutultimapelis";
            this.flowLayoutultimapelis.Size = new System.Drawing.Size(1334, 330);
            this.flowLayoutultimapelis.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(3, 921);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(336, 31);
            this.label2.TabIndex = 17;
            this.label2.Text = "Tambien Te Recomendamos";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 965);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1334, 335);
            this.flowLayoutPanel1.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(3, 1313);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 31);
            this.label3.TabIndex = 19;
            this.label3.Text = "Animacion";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoScroll = true;
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.AntiqueWhite;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 1357);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1334, 335);
            this.flowLayoutPanel2.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(3, 1705);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(231, 31);
            this.label4.TabIndex = 21;
            this.label4.Text = "Para ver en Familia";
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel4.AutoScroll = true;
            this.flowLayoutPanel4.BackColor = System.Drawing.Color.AntiqueWhite;
            this.flowLayoutPanel4.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(3, 1749);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(1334, 335);
            this.flowLayoutPanel4.TabIndex = 22;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panelTop);
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(850, 500);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Recomendador de Películas";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelContainer.ResumeLayout(false);
            this.panelContainer.PerformLayout();
            this.flowLayoutPeli.ResumeLayout(false);
            this.flowLayoutPeli.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayout_categorias.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelTop;
        private FontAwesome.Sharp.IconButton btnMinimize;
        private FontAwesome.Sharp.IconButton btnExit;
        private FontAwesome.Sharp.IconButton btnMaximize;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPeli;
        private System.Windows.Forms.Label lb_buscar;
        private FontAwesome.Sharp.IconButton btn_buscar;
        private System.Windows.Forms.Label lb_name_user;
        public System.Windows.Forms.Label lb_seccion_name;
        private System.Windows.Forms.FlowLayoutPanel flowLayout_categorias;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.WebBrowser web_video_Principal1;
        private System.Windows.Forms.WebBrowser web_video_Principal2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutultimapelis;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        public System.Windows.Forms.Label label4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private FontAwesome.Sharp.IconButton btn_animacion;
        private FontAwesome.Sharp.IconButton btn_aventura;
        private FontAwesome.Sharp.IconButton Btn_accion;
        private FontAwesome.Sharp.IconButton btn_comedia;
        private FontAwesome.Sharp.IconButton btn_cienciaficion;
        private FontAwesome.Sharp.IconButton btn_fantasia;
        private FontAwesome.Sharp.IconButton btn_familia;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

