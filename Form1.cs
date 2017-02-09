using OrderAnalysisClassLib;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace NodeOrdersAnalysis
{
    public partial class Form1 : Form
    {
        private DataSet ordersDataSet;
        DataView Orders = new DataView();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           

        }

        private void buttonCD_Click(object sender, EventArgs e)
        {
            ordersDataSet = OrderDataAccess.GetOrdersData();

            CDdataGridView.DataSource = ordersDataSet;  // points to the DataSet, but needs more info to know what you want to show
            CDdataGridView.DataMember = "CD-Table";  // show ONE of the DataTables in the DataSet
            CDdataGridView.AutoResizeColumns();
            CDdataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.BlanchedAlmond;


            CDdataGridView.DataSource = ordersDataSet;  // now point the 2nd datagridview to the DataSet
            CDdataGridView.DataMember = "CD-Table.UsefulRelation";  // but have it display the results of the "inner join"
            CDdataGridView.AutoResizeColumns();
            CDdataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.LavenderBlush;


        }

        private void SalesPersonButton_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
