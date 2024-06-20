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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "LINK DEL VIDEO";
            // 
            // txt_videoLink
            // 
            this.txt_videoLink.Location = new System.Drawing.Point(140, 26);
            this.txt_videoLink.Name = "txt_videoLink";
            this.txt_videoLink.Size = new System.Drawing.Size(419, 20);
            this.txt_videoLink.TabIndex = 1;
            // 
            // btn_play
            // 
            this.btn_play.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_play.IconColor = System.Drawing.Color.Black;
            this.btn_play.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_play.Location = new System.Drawing.Point(581, 26);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(70, 22);
            this.btn_play.TabIndex = 2;
            this.btn_play.Text = "iconButton1";
            this.btn_play.UseVisualStyleBackColor = true;
            this.btn_play.Click += new System.EventHandler(this.btn_play_Click);
            // 
            // web_video
            // 
            this.web_video.Location = new System.Drawing.Point(27, 76);
            this.web_video.MinimumSize = new System.Drawing.Size(20, 20);
            this.web_video.Name = "web_video";
            this.web_video.Size = new System.Drawing.Size(720, 340);
            this.web_video.TabIndex = 3;
            // 
            // Template_Video
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.web_video);
            this.Controls.Add(this.btn_play);
            this.Controls.Add(this.txt_videoLink);
            this.Controls.Add(this.label1);
            this.Name = "Template_Video";
            this.Text = "Template_Video";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_videoLink;
        private FontAwesome.Sharp.IconButton btn_play;
        private System.Windows.Forms.WebBrowser web_video;
    }
}