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
    public partial class Check_out_Detail_s : Form
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOPOFNGUYEN;Initial Catalog=resort;Integrated Security=True");
        public Check_out_Detail_s()
        {
            InitializeComponent();
        }
        private void Filldata()
        {
            try
            {
                con.Open();
                SqlDataAdapter cc = new SqlDataAdapter("SELECT room_no, room_type, floorr, check_in_date, check_out_date, total, namee, last_name, ph_no, receptionist FROM Checkout where room_no LIKE '%" + txtsearch.Text + "%'", con);
                DataTable dt = new DataTable();
                cc.Fill(dt);
                dataGridView1.Rows.Clear();
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        dataGridView1.Rows.Add(
                            i + 1,
                            dt.Rows[i]["room_no"],
                            dt.Rows[i]["room_type"],
                            dt.Rows[i]["floorr"],
                            dt.Rows[i]["check_in_date"],
                            dt.Rows[i]["check_out_date"],
                            dt.Rows[i]["total"],
                            dt.Rows[i]["namee"],
                            dt.Rows[i]["last_name"],
                            dt.Rows[i]["ph_no"],
                            dt.Rows[i]["receptionist"]
                        );
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void Check_out_Detail_s_Load(object sender, EventArgs e)
        {         
            Filldata();
        }
        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            Filldata();
        }
    }
}
