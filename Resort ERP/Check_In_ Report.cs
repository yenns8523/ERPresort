using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Resort_ERP
{
    public partial class Check_In__Report : Form
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOPOFNGUYEN;Initial Catalog=resort;Integrated Security=True");
        public Check_In__Report()
        {
            InitializeComponent();
        }

        private void Check_In__Report_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.ReportPath = "ReportCheck-in.rdlc";
            string query = "SELECT room_no, room_type, floorr, check_in_date, no_of_days, namee, last_name, receptionist FROM details";
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            ReportDataSource reportDataSource = new ReportDataSource("DataSet2", dataTable);
            reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
