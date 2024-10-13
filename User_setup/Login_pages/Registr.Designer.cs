namespace User_Interface.Login_pages
{
    partial class Registr
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registr));
            guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            Close_button = new PictureBox();
            btn_Register = new Button();
            txtPassword = new TextBox();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            txtLogin = new TextBox();
            ((System.ComponentModel.ISupportInitialize)Close_button).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
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
            guna2CircleButton1.Location = new Point(-128, -32);
            guna2CircleButton1.Name = "guna2CircleButton1";
            guna2CircleButton1.ShadowDecoration.CustomizableEdges = customizableEdges1;
            guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            guna2CircleButton1.Size = new Size(446, 496);
            guna2CircleButton1.TabIndex = 11;
            guna2CircleButton1.Visible = false;
            // 
            // Close_button
            // 
            Close_button.Image = (Image)resources.GetObject("Close_button.Image");
            Close_button.Location = new Point(737, 12);
            Close_button.Name = "Close_button";
            Close_button.Size = new Size(47, 43);
            Close_button.SizeMode = PictureBoxSizeMode.Zoom;
            Close_button.TabIndex = 12;
            Close_button.TabStop = false;
            // 
            // btn_Register
            // 
            btn_Register.BackColor = Color.FromArgb(105, 214, 172);
            btn_Register.Location = new Point(465, 320);
            btn_Register.Name = "btn_Register";
            btn_Register.Size = new Size(224, 43);
            btn_Register.TabIndex = 19;
            btn_Register.Text = "Регистрация";
            btn_Register.UseVisualStyleBackColor = false;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(465, 256);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(224, 23);
            txtPassword.TabIndex = 17;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 18.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(339, 247);
            label2.Name = "label2";
            label2.Size = new Size(120, 31);
            label2.TabIndex = 16;
            label2.Text = "Пароль";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(465, 61);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(224, 106);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Enabled = false;
            label1.Font = new Font("Verdana", 18.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label1.Location = new Point(358, 190);
            label1.Name = "label1";
            label1.Size = new Size(101, 31);
            label1.TabIndex = 14;
            label1.Text = "Логин";
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(465, 198);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(224, 23);
            txtLogin.TabIndex = 13;
            // 
            // Registr
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(796, 420);
            Controls.Add(btn_Register);
            Controls.Add(txtPassword);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(txtLogin);
            Controls.Add(Close_button);
            Controls.Add(guna2CircleButton1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Registr";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registr";
            ((System.ComponentModel.ISupportInitialize)Close_button).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
        private PictureBox Close_button;
        private Button btn_Register;
        private TextBox txtPassword;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label1;
        private TextBox txtLogin;
    }
}