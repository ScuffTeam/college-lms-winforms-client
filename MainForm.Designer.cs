namespace college_lms_winforms_client
{
    partial class MainForm
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
            _pagesTabControl = new TabControl();
            tabPage1 = new TabPage();
            _scheduleGridView = new DataGridView();
            panelNavigation = new Panel();
            lblWeekInfo = new Label();
            BtnNextWeek = new Button();
            BtnPrevWeek = new Button();
            tabPage2 = new TabPage();
            panel6 = new Panel();
            AttendanceLabel = new Label();
            label1 = new Label();
            panel5 = new Panel();
            ProfileLocationLabel = new Label();
            panel4 = new Panel();
            ProfileBezdayLabel = new Label();
            panel3 = new Panel();
            ProfileEmailLabel = new Label();
            panel2 = new Panel();
            ProfilePhoneLabel = new Label();
            panel1 = new Panel();
            ProfileNameLabel = new Label();
            folderBrowserDialog1 = new FolderBrowserDialog();
            _pagesTabControl.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_scheduleGridView).BeginInit();
            panelNavigation.SuspendLayout();
            tabPage2.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // _pagesTabControl
            // 
            _pagesTabControl.Controls.Add(tabPage1);
            _pagesTabControl.Controls.Add(tabPage2);
            _pagesTabControl.Dock = DockStyle.Fill;
            _pagesTabControl.Location = new Point(0, 0);
            _pagesTabControl.Name = "_pagesTabControl";
            _pagesTabControl.SelectedIndex = 0;
            _pagesTabControl.Size = new Size(800, 450);
            _pagesTabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(_scheduleGridView);
            tabPage1.Controls.Add(panelNavigation);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(792, 422);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "расписание";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // _scheduleGridView
            // 
            _scheduleGridView.AllowUserToAddRows = false;
            _scheduleGridView.AllowUserToDeleteRows = false;
            _scheduleGridView.AllowUserToResizeColumns = false;
            _scheduleGridView.AllowUserToResizeRows = false;
            _scheduleGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            _scheduleGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            _scheduleGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            _scheduleGridView.Dock = DockStyle.Fill;
            _scheduleGridView.Location = new Point(3, 48);
            _scheduleGridView.Name = "_scheduleGridView";
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            _scheduleGridView.RowsDefaultCellStyle = dataGridViewCellStyle1;
            _scheduleGridView.RowTemplate.Height = 280;
            _scheduleGridView.Size = new Size(786, 371);
            _scheduleGridView.TabIndex = 0;
            // 
            // panelNavigation
            // 
            panelNavigation.Controls.Add(lblWeekInfo);
            panelNavigation.Controls.Add(BtnNextWeek);
            panelNavigation.Controls.Add(BtnPrevWeek);
            panelNavigation.Dock = DockStyle.Top;
            panelNavigation.Location = new Point(3, 3);
            panelNavigation.Name = "panelNavigation";
            panelNavigation.Padding = new Padding(100, 0, 100, 0);
            panelNavigation.Size = new Size(786, 45);
            panelNavigation.TabIndex = 1;
            // 
            // lblWeekInfo
            // 
            lblWeekInfo.Dock = DockStyle.Fill;
            lblWeekInfo.Location = new Point(175, 0);
            lblWeekInfo.Name = "lblWeekInfo";
            lblWeekInfo.Size = new Size(436, 45);
            lblWeekInfo.TabIndex = 2;
            lblWeekInfo.Text = "label1";
            lblWeekInfo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BtnNextWeek
            // 
            BtnNextWeek.Dock = DockStyle.Right;
            BtnNextWeek.Location = new Point(611, 0);
            BtnNextWeek.Name = "BtnNextWeek";
            BtnNextWeek.Size = new Size(75, 45);
            BtnNextWeek.TabIndex = 1;
            BtnNextWeek.Text = "▶";
            BtnNextWeek.UseVisualStyleBackColor = true;
            // 
            // BtnPrevWeek
            // 
            BtnPrevWeek.Dock = DockStyle.Left;
            BtnPrevWeek.Location = new Point(100, 0);
            BtnPrevWeek.Name = "BtnPrevWeek";
            BtnPrevWeek.Size = new Size(75, 45);
            BtnPrevWeek.TabIndex = 0;
            BtnPrevWeek.Text = "◀";
            BtnPrevWeek.UseVisualStyleBackColor = true;
            BtnPrevWeek.Click += BtnPrevWeek_Click;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = SystemColors.ControlDark;
            tabPage2.Controls.Add(panel6);
            tabPage2.Controls.Add(panel5);
            tabPage2.Controls.Add(panel4);
            tabPage2.Controls.Add(panel3);
            tabPage2.Controls.Add(panel2);
            tabPage2.Controls.Add(panel1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(792, 422);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.ControlDarkDark;
            panel6.Controls.Add(AttendanceLabel);
            panel6.Controls.Add(label1);
            panel6.Location = new Point(445, 256);
            panel6.Name = "panel6";
            panel6.Size = new Size(339, 158);
            panel6.TabIndex = 7;
            // 
            // AttendanceLabel
            // 
            AttendanceLabel.AutoSize = true;
            AttendanceLabel.Font = new Font("Segoe UI Black", 32F, FontStyle.Bold, GraphicsUnit.Point, 204);
            AttendanceLabel.Location = new Point(111, 64);
            AttendanceLabel.Name = "AttendanceLabel";
            AttendanceLabel.Size = new Size(137, 59);
            AttendanceLabel.TabIndex = 1;
            AttendanceLabel.Text = "100%";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(76, 6);
            label1.Name = "label1";
            label1.Size = new Size(168, 30);
            label1.TabIndex = 0;
            label1.Text = "посещаемость:";
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ControlDarkDark;
            panel5.BackgroundImageLayout = ImageLayout.Center;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(ProfileLocationLabel);
            panel5.Location = new Point(8, 256);
            panel5.Name = "panel5";
            panel5.Size = new Size(339, 158);
            panel5.TabIndex = 6;
            // 
            // ProfileLocationLabel
            // 
            ProfileLocationLabel.AutoSize = true;
            ProfileLocationLabel.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ProfileLocationLabel.Location = new Point(3, 5);
            ProfileLocationLabel.Name = "ProfileLocationLabel";
            ProfileLocationLabel.Size = new Size(181, 25);
            ProfileLocationLabel.TabIndex = 1;
            ProfileLocationLabel.Text = "место проживания";
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ControlDarkDark;
            panel4.BackgroundImageLayout = ImageLayout.Center;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(ProfileBezdayLabel);
            panel4.Location = new Point(8, 143);
            panel4.Name = "panel4";
            panel4.Size = new Size(339, 107);
            panel4.TabIndex = 5;
            // 
            // ProfileBezdayLabel
            // 
            ProfileBezdayLabel.AutoSize = true;
            ProfileBezdayLabel.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ProfileBezdayLabel.Location = new Point(3, 4);
            ProfileBezdayLabel.Name = "ProfileBezdayLabel";
            ProfileBezdayLabel.Size = new Size(154, 25);
            ProfileBezdayLabel.TabIndex = 1;
            ProfileBezdayLabel.Text = "Дата рождения:";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlDarkDark;
            panel3.BackgroundImageLayout = ImageLayout.Center;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(ProfileEmailLabel);
            panel3.Location = new Point(445, 143);
            panel3.Name = "panel3";
            panel3.Size = new Size(339, 107);
            panel3.TabIndex = 4;
            // 
            // ProfileEmailLabel
            // 
            ProfileEmailLabel.AutoSize = true;
            ProfileEmailLabel.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ProfileEmailLabel.Location = new Point(3, 5);
            ProfileEmailLabel.Name = "ProfileEmailLabel";
            ProfileEmailLabel.Size = new Size(71, 25);
            ProfileEmailLabel.TabIndex = 1;
            ProfileEmailLabel.Text = "Почта:";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlDarkDark;
            panel2.BackgroundImageLayout = ImageLayout.Center;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(ProfilePhoneLabel);
            panel2.Location = new Point(445, 25);
            panel2.Name = "panel2";
            panel2.Size = new Size(339, 112);
            panel2.TabIndex = 3;
            // 
            // ProfilePhoneLabel
            // 
            ProfilePhoneLabel.AutoSize = true;
            ProfilePhoneLabel.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ProfilePhoneLabel.Location = new Point(3, 5);
            ProfilePhoneLabel.Name = "ProfilePhoneLabel";
            ProfilePhoneLabel.Size = new Size(92, 25);
            ProfilePhoneLabel.TabIndex = 1;
            ProfilePhoneLabel.Text = "Телефон:";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDarkDark;
            panel1.BackgroundImageLayout = ImageLayout.Center;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(ProfileNameLabel);
            panel1.Location = new Point(8, 25);
            panel1.Name = "panel1";
            panel1.Size = new Size(339, 112);
            panel1.TabIndex = 2;
            // 
            // ProfileNameLabel
            // 
            ProfileNameLabel.AutoSize = true;
            ProfileNameLabel.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ProfileNameLabel.Location = new Point(3, 5);
            ProfileNameLabel.Name = "ProfileNameLabel";
            ProfileNameLabel.Size = new Size(143, 25);
            ProfileNameLabel.TabIndex = 1;
            ProfileNameLabel.Text = "Имя Фамилия:";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(_pagesTabControl);
            Name = "MainForm";
            Text = "MainForm";
            Resize += OnFormResize;
            _pagesTabControl.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)_scheduleGridView).EndInit();
            panelNavigation.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl _pagesTabControl;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView _scheduleGridView;
        private Panel panel1;
        private Label ProfileNameLabel;
        private Panel panel2;
        private Label ProfilePhoneLabel;
        private Panel panel4;
        private Label ProfileBezdayLabel;
        private Panel panel3;
        private Label ProfileEmailLabel;
        private Panel panel5;
        private Label ProfileLocationLabel;
        private FolderBrowserDialog folderBrowserDialog1;
        private Panel panel6;
        private Label AttendanceLabel;
        private Label label1;
        private Button button2;
        private Button button1;
        private Panel panelNavigation;
        private Button BtnNextWeek;
        private Button BtnPrevWeek;
        private Label lblWeekInfo;
    }
}
