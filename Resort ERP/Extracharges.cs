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
    public partial class Extracharges : Form
    {
        public Boolean nonNumberEntered = false;
         SqlConnection con = new SqlConnection("Data Source=LAPTOPOFNGUYEN;Initial Catalog=resort;Integrated Security=True");
        public Extracharges()
        
        {
            InitializeComponent();
        }

        private void btnset_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd2 = new SqlCommand(" update extracharges set AdultCharge='" + tXTSETADULTCHARGES.Text + "',ChildCharge='" + TXTCHILDCHARGE.Text + "',BedCharge='" + TXTSETBEDCHARGE.Text + "' ", con);
            int b = cmd2.ExecuteNonQuery();
            if (b > 0)
            {
                MessageBox.Show("Đã cập nhật các khoản phí");
                this.Close();
                
            }
            else
            {
                MessageBox.Show("Không thể cập nhật");
            }
            con.Close();
        }

        private void Extracharges_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand ccd = new SqlCommand("select AdultCharge,ChildCharge,BedCharge  from extracharges ", con);
            SqlDataAdapter sda = new SqlDataAdapter(ccd);
            DataSet sd = new DataSet();
             sda.Fill(sd);
           if(sd.Tables[0].Rows.Count>0)
           {
               tXTSETADULTCHARGES.Text=sd.Tables[0].Rows[0][0].ToString();
               TXTCHILDCHARGE.Text=sd.Tables[0].Rows[0][1].ToString();
               TXTSETBEDCHARGE.Text=sd.Tables[0].Rows[0][2].ToString();
               con.Close();
           }

        }

        private void tXTSETADULTCHARGES_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (nonNumberEntered == true)
            {
                MessageBox.Show("Vui lòng chỉ nhập số...", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }

        private void tXTSETADULTCHARGES_KeyDown(object sender, KeyEventArgs e)
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

        private void TXTCHILDCHARGE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (nonNumberEntered == true)
            {
                MessageBox.Show("Vui lòng chỉ nhập số...", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }

        private void TXTCHILDCHARGE_KeyDown(object sender, KeyEventArgs e)
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

        private void TXTSETBEDCHARGE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (nonNumberEntered == true)
            {
                MessageBox.Show("Vui lòng chỉ nhập số...", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }

        private void TXTSETBEDCHARGE_KeyDown(object sender, KeyEventArgs e)
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
