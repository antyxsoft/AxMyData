using System;
using System.Data;
using System.Text;
using System.Xml;
using Tripous;

namespace MyData.TestApp
{
    public partial class MainForm : Form, ILogListener
    {

        void AnyClick(object sender, EventArgs e)
        {
            if (btnExit == sender)
            {
                Close();
            }
            else if (btnApiKeyDialog == sender)
            {
                AppSettingsDialog.ShowModal();
            }

            else if (btnTestValidation == sender)
            {
                TestValidation();
            }
        }

        void FormInitialize()
        {
            btnExit.Click += AnyClick;
            btnApiKeyDialog.Click += AnyClick;

            btnTestValidation.Click += AnyClick;

            TestValidation();
        }
 
        void TestSerialization()
        {
            AadeBookInvoiceType Invoice = new AadeBookInvoiceType();
            Invoice.uid = "XXXXXXXX";
            Invoice.mark = 12345;
            InvoiceHeaderType invoiceHeaderType = new InvoiceHeaderType();
            invoiceHeaderType.currency = CurrencyType.HTG;
            Invoice.invoiceHeader = invoiceHeaderType;
            string XmlText = ApiXml.Serialize(Invoice);
            Log(XmlText);
        }

        void TestValidation()
        {
 
            string Results = Validators.Test();
            if (!string .IsNullOrWhiteSpace(Results))
            {
                Log(Results);
            }
        }
 

        void ScrollToEnd()
        {
            edtLog.SelectionStart = edtLog.Text.Length;
            edtLog.ScrollToCaret();
        }
        public void Log(string LogText)
        {
            void Internal()
            {
                LogText = $"{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}: {LogText}";
                edtLog.AppendText(LogText + Environment.NewLine);
                ScrollToEnd();
            }
            if (!InvokeRequired)
            {
                Internal();
            }
            else
            {
                Invoke(new Action(() =>
                {
                    Internal();
                }));
            }
        }
        public void ProcessLog(LogInfo Info)
        {
            void Internal()
            {
                string LogText = Bf.In(Info.Level, LogLevel.Fatal | LogLevel.Error) ? Info.ToString() : Info.Text;
                Log(LogText);
            }
            if (!InvokeRequired)
            {
                Internal();
            }
            else
            {
                Invoke(new Action(() =>
                {
                    Internal();
                }));
            }
        }

        public void LogStart(string LogText)
        {
            void Internal()
            {
                LogText = $"{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}: {LogText}";
                edtLog.AppendText(LogText);
            }
            if (!InvokeRequired)
            {
                Internal();
            }
            else
            {
                Invoke(new Action(() =>
                {
                    Internal();
                }));
            }

        }
        public void LogAppend(string LogText)
        {
            void Internal()
            {
                edtLog.AppendText(LogText);
            }
            if (!InvokeRequired)
            {
                Internal();
            }
            else
            {
                Invoke(new Action(() =>
                {
                    Internal();
                }));
            }

        }
        public void LogEnd(string LogText)
        {
            void Internal()
            {
                edtLog.AppendText(LogText + Environment.NewLine);
                ScrollToEnd();
            }
            if (!InvokeRequired)
            {
                Internal();
            }
            else
            {
                Invoke(new Action(() =>
                {
                    Internal();
                }));
            }

        }
        public void LogClear()
        {
            void Internal()
            {
                edtLog.Text = string.Empty;
            }
            if (!InvokeRequired)
            {
                Internal();
            }
            else
            {
                Invoke(new Action(() =>
                {
                    Internal();
                }));
            }

        }

        /* overrides */
        protected override void OnShown(EventArgs e)
        {
            if (!DesignMode)
                FormInitialize();
            base.OnShown(e);
        }
 

        /* static */
        static public void InitializeGrid(BindingSource bs, DataGridView Grid)
        {
            Grid.AutoGenerateColumns = true;
            Grid.DataSource = bs;
            Grid.ReadOnly = true;
            Grid.AllowUserToAddRows = false;
            Grid.AllowUserToDeleteRows = false;
            Grid.MultiSelect = false;
            Grid.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
            Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells; //.Fill;
            Grid.BorderStyle = BorderStyle.None;
            Grid.GridColor = SystemColors.ScrollBar;
        }
        static public void SetComboBoxValue(string Value, ComboBox Box)
        {
            int Index = Box.Items.IndexOf(Value);
            Index = Index >= 0 ? Index : 0;
            Box.SelectedIndex = Index;
        }
        static public T ToEnum<T>(string value)
        {
            try
            {
                return (T)Enum.Parse(typeof(T), value, true);
            }
            catch
            {
            }

            return default(T);
        }
        static public DataRow GetCurrentRow(DataGridView Grid)
        {
            BindingSource bs = Grid.DataSource as BindingSource;
            DataRow Row = bs.Current is DataRowView ? (bs.Current as DataRowView).Row : null;
            return Row;
        }

        /* construction */
        public MainForm()
        {
            InitializeComponent();
        }
    }
}
