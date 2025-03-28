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
    
    public partial class Gatway : Form
    {
         SqlConnection con = new SqlConnection("Data Source=LAPTOPOFNGUYEN;Initial Catalog=resort;Integrated Security=True");
        public Gatway()
        {
            InitializeComponent();
        }

        public static bool s;

        public void chh()
        {
           
            //Check_In_Out.ActiveForm;
            if (chkgatevy.Checked)
            {


                this.Close();

            }
            else
            {
                btn_pay.Enabled = true;
            }
        }

        private void btncreditcard_Click(object sender, EventArgs e)
        {
            panel1.Show();
          
        }

        private void btndebitcard_Click(object sender, EventArgs e)
        {
            panel2.Show();
            panel1.Hide();
        }

        private void Gatway_Load(object sender, EventArgs e)
        {
            
            panel3.Hide();
            
          //  btn_pay.Enabled = false;
            chkgatevy.Checked = Check_In_Out.bnn;
            txtgatewaypay.Text = Check_In_Out.renmmm ;
            txtamtsbi.Text = Check_In_Out.renmmm + " VND";
            
            con.Open();
            
            SqlDataAdapter s = new SqlDataAdapter("select * from hotelconfiguration", con);
            DataSet cc = new DataSet();
            s.Fill(cc);
            {
                txtmerchantname.Text = cc.Tables[0].Rows[0][1].ToString();
                
                
            }
            con.Close();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnpay_Click(object sender, EventArgs e)
        {
            panel3.Show();
            panel1.Hide();
            panel2.Hide();
        }

        private void panel3_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MDI fr = new MDI();
            fr.Show();
            this.Close();
            MessageBox.Show("Đã nhận thanh toán");
                
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            panel3.Show();
            panel1.Hide();
            panel2.Hide();
        

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
           
            this.Close();
            MessageBox.Show("Đã nhận thanh toán");

        }
    }
}
