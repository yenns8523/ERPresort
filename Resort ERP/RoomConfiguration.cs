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
    public partial class RoomConfiguration : Form
    {
        public Boolean nonNumberEntered = false;
         SqlConnection con = new SqlConnection("Data Source=LAPTOPOFNGUYEN;Initial Catalog=resort;Integrated Security=True");

        public RoomConfiguration()
        {
            InitializeComponent();
        }

        private void RoomConfiguration_Load(object sender, EventArgs e)
        {
            con.Close();
            con.Open();
            SqlDataAdapter cmd = new SqlDataAdapter("select room_num from roomconfiguration", con);
            DataSet ds = new DataSet();
            cmd.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    cmbroomnum.Items.Add(ds.Tables[0].Rows[i]["room_num"].ToString());
                    cmbrmcon.Items.Add(ds.Tables[0].Rows[i]["room_num"].ToString());
                }
            }
            else
            {
                cmbroomnum.Items.Clear();
                cmbrmcon.Items.Clear();
            }
            //cmbidproof.DataSource = ds.Tables[0];
            con.Close(); 
            
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs p)
        {
            con.Open();
            SqlCommand cmd2 = new SqlCommand(" update roomconfiguration set charges='" + txtchar.Text + "' where room_type='" + cmbtr.Text + "'", con);
            int b = cmd2.ExecuteNonQuery();
            if (b > 0)
            {
                MessageBox.Show("Cài đặt giá tiền theo kiểu phòng thành công!");
                RoomConfiguration_Load(sender, p);
                txtchar.Clear();
            }
            else
            {
                MessageBox.Show("Không thể cài đặt!");
            }
            con.Close();
        }

        private void btnupdate_Click_1(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd2 = new SqlCommand(" update roomconfiguration set room_type='" + cmbconffigroomtype.Text + "',charges='" + txtroomconfigcharges.Text + "' where room_num='" + cmbroomnum.Text + "'", con);
            int b = cmd2.ExecuteNonQuery();
            if (b > 0)
            {
                MessageBox.Show("Cài đặt phòng thành công!");
                
                cmbroomnum.Items.Clear();
                txtroomconfigcharges.Clear();
                RoomConfiguration_Load(sender, e);
                

            }
            else
            {
                MessageBox.Show("Không thể cài đặt!");
            }
            con.Close();
        }

        private void btnset_Click(object sender, EventArgs q)
        {
            con.Open();
            SqlCommand cmd2 = new SqlCommand(" update roomconfiguration set room_type='" + cmbrtconfig.Text + "' where room_num='" + cmbrmcon.Text + "'", con);
            int b = cmd2.ExecuteNonQuery();
            if (b > 0)
            {
                MessageBox.Show("Thay đổi loại phòng thành công!");
                RoomConfiguration_Load(sender,q );
                txtchar.Clear();
            }
            else
            {
                MessageBox.Show("Không thể thay đổi!");
            }
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtroomconfigcharges_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (nonNumberEntered == true)
            {
                MessageBox.Show("Vui lòng chỉ nhập số...!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }

        private void txtroomconfigcharges_KeyDown(object sender, KeyEventArgs e)
        {
            nonNumberEntered = false;
            if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
            {
                if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
                {
                    if (e.KeyCode != Keys.Back)
                    {
                        nonNumberEntered = true;
                    }
                }
            }
        }

        private void cmbconffigroomtype_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (nonNumberEntered == true)
            {
                MessageBox.Show("Vui lòng chỉ nhập ký tự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }

        private void cmbconffigroomtype_KeyDown(object sender, KeyEventArgs e)
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

        private void txtchar_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (nonNumberEntered == true)
            {
                MessageBox.Show("Vui lòng chỉ nhập số...!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }

        private void txtchar_KeyDown(object sender, KeyEventArgs e)
        {
            nonNumberEntered = false;
            if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
            {
                if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
                {
                    if (e.KeyCode != Keys.Back)
                    {
                        nonNumberEntered = true;
                    }
                }
            }
        }
    }
}
