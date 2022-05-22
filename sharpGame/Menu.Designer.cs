
namespace sharpGame
{
    partial class Menu
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_exit = new System.Windows.Forms.PictureBox();
            this.btn_play = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_play)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::sharpGame.Properties.Resources.questionTrue;
            this.pictureBox2.Location = new System.Drawing.Point(524, 351);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 48);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.btn_question_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Image = global::sharpGame.Properties.Resources.exitTrue;
            this.btn_exit.Location = new System.Drawing.Point(120, 247);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(358, 93);
            this.btn_exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btn_exit.TabIndex = 2;
            this.btn_exit.TabStop = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            this.btn_exit.MouseLeave += new System.EventHandler(this.btn_exit_MouseLeave);
            this.btn_exit.MouseHover += new System.EventHandler(this.btn_exit_MouseHover);
            // 
            // btn_play
            // 
            this.btn_play.Image = global::sharpGame.Properties.Resources.playTrue;
            this.btn_play.Location = new System.Drawing.Point(120, 121);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(358, 93);
            this.btn_play.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btn_play.TabIndex = 1;
            this.btn_play.TabStop = false;
            this.btn_play.Click += new System.EventHandler(this.btn_play_Click);
            this.btn_play.MouseLeave += new System.EventHandler(this.btn_play_MouseLeave);
            this.btn_play.MouseHover += new System.EventHandler(this.btn_play_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::sharpGame.Properties.Resources.menuName;
            this.pictureBox1.Location = new System.Drawing.Point(54, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(494, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_play);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game_Menu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_play)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox btn_play;
        private System.Windows.Forms.PictureBox btn_exit;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}