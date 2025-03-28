using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;

namespace Resort_ERP
{
    public partial class Check_out_report : Form
        
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOPOFNGUYEN;Initial Catalog=resort;Integrated Security=True");
        public Check_out_report()
        {
            InitializeComponent();
        }

        private void Check_out_report_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void Check_out_report_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.ReportPath = "ReportCheck-out.rdlc";
            string query = "SELECT room_no, room_type, floorr, check_out_date, total, namee,last_name, receptionist FROM Checkout";
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            ReportDataSource reportDataSource = new ReportDataSource("DataSet1", dataTable);
            reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
