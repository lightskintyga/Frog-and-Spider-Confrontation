
namespace sharpGame
{
    partial class Game
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lable_frog_score = new System.Windows.Forms.Label();
            this.label_spider_score = new System.Windows.Forms.Label();
            this.label_over = new System.Windows.Forms.Label();
            this.label_frogWin = new System.Windows.Forms.Label();
            this.label_spiderWin = new System.Windows.Forms.Label();
            this.spider = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.water = new System.Windows.Forms.PictureBox();
            this.enemySnake = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.spider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.water)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemySnake)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lable_frog_score
            // 
            this.lable_frog_score.AutoSize = true;
            this.lable_frog_score.BackColor = System.Drawing.Color.Transparent;
            this.lable_frog_score.Font = new System.Drawing.Font("Imprint MT Shadow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable_frog_score.ForeColor = System.Drawing.Color.Transparent;
            this.lable_frog_score.Location = new System.Drawing.Point(46, 20);
            this.lable_frog_score.Name = "lable_frog_score";
            this.lable_frog_score.Size = new System.Drawing.Size(90, 25);
            this.lable_frog_score.TabIndex = 8;
            this.lable_frog_score.Text = "Frog : 0";
            // 
            // label_spider_score
            // 
            this.label_spider_score.AutoSize = true;
            this.label_spider_score.BackColor = System.Drawing.Color.Transparent;
            this.label_spider_score.Font = new System.Drawing.Font("Imprint MT Shadow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_spider_score.ForeColor = System.Drawing.Color.Transparent;
            this.label_spider_score.Location = new System.Drawing.Point(434, 20);
            this.label_spider_score.Name = "label_spider_score";
            this.label_spider_score.Size = new System.Drawing.Size(108, 25);
            this.label_spider_score.TabIndex = 9;
            this.label_spider_score.Text = "Spider : 0";
            // 
            // label_over
            // 
            this.label_over.AutoSize = true;
            this.label_over.BackColor = System.Drawing.Color.Transparent;
            this.label_over.Font = new System.Drawing.Font("High Tower Text", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_over.ForeColor = System.Drawing.Color.White;
            this.label_over.Location = new System.Drawing.Point(206, 187);
            this.label_over.Name = "label_over";
            this.label_over.Size = new System.Drawing.Size(167, 28);
            this.label_over.TabIndex = 10;
            this.label_over.Text = "GAME OVER";
            // 
            // label_frogWin
            // 
            this.label_frogWin.AutoSize = true;
            this.label_frogWin.BackColor = System.Drawing.Color.Transparent;
            this.label_frogWin.Font = new System.Drawing.Font("High Tower Text", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_frogWin.ForeColor = System.Drawing.Color.White;
            this.label_frogWin.Location = new System.Drawing.Point(192, 187);
            this.label_frogWin.Name = "label_frogWin";
            this.label_frogWin.Size = new System.Drawing.Size(195, 28);
            this.label_frogWin.TabIndex = 11;
            this.label_frogWin.Text = "YOU\'VE WON!";
            // 
            // label_spiderWin
            // 
            this.label_spiderWin.AutoSize = true;
            this.label_spiderWin.BackColor = System.Drawing.Color.Transparent;
            this.label_spiderWin.Font = new System.Drawing.Font("High Tower Text", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_spiderWin.ForeColor = System.Drawing.Color.White;
            this.label_spiderWin.Location = new System.Drawing.Point(192, 187);
            this.label_spiderWin.Name = "label_spiderWin";
            this.label_spiderWin.Size = new System.Drawing.Size(183, 28);
            this.label_spiderWin.TabIndex = 12;
            this.label_spiderWin.Text = "SPIDER WON!";
            // 
            // spider
            // 
            this.spider.BackColor = System.Drawing.Color.Transparent;
            this.spider.Image = global::sharpGame.Properties.Resources.spiderOrig1;
            this.spider.Location = new System.Drawing.Point(211, -6);
            this.spider.Name = "spider";
            this.spider.Size = new System.Drawing.Size(127, 190);
            this.spider.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.spider.TabIndex = 3;
            this.spider.TabStop = false;
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.Image = global::sharpGame.Properties.Resources.frogRightOrig1;
            this.player.Location = new System.Drawing.Point(12, 260);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(48, 36);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.player.TabIndex = 1;
            this.player.TabStop = false;
            // 
            // water
            // 
            this.water.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.water.Image = global::sharpGame.Properties.Resources.backgroundGrey;
            this.water.Location = new System.Drawing.Point(0, 295);
            this.water.Name = "water";
            this.water.Size = new System.Drawing.Size(584, 116);
            this.water.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.water.TabIndex = 0;
            this.water.TabStop = false;
            // 
            // enemySnake
            // 
            this.enemySnake.BackColor = System.Drawing.Color.Transparent;
            this.enemySnake.Image = global::sharpGame.Properties.Resources.snakeOrig1;
            this.enemySnake.Location = new System.Drawing.Point(439, 269);
            this.enemySnake.Name = "enemySnake";
            this.enemySnake.Size = new System.Drawing.Size(25, 29);
            this.enemySnake.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.enemySnake.TabIndex = 2;
            this.enemySnake.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::sharpGame.Properties.Resources.upload__1_;
            this.pictureBox1.Location = new System.Drawing.Point(135, 260);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "fly";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::sharpGame.Properties.Resources.upload__1_;
            this.pictureBox2.Location = new System.Drawing.Point(232, 260);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "fly";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::sharpGame.Properties.Resources.upload__1_;
            this.pictureBox4.Location = new System.Drawing.Point(345, 260);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(30, 26);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "fly";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::sharpGame.Properties.Resources.upload__1_;
            this.pictureBox3.Location = new System.Drawing.Point(512, 260);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 26);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "fly";
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Controls.Add(this.lable_frog_score);
            this.Controls.Add(this.label_spider_score);
            this.Controls.Add(this.label_spiderWin);
            this.Controls.Add(this.label_frogWin);
            this.Controls.Add(this.label_over);
            this.Controls.Add(this.spider);
            this.Controls.Add(this.player);
            this.Controls.Add(this.water);
            this.Controls.Add(this.enemySnake);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.DoubleBuffered = true;
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameKeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameKeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.spider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.water)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemySnake)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox enemySnake;
        private System.Windows.Forms.PictureBox spider;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lable_frog_score;
        private System.Windows.Forms.Label label_spider_score;
        private System.Windows.Forms.Label label_over;
        private System.Windows.Forms.Label label_frogWin;
        private System.Windows.Forms.Label label_spiderWin;
        private System.Windows.Forms.PictureBox water;
    }
}