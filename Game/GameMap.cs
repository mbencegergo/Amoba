using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace Game
{

    public partial class GameMap : Form {
        int player;
        public int X { get; set; }
        public int Y { get; set; }

        List<Area> areas = new List<Area>();
        Menu menu;

        public GameMap(int x, int y) {
            this.X = x;
            this.Y = y;
            player = 1;
            InitializeComponent();
            AreaDefinition(this.X, Y);
            SetPictureBoxes(X, Y);
        }

        private void AreaDefinition(int x, int y) {
            int i;
            for (i = 0; i < x; i++) {
                for (int j = 0; j < y; j++) {
                    areas.Add(new Area());
                }
            }
        }

        private void SetPictureBoxes(int x, int y)
        {
            int koorX=200, koorY = 50, width=100, height=100;
            int j=1;
            foreach (Area item in areas)
            {
                item.SetPictureBox(true,koorX,koorY,width,height);
                this.Controls.Add(item.PicturBox);
                item.PicturBox.Click += Picture_Click;
                item.PicturBox.MouseEnter += Picture_MouseEnter;
                item.PicturBox.MouseLeave += Picture_MouseLeave;
               
                if (j % x == 0)
                {
                    koorY += 100;
                    koorX = 200;
                }
                else
                {
                    koorX += 100;
                }
                j++;
            }
        }

        private void Picture_MouseHover(object sender, EventArgs e)
        {
            PictureBox pctr = sender as PictureBox;
            pctr.BackColor = Color.Pink;
        }

        private void Picture_MouseEnter(object sender, EventArgs e)
        {
            PictureBox pctr = sender as PictureBox;
            pctr.BackColor = Color.Pink;
        }

        private void Picture_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pctr = sender as PictureBox;
            pctr.BackColor = Color.White;
        }

        private void Picture_Click(object sender, EventArgs e)
        {

            PictureBox pctr = sender as PictureBox;
            if (player == 1 && pctr.Image==null)
            {
                pctr.Image = Properties.Resources.O;
                pctr.Tag = "O";
                player = 2;
                SearchWin("O", X, Y);
                Draw();
            }
            else if(player == 2 && pctr.Image == null)
            {
                pctr.Image = Properties.Resources.X;
                pctr.Tag = "X";
                player = 1;
                SearchWin("X", X, Y);
                Draw();
            }
        }

        private void SearchWin(string Tag, int x, int y)
        {
            int count = 3, countCheck = 0;
            
            for(int i = 0; i < (x * y); i++)
            {
                //vizszintes
                countCheck = 0;
                if ((string)areas[i].PicturBox.Tag == Tag && i % x == 0)
                {
                    countCheck += 1;
                    for (int j = i + 1; j < i + count; j++)
                    {
                        if ((string)areas[j].PicturBox.Tag == Tag)
                        {
                            countCheck += 1;
                        }
                    }
                    if (countCheck == count)
                    {
                        GameEnd(Tag);
                        break;
                    }
                }

                countCheck = 0;
                //HIBÁÁÁÁÁÁÁÁSSSSSS!!!! szerintem 
                //kereszt
                for (int j = 0; j < x*y; j+=x+1)
                    {
                        if((string)areas[j].PicturBox.Tag == Tag)
                        {
                            countCheck += 1;
                        }
                    }
                    if (countCheck == count)
                    {
                        GameEnd(Tag);
                        break;
                    }
                countCheck = 0;
                for (int j = count-1; j < x * y; j += x - 1)
                {
                    if ((string)areas[j].PicturBox.Tag == Tag)
                    {
                        countCheck += 1;
                    }
                    else { break; }
                }
                if (countCheck == count)
                {
                    GameEnd(Tag);
                    break;
                }

                countCheck = 0;

                    for (int j =i; j < x * y; j += y)
                    {
                        if ((string)areas[j].PicturBox.Tag == Tag)
                        {
                            countCheck += 1;
                        }
                    }
                    if (countCheck == count)
                    {
                        GameEnd(Tag);
                        break;
                    
                }
                
            }
        }

        void Draw()
        {
            bool tie=true;
            foreach (Area item in areas)
            {
                if (item.PicturBox.Tag == null)
                {
                    tie = false;
                    break;
                }
            }
            if (tie)
            {
                GameEnd("Draw");
            }
        }

        void GameEnd(string Winner)
        {
            if(Winner=="X" || Winner == "O")
            {
                Winner = "Congratulations Mr. " + Winner +"\nRestart?";
            }
            else
            {
                Winner = "Tie!\nRestart?";
            }
            if (MessageBox.Show(Winner, "Game Over", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Restart();
            }
            else
            {
                menu = new Menu();
                this.Hide();
                menu.Show();
            }
        }

        private void surrenderButton_Click(object sender, EventArgs e) {
            menu = new Menu();
            this.Hide();
            menu.Show();
        }

        private void GameMap_FormClosed(object sender, FormClosedEventArgs e) {
            Application.Exit();
        }

        private void Restart()
        {
            foreach (Area item in areas)
            {
                item.PicturBox.Image = null;
                item.PicturBox.Tag = null;
            }
        }
    }
}
