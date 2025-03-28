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
    public partial class HotelConfiguration : Form
    {
        public Boolean nonNumberEntered = false;
        
         SqlConnection con = new SqlConnection("Data Source=LAPTOPOFNGUYEN;Initial Catalog=resort;Integrated Security=True");
        public HotelConfiguration()
        {
            InitializeComponent();
        }

        private void btnhotelupdate_Click(object sender, EventArgs e)
        {        
            con.Open();
            SqlCommand cc=new SqlCommand("update hotelconfiguration set name='"+txthotelname.Text+"',address='"+txthoteladdress.Text+"',ph_no='"+txthotelphno.Text+"',email='"+txthotelemail.Text+"' where id=2",con);
            int a = cc.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("Hồ sơ đã cập nhật");
                
            }
            else
            {
                MessageBox.Show("Không thể cập nhật");
            }
            con.Close();

        }

        private void HotelConfiguration_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter s = new SqlDataAdapter("select * from hotelconfiguration", con);
            DataSet cc = new DataSet();
            s.Fill(cc);

            if (cc.Tables[0].Rows.Count > 0)
            {
                txthotelname.Text = cc.Tables[0].Rows[0][1].ToString();
                txthoteladdress.Text = cc.Tables[0].Rows[0][2].ToString();
                txthotelphno.Text = cc.Tables[0].Rows[0][3].ToString();
                txthotelemail.Text = cc.Tables[0].Rows[0][4].ToString();
            }
            else
            {
                MessageBox.Show("Không tìm thấy hồ sơ của khách sạn.");
            }

            con.Close();
        }


        private void txthotelname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (nonNumberEntered == true)
            {
                MessageBox.Show("Vui lòng chỉ nhập kí tự...", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }

        private void txthotelname_KeyDown(object sender, KeyEventArgs e)
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

        private void txthotelphno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (nonNumberEntered == true)
            {
                MessageBox.Show("Vui lòng chỉ nhập số...", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }

        private void txthotelphno_KeyDown(object sender, KeyEventArgs e)
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

        

        private void txthotelemail_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidEmailAddress(txthotelemail.Text, out errorMsg))
            {
                e.Cancel = true;
                txthotelemail.Select(0, txthotelemail.Text.Length);
                this.errorProvider1.SetError(txthotelemail, errorMsg);
            }
        }

        private void txthotelemail_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txthotelemail, "");
        }
        public bool ValidEmailAddress(string emailAddress, out string errorMessage)
        {
            if (emailAddress.Length == 0)
            {
                errorMessage = "Yêu cầu nhập email.";
                return false;
            }
            if (emailAddress.IndexOf("@") > -1)
            {
                if (emailAddress.IndexOf(".", emailAddress.IndexOf("@")) > emailAddress.IndexOf("@"))
                {
                    errorMessage = "";
                    return true;
                }
            }
            errorMessage = "địa chỉ email phải là định dạng địa chỉ email hợp lệ.\n" +
               "ví dụ: 'someone@example.com' ";
            return false;
        }

        
    }
}
