using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyData.TestApp
{
    public partial class AppSettingsDialog : Form
    {
        void AnyClick(object sender, EventArgs e)
        {
            if (btnOK == sender)
            {
                if (!string.IsNullOrWhiteSpace(edtUser.Text.Trim()) 
                    && !string.IsNullOrWhiteSpace(edtKey.Text.Trim())
                    && !string.IsNullOrWhiteSpace(edtApiEndPoint.Text.Trim())
                    )
                {
                    App.Settings.MyDataConnection.User = edtUser.Text.Trim();
                    App.Settings.MyDataConnection.Key = edtKey.Text.Trim();
                    App.Settings.MyDataConnection.IsInvoicingProvider = chIsInvoicingProvider.Checked;
                    App.Settings.ApiEndPoint = edtApiEndPoint.Text.Trim();

                    App.Settings.Save();
                    this.DialogResult = DialogResult.OK;
                }
            }
        }

        void FormInitialize()
        {
            AcceptButton = btnOK;
            CancelButton = btnCancel;

            btnOK.Click += AnyClick;

            edtUser.Text = App.Settings.MyDataConnection.User;
            edtKey.Text = App.Settings.MyDataConnection.Key;
            chIsInvoicingProvider.Checked = App.Settings.MyDataConnection.IsInvoicingProvider;
            edtApiEndPoint.Text = App.Settings.ApiEndPoint;
            
        }
        /* overrides */
        protected override void OnShown(EventArgs e)
        {
            if (!DesignMode)
                FormInitialize();
            base.OnShown(e);
        }
        public AppSettingsDialog()
        {
            InitializeComponent();
        }


        static public bool ShowModal()
        {
            using (var F = new AppSettingsDialog())
            {
                return F.ShowDialog() == DialogResult.OK;
            }
        }
    }
}
