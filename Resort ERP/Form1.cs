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
    public partial class MDI : Form
    {
         SqlConnection con = new SqlConnection("Data Source=LAPTOPOFNGUYEN;Initial Catalog=resort;Integrated Security=True");
        public static string roomno;
        

        public void icnchange()
        {
 
        }
    
    public static string strstatus="A";
    public static string role;
        public static string firstf;
        public void firstfloor()
        {
            for (int a = 101; a <= 117; a = a + 1)
            {
                SqlCommand cmd = new SqlCommand("select floorr from details where room_no='" + a.ToString() + "'  ", con);
                SqlDataAdapter ssd = new SqlDataAdapter(cmd);
                DataSet sd = new DataSet();
                ssd.Fill(sd);
                if (sd.Tables[0].Rows.Count > 0)
                {

                    firstf = sd.Tables[0].Rows[0]["floorr"].ToString();
                    firstf = sd.Tables[0].Rows[0]["floorr"].ToString();
                    firstf = sd.Tables[0].Rows[0]["floorr"].ToString();
                }

            }
        }

    public void recpt()
    {
        con.Open();
        SqlCommand cd = new SqlCommand("select Role From Login_Details where user_Name='" + textBox1.Text + "' ", con);
        SqlDataAdapter sda = new SqlDataAdapter(cd);
        DataSet ds = new DataSet();
        sda.Fill(ds);
        if (ds.Tables[0].Rows.Count > 0)
        {
            role = ds.Tables[0].Rows[0]["Role"].ToString().Trim();
            textBox2.Text = role;
        }
        else
        {
            textBox2.Clear();
        }
        con.Close();
    }
        

        public MDI()
        {
            InitializeComponent();
        }

        private void checkInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Check_In__Report checkinrp = new Check_In__Report();
            checkinrp.ShowDialog();
        }

        private void hotelConfigurationToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            roomno = "111";
            Check_In_Out ch = new Check_In_Out();
            ch.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            roomno = "209";
            Check_In_Out ch = new Check_In_Out();
            ch.Show();
        }

        private void btn101_Click(object sender, EventArgs e)
        {
            roomno = "101";
            Check_In_Out ch = new Check_In_Out();
            //btn101.Image=Resort_ERP.Properties.Resources.Locked;
            ch.Show();
           
           
            
        }

        private void roomConfigurationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void addIdentifactionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {

           
        }

        private void hotelConfigurationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            HotelConfiguration hc = new HotelConfiguration();
            hc.Show();
        }

        private void setUpUserToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmAdd_New_User frm = new frmAdd_New_User();
            frm.Show();
        }

        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc");
        }

        private void notePadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process p = System.Diagnostics.Process.Start("notepad.exe");

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đóng ứng dụng", "Đóng", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (DialogResult.Yes.Equals(result))
            {
                Close();
            }
            else
            {
                //e.Cancel = true;
            }
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            HotelConfiguration hc = new HotelConfiguration();
            hc.Show();
                
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RoomConfiguration rc = new RoomConfiguration();
            rc.Show();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đóng ứng dụng", "Đóng", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult.Yes.Equals(result))
                {
                    Close();
                    Application.Exit();
                }
                else
                {
                    //e.Cancel = true;
                }
         
        }

        private void extraChargesToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void btn102_Click(object sender, EventArgs e)
        {
            roomno = "102";
            Check_In_Out ch = new Check_In_Out();
            ch.Show();
        }

        private void btn103_Click(object sender, EventArgs e)
        {
            roomno = "103";
            Check_In_Out ch = new Check_In_Out();
            ch.Show();
        }

        private void btn104_Click(object sender, EventArgs e)
        {
            roomno = "104";
            Check_In_Out ch = new Check_In_Out();
            ch.Show();
        }

        private void btn105_Click(object sender, EventArgs e)
        {
            roomno = "105";
            Check_In_Out ch = new Check_In_Out();
            ch.Show();
        }

        private void btn106_Click(object sender, EventArgs e)
        {
            roomno = "106";
            Check_In_Out ch = new Check_In_Out();
            ch.Show();
        }

        private void btn107_Click(object sender, EventArgs e)
        {
            roomno = "107";
            Check_In_Out ch = new Check_In_Out();
            ch.Show();
        }

        private void btn108_Click(object sender, EventArgs e)
        {
            roomno = "108";
            Check_In_Out ch = new Check_In_Out();
            ch.Show();
        }

        private void btn109_Click(object sender, EventArgs e)
        {
            roomno = "109";
            Check_In_Out ch = new Check_In_Out();
            ch.Show();
        }

        private void btn110_Click(object sender, EventArgs e)
        {
            roomno = "110";
            Check_In_Out ch = new Check_In_Out();
            ch.Show();
        }

        private void btb112_Click(object sender, EventArgs e)
        {
            roomno = "112";
            Check_In_Out ch = new Check_In_Out();
            ch.Show();
        }

        private void btn201_Click(object sender, EventArgs e)
        {
            roomno = "201";
            Check_In_Out ch = new Check_In_Out();
            ch.Show();
        }

        private void btn202_Click(object sender, EventArgs e)
        {
            roomno = "202";
            Check_In_Out ch = new Check_In_Out();
            ch.Show();
        }

        private void bnt203_Click(object sender, EventArgs e)
        {
            roomno = "203";
            Check_In_Out ch = new Check_In_Out();
            ch.Show();
        }

        private void bnt204_Click(object sender, EventArgs e)
        {
            roomno = "204";
            Check_In_Out ch = new Check_In_Out();
            ch.Show();
        }

        private void btn205_Click(object sender, EventArgs e)
        {
            roomno = "205";
            Check_In_Out ch = new Check_In_Out();
            ch.Show();
        }

        private void btn206_Click(object sender, EventArgs e)
        {
            roomno = "206";
            Check_In_Out ch = new Check_In_Out();
            ch.Show();

        }

        private void bnt207_Click(object sender, EventArgs e)
        {
            roomno = "207";
            Check_In_Out ch = new Check_In_Out();
            ch.Show();
        }

        private void bnt208_Click(object sender, EventArgs e)
        {
            roomno = "208";
            Check_In_Out ch = new Check_In_Out();
            ch.Show();
        }

        private void btn210_Click(object sender, EventArgs e)
        {
            roomno = "210";
            Check_In_Out ch = new Check_In_Out();
            ch.Show();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
           
        }

        private void MDI_Load(object sender, EventArgs e)
        {
            
            
            textBox1.Text = Login.username.ToString();
            textBox2.Text = Login.role;
           firstfloor();        
           recpt();   
           
        }

        private void ToolStripButtonRooms_Click(object sender, EventArgs e)
        {
            RoomConfiguration rc = new RoomConfiguration();
            rc.Show(); 
        }

        private void ToolStripButtonRestaurant_Click(object sender, EventArgs e)
        {
            HotelConfiguration hotelConfiguration  = new HotelConfiguration();
            hotelConfiguration.Show();
        }

        private void ToolStripButtonReservation_Click(object sender, EventArgs e)
        {
            frmAdd_New_User new_User = new frmAdd_New_User();
            new_User.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            roomno = "114";
            Check_In_Out ch = new Check_In_Out();
            ch.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            roomno = "115";
            Check_In_Out ch = new Check_In_Out();
            ch.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            roomno = "116";
            Check_In_Out ch = new Check_In_Out();
            ch.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            roomno = "117";
            Check_In_Out ch = new Check_In_Out();
            ch.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            roomno = "210";
            Check_In_Out ch = new Check_In_Out();
            ch.Show();
        }

        private void button11_Click_1(object sender, EventArgs e)
        {

            roomno = "113";
            Check_In_Out ch = new Check_In_Out();
            ch.Show(); 
        }

        private void btn209_Click(object sender, EventArgs e)
        {

            roomno = "209";
            Check_In_Out ch = new Check_In_Out();
            ch.Show();
        }

        private void btn211_Click(object sender, EventArgs e)
        {

            roomno = "211";
            Check_In_Out ch = new Check_In_Out();
            ch.Show();
        }

        private void btn212_Click(object sender, EventArgs e)
        {
            roomno = "212";
            Check_In_Out ch = new Check_In_Out();
            ch.Show();
        }

        private void btn213_Click(object sender, EventArgs e)
        {
             roomno = "213";
            Check_In_Out ch = new Check_In_Out();
            ch.Show();
        }

        private void btn214_Click(object sender, EventArgs e)
        {
             roomno = "214";
            Check_In_Out ch = new Check_In_Out();
            ch.Show();
        }

        private void btn301_Click(object sender, EventArgs e)
        {
             roomno = "301";
            Check_In_Out ch = new Check_In_Out();
            ch.Show();
           
        }
        


        private void btn302_Click(object sender, EventArgs e)
        {
            roomno = "302";
            Check_In_Out ch = new Check_In_Out();
            ch.Show();
        }

        private void btn303_Click(object sender, EventArgs e)
        {
            roomno = "303";
            Check_In_Out ch = new Check_In_Out();
            ch.Show();
        }

        private void btn304_Click(object sender, EventArgs e)
        {
            roomno = "304";
            Check_In_Out ch = new Check_In_Out();
            ch.Show();
        }

        private void btn305_Click(object sender, EventArgs e)
        {
            roomno = "305";
            Check_In_Out ch = new Check_In_Out();
            ch.Show();
        }

        private void btn306_Click(object sender, EventArgs e)
        {
            roomno = "306";
            Check_In_Out ch = new Check_In_Out();
            ch.Show();
        }

        private void bnt307_Click(object sender, EventArgs e)
        {
            roomno = "307";
            Check_In_Out ch = new Check_In_Out();
            ch.Show();
        }

        private void btn308_Click(object sender, EventArgs e)
        {
            roomno = "309";
            Check_In_Out ch = new Check_In_Out();
            ch.Show();
        }

        private void btn309_Click(object sender, EventArgs e)
        {
            roomno = "309";
            Check_In_Out ch = new Check_In_Out();
            ch.Show();
        }

        private void btn310_Click(object sender, EventArgs e)
        {
            roomno = "310";
            Check_In_Out ch = new Check_In_Out();
            ch.Show();
        }

        private void setUpUserToolStripMenuItem2_Click_1(object sender, EventArgs e)
        {
          
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            MDI_Load( sender, e);
            this.Opacity=0.7;
            Login frm = new Login();
            strstatus = "C";
            frm.ShowDialog();
            this.Opacity = 1;
            textBox1.Text = Login.username;
            textBox2.Text = Login.role;           
        }

        private void MDI_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void MDI_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.S && e.Control)
            {
                frmAdd_New_User frm = new frmAdd_New_User();
                frm.Show();
            }
        }

        private void MDI_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            recpt();
               
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text.Contains("admin"))
            {
                setUpUserToolStripMenuItem2.Enabled = true;
            }
            else
            {
                setUpUserToolStripMenuItem2.Enabled = false;
            }

        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void todaysCheckOutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Today_s_Check_Out tc = new Today_s_Check_Out();
            tc.Show();

        }

        private void addNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdd_New_User fre = new frmAdd_New_User();
            fre.Show();
        }

        private void changePasswordToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmChange_Password frm = new frmChange_Password();
            frm.Show();
        }

        private void roomConfigurationToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            RoomConfiguration rm = new RoomConfiguration();
            rm.Show();
        }

        private void extraChargesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Extracharges ec = new Extracharges();
            ec.Show();
        }

        private void addNewIdentityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Identifaction id = new Identifaction();
            id.Show();
        }

        private void hotelConfigurationToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            HotelConfiguration hc = new HotelConfiguration();
            hc.Show();
                
        }

        private void chechInCheckOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hãy chọn số phòng");
        }

        private void incomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HotelIncome hi = new HotelIncome();
            hi.Show();
        }

        private void checkOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Check_out_report checkoutrp = new Check_out_report();
            checkoutrp.ShowDialog();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Today_s_Check_Out tdco = new Today_s_Check_Out();
            tdco.Show();
        }
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Extracharges extracharges = new Extracharges();
            extracharges.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process p = System.Diagnostics.Process.Start("notepad.exe");
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc");
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            HotelIncome hotelIncome = new HotelIncome();
            hotelIncome.Show();
        }
    }
}