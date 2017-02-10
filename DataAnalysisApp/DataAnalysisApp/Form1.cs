using System;
using System.Configuration;
using System.Globalization;
using System.Windows.Forms;
using DataAccess;

namespace DataAnalysisApp
{
    public partial class Form1 : Form
    {
        private Data _data;

        public Form1()
        {
            InitializeComponent();

            InitializeDataSource();
            PopulateCdList();
        }

        private void btnCD_Click(object sender, EventArgs e)
        {
            dgvOut.DataSource = _data.GetCdData((int) cboCD.SelectedValue);
            dgvOut.Columns[2].DefaultCellStyle.Format = "c2";
            dgvOut.Columns[2].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("en-US");
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            dgvOut.DataSource = _data.GetEmployeeData();

            dgvOut.Columns[3].DefaultCellStyle.Format = "c2";
            dgvOut.Columns[3].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("en-US");
        }

        private void btnStore_Click(object sender, EventArgs e)
        {
            dgvOut.DataSource = _data.GetStoreData();
            dgvOut.Columns[2].DefaultCellStyle.Format = "c2";
            dgvOut.Columns[2].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("en-US");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void InitializeDataSource()
        {
            var connString =
                ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            _data = new Data(connString);
        }

        private void PopulateCdList()
        {
            var bindingSrc = new BindingSource {DataSource = _data.GetCds()};
            cboCD.DataSource = bindingSrc;
            cboCD.DisplayMember = "Name";
            cboCD.ValueMember = "Id";
        }
    }
}