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
using System.Diagnostics;
using System.Threading;

namespace Game
{

    public partial class GameMap : Form {
        int player;
        public int X { get; set; }
        public int Y { get; set; }
		public int Count { get; private set; }

        List<Area> areas = new List<Area>();
        Menu menu;

        public GameMap(int x, int y) {
            this.X = x;
            this.Y = y;
            player = 1;
            Count = 4;
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
            int koorX=200, koorY = 50, width, height;
            int j=1;
            width =(int)(300 / x);
            height = (int)(300 / y);
            foreach (Area item in areas)
            {
                item.SetPictureBox(true,koorX,koorY,width,height);
                this.Controls.Add(item.PicturBox);
                item.PicturBox.Click += Picture_Click;
                item.PicturBox.MouseEnter += Picture_MouseEnter;
                item.PicturBox.MouseLeave += Picture_MouseLeave;
               
                if (j % x == 0)
                {
                    koorY += height;
                    koorX = 200;
                }
                else
                {
                    koorX += width;
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
                if(!SearchWin("X", X, Y))
                {
                    Draw();
                }
            }
        }

        private bool SearchWin(string Tag, int x, int y)
        {
            if (Horizontal(Tag, x, y))
            {
                return true;
            }
            else if (Vertical(Tag, x, y))
            {
                return true;
            }else if (AcrossPlus(Tag, x, y))
            {
                return true;
            }else if (AcrossMinus(Tag, x, y))
            {
                return true;
            }
            return false;
        }

        private bool AcrossPlus(string tag, int x, int y)
        {
            int i, j, z, CountSearch=0;
            
            for(i=0; i <= y*x-(Count*x); i += x)
            {
                for (j = i; j <= i+(x-(Count-1)); j++)
                {
                    for (z = j; z < x * y; z += x + 1)
                    {
                        if ((string)areas[z].PicturBox.Tag == tag)
                        {
                            CountSearch++;
                            if (CountSearch == Count)
                            {
                                GameEnd(tag);
                                return true;
                            }
                        }
                        else
                        {
                            CountSearch = 0;
                            break;
                        }
                    }
                }
            }
            return false;
        }

        private bool AcrossMinus(string tag, int x, int y)
        {
            int i, j, z, CountSearch = 0;

            for (i = 0; i <= y * x - (Count * x); i += x)
            {
                for (j = i+(Count-1); j <= i + x; j++)
                {
                    for (z = j; z < x * y; z += x - 1)
                    {
                        if ((string)areas[z].PicturBox.Tag == tag)
                        {
                            CountSearch++;
                            if (CountSearch == Count)
                            {
                                GameEnd(tag);
                                return true;
                            }
                        }
                        else
                        {
                            CountSearch = 0;
                            break;
                        }
                    }
                }
            }
            return false;
        }

        private bool Vertical(string tag, int x, int y)
        {
            int i,j, countSearch = 0;

            for (i = 0; i < x * y - x * (Count - 1); i++)
            {
                countSearch = 0;
                for (j = i; j < (i + Count * x); j += x)
                {
                    if ((string)areas[j].PicturBox.Tag == tag)
                    {
                        countSearch++;
                    }
                    else
                    {
                        break;
                    }
                    if (countSearch == Count)
                    {
                        GameEnd(tag);
                        return true;
                    }
                }
            }
            return false;
        }

        private bool Horizontal(string tag, int x, int y)
        {
            int i, countSearch=0;
            for (i = 0; i < x * y; i++)
            {
                if (i % x == 0)
                {
                    countSearch = 0;
                }
                if ((string)areas[i].PicturBox.Tag == tag)
                {
                    countSearch++;
                }
                else { countSearch = 0; }
                if (countSearch == Count)
                {
                    GameEnd(tag);
                    return true;
                }
            }
            return false;
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
