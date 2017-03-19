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
    public partial class Login : Form {
        public Login() {
            InitializeComponent();
        }

        Menu menu;

        private void loginButton_Click(object sender, EventArgs e) {
            if (usernameBox.Text == "admin" && passwordBox.Text == "admin") {
                menu = new Menu();
                this.Hide();
                menu.Show();
            } else if (usernameBox.Text != "admin" || passwordBox.Text != "admin") {
                MessageBox.Show("Incorrect username/password!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void exitButton_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e) {
            Application.Exit();
        }
    }
}
