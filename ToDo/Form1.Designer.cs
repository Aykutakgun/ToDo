namespace ToDo
{
    partial class Form1
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
            hopeDatePicker1 = new ReaLTaiizor.Controls.HopeDatePicker();
            separator1 = new ReaLTaiizor.Controls.Separator();
            nightPanel1 = new ReaLTaiizor.Controls.NightPanel();
            spaceLabel1 = new ReaLTaiizor.Controls.SpaceLabel();
            crownComboBox1 = new ReaLTaiizor.Controls.CrownComboBox();
            textBoxEdit1 = new ReaLTaiizor.Controls.TextBoxEdit();
            spaceLabel2 = new ReaLTaiizor.Controls.SpaceLabel();
            panel1 = new ReaLTaiizor.Controls.Panel();
            nightPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // hopeDatePicker1
            // 
            hopeDatePicker1.BackColor = Color.White;
            hopeDatePicker1.BorderColor = Color.FromArgb(220, 223, 230);
            hopeDatePicker1.Date = new DateTime(2025, 6, 29, 0, 0, 0, 0);
            hopeDatePicker1.DayNames = "MTWTFSS";
            hopeDatePicker1.DaysTextColor = Color.FromArgb(96, 98, 102);
            hopeDatePicker1.DayTextColorA = Color.FromArgb(48, 49, 51);
            hopeDatePicker1.DayTextColorB = Color.FromArgb(144, 147, 153);
            hopeDatePicker1.HeaderFormat = "{0} Y - {1} M";
            hopeDatePicker1.HeaderTextColor = Color.FromArgb(48, 49, 51);
            hopeDatePicker1.HeadLineColor = Color.FromArgb(228, 231, 237);
            hopeDatePicker1.HoverColor = Color.FromArgb(235, 238, 245);
            hopeDatePicker1.Location = new Point(12, 17);
            hopeDatePicker1.Name = "hopeDatePicker1";
            hopeDatePicker1.NMColor = Color.FromArgb(192, 196, 204);
            hopeDatePicker1.NMHoverColor = Color.FromArgb(64, 158, 255);
            hopeDatePicker1.NYColor = Color.FromArgb(192, 196, 204);
            hopeDatePicker1.NYHoverColor = Color.FromArgb(64, 158, 255);
            hopeDatePicker1.PMColor = Color.FromArgb(192, 196, 204);
            hopeDatePicker1.PMHoverColor = Color.FromArgb(64, 158, 255);
            hopeDatePicker1.PYColor = Color.FromArgb(192, 196, 204);
            hopeDatePicker1.PYHoverColor = Color.FromArgb(64, 158, 255);
            hopeDatePicker1.SelectedBackColor = Color.FromArgb(64, 158, 255);
            hopeDatePicker1.SelectedTextColor = Color.White;
            hopeDatePicker1.Size = new Size(250, 270);
            hopeDatePicker1.TabIndex = 0;
            hopeDatePicker1.Text = "hopeDatePicker1";
            hopeDatePicker1.ValueTextColor = Color.FromArgb(43, 133, 228);
            // 
            // separator1
            // 
            separator1.LineColor = Color.Gray;
            separator1.Location = new Point(12, 293);
            separator1.Name = "separator1";
            separator1.Size = new Size(250, 14);
            separator1.TabIndex = 1;
            separator1.Text = "separator1";
            // 
            // nightPanel1
            // 
            nightPanel1.Controls.Add(hopeDatePicker1);
            nightPanel1.Controls.Add(separator1);
            nightPanel1.ForeColor = Color.FromArgb(250, 250, 250);
            nightPanel1.LeftSideColor = Color.FromArgb(41, 44, 61);
            nightPanel1.Location = new Point(12, 9);
            nightPanel1.Name = "nightPanel1";
            nightPanel1.RightSideColor = Color.FromArgb(41, 44, 61);
            nightPanel1.Side = ReaLTaiizor.Controls.NightPanel.PanelSide.Left;
            nightPanel1.Size = new Size(278, 602);
            nightPanel1.TabIndex = 2;
            // 
            // spaceLabel1
            // 
            spaceLabel1.Customization = "/v7+/yoqKv8=";
            spaceLabel1.Font = new Font("Verdana", 8F);
            spaceLabel1.Image = null;
            spaceLabel1.Location = new Point(8, 8);
            spaceLabel1.Name = "spaceLabel1";
            spaceLabel1.NoRounding = false;
            spaceLabel1.Size = new Size(75, 40);
            spaceLabel1.TabIndex = 6;
            spaceLabel1.Text = "Task";
            spaceLabel1.TextAlignment = HorizontalAlignment.Center;
            spaceLabel1.Transparent = false;
            // 
            // crownComboBox1
            // 
            crownComboBox1.DrawMode = DrawMode.OwnerDrawVariable;
            crownComboBox1.FormattingEnabled = true;
            crownComboBox1.Location = new Point(89, 50);
            crownComboBox1.Name = "crownComboBox1";
            crownComboBox1.Size = new Size(172, 24);
            crownComboBox1.TabIndex = 7;
            // 
            // textBoxEdit1
            // 
            textBoxEdit1.BackColor = Color.Transparent;
            textBoxEdit1.Font = new Font("Tahoma", 11F);
            textBoxEdit1.ForeColor = Color.FromArgb(176, 183, 191);
            textBoxEdit1.Image = null;
            textBoxEdit1.Location = new Point(89, 7);
            textBoxEdit1.MaxLength = 32767;
            textBoxEdit1.Multiline = false;
            textBoxEdit1.Name = "textBoxEdit1";
            textBoxEdit1.ReadOnly = false;
            textBoxEdit1.Size = new Size(378, 41);
            textBoxEdit1.TabIndex = 5;
            textBoxEdit1.TextAlignment = HorizontalAlignment.Left;
            textBoxEdit1.UseSystemPasswordChar = false;
            // 
            // spaceLabel2
            // 
            spaceLabel2.Customization = "/v7+/yoqKv8=";
            spaceLabel2.Font = new Font("Verdana", 8F);
            spaceLabel2.Image = null;
            spaceLabel2.Location = new Point(7, 51);
            spaceLabel2.Name = "spaceLabel2";
            spaceLabel2.NoRounding = false;
            spaceLabel2.Size = new Size(75, 25);
            spaceLabel2.TabIndex = 8;
            spaceLabel2.Text = "Priority";
            spaceLabel2.TextAlignment = HorizontalAlignment.Center;
            spaceLabel2.Transparent = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(39, 51, 63);
            panel1.Controls.Add(spaceLabel2);
            panel1.Controls.Add(textBoxEdit1);
            panel1.Controls.Add(crownComboBox1);
            panel1.Controls.Add(spaceLabel1);
            panel1.EdgeColor = Color.FromArgb(32, 41, 50);
            panel1.Location = new Point(296, 9);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(5);
            panel1.Size = new Size(634, 602);
            panel1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            panel1.TabIndex = 2;
            panel1.Text = "panel1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(938, 623);
            Controls.Add(panel1);
            Controls.Add(nightPanel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximumSize = new Size(1920, 1040);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ToDo";
            TransparencyKey = Color.Fuchsia;
            nightPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.HopeDatePicker hopeDatePicker1;
        private ReaLTaiizor.Controls.Separator separator1;
        private ReaLTaiizor.Controls.NightPanel nightPanel1;
        private ReaLTaiizor.Controls.SpaceLabel spaceLabel1;
        private ReaLTaiizor.Controls.CrownComboBox crownComboBox1;
        private ReaLTaiizor.Controls.TextBoxEdit textBoxEdit1;
        private ReaLTaiizor.Controls.SpaceLabel spaceLabel2;
        private ReaLTaiizor.Controls.Panel panel1;
    }
}
