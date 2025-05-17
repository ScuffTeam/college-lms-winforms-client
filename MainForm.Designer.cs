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
            _pagesTabControl = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            _scheduleGridView = new DataGridView();
            _pagesTabControl.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_scheduleGridView).BeginInit();
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
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(792, 422);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "расписание";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(792, 422);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // _scheduleGridView
            // 
            _scheduleGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            _scheduleGridView.Dock = DockStyle.Fill;
            _scheduleGridView.Location = new Point(3, 3);
            _scheduleGridView.Name = "_scheduleGridView";
            _scheduleGridView.Size = new Size(786, 416);
            _scheduleGridView.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(_pagesTabControl);
            Name = "MainForm";
            Text = "MainForm";
            _pagesTabControl.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)_scheduleGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl _pagesTabControl;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView _scheduleGridView;
    }
}