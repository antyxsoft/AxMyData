namespace MyData.TestApp
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
            ToolBar = new ToolStrip();
            btnApiKeyDialog = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnExit = new ToolStripButton();
            StatusBar = new StatusStrip();
            Splitter = new SplitContainer();
            Pager = new TabControl();
            tabSendInvoices = new TabPage();
            tabPage2 = new TabPage();
            edtLog = new RichTextBox();
            ToolBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Splitter).BeginInit();
            Splitter.Panel1.SuspendLayout();
            Splitter.Panel2.SuspendLayout();
            Splitter.SuspendLayout();
            Pager.SuspendLayout();
            SuspendLayout();
            // 
            // ToolBar
            // 
            ToolBar.ImageScalingSize = new Size(32, 32);
            ToolBar.Items.AddRange(new ToolStripItem[] { btnApiKeyDialog, toolStripSeparator1, btnExit });
            ToolBar.Location = new Point(0, 0);
            ToolBar.Name = "ToolBar";
            ToolBar.Size = new Size(1008, 39);
            ToolBar.TabIndex = 0;
            ToolBar.Text = "toolStrip1";
            // 
            // btnApiKeyDialog
            // 
            btnApiKeyDialog.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnApiKeyDialog.Image = Properties.Resources.account_functions;
            btnApiKeyDialog.ImageTransparentColor = Color.Magenta;
            btnApiKeyDialog.Name = "btnApiKeyDialog";
            btnApiKeyDialog.Size = new Size(36, 36);
            btnApiKeyDialog.Text = "MyData Connection Information";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 39);
            // 
            // btnExit
            // 
            btnExit.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnExit.Image = Properties.Resources.door_out;
            btnExit.ImageTransparentColor = Color.Magenta;
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(36, 36);
            btnExit.Text = "Exit";
            // 
            // StatusBar
            // 
            StatusBar.Location = new Point(0, 707);
            StatusBar.Name = "StatusBar";
            StatusBar.Size = new Size(1008, 22);
            StatusBar.TabIndex = 1;
            StatusBar.Text = "statusStrip1";
            // 
            // Splitter
            // 
            Splitter.Dock = DockStyle.Fill;
            Splitter.Location = new Point(0, 39);
            Splitter.Name = "Splitter";
            Splitter.Orientation = Orientation.Horizontal;
            // 
            // Splitter.Panel1
            // 
            Splitter.Panel1.Controls.Add(Pager);
            // 
            // Splitter.Panel2
            // 
            Splitter.Panel2.Controls.Add(edtLog);
            Splitter.Size = new Size(1008, 668);
            Splitter.SplitterDistance = 596;
            Splitter.SplitterWidth = 6;
            Splitter.TabIndex = 2;
            // 
            // Pager
            // 
            Pager.Controls.Add(tabSendInvoices);
            Pager.Controls.Add(tabPage2);
            Pager.Dock = DockStyle.Fill;
            Pager.Location = new Point(0, 0);
            Pager.Name = "Pager";
            Pager.SelectedIndex = 0;
            Pager.Size = new Size(1008, 596);
            Pager.TabIndex = 0;
            // 
            // tabSendInvoices
            // 
            tabSendInvoices.Location = new Point(4, 24);
            tabSendInvoices.Name = "tabSendInvoices";
            tabSendInvoices.Padding = new Padding(3);
            tabSendInvoices.Size = new Size(1000, 568);
            tabSendInvoices.TabIndex = 0;
            tabSendInvoices.Text = "Send Invoices";
            tabSendInvoices.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1000, 568);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // edtLog
            // 
            edtLog.BackColor = Color.Gainsboro;
            edtLog.Dock = DockStyle.Fill;
            edtLog.Location = new Point(0, 0);
            edtLog.Name = "edtLog";
            edtLog.Size = new Size(1008, 66);
            edtLog.TabIndex = 1;
            edtLog.Text = "";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 729);
            Controls.Add(Splitter);
            Controls.Add(StatusBar);
            Controls.Add(ToolBar);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MyData Test Application";
            ToolBar.ResumeLayout(false);
            ToolBar.PerformLayout();
            Splitter.Panel1.ResumeLayout(false);
            Splitter.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Splitter).EndInit();
            Splitter.ResumeLayout(false);
            Pager.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip ToolBar;
        private StatusStrip StatusBar;
        private ToolStripButton btnApiKeyDialog;
        private SplitContainer Splitter;
        private RichTextBox edtLog;
        private TabControl Pager;
        private TabPage tabSendInvoices;
        private TabPage tabPage2;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnExit;
    }
}
