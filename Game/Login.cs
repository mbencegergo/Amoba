using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;

namespace Game {
    public partial class Login : Form {
        public Login() {
            InitializeComponent();
        }

        Menu menu;

        private static readonly HttpClient client = new HttpClient();
        private static string HOST = "http://localhost:3333";

        private async void loginButton_Click(object sender, EventArgs e) {
            var values = new Dictionary<string, string>
            {
                { "username", usernameBox.Text },
                { "password", passwordBox.Text }
            };
            var content = new FormUrlEncodedContent(values);
            var response = await client.PostAsync(HOST + "/login", content);
            var responseString = await response.Content.ReadAsStringAsync();
            var msg = JsonConvert.DeserializeObject<Response>(responseString);
            if(msg.msg == "OK") {
                Response.Username = usernameBox.Text;
                menu = new Menu();
                this.Hide();
                menu.Show();
            } else {
                MessageBox.Show(msg.msg, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void registerButton_Click(object sender, EventArgs e) {
            var values = new Dictionary<string, string>
            {
                { "username", usernameBox.Text },
                { "password", passwordBox.Text }
            };
            var content = new FormUrlEncodedContent(values);
            var response = await client.PostAsync(HOST + "/register", content);
            var responseString = await response.Content.ReadAsStringAsync();
            var msg = JsonConvert.DeserializeObject<Response>(responseString);
            if (msg.msg == "OK") {
                MessageBox.Show("Register successful!\nRegistered username: " + usernameBox.Text, "Register successful!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                usernameBox.Text = "";
                passwordBox.Text = "";
                usernameBox.Focus();
            } else {
                MessageBox.Show(msg.msg, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
