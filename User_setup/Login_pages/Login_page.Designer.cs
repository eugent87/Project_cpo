namespace User_setup
{
    partial class Login_page
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_page));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            txtLogin = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            txtPassword = new TextBox();
            Close_button = new PictureBox();
            Show_pass = new CheckBox();
            btn_Login = new Button();
            btn_Register = new Button();
            btn_Clear = new Button();
            guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Close_button).BeginInit();
            SuspendLayout();
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(432, 176);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(224, 22);
            txtLogin.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Enabled = false;
            label1.Font = new Font("Verdana", 18.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label1.Location = new Point(325, 168);
            label1.Name = "label1";
            label1.Size = new Size(101, 31);
            label1.TabIndex = 1;
            label1.Text = "Логин";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(432, 39);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(224, 106);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 18.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(306, 225);
            label2.Name = "label2";
            label2.Size = new Size(120, 31);
            label2.TabIndex = 3;
            label2.Text = "Пароль";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(432, 234);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(224, 22);
            txtPassword.TabIndex = 4;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // Close_button
            // 
            Close_button.Image = (Image)resources.GetObject("Close_button.Image");
            Close_button.Location = new Point(737, 12);
            Close_button.Name = "Close_button";
            Close_button.Size = new Size(47, 43);
            Close_button.SizeMode = PictureBoxSizeMode.Zoom;
            Close_button.TabIndex = 5;
            Close_button.TabStop = false;
            Close_button.Click += pictureBox2_Click;
            Close_button.MouseEnter += Close_button_MouseEnter;
            Close_button.MouseLeave += Close_button_MouseLeave;
            // 
            // Show_pass
            // 
            Show_pass.AutoSize = true;
            Show_pass.Location = new Point(662, 236);
            Show_pass.Name = "Show_pass";
            Show_pass.Size = new Size(132, 18);
            Show_pass.TabIndex = 6;
            Show_pass.Text = "Показать пароль";
            Show_pass.UseVisualStyleBackColor = true;
            Show_pass.CheckedChanged += Show_pass_CheckedChanged;
            // 
            // btn_Login
            // 
            btn_Login.BackColor = Color.FromArgb(105, 214, 172);
            btn_Login.Location = new Point(432, 299);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(110, 43);
            btn_Login.TabIndex = 7;
            btn_Login.Text = "Войти";
            btn_Login.UseVisualStyleBackColor = false;
            btn_Login.Click += btn_Login_Click;
            // 
            // btn_Register
            // 
            btn_Register.BackColor = Color.FromArgb(105, 214, 172);
            btn_Register.Location = new Point(546, 299);
            btn_Register.Name = "btn_Register";
            btn_Register.Size = new Size(110, 43);
            btn_Register.TabIndex = 8;
            btn_Register.Text = "Регистрация";
            btn_Register.UseVisualStyleBackColor = false;
            btn_Register.Click += btn_Register_Click;
            // 
            // btn_Clear
            // 
            btn_Clear.Location = new Point(694, 168);
            btn_Clear.Name = "btn_Clear";
            btn_Clear.Size = new Size(74, 30);
            btn_Clear.TabIndex = 9;
            btn_Clear.Text = "Очистить";
            btn_Clear.UseVisualStyleBackColor = true;
            btn_Clear.Click += btn_Clear_Click;
            // 
            // guna2CircleButton1
            // 
            guna2CircleButton1.CausesValidation = false;
            guna2CircleButton1.DisabledState.BorderColor = Color.DarkGray;
            guna2CircleButton1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2CircleButton1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2CircleButton1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2CircleButton1.Enabled = false;
            guna2CircleButton1.FillColor = Color.FromArgb(192, 255, 165);
            guna2CircleButton1.Font = new Font("Segoe UI", 9F);
            guna2CircleButton1.ForeColor = Color.White;
            guna2CircleButton1.ImeMode = ImeMode.Off;
            guna2CircleButton1.Location = new Point(-149, -39);
            guna2CircleButton1.Name = "guna2CircleButton1";
            guna2CircleButton1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            guna2CircleButton1.Size = new Size(446, 496);
            guna2CircleButton1.TabIndex = 10;
            guna2CircleButton1.Visible = false;
            guna2CircleButton1.Click += guna2CircleButton1_Click;
            // 
            // Login_page
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(796, 420);
            Controls.Add(guna2CircleButton1);
            Controls.Add(btn_Clear);
            Controls.Add(btn_Register);
            Controls.Add(btn_Login);
            Controls.Add(Show_pass);
            Controls.Add(Close_button);
            Controls.Add(txtPassword);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(txtLogin);
            Font = new Font("Verdana", 9F, FontStyle.Italic, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Login_page";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Страница регистрации";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Close_button).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtLogin;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private TextBox txtPassword;
        private PictureBox Close_button;
        private CheckBox Show_pass;
        private Button btn_Login;
        private Button btn_Register;
        private Button btn_Clear;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
    }
}
