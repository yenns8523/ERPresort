using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Resort_ERP
{
    public partial class Today_s_Check_Out : Form
    {
        public SqlConnection con = new SqlConnection("Data Source=LAPTOPOFNGUYEN;Initial Catalog=resort;Integrated Security=True");

        public Today_s_Check_Out()
        {
            InitializeComponent();
        }
       
        private void Today_s_Check_Out_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
        private BindingSource bindingSource = new BindingSource();
        private void Today_s_Check_Out_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = bindingSource;   
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = dtpcheckoutDay.Value;
            if (selectedDate == DateTime.MinValue)
            {
                selectedDate = DateTime.Now;
                dtpcheckoutDay.Value = selectedDate;
            }
            string connectionString = "Data Source=LAPTOPOFNGUYEN;Initial Catalog=resort;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT ROW_NUMBER() OVER (ORDER BY [check_in_date]) AS STT, [room_no], [room_type], [floorr], [namee], [last_name], [ph_no], [no_of_days] " +
                                "FROM [dbo].[Checkout] " +
                                "WHERE CONVERT(DATE, [check_out_date]) = @SelectedDate";
                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.Add(new SqlParameter("@SelectedDate", selectedDate));
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("room_no");
                dataTable.Columns.Add("room_type");
                dataTable.Columns.Add("floorr");
                dataTable.Columns.Add("namee");
                dataTable.Columns.Add("last_name");
                dataTable.Columns.Add("ph_no");
                dataTable.Columns.Add("no_of_days");
                adapter.Fill(dataTable);
                dataTable.Columns["room_no"].ColumnName = "Số phòng";
                dataTable.Columns["room_type"].ColumnName = "Kiểu phòng";
                dataTable.Columns["floorr"].ColumnName = "Tầng";
                dataTable.Columns["namee"].ColumnName = "Tên";
                dataTable.Columns["last_name"].ColumnName = "Họ";
                dataTable.Columns["ph_no"].ColumnName = "SDT";
                dataTable.Columns["no_of_days"].ColumnName = "Số ngày ở";
                bindingSource.DataSource = dataTable;
                if (dataTable.Rows.Count == 0)
                {
                    MessageBox.Show("Không có check-out vào ngày được chọn.");
                }
                con.Close();
                foreach (DataGridViewColumn column in dataGridView1.Columns)
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
        }
    }
}
