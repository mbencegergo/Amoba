namespace Game {
    partial class HostWindow {
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
            this.backButton = new System.Windows.Forms.Button();
            this.radio3x3 = new System.Windows.Forms.RadioButton();
            this.radio6x6 = new System.Windows.Forms.RadioButton();
            this.radio9x9 = new System.Windows.Forms.RadioButton();
            this.gameSize = new System.Windows.Forms.GroupBox();
            this.createButton = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.gameNameBox = new System.Windows.Forms.TextBox();
            this.gameSize.SuspendLayout();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(543, 351);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(143, 55);
            this.backButton.TabIndex = 0;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // radio3x3
            // 
            this.radio3x3.AutoSize = true;
            this.radio3x3.Checked = true;
            this.radio3x3.Location = new System.Drawing.Point(22, 19);
            this.radio3x3.Name = "radio3x3";
            this.radio3x3.Size = new System.Drawing.Size(42, 17);
            this.radio3x3.TabIndex = 1;
            this.radio3x3.TabStop = true;
            this.radio3x3.Text = "3x3";
            this.radio3x3.UseVisualStyleBackColor = true;
            this.radio3x3.CheckedChanged += new System.EventHandler(this.radio3x3_CheckedChanged);
            // 
            // radio6x6
            // 
            this.radio6x6.AutoSize = true;
            this.radio6x6.Location = new System.Drawing.Point(113, 19);
            this.radio6x6.Name = "radio6x6";
            this.radio6x6.Size = new System.Drawing.Size(42, 17);
            this.radio6x6.TabIndex = 2;
            this.radio6x6.Text = "6x6";
            this.radio6x6.UseVisualStyleBackColor = true;
            this.radio6x6.CheckedChanged += new System.EventHandler(this.radio6x6_CheckedChanged);
            // 
            // radio9x9
            // 
            this.radio9x9.AutoSize = true;
            this.radio9x9.Location = new System.Drawing.Point(204, 19);
            this.radio9x9.Name = "radio9x9";
            this.radio9x9.Size = new System.Drawing.Size(42, 17);
            this.radio9x9.TabIndex = 3;
            this.radio9x9.Text = "9x9";
            this.radio9x9.UseVisualStyleBackColor = true;
            this.radio9x9.CheckedChanged += new System.EventHandler(this.radio9x9_CheckedChanged);
            // 
            // gameSize
            // 
            this.gameSize.Controls.Add(this.radio9x9);
            this.gameSize.Controls.Add(this.radio6x6);
            this.gameSize.Controls.Add(this.radio3x3);
            this.gameSize.Location = new System.Drawing.Point(12, 80);
            this.gameSize.Name = "gameSize";
            this.gameSize.Size = new System.Drawing.Size(270, 48);
            this.gameSize.TabIndex = 4;
            this.gameSize.TabStop = false;
            this.gameSize.Text = "Game Size";
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(543, 290);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(143, 55);
            this.createButton.TabIndex = 5;
            this.createButton.Text = "Create Game";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(12, 47);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(66, 13);
            this.nameLabel.TabIndex = 6;
            this.nameLabel.Text = "Game Name";
            // 
            // gameNameBox
            // 
            this.gameNameBox.Location = new System.Drawing.Point(102, 44);
            this.gameNameBox.Name = "gameNameBox";
            this.gameNameBox.Size = new System.Drawing.Size(180, 20);
            this.gameNameBox.TabIndex = 7;
            // 
            // HostWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 418);
            this.Controls.Add(this.gameNameBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.gameSize);
            this.Controls.Add(this.backButton);
            this.Name = "HostWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Amoba";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HostWindow_FormClosed);
            this.gameSize.ResumeLayout(false);
            this.gameSize.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.RadioButton radio3x3;
        private System.Windows.Forms.RadioButton radio6x6;
        private System.Windows.Forms.RadioButton radio9x9;
        private System.Windows.Forms.GroupBox gameSize;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox gameNameBox;
    }
}