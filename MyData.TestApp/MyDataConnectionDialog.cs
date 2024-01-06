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
    public partial class MyDataConnectionDialog : Form
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
                    App.Settings.MyDataConnection.ApiEndPoint = edtApiEndPoint.Text.Trim();

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
            edtApiEndPoint.Text = App.Settings.MyDataConnection.ApiEndPoint;
        }
        /* overrides */
        protected override void OnShown(EventArgs e)
        {
            if (!DesignMode)
                FormInitialize();
            base.OnShown(e);
        }
        public MyDataConnectionDialog()
        {
            InitializeComponent();
        }


        static public bool ShowModal()
        {
            using (var F = new MyDataConnectionDialog())
            {
                return F.ShowDialog() == DialogResult.OK;
            }
        }
    }
}
