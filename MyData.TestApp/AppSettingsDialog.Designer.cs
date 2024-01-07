namespace MyData.TestApp
{
    partial class AppSettingsDialog
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
            label1 = new Label();
            label2 = new Label();
            edtUser = new TextBox();
            edtKey = new TextBox();
            btnCancel = new Button();
            btnOK = new Button();
            edtApiEndPoint = new TextBox();
            label3 = new Label();
            chIsInvoicingProvider = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 19);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 0;
            label1.Text = "User Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 49);
            label2.Name = "label2";
            label2.Size = new Size(95, 15);
            label2.TabIndex = 1;
            label2.Text = "Subscription Key";
            // 
            // edtUser
            // 
            edtUser.Font = new Font("Courier New", 9F);
            edtUser.Location = new Point(113, 16);
            edtUser.Name = "edtUser";
            edtUser.Size = new Size(312, 21);
            edtUser.TabIndex = 2;
            // 
            // edtKey
            // 
            edtKey.Font = new Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            edtKey.Location = new Point(113, 45);
            edtKey.Name = "edtKey";
            edtKey.Size = new Size(312, 21);
            edtKey.TabIndex = 3;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(355, 160);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 32);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            btnOK.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnOK.Location = new Point(277, 160);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(75, 32);
            btnOK.TabIndex = 5;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            // 
            // edtApiEndPoint
            // 
            edtApiEndPoint.Font = new Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            edtApiEndPoint.Location = new Point(112, 74);
            edtApiEndPoint.Name = "edtApiEndPoint";
            edtApiEndPoint.Size = new Size(312, 21);
            edtApiEndPoint.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 77);
            label3.Name = "label3";
            label3.Size = new Size(76, 15);
            label3.TabIndex = 6;
            label3.Text = "Api EndPoint";
            // 
            // chIsInvoicingProvider
            // 
            chIsInvoicingProvider.AutoSize = true;
            chIsInvoicingProvider.Location = new Point(30, 115);
            chIsInvoicingProvider.Name = "chIsInvoicingProvider";
            chIsInvoicingProvider.Size = new Size(133, 19);
            chIsInvoicingProvider.TabIndex = 8;
            chIsInvoicingProvider.Text = "Is Invoicing Provider";
            chIsInvoicingProvider.UseVisualStyleBackColor = true;
            // 
            // AppSettingsDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(435, 194);
            Controls.Add(chIsInvoicingProvider);
            Controls.Add(edtApiEndPoint);
            Controls.Add(label3);
            Controls.Add(btnOK);
            Controls.Add(btnCancel);
            Controls.Add(edtKey);
            Controls.Add(edtUser);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AppSettingsDialog";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MyData Connection Information";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox edtUser;
        private TextBox edtKey;
        private Button btnCancel;
        private Button btnOK;
        private TextBox edtApiEndPoint;
        private Label label3;
        private CheckBox chIsInvoicingProvider;
    }
}