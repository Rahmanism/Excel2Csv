namespace Excel2Csv
{
    partial class MainForm
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
            if (disposing && (components != null)) {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.inputPanel = new System.Windows.Forms.Panel();
            this.aboutBtn = new System.Windows.Forms.Button();
            this.clearListBtn = new System.Windows.Forms.Button();
            this.outputLbl = new System.Windows.Forms.Label();
            this.fileListLbx = new System.Windows.Forms.ListBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.bottomPnl = new System.Windows.Forms.Panel();
            this.messageLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.inputPanel.SuspendLayout();
            this.bottomPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputPanel
            // 
            this.inputPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.inputPanel.Controls.Add(this.aboutBtn);
            this.inputPanel.Controls.Add(this.clearListBtn);
            this.inputPanel.Controls.Add(this.outputLbl);
            this.inputPanel.Controls.Add(this.fileListLbx);
            this.inputPanel.Location = new System.Drawing.Point(0, 0);
            this.inputPanel.Name = "inputPanel";
            this.inputPanel.Size = new System.Drawing.Size(800, 403);
            this.inputPanel.TabIndex = 0;
            // 
            // aboutBtn
            // 
            this.aboutBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.aboutBtn.AutoSize = true;
            this.aboutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.aboutBtn.Location = new System.Drawing.Point(752, 7);
            this.aboutBtn.Name = "aboutBtn";
            this.aboutBtn.Size = new System.Drawing.Size(34, 31);
            this.aboutBtn.TabIndex = 0;
            this.aboutBtn.Text = "?";
            this.aboutBtn.Click += new System.EventHandler(this.aboutBtn_Click);
            // 
            // clearListBtn
            // 
            this.clearListBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.clearListBtn.AutoSize = true;
            this.clearListBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearListBtn.Location = new System.Drawing.Point(19, 361);
            this.clearListBtn.Name = "clearListBtn";
            this.clearListBtn.Size = new System.Drawing.Size(99, 31);
            this.clearListBtn.TabIndex = 0;
            this.clearListBtn.Text = "Clear &list";
            this.clearListBtn.Click += new System.EventHandler(this.clearListBtn_Click);
            // 
            // outputLbl
            // 
            this.outputLbl.Location = new System.Drawing.Point(367, 41);
            this.outputLbl.Name = "outputLbl";
            this.outputLbl.Size = new System.Drawing.Size(419, 351);
            this.outputLbl.TabIndex = 2;
            this.outputLbl.Text = "Drag Excel files and drop them here... or just double click.\r\nClick on Convert bu" +
    "tton to start converting.";
            this.outputLbl.DoubleClick += new System.EventHandler(this.outputLbl_DoubleClick);
            // 
            // fileListLbx
            // 
            this.fileListLbx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.fileListLbx.FormattingEnabled = true;
            this.fileListLbx.HorizontalScrollbar = true;
            this.fileListLbx.ItemHeight = 21;
            this.fileListLbx.Location = new System.Drawing.Point(19, 36);
            this.fileListLbx.Name = "fileListLbx";
            this.fileListLbx.Size = new System.Drawing.Size(325, 319);
            this.fileListLbx.TabIndex = 1;
            // 
            // saveBtn
            // 
            this.saveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.saveBtn.AutoSize = true;
            this.saveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveBtn.Location = new System.Drawing.Point(689, 5);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(99, 31);
            this.saveBtn.TabIndex = 0;
            this.saveBtn.Text = "&Convert";
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // bottomPnl
            // 
            this.bottomPnl.Controls.Add(this.messageLbl);
            this.bottomPnl.Controls.Add(this.label1);
            this.bottomPnl.Controls.Add(this.saveBtn);
            this.bottomPnl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPnl.Location = new System.Drawing.Point(0, 409);
            this.bottomPnl.Name = "bottomPnl";
            this.bottomPnl.Size = new System.Drawing.Size(800, 41);
            this.bottomPnl.TabIndex = 1;
            // 
            // messageLbl
            // 
            this.messageLbl.AutoSize = true;
            this.messageLbl.Location = new System.Drawing.Point(12, 10);
            this.messageLbl.Name = "messageLbl";
            this.messageLbl.Size = new System.Drawing.Size(0, 21);
            this.messageLbl.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 21);
            this.label1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bottomPnl);
            this.Controls.Add(this.inputPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Excel2Csv";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);
            this.DragLeave += new System.EventHandler(this.MainForm_DragLeave);
            this.inputPanel.ResumeLayout(false);
            this.inputPanel.PerformLayout();
            this.bottomPnl.ResumeLayout(false);
            this.bottomPnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel inputPanel;
        private System.Windows.Forms.Panel bottomPnl;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.ListBox fileListLbx;
        private System.Windows.Forms.Label outputLbl;
        private System.Windows.Forms.Button clearListBtn;
        private System.Windows.Forms.Button aboutBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label messageLbl;
    }
}

