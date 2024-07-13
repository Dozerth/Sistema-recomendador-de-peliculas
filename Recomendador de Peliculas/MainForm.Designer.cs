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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lb_user = new System.Windows.Forms.Label();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.btnMaximize = new FontAwesome.Sharp.IconButton();
            this.btnMinimize = new FontAwesome.Sharp.IconButton();
            this.lb_buscar = new System.Windows.Forms.Label();
            this.btn_buscar = new FontAwesome.Sharp.IconButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.btn_cerrar_sesion = new FontAwesome.Sharp.IconButton();
            this.flowLayoutPeli = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.web_video_Principal1 = new System.Windows.Forms.WebBrowser();
            this.lb_seccion_name = new System.Windows.Forms.Label();
            this.flowLayout_categorias = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_animacion = new FontAwesome.Sharp.IconButton();
            this.btn_aventura = new FontAwesome.Sharp.IconButton();
            this.Btn_accion = new FontAwesome.Sharp.IconButton();
            this.btn_comedia = new FontAwesome.Sharp.IconButton();
            this.btn_cienciaficion = new FontAwesome.Sharp.IconButton();
            this.btn_fantasia = new FontAwesome.Sharp.IconButton();
            this.btn_familia = new FontAwesome.Sharp.IconButton();
            this.lb_ultimos_estrenos = new System.Windows.Forms.Label();
            this.flowLayoutultimapelis = new System.Windows.Forms.FlowLayoutPanel();
            this.lb_recomenda = new System.Windows.Forms.Label();
            this.panelRecomendados = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.panelAnimacion = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.panelFamilia = new System.Windows.Forms.FlowLayoutPanel();
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
            this.panelTop.Controls.Add(this.panel1);
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Controls.Add(this.pictureBox1);
            this.panelTop.Controls.Add(this.lb_user);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(207)))), ((int)(((byte)(9)))));
            this.panel1.Location = new System.Drawing.Point(344, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(318, 2);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(350, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 27);
            this.label1.TabIndex = 5;
            this.label1.Text = "¡ Hola de Nuevo !    : ";
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
            // lb_user
            // 
            this.lb_user.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_user.AutoSize = true;
            this.lb_user.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_user.ForeColor = System.Drawing.Color.White;
            this.lb_user.Location = new System.Drawing.Point(577, 37);
            this.lb_user.Name = "lb_user";
            this.lb_user.Size = new System.Drawing.Size(85, 23);
            this.lb_user.TabIndex = 3;
            this.lb_user.Text = "usuarios";
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
            this.btnMaximize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(53)))), ((int)(((byte)(179)))));
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
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(53)))), ((int)(((byte)(179)))));
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
            this.btn_buscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            this.btn_buscar.FlatAppearance.BorderSize = 0;
            this.btn_buscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(53)))), ((int)(((byte)(179)))));
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
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
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
            this.panelContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(6)))), ((int)(((byte)(61)))));
            this.panelContainer.Controls.Add(this.btn_cerrar_sesion);
            this.panelContainer.Controls.Add(this.btn_buscar);
            this.panelContainer.Controls.Add(this.lb_buscar);
            this.panelContainer.Controls.Add(this.flowLayoutPeli);
            this.panelContainer.Controls.Add(this.textBox1);
            this.panelContainer.Location = new System.Drawing.Point(5, 105);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1376, 678);
            this.panelContainer.TabIndex = 2;
            // 
            // btn_cerrar_sesion
            // 
            this.btn_cerrar_sesion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cerrar_sesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            this.btn_cerrar_sesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cerrar_sesion.FlatAppearance.BorderSize = 0;
            this.btn_cerrar_sesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(53)))), ((int)(((byte)(179)))));
            this.btn_cerrar_sesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cerrar_sesion.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cerrar_sesion.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_cerrar_sesion.IconChar = FontAwesome.Sharp.IconChar.ArrowRightFromBracket;
            this.btn_cerrar_sesion.IconColor = System.Drawing.SystemColors.Window;
            this.btn_cerrar_sesion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_cerrar_sesion.IconSize = 25;
            this.btn_cerrar_sesion.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_cerrar_sesion.Location = new System.Drawing.Point(1225, 21);
            this.btn_cerrar_sesion.Margin = new System.Windows.Forms.Padding(40, 0, 50, 0);
            this.btn_cerrar_sesion.Name = "btn_cerrar_sesion";
            this.btn_cerrar_sesion.Size = new System.Drawing.Size(120, 33);
            this.btn_cerrar_sesion.TabIndex = 10;
            this.btn_cerrar_sesion.Text = "Cerrar Sesion";
            this.btn_cerrar_sesion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cerrar_sesion.UseVisualStyleBackColor = false;
            this.btn_cerrar_sesion.Click += new System.EventHandler(this.btn_cerrar_sesion_Click);
            // 
            // flowLayoutPeli
            // 
            this.flowLayoutPeli.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPeli.AutoScroll = true;
            this.flowLayoutPeli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(6)))), ((int)(((byte)(61)))));
            this.flowLayoutPeli.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPeli.Controls.Add(this.lb_seccion_name);
            this.flowLayoutPeli.Controls.Add(this.flowLayout_categorias);
            this.flowLayoutPeli.Controls.Add(this.lb_ultimos_estrenos);
            this.flowLayoutPeli.Controls.Add(this.flowLayoutultimapelis);
            this.flowLayoutPeli.Controls.Add(this.lb_recomenda);
            this.flowLayoutPeli.Controls.Add(this.panelRecomendados);
            this.flowLayoutPeli.Controls.Add(this.label3);
            this.flowLayoutPeli.Controls.Add(this.panelAnimacion);
            this.flowLayoutPeli.Controls.Add(this.label4);
            this.flowLayoutPeli.Controls.Add(this.panelFamilia);
            this.flowLayoutPeli.Location = new System.Drawing.Point(43, 76);
            this.flowLayoutPeli.Name = "flowLayoutPeli";
            this.flowLayoutPeli.Size = new System.Drawing.Size(1302, 561);
            this.flowLayoutPeli.TabIndex = 3;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel3.AutoScroll = true;
            this.flowLayoutPanel3.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel3.Controls.Add(this.web_video_Principal1);
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.flowLayoutPanel3.MaximumSize = new System.Drawing.Size(1934, 521);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(1262, 409);
            this.flowLayoutPanel3.TabIndex = 9;
            // 
            // web_video_Principal1
            // 
            this.web_video_Principal1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.web_video_Principal1.Location = new System.Drawing.Point(160, 3);
            this.web_video_Principal1.Margin = new System.Windows.Forms.Padding(160, 3, 3, 3);
            this.web_video_Principal1.MinimumSize = new System.Drawing.Size(1003, 380);
            this.web_video_Principal1.Name = "web_video_Principal1";
            this.web_video_Principal1.Size = new System.Drawing.Size(1003, 380);
            this.web_video_Principal1.TabIndex = 7;
            // 
            // lb_seccion_name
            // 
            this.lb_seccion_name.AutoSize = true;
            this.lb_seccion_name.Dock = System.Windows.Forms.DockStyle.Top;
            this.lb_seccion_name.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_seccion_name.ForeColor = System.Drawing.SystemColors.Window;
            this.lb_seccion_name.Location = new System.Drawing.Point(610, 437);
            this.lb_seccion_name.Margin = new System.Windows.Forms.Padding(610, 5, 3, 35);
            this.lb_seccion_name.Name = "lb_seccion_name";
            this.lb_seccion_name.Size = new System.Drawing.Size(135, 31);
            this.lb_seccion_name.TabIndex = 4;
            this.lb_seccion_name.Text = "Categorias";
            // 
            // flowLayout_categorias
            // 
            this.flowLayout_categorias.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayout_categorias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(6)))), ((int)(((byte)(61)))));
            this.flowLayout_categorias.Controls.Add(this.btn_animacion);
            this.flowLayout_categorias.Controls.Add(this.btn_aventura);
            this.flowLayout_categorias.Controls.Add(this.Btn_accion);
            this.flowLayout_categorias.Controls.Add(this.btn_comedia);
            this.flowLayout_categorias.Controls.Add(this.btn_cienciaficion);
            this.flowLayout_categorias.Controls.Add(this.btn_fantasia);
            this.flowLayout_categorias.Controls.Add(this.btn_familia);
            this.flowLayout_categorias.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayout_categorias.Location = new System.Drawing.Point(3, 506);
            this.flowLayout_categorias.MinimumSize = new System.Drawing.Size(1234, 52);
            this.flowLayout_categorias.Name = "flowLayout_categorias";
            this.flowLayout_categorias.Size = new System.Drawing.Size(1262, 59);
            this.flowLayout_categorias.TabIndex = 1;
            // 
            // btn_animacion
            // 
            this.btn_animacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            this.btn_animacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_animacion.FlatAppearance.BorderSize = 0;
            this.btn_animacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(53)))), ((int)(((byte)(179)))));
            this.btn_animacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_animacion.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_animacion.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_animacion.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_animacion.IconColor = System.Drawing.Color.Black;
            this.btn_animacion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_animacion.Location = new System.Drawing.Point(40, 0);
            this.btn_animacion.Margin = new System.Windows.Forms.Padding(40, 0, 40, 0);
            this.btn_animacion.Name = "btn_animacion";
            this.btn_animacion.Size = new System.Drawing.Size(127, 43);
            this.btn_animacion.TabIndex = 0;
            this.btn_animacion.Text = "Animación";
            this.btn_animacion.UseVisualStyleBackColor = false;
            this.btn_animacion.Click += new System.EventHandler(this.Btn_animacion_Click);
            // 
            // btn_aventura
            // 
            this.btn_aventura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            this.btn_aventura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_aventura.FlatAppearance.BorderSize = 0;
            this.btn_aventura.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(53)))), ((int)(((byte)(179)))));
            this.btn_aventura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_aventura.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_aventura.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_aventura.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_aventura.IconColor = System.Drawing.Color.Black;
            this.btn_aventura.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_aventura.Location = new System.Drawing.Point(247, 0);
            this.btn_aventura.Margin = new System.Windows.Forms.Padding(40, 0, 40, 0);
            this.btn_aventura.Name = "btn_aventura";
            this.btn_aventura.Size = new System.Drawing.Size(127, 43);
            this.btn_aventura.TabIndex = 5;
            this.btn_aventura.Text = "Aventura";
            this.btn_aventura.UseVisualStyleBackColor = false;
            this.btn_aventura.Click += new System.EventHandler(this.Btn_Aventura_Click);
            // 
            // Btn_accion
            // 
            this.Btn_accion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            this.Btn_accion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_accion.FlatAppearance.BorderSize = 0;
            this.Btn_accion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(53)))), ((int)(((byte)(179)))));
            this.Btn_accion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_accion.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_accion.ForeColor = System.Drawing.SystemColors.Window;
            this.Btn_accion.IconChar = FontAwesome.Sharp.IconChar.None;
            this.Btn_accion.IconColor = System.Drawing.Color.Black;
            this.Btn_accion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Btn_accion.Location = new System.Drawing.Point(454, 0);
            this.Btn_accion.Margin = new System.Windows.Forms.Padding(40, 0, 40, 0);
            this.Btn_accion.Name = "Btn_accion";
            this.Btn_accion.Size = new System.Drawing.Size(127, 43);
            this.Btn_accion.TabIndex = 1;
            this.Btn_accion.Text = "Acción";
            this.Btn_accion.UseVisualStyleBackColor = false;
            this.Btn_accion.Click += new System.EventHandler(this.Btn_Accion_Click);
            // 
            // btn_comedia
            // 
            this.btn_comedia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            this.btn_comedia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_comedia.FlatAppearance.BorderSize = 0;
            this.btn_comedia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(53)))), ((int)(((byte)(179)))));
            this.btn_comedia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_comedia.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_comedia.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_comedia.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_comedia.IconColor = System.Drawing.Color.Black;
            this.btn_comedia.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_comedia.Location = new System.Drawing.Point(661, 0);
            this.btn_comedia.Margin = new System.Windows.Forms.Padding(40, 0, 40, 0);
            this.btn_comedia.Name = "btn_comedia";
            this.btn_comedia.Size = new System.Drawing.Size(127, 43);
            this.btn_comedia.TabIndex = 6;
            this.btn_comedia.Text = "Comedia";
            this.btn_comedia.UseVisualStyleBackColor = false;
            this.btn_comedia.Click += new System.EventHandler(this.btn_comedia_Click);
            // 
            // btn_cienciaficion
            // 
            this.btn_cienciaficion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            this.btn_cienciaficion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cienciaficion.FlatAppearance.BorderSize = 0;
            this.btn_cienciaficion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(53)))), ((int)(((byte)(179)))));
            this.btn_cienciaficion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cienciaficion.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cienciaficion.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_cienciaficion.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_cienciaficion.IconColor = System.Drawing.Color.Black;
            this.btn_cienciaficion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_cienciaficion.Location = new System.Drawing.Point(868, 0);
            this.btn_cienciaficion.Margin = new System.Windows.Forms.Padding(40, 0, 40, 0);
            this.btn_cienciaficion.Name = "btn_cienciaficion";
            this.btn_cienciaficion.Size = new System.Drawing.Size(127, 43);
            this.btn_cienciaficion.TabIndex = 7;
            this.btn_cienciaficion.Text = "Ciencia Ficción";
            this.btn_cienciaficion.UseVisualStyleBackColor = false;
            this.btn_cienciaficion.Click += new System.EventHandler(this.btn_cienciaficion_Click);
            // 
            // btn_fantasia
            // 
            this.btn_fantasia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            this.btn_fantasia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_fantasia.FlatAppearance.BorderSize = 0;
            this.btn_fantasia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(53)))), ((int)(((byte)(179)))));
            this.btn_fantasia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_fantasia.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_fantasia.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_fantasia.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_fantasia.IconColor = System.Drawing.Color.Black;
            this.btn_fantasia.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_fantasia.Location = new System.Drawing.Point(1075, 0);
            this.btn_fantasia.Margin = new System.Windows.Forms.Padding(40, 0, 40, 0);
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
            this.btn_familia.Location = new System.Drawing.Point(1245, 3);
            this.btn_familia.Name = "btn_familia";
            this.btn_familia.Size = new System.Drawing.Size(0, 43);
            this.btn_familia.TabIndex = 9;
            this.btn_familia.Text = "Familia";
            this.btn_familia.UseVisualStyleBackColor = true;
            // 
            // lb_ultimos_estrenos
            // 
            this.lb_ultimos_estrenos.AutoSize = true;
            this.lb_ultimos_estrenos.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ultimos_estrenos.ForeColor = System.Drawing.SystemColors.Window;
            this.lb_ultimos_estrenos.Location = new System.Drawing.Point(3, 588);
            this.lb_ultimos_estrenos.Margin = new System.Windows.Forms.Padding(3, 20, 3, 25);
            this.lb_ultimos_estrenos.Name = "lb_ultimos_estrenos";
            this.lb_ultimos_estrenos.Size = new System.Drawing.Size(206, 31);
            this.lb_ultimos_estrenos.TabIndex = 5;
            this.lb_ultimos_estrenos.Text = "Ultimos Estrenos";
            // 
            // flowLayoutultimapelis
            // 
            this.flowLayoutultimapelis.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutultimapelis.AutoScroll = true;
            this.flowLayoutultimapelis.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutultimapelis.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutultimapelis.Location = new System.Drawing.Point(3, 647);
            this.flowLayoutultimapelis.Name = "flowLayoutultimapelis";
            this.flowLayoutultimapelis.Size = new System.Drawing.Size(1262, 330);
            this.flowLayoutultimapelis.TabIndex = 16;
            // 
            // lb_recomenda
            // 
            this.lb_recomenda.AutoSize = true;
            this.lb_recomenda.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_recomenda.ForeColor = System.Drawing.SystemColors.Window;
            this.lb_recomenda.Location = new System.Drawing.Point(3, 1000);
            this.lb_recomenda.Margin = new System.Windows.Forms.Padding(3, 20, 3, 25);
            this.lb_recomenda.Name = "lb_recomenda";
            this.lb_recomenda.Size = new System.Drawing.Size(336, 31);
            this.lb_recomenda.TabIndex = 17;
            this.lb_recomenda.Text = "Tambien Te Recomendamos";
            // 
            // panelRecomendados
            // 
            this.panelRecomendados.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelRecomendados.AutoScroll = true;
            this.panelRecomendados.BackColor = System.Drawing.Color.Transparent;
            this.panelRecomendados.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panelRecomendados.Location = new System.Drawing.Point(3, 1059);
            this.panelRecomendados.Name = "panelRecomendados";
            this.panelRecomendados.Size = new System.Drawing.Size(1262, 335);
            this.panelRecomendados.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(3, 1417);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 20, 3, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 31);
            this.label3.TabIndex = 19;
            this.label3.Text = "Animacion";
            // 
            // panelAnimacion
            // 
            this.panelAnimacion.AutoScroll = true;
            this.panelAnimacion.BackColor = System.Drawing.Color.Transparent;
            this.panelAnimacion.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panelAnimacion.Location = new System.Drawing.Point(3, 1476);
            this.panelAnimacion.Name = "panelAnimacion";
            this.panelAnimacion.Size = new System.Drawing.Size(1262, 335);
            this.panelAnimacion.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(3, 1834);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 20, 3, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(231, 31);
            this.label4.TabIndex = 21;
            this.label4.Text = "Para ver en Familia";
            // 
            // panelFamilia
            // 
            this.panelFamilia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFamilia.AutoScroll = true;
            this.panelFamilia.BackColor = System.Drawing.Color.Transparent;
            this.panelFamilia.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panelFamilia.Location = new System.Drawing.Point(3, 1893);
            this.panelFamilia.Name = "panelFamilia";
            this.panelFamilia.Size = new System.Drawing.Size(1262, 335);
            this.panelFamilia.TabIndex = 22;
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1364, 726);
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
        private System.Windows.Forms.Label lb_user;
        public System.Windows.Forms.Label lb_seccion_name;
        private System.Windows.Forms.FlowLayoutPanel flowLayout_categorias;
        public System.Windows.Forms.Label lb_ultimos_estrenos;
        public System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.WebBrowser web_video_Principal1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutultimapelis;
        public System.Windows.Forms.Label lb_recomenda;
        private System.Windows.Forms.FlowLayoutPanel panelRecomendados;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel panelAnimacion;
        public System.Windows.Forms.Label label4;
        private System.Windows.Forms.FlowLayoutPanel panelFamilia;
        private FontAwesome.Sharp.IconButton btn_animacion;
        private FontAwesome.Sharp.IconButton btn_aventura;
        private FontAwesome.Sharp.IconButton Btn_accion;
        private FontAwesome.Sharp.IconButton btn_comedia;
        private FontAwesome.Sharp.IconButton btn_cienciaficion;
        private FontAwesome.Sharp.IconButton btn_fantasia;
        private FontAwesome.Sharp.IconButton btn_familia;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton btn_cerrar_sesion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}

