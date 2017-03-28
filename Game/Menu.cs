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
    public partial class Menu : Form {

        public Menu() {
            InitializeComponent();
        }

        GameMap gameMap;
        Login login;
        HostWindow hostWindow;

        private void testButton_Click(object sender, EventArgs e) {
            gameMap = new GameMap(3, 3);
            this.Hide();
            gameMap.Show();
        }

        private void logoutButton_Click(object sender, EventArgs e) {
            login = new Login();
            this.Hide();
            login.Show();
        }

        private void exitButton_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e) {
            Application.Exit();
        }

        private void hostButton_Click(object sender, EventArgs e) {
            hostWindow = new HostWindow();
            this.Hide();
            hostWindow.Show();
        }
    }
}
