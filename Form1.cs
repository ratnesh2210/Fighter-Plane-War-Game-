using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Fighter_Plane_War_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            startgame();
        }

        void startgame()
        {
            gameover.Visible = false;
            Restart.Visible = false;
            Bullet1.Visible = false;
            Bullet2.Visible = false;
            Bullet3.Visible = false;
            enemy1.Left = 1000;
            enemy2.Left = 3000;
            enemy3.Left = 4000;
            enemy4.Left = 3000;
            enemy5.Left = 2000;




        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        int bulletcount = 0;

       


 
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                if(fighter.Top>0)
                fighter.Top += -10;
            }

            if (e.KeyCode == Keys.Down)
            {
                if(fighter.Top < 320)
                fighter.Top += 10;
            }

            if (e.KeyCode == Keys.Space)
            {
                if (bulletcount % 1 == 0)
                {
                    Bullet1.Location = fighter.Location;
                    fire1.Enabled = true;
                    bulletcount++;
                }
                if (bulletcount % 2 == 0)
                {
                    Bullet2.Location = fighter.Location;
                    fire2.Enabled = true;
                    bulletcount++;
                }
                if (bulletcount % 3 == 0)
                {
                    Bullet3.Location = fighter.Location;
                    fire3.Enabled = true;
                    bulletcount++;
                }

            }
        }

        private void fire1_Tick(object sender, EventArgs e)
        {
            Bullet1.Visible = true;
            
            Bullet1.Left += 10;
        }

        private void fire2_Tick(object sender, EventArgs e)
        {
            Bullet2.Visible = true;
            
            Bullet2.Left += 10;
        }

        private void fire3_Tick(object sender, EventArgs e)
        {
            Bullet3.Visible = true;
           
            Bullet3.Left += 10;
        }

        int score = 0;

        private void enemytimer_Tick(object sender, EventArgs e)
        {
            Moveenemy(enemy1);
            Moveenemy(enemy2);
            Moveenemy(enemy3);
            Moveenemy(enemy4);
            Moveenemy(enemy5);
        }

        Random r = new Random();
        void Moveenemy(PictureBox enemyObj)
        {
            if (enemyObj.Left >= 0)
            {
                enemyObj.Left += -5;
            }
            else
            {
                enemyObj.Location = new Point(1000, r.Next(100,400));
            }

            if (enemyObj.Bounds.IntersectsWith(fighter.Bounds))
            {
                fighter.Image = Properties.Resources.explosion_png_1;
                Restart.Visible = true;
                gameover.Visible = true;
                enemytimer.Enabled = false;
            }

            if ((Bullet1.Bounds.IntersectsWith(enemyObj.Bounds))|| (Bullet2.Bounds.IntersectsWith(enemyObj.Bounds))|| (Bullet3.Bounds.IntersectsWith(enemyObj.Bounds)))
            {
                score++;
                Points.Text = score.ToString();
                enemyObj.Location = new Point(1000, r.Next(100,400));
            }
        }

        private void Restart_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
