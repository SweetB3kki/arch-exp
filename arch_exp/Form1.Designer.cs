using System.Drawing.Drawing2D;

namespace arch_exp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            usernameTextBox = new TextBox();
            passwordTextBox = new TextBox();
            labelTitle = new Label();
            SuspendLayout();

            // 
            // usernameTextBox
            // 
            usernameTextBox.BackColor = Color.LightGray;
            usernameTextBox.BorderStyle = BorderStyle.None;
            usernameTextBox.Font = new Font("Courier New", 10F);
            usernameTextBox.ForeColor = Color.Gray;
            usernameTextBox.Location = new Point(275, 150);
            usernameTextBox.Multiline = true;
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.PlaceholderText = "Username";
            usernameTextBox.Size = new Size(250, 22);
            usernameTextBox.TabIndex = 0;
            usernameTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // passwordTextBox
            // 
            passwordTextBox.BackColor = Color.LightGray;
            passwordTextBox.BorderStyle = BorderStyle.None;
            passwordTextBox.Font = new Font("Courier New", 10F);
            passwordTextBox.ForeColor = Color.Gray;
            passwordTextBox.Location = new Point(275, 200);
            passwordTextBox.Multiline = true;
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.PlaceholderText = "Password";
            passwordTextBox.Size = new Size(250, 22);
            passwordTextBox.TabIndex = 1;
            passwordTextBox.TextAlign = HorizontalAlignment.Center;

            // 
            // loginButton
            // 
            Button loginButton = new Button();
            loginButton.Text = "Login";
            loginButton.BackColor = Color.Black;
            loginButton.ForeColor = Color.White;
            loginButton.Location = new Point(275, 250);
            loginButton.Size = new Size(250, 40);
            loginButton.FlatStyle = FlatStyle.Flat;
            loginButton.FlatAppearance.BorderSize = 0;
            loginButton.Font = new Font("Courier New", 12F, FontStyle.Bold);

            // Создаем закругленный регион для кнопки
            GraphicsPath buttonPath = new GraphicsPath();
            buttonPath.AddArc(0, 0, 20, 20, 180, 90); // Верхний левый угол
            buttonPath.AddArc(loginButton.Width - 20, 0, 20, 20, 270, 90); // Верхний правый угол
            buttonPath.AddArc(loginButton.Width - 20, loginButton.Height - 20, 20, 20, 0, 90); // Нижний правый угол
            buttonPath.AddArc(0, loginButton.Height - 20, 20, 20, 90, 90); // Нижний левый угол
            buttonPath.CloseFigure();
            loginButton.Region = new Region(buttonPath);

            loginButton.Click += loginButton_Click;
            Controls.Add(loginButton);
            // 
            // labelTitle
            // 
            labelTitle.Font = new Font("Courier New", 14F, FontStyle.Bold);
            labelTitle.ForeColor = Color.Black;
            labelTitle.Location = new Point(250, 90);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(300, 40);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "ArchExpeditionDB";
            labelTitle.TextAlign = ContentAlignment.MiddleCenter;


            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(labelTitle);
            Controls.Add(loginButton);
            Controls.Add(passwordTextBox);
            Controls.Add(usernameTextBox);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login Form";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label labelTitle;
    }
}
