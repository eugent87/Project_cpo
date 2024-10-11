namespace User_setup
{
    partial class Main_page
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_page));
            Data_table = new Guna.UI2.WinForms.Guna2DataGridView();
            UserName_Friends = new DataGridViewTextBoxColumn();
            BD = new DataGridViewTextBoxColumn();
            Interests = new DataGridViewTextBoxColumn();
            Is_Congrutulated = new DataGridViewTextBoxColumn();
            Add_button = new Guna.UI2.WinForms.Guna2GradientButton();
            Refresh_button = new Guna.UI2.WinForms.Guna2GradientButton();
            Update_button = new Guna.UI2.WinForms.Guna2GradientButton();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)Data_table).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Data_table
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            Data_table.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            Data_table.BackgroundColor = Color.Silver;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            Data_table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            Data_table.ColumnHeadersHeight = 32;
            Data_table.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            Data_table.Columns.AddRange(new DataGridViewColumn[] { UserName_Friends, BD, Interests, Is_Congrutulated });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            Data_table.DefaultCellStyle = dataGridViewCellStyle3;
            Data_table.GridColor = Color.FromArgb(192, 255, 165);
            Data_table.Location = new Point(12, 58);
            Data_table.Name = "Data_table";
            Data_table.RowHeadersVisible = false;
            Data_table.Size = new Size(705, 361);
            Data_table.TabIndex = 0;
            Data_table.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            Data_table.ThemeStyle.AlternatingRowsStyle.Font = null;
            Data_table.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            Data_table.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            Data_table.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            Data_table.ThemeStyle.BackColor = Color.Silver;
            Data_table.ThemeStyle.GridColor = Color.FromArgb(192, 255, 165);
            Data_table.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            Data_table.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            Data_table.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            Data_table.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            Data_table.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            Data_table.ThemeStyle.HeaderStyle.Height = 32;
            Data_table.ThemeStyle.ReadOnly = false;
            Data_table.ThemeStyle.RowsStyle.BackColor = Color.White;
            Data_table.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            Data_table.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            Data_table.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            Data_table.ThemeStyle.RowsStyle.Height = 25;
            Data_table.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            Data_table.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            Data_table.CellContentClick += guna2DataGridView1_CellContentClick;
            // 
            // UserName_Friends
            // 
            UserName_Friends.HeaderText = "UserName Friends";
            UserName_Friends.Name = "UserName_Friends";
            // 
            // BD
            // 
            BD.HeaderText = "Birtday";
            BD.Name = "BD";
            // 
            // Interests
            // 
            Interests.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Interests.HeaderText = "Interests";
            Interests.Name = "Interests";
            Interests.Width = 200;
            // 
            // Is_Congrutulated
            // 
            Is_Congrutulated.HeaderText = "Congrutulated";
            Is_Congrutulated.Name = "Is_Congrutulated";
            // 
            // Add_button
            // 
            Add_button.AutoRoundedCorners = true;
            Add_button.BorderRadius = 24;
            Add_button.CustomizableEdges = customizableEdges1;
            Add_button.DisabledState.BorderColor = Color.DarkGray;
            Add_button.DisabledState.CustomBorderColor = Color.DarkGray;
            Add_button.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Add_button.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            Add_button.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Add_button.FillColor = Color.FromArgb(192, 255, 165);
            Add_button.FillColor2 = Color.FromArgb(105, 214, 172);
            Add_button.Font = new Font("Segoe UI", 9F);
            Add_button.ForeColor = Color.Black;
            Add_button.Location = new Point(12, 425);
            Add_button.Name = "Add_button";
            Add_button.ShadowDecoration.CustomizableEdges = customizableEdges2;
            Add_button.Size = new Size(104, 51);
            Add_button.TabIndex = 1;
            Add_button.Text = "Add";
            Add_button.Click += ADD_button_Click;
            // 
            // Refresh_button
            // 
            Refresh_button.AutoRoundedCorners = true;
            Refresh_button.BorderRadius = 24;
            Refresh_button.CustomizableEdges = customizableEdges3;
            Refresh_button.DisabledState.BorderColor = Color.DarkGray;
            Refresh_button.DisabledState.CustomBorderColor = Color.DarkGray;
            Refresh_button.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Refresh_button.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            Refresh_button.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Refresh_button.FillColor = Color.FromArgb(192, 255, 165);
            Refresh_button.FillColor2 = Color.FromArgb(105, 214, 172);
            Refresh_button.Font = new Font("Segoe UI", 9F);
            Refresh_button.ForeColor = Color.Black;
            Refresh_button.Location = new Point(232, 425);
            Refresh_button.Name = "Refresh_button";
            Refresh_button.ShadowDecoration.CustomizableEdges = customizableEdges4;
            Refresh_button.Size = new Size(104, 51);
            Refresh_button.TabIndex = 2;
            Refresh_button.Text = "Refresh";
            // 
            // Update_button
            // 
            Update_button.AutoRoundedCorners = true;
            Update_button.BorderRadius = 24;
            Update_button.CustomizableEdges = customizableEdges5;
            Update_button.DisabledState.BorderColor = Color.DarkGray;
            Update_button.DisabledState.CustomBorderColor = Color.DarkGray;
            Update_button.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Update_button.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            Update_button.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Update_button.FillColor = Color.FromArgb(192, 255, 165);
            Update_button.FillColor2 = Color.FromArgb(105, 214, 172);
            Update_button.Font = new Font("Segoe UI", 9F);
            Update_button.ForeColor = Color.Black;
            Update_button.Location = new Point(122, 425);
            Update_button.Name = "Update_button";
            Update_button.ShadowDecoration.CustomizableEdges = customizableEdges6;
            Update_button.Size = new Size(104, 51);
            Update_button.TabIndex = 3;
            Update_button.Text = "Update";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(670, 9);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(47, 43);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-7, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(114, 54);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // Main_page
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(729, 503);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(Update_button);
            Controls.Add(Refresh_button);
            Controls.Add(Add_button);
            Controls.Add(Data_table);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Main_page";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += Main_page_Load;
            ((System.ComponentModel.ISupportInitialize)Data_table).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView Data_table;
        private DataGridViewTextBoxColumn UserName_Friends;
        private DataGridViewTextBoxColumn BD;
        private DataGridViewTextBoxColumn Interests;
        private DataGridViewTextBoxColumn Is_Congrutulated;
        private Guna.UI2.WinForms.Guna2GradientButton Add_button;
        private Guna.UI2.WinForms.Guna2GradientButton Refresh_button;
        private Guna.UI2.WinForms.Guna2GradientButton Update_button;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
    }
}