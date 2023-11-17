namespace FileHasher
{
    partial class frmMain
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
            lblFolder = new Label();
            lblExtension = new Label();
            txtFilter = new TextBox();
            txtFolder = new TextBox();
            btnProcess = new Button();
            saveFileDialog1 = new SaveFileDialog();
            folderBrowserDialog1 = new FolderBrowserDialog();
            lblInfo = new Label();
            lblInfoDetails = new Label();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lblFolder
            // 
            lblFolder.AutoSize = true;
            lblFolder.Location = new Point(40, 69);
            lblFolder.Name = "lblFolder";
            lblFolder.Size = new Size(40, 15);
            lblFolder.TabIndex = 0;
            lblFolder.Text = "Folder";
            // 
            // lblExtension
            // 
            lblExtension.AutoSize = true;
            lblExtension.Location = new Point(40, 31);
            lblExtension.Name = "lblExtension";
            lblExtension.Size = new Size(33, 15);
            lblExtension.TabIndex = 1;
            lblExtension.Text = "Filter";
            // 
            // txtFilter
            // 
            txtFilter.Location = new Point(84, 28);
            txtFilter.Name = "txtFilter";
            txtFilter.Size = new Size(100, 23);
            txtFilter.TabIndex = 2;
            txtFilter.Text = "*.cshtml";
            // 
            // txtFolder
            // 
            txtFolder.Location = new Point(84, 66);
            txtFolder.Name = "txtFolder";
            txtFolder.Size = new Size(564, 23);
            txtFolder.TabIndex = 3;
            // 
            // btnProcess
            // 
            btnProcess.Location = new Point(84, 109);
            btnProcess.Name = "btnProcess";
            btnProcess.Size = new Size(75, 23);
            btnProcess.TabIndex = 4;
            btnProcess.Text = "Process";
            btnProcess.UseVisualStyleBackColor = true;
            btnProcess.Click += btnProcess_Click;
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.Filter = "CSV Files|*.csv|All FIles|*.*";
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Location = new Point(40, 159);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(28, 15);
            lblInfo.TabIndex = 5;
            lblInfo.Text = "Info";
            // 
            // lblInfoDetails
            // 
            lblInfoDetails.AutoSize = true;
            lblInfoDetails.Location = new Point(84, 159);
            lblInfoDetails.Name = "lblInfoDetails";
            lblInfoDetails.Size = new Size(0, 15);
            lblInfoDetails.TabIndex = 6;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(680, 24);
            menuStrip1.TabIndex = 7;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(180, 22);
            exitToolStripMenuItem.Text = "E&xit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(680, 190);
            Controls.Add(lblInfoDetails);
            Controls.Add(lblInfo);
            Controls.Add(btnProcess);
            Controls.Add(txtFolder);
            Controls.Add(txtFilter);
            Controls.Add(lblExtension);
            Controls.Add(lblFolder);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MainMenuStrip = menuStrip1;
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "File Hasher";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFolder;
        private Label lblExtension;
        private TextBox txtFilter;
        private TextBox txtFolder;
        private Button btnProcess;
        private SaveFileDialog saveFileDialog1;
        private FolderBrowserDialog folderBrowserDialog1;
        private Label lblInfo;
        private Label lblInfoDetails;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
    }
}