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
    public partial class Identifaction : Form
    {
        public Boolean nonNumberEntered = false;
         SqlConnection con = new SqlConnection("Data Source=LAPTOPOFNGUYEN;Initial Catalog=resort;Integrated Security=True");

        public Identifaction()
        {
            InitializeComponent();
        }

        private void Identifaction_Load(object sender, EventArgs e)
        {
            con.Close();
            con.Open();
            SqlDataAdapter cmd = new SqlDataAdapter("select id_proof from identifaction", con);
            DataSet ds = new DataSet();
            cmd.Fill(ds);

            if (ds.Tables[0].Rows.Count > 0)
            {
                cmbidproof.DataSource = ds.Tables[0];
                cmbidproof.DisplayMember = "id_proof"; // Set this property to the column you want to display
                cmbidproof.ValueMember = "id_proof";   // Set this property to the corresponding value
            }
            else
            {
                cmbidproof.Items.Clear();
            }

            con.Close();
        }


        private void cmbidproof_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd1 = new SqlCommand("insert into identifaction(id_proof) values('" + cmbidproof.Text + "')", con);
            int a =cmd1.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("Định danh thêm thành công");
                cmbidproof.Items.Clear();
                Identifaction_Load(sender, e);
                con.Close();
            }
            else
            {
                MessageBox.Show("Không thể thêm ");
            }

            con.Close();
        }

        private void btnremove_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd2 = new SqlCommand("delete from identifaction where id_proof='" + cmbidproof.Text + "'", con);
            int s = cmd2.ExecuteNonQuery();
            if (s > 0)
            {
                MessageBox.Show("Đã xóa định danh");
                cmbidproof.Items.Clear();
                Identifaction_Load(sender, e); 
               

            }
            else
            {
                MessageBox.Show("CKhông thể xóa");
            }


            con.Close();
        }

        private void cmbidproof_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (nonNumberEntered == true)
            {
                MessageBox.Show("Vui lòng chỉ nhập kí tự...", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }

        private void cmbidproof_KeyDown(object sender, KeyEventArgs e)
        {
            nonNumberEntered = false;

            if (e.KeyCode >= Keys.A && e.KeyCode <= Keys.Z || (e.KeyCode == Keys.Back) || (e.KeyCode == Keys.Space))
            {
                nonNumberEntered = false;
            }
            else
            {
                nonNumberEntered = true;
            }
        }
    }
}
