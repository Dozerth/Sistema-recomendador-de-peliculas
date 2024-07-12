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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_videoLink = new System.Windows.Forms.TextBox();
            this.btn_play = new FontAwesome.Sharp.IconButton();
            this.web_video = new System.Windows.Forms.WebBrowser();
            this.btn_exit = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(122, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "LINK DEL VIDEO";
            // 
            // txt_videoLink
            // 
            this.txt_videoLink.Location = new System.Drawing.Point(219, 27);
            this.txt_videoLink.Name = "txt_videoLink";
            this.txt_videoLink.Size = new System.Drawing.Size(419, 20);
            this.txt_videoLink.TabIndex = 1;
            // 
            // btn_play
            // 
            this.btn_play.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_play.IconColor = System.Drawing.Color.Black;
            this.btn_play.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_play.Location = new System.Drawing.Point(660, 27);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(70, 22);
            this.btn_play.TabIndex = 2;
            this.btn_play.Text = "iconButton1";
            this.btn_play.UseVisualStyleBackColor = true;
            this.btn_play.Click += new System.EventHandler(this.btn_play_Click);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(815, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(257, 39);
            this.label2.TabIndex = 5;
            this.label2.Text = "TRAILER PELI";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(12, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(215, 250);
            this.panel1.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(10, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "IMG DE LA PELI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(24, 363);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Description";
            // 
            // Template_Video
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(6)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(1449, 789);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.web_video);
            this.Controls.Add(this.btn_play);
            this.Controls.Add(this.txt_videoLink);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Template_Video";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Template_Video";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_videoLink;
        private FontAwesome.Sharp.IconButton btn_play;
        private System.Windows.Forms.WebBrowser web_video;
        private FontAwesome.Sharp.IconButton btn_exit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}