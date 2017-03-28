namespace Game {
    partial class Menu {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.testButton = new System.Windows.Forms.Button();
            this.hostButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.joinButton = new System.Windows.Forms.Button();
            this.browserButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // testButton
            // 
            this.testButton.Location = new System.Drawing.Point(543, 12);
            this.testButton.Name = "testButton";
            this.testButton.Size = new System.Drawing.Size(143, 55);
            this.testButton.TabIndex = 0;
            this.testButton.Text = "Test Game";
            this.testButton.UseVisualStyleBackColor = true;
            this.testButton.Click += new System.EventHandler(this.testButton_Click);
            // 
            // hostButton
            // 
            this.hostButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.hostButton.Location = new System.Drawing.Point(278, 129);
            this.hostButton.Name = "hostButton";
            this.hostButton.Size = new System.Drawing.Size(143, 55);
            this.hostButton.TabIndex = 1;
            this.hostButton.Text = "Host Game";
            this.hostButton.UseVisualStyleBackColor = true;
            this.hostButton.Click += new System.EventHandler(this.hostButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(278, 351);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(143, 55);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // joinButton
            // 
            this.joinButton.Location = new System.Drawing.Point(278, 203);
            this.joinButton.Name = "joinButton";
            this.joinButton.Size = new System.Drawing.Size(143, 55);
            this.joinButton.TabIndex = 3;
            this.joinButton.Text = "Join Game";
            this.joinButton.UseVisualStyleBackColor = true;
            // 
            // browserButton
            // 
            this.browserButton.Location = new System.Drawing.Point(278, 277);
            this.browserButton.Name = "browserButton";
            this.browserButton.Size = new System.Drawing.Size(143, 55);
            this.browserButton.TabIndex = 4;
            this.browserButton.Text = "Game Browser";
            this.browserButton.UseVisualStyleBackColor = true;
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(543, 351);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(143, 55);
            this.logoutButton.TabIndex = 5;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 418);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.browserButton);
            this.Controls.Add(this.joinButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.hostButton);
            this.Controls.Add(this.testButton);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Amoba";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Menu_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button testButton;
        private System.Windows.Forms.Button hostButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button joinButton;
        private System.Windows.Forms.Button browserButton;
        private System.Windows.Forms.Button logoutButton;
    }
}