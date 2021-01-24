namespace Fighter_Plane_War_Game
{
    partial class Form1
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
            this.Points = new System.Windows.Forms.Label();
            this.gameover = new System.Windows.Forms.Label();
            this.Restart = new System.Windows.Forms.Button();
            this.enemytimer = new System.Windows.Forms.Timer(this.components);
            this.fire1 = new System.Windows.Forms.Timer(this.components);
            this.fire2 = new System.Windows.Forms.Timer(this.components);
            this.fire3 = new System.Windows.Forms.Timer(this.components);
            this.Bullet2 = new System.Windows.Forms.PictureBox();
            this.Bullet3 = new System.Windows.Forms.PictureBox();
            this.Bullet1 = new System.Windows.Forms.PictureBox();
            this.enemy4 = new System.Windows.Forms.PictureBox();
            this.enemy3 = new System.Windows.Forms.PictureBox();
            this.enemy5 = new System.Windows.Forms.PictureBox();
            this.enemy2 = new System.Windows.Forms.PictureBox();
            this.fighter = new System.Windows.Forms.PictureBox();
            this.enemy1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Bullet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bullet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bullet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fighter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).BeginInit();
            this.SuspendLayout();
            // 
            // Points
            // 
            this.Points.AutoSize = true;
            this.Points.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Points.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Points.ForeColor = System.Drawing.Color.Yellow;
            this.Points.Location = new System.Drawing.Point(-6, -1);
            this.Points.Name = "Points";
            this.Points.Size = new System.Drawing.Size(47, 52);
            this.Points.TabIndex = 6;
            this.Points.Text = "0";
            // 
            // gameover
            // 
            this.gameover.AutoSize = true;
            this.gameover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gameover.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameover.ForeColor = System.Drawing.Color.Red;
            this.gameover.Location = new System.Drawing.Point(366, 164);
            this.gameover.Name = "gameover";
            this.gameover.Size = new System.Drawing.Size(249, 52);
            this.gameover.TabIndex = 7;
            this.gameover.Text = "Game Over";
            // 
            // Restart
            // 
            this.Restart.BackColor = System.Drawing.Color.Gray;
            this.Restart.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Restart.ForeColor = System.Drawing.Color.Yellow;
            this.Restart.Location = new System.Drawing.Point(365, 219);
            this.Restart.Name = "Restart";
            this.Restart.Size = new System.Drawing.Size(250, 59);
            this.Restart.TabIndex = 8;
            this.Restart.Tag = "";
            this.Restart.Text = "Restart Game";
            this.Restart.UseVisualStyleBackColor = false;
            this.Restart.Click += new System.EventHandler(this.Restart_Click);
            // 
            // enemytimer
            // 
            this.enemytimer.Enabled = true;
            this.enemytimer.Interval = 10;
            this.enemytimer.Tick += new System.EventHandler(this.enemytimer_Tick);
            // 
            // fire1
            // 
            this.fire1.Enabled = true;
            this.fire1.Interval = 10;
            this.fire1.Tick += new System.EventHandler(this.fire1_Tick);
            // 
            // fire2
            // 
            this.fire2.Interval = 10;
            this.fire2.Tick += new System.EventHandler(this.fire2_Tick);
            // 
            // fire3
            // 
            this.fire3.Interval = 10;
            this.fire3.Tick += new System.EventHandler(this.fire3_Tick);
            // 
            // Bullet2
            // 
            this.Bullet2.Image = global::Fighter_Plane_War_Game.Properties.Resources.download_bullet_image_old_10;
            this.Bullet2.Location = new System.Drawing.Point(149, 131);
            this.Bullet2.Name = "Bullet2";
            this.Bullet2.Size = new System.Drawing.Size(43, 27);
            this.Bullet2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Bullet2.TabIndex = 12;
            this.Bullet2.TabStop = false;
            // 
            // Bullet3
            // 
            this.Bullet3.Image = global::Fighter_Plane_War_Game.Properties.Resources.download_bullet_image_old_10;
            this.Bullet3.Location = new System.Drawing.Point(149, 235);
            this.Bullet3.Name = "Bullet3";
            this.Bullet3.Size = new System.Drawing.Size(43, 27);
            this.Bullet3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Bullet3.TabIndex = 11;
            this.Bullet3.TabStop = false;
            this.Bullet3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // Bullet1
            // 
            this.Bullet1.Image = global::Fighter_Plane_War_Game.Properties.Resources.download_bullet_image_old_10;
            this.Bullet1.Location = new System.Drawing.Point(149, 184);
            this.Bullet1.Name = "Bullet1";
            this.Bullet1.Size = new System.Drawing.Size(43, 27);
            this.Bullet1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Bullet1.TabIndex = 9;
            this.Bullet1.TabStop = false;
            // 
            // enemy4
            // 
            this.enemy4.Image = global::Fighter_Plane_War_Game.Properties.Resources.fighter_plane_sprite_png_2;
            this.enemy4.Location = new System.Drawing.Point(672, 276);
            this.enemy4.Name = "enemy4";
            this.enemy4.Size = new System.Drawing.Size(60, 50);
            this.enemy4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy4.TabIndex = 5;
            this.enemy4.TabStop = false;
            // 
            // enemy3
            // 
            this.enemy3.Image = global::Fighter_Plane_War_Game.Properties.Resources.fighter_plane_sprite_png_2;
            this.enemy3.Location = new System.Drawing.Point(864, 161);
            this.enemy3.Name = "enemy3";
            this.enemy3.Size = new System.Drawing.Size(60, 50);
            this.enemy3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy3.TabIndex = 4;
            this.enemy3.TabStop = false;
            // 
            // enemy5
            // 
            this.enemy5.Image = global::Fighter_Plane_War_Game.Properties.Resources.fighter_plane_silhouette_12;
            this.enemy5.Location = new System.Drawing.Point(849, 257);
            this.enemy5.Name = "enemy5";
            this.enemy5.Size = new System.Drawing.Size(65, 50);
            this.enemy5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy5.TabIndex = 3;
            this.enemy5.TabStop = false;
            // 
            // enemy2
            // 
            this.enemy2.Image = global::Fighter_Plane_War_Game.Properties.Resources.fighter_plane_silhouette_11;
            this.enemy2.Location = new System.Drawing.Point(689, 145);
            this.enemy2.Name = "enemy2";
            this.enemy2.Size = new System.Drawing.Size(65, 50);
            this.enemy2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy2.TabIndex = 2;
            this.enemy2.TabStop = false;
            // 
            // fighter
            // 
            this.fighter.Image = global::Fighter_Plane_War_Game.Properties.Resources.eebd9255431d;
            this.fighter.Location = new System.Drawing.Point(12, 156);
            this.fighter.Name = "fighter";
            this.fighter.Size = new System.Drawing.Size(80, 60);
            this.fighter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fighter.TabIndex = 1;
            this.fighter.TabStop = false;
            // 
            // enemy1
            // 
            this.enemy1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.enemy1.Image = global::Fighter_Plane_War_Game.Properties.Resources.fighter_plane_silhouette_1;
            this.enemy1.Location = new System.Drawing.Point(849, 55);
            this.enemy1.Name = "enemy1";
            this.enemy1.Size = new System.Drawing.Size(65, 50);
            this.enemy1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy1.TabIndex = 0;
            this.enemy1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(982, 453);
            this.Controls.Add(this.Bullet2);
            this.Controls.Add(this.Bullet3);
            this.Controls.Add(this.Bullet1);
            this.Controls.Add(this.Restart);
            this.Controls.Add(this.gameover);
            this.Controls.Add(this.Points);
            this.Controls.Add(this.enemy4);
            this.Controls.Add(this.enemy3);
            this.Controls.Add(this.enemy5);
            this.Controls.Add(this.enemy2);
            this.Controls.Add(this.fighter);
            this.Controls.Add(this.enemy1);
            this.Name = "Form1";
            this.Text = "Fighter Plane War Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.Bullet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bullet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bullet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fighter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox enemy1;
        private System.Windows.Forms.PictureBox fighter;
        private System.Windows.Forms.PictureBox enemy2;
        private System.Windows.Forms.PictureBox enemy5;
        private System.Windows.Forms.PictureBox enemy3;
        private System.Windows.Forms.PictureBox enemy4;
        private System.Windows.Forms.Label Points;
        private System.Windows.Forms.Label gameover;
        private System.Windows.Forms.Button Restart;
        private System.Windows.Forms.PictureBox Bullet1;
        private System.Windows.Forms.PictureBox Bullet3;
        private System.Windows.Forms.PictureBox Bullet2;
        private System.Windows.Forms.Timer enemytimer;
        private System.Windows.Forms.Timer fire1;
        private System.Windows.Forms.Timer fire2;
        private System.Windows.Forms.Timer fire3;
    }
}

