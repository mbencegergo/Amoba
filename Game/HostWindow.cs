using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game {
    public partial class HostWindow : Form {
        public HostWindow() {
            InitializeComponent();
        }

        private int X { get; set; }
        private int Y { get; set; }

        Menu menu;
        GameMap gameMap;

        private void backButton_Click(object sender, EventArgs e) {
            menu = new Menu();
            this.Hide();
            menu.Show();
        }

        private void HostWindow_FormClosed(object sender, FormClosedEventArgs e) {
            Application.Exit();
        }

        private void createButton_Click(object sender, EventArgs e) {
            gameMap = new GameMap(X, Y);
            this.Hide();
            gameMap.Show();
        }

        private void radio3x3_CheckedChanged(object sender, EventArgs e) {
            this.X = 3;
            this.Y = 3;
        }

        private void radio6x6_CheckedChanged(object sender, EventArgs e) {
            this.X = 6;
            this.Y = 6;
        }

        private void radio9x9_CheckedChanged(object sender, EventArgs e) {
            this.X = 9;
            this.Y = 9;
        }
    }
}
