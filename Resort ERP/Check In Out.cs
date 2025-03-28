using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Resort_ERP
{
    public partial class Check_In_Out : Form
    {
         SqlConnection con = new SqlConnection("Data Source=LAPTOPOFNGUYEN;Initial Catalog=resort;Integrated Security=True");
        public static int adult, child, bed ;
        public static string renmmm;
        public static bool bnn;
        public Boolean nonNumberEntered = false;
    
        public void chk()
        {

            if (chkclearbalance.Checked)
            {
                btncheckout.Enabled = true;
                btnupdate.Enabled = false;
            }
            else
            {
                btnupdate.Enabled = true;
                btncheckout.Enabled = false;

            }
        }
  
        public void payment()
        {
            if (cmbpaymenttype.Text == "Card")
            {
                btnpayment.Enabled = true;
                txtcardnum.Enabled = true;

                chkclearbalance.Enabled = false;
                chkclearbalance.Checked = false;
            }
            else
            {
                chkclearbalance.Enabled = true;

                btnpayment.Enabled = false;
                txtcardnum.Enabled = false;
                txtcardnum.Clear();
            }
        }


        public void total()
        {
            double a, b, c, d, calc;

            if (double.TryParse(txtadultcharges.Text.Trim(), out a) &&
                double.TryParse(txtchildcharges.Text.Trim(), out b) &&
                double.TryParse(txtbedcharges.Text.Trim(), out c) &&
                double.TryParse(txtothercharge.Text.Trim(), out d))
            {
                calc = a + b + c + d;
                txttotalextracharge.Text = calc.ToString();
                txtextracharges.Text = calc.ToString();
                if (int.TryParse(txtperdaycharges.Text.Trim(), out int perDayCharge))
                {
                    txttotal.Text = (calc + perDayCharge).ToString();
                }
                else
                {

                }
            }
            else
            {

            }
        }

        public void remained()
        {
            double rem, q, r;
            int w;

            if (double.TryParse(txttotal.Text, out q) &&
                int.TryParse(txtdiscount.Text, out w) &&
                double.TryParse(txtprepaid.Text, out r))
            {
                rem = q - w - r;
                txtremained.Text = rem.ToString();
            }
            else
            {
          
            }
        }
        public Check_In_Out()
        {
            InitializeComponent();
        }
        public void Charge()
        {
      
            SqlCommand cmd4=new SqlCommand("select AdultCharge,ChildCharge,BedCharge from extracharges",con);
            SqlDataAdapter aaa = new SqlDataAdapter(cmd4);
            DataSet dss = new DataSet();
            aaa.Fill(dss);
            if (dss.Tables[0].Rows.Count > 0)
            {
               adult =Convert.ToInt32( dss.Tables[0].Rows[0][0].ToString());
               child = Convert.ToInt32( dss.Tables[0].Rows[0][1].ToString());
               bed =Convert.ToInt32( dss.Tables[0].Rows[0][2].ToString());
                
            }
            SqlDataAdapter cmd5 = new SqlDataAdapter("select charges from roomconfiguration where room_num='" + MDI.roomno + "'", con);
            DataSet ds = new DataSet();
            cmd5.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                txtrooms.Text=ds.Tables[0].Rows[0][0].ToString();
            }
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            if (txtdiscount.Text == "")
            {
                txtdiscount.Text = "0";
            }
            else
            {
                remained();
            }
        }

        private void grproomchargesdetails_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            payment();
        }

        private void Check_In_Out_Load(object sender, EventArgs e)
        {
            con.Close();
            con.Open();
            chkclearbalance.Enabled = false;
            btnpayment.Enabled = false;
            btnupdate.Enabled = false;
            btncheckout.Enabled = false;
            txtcardnum.Enabled = false;
            txtnoofadys.Focus();
            ccmbgender.SelectedIndex = 0;
            cmbpaymenttype.SelectedIndex = 1;
            Charge();
            txtroomno.Text = MDI.roomno;
            TXTRECEPTIPNIST.Text = Login.username;
            
            //int a = chkclearbalance.Enabled = false;
            //if (chkclearbalance.ItemCheck== true)
            //{
            //    btncheckout.Enabled = true;
            //}
            //else
            //{
            //    btncheckout.Enabled = false;
            //}
            SqlCommand cmd4 = new SqlCommand("select * from roomconfiguration where room_num='" + MDI.roomno + "' ", con);
            SqlDataAdapter aa = new SqlDataAdapter(cmd4);
            DataSet dss = new DataSet();
            aa.Fill(dss);
            if (dss.Tables[0].Rows.Count > 0)
            {
                txtroomno.Text = dss.Tables[0].Rows[0][3].ToString();
                ttxtroomtype.Text = dss.Tables[0].Rows[0][1].ToString();
                txtfloor.Text = dss.Tables[0].Rows[0][4].ToString();
            }
            con.Close();
            con.Open();
            SqlDataAdapter cmd = new SqlDataAdapter("select id_proof from identifaction", con);
            DataSet ds = new DataSet();
            cmd.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                cmmidprooff.Items.Clear();
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    cmmidprooff.Items.Add(ds.Tables[0].Rows[i]["id_proof"].ToString());
                }
            }
            else
            {
                cmmidprooff.Items.Clear();
            }
            //cmbidproof.DataSource = ds.Tables[0];
            con.Close();
            {
                con.Open();
                SqlCommand cc = new SqlCommand("select room_no,room_Type,floorr,check_in_date,check_out_date,no_of_days,extra_adult,extra_child,extra_bed,adult_charge,child_charge,bed_charge,room_charge,extra_charge,prepaid,discount,total,namee,last_name,gender,dob,address,id_proof,id_no,ph_no,payment_type,card_no,email from details where room_no='" + MDI.roomno + "'", con);
                SqlDataAdapter sda = new SqlDataAdapter(cc);
                DataSet sd = new DataSet();
                sda.Fill(sd);
                if (sd.Tables[0].Rows.Count > 0)
                {
                    txtroomno.Text = sd.Tables[0].Rows[0][0].ToString();
                    ttxtroomtype.Text = sd.Tables[0].Rows[0][1].ToString();
                    txtfloor.Text = sd.Tables[0].Rows[0][2].ToString();
                    dateTimePicker1.Text = sd.Tables[0].Rows[0][3].ToString();
                    dateTimePicker2.Text = sd.Tables[0].Rows[0][4].ToString();
                    txtnoofadys.Text = sd.Tables[0].Rows[0][5].ToString();
                    txtextraadult.Text = sd.Tables[0].Rows[0][6].ToString();
                    txtnoextrachild.Text = sd.Tables[0].Rows[0][7].ToString();
                    txtnoextrrbed.Text = sd.Tables[0].Rows[0][8].ToString();
                    txtadultcharges.Text = sd.Tables[0].Rows[0][9].ToString();
                    txtchildcharges.Text = sd.Tables[0].Rows[0][10].ToString();
                    txtbedcharges.Text = sd.Tables[0].Rows[0][11].ToString();
                    txtroomchargess.Text = sd.Tables[0].Rows[0][12].ToString();
                    txtextracharges.Text = sd.Tables[0].Rows[0][13].ToString();
                    txtprepaid.Text = sd.Tables[0].Rows[0][14].ToString();
                    txtdiscount.Text = sd.Tables[0].Rows[0][15].ToString();
                    txttotal.Text = sd.Tables[0].Rows[0][16].ToString();
                    txtname.Text = sd.Tables[0].Rows[0][17].ToString();
                    txtlastname.Text = sd.Tables[0].Rows[0][18].ToString();
                    ccmbgender.Text = sd.Tables[0].Rows[0][19].ToString();
                    dateTimePickerdob.Text = sd.Tables[0].Rows[0][20].ToString();
                    txtaddress.Text = sd.Tables[0].Rows[0][21].ToString();
                    cmmidprooff.Text = sd.Tables[0].Rows[0][22].ToString();
                    txtidno.Text = sd.Tables[0].Rows[0][23].ToString();
                    cmbpaymenttype.Text = sd.Tables[0].Rows[0][25].ToString();
                    txtcardnum.Text = sd.Tables[0].Rows[0][26].ToString();
                    txtemail.Text = sd.Tables[0].Rows[0][27].ToString();
                    txtphnum.Text = sd.Tables[0].Rows[0][24].ToString();
                    con.Close();
                    btncheckin.Enabled = false;
                    btnupdate.Enabled = true;
                }

                con.Close();
            }         
           //if (cmbpaymenttype.Text = "card")
            //{
            //    chkclearbalance.Enabled = false;
            //}
            //else
            //{
            //    chkclearbalance.Enabled = true;
            //}
        }

        private void txtnoofadys_TextChanged(object sender, EventArgs e)
        {
            double s;
            {
                s = Convert.ToInt32(txtrooms.Text);
               
            }
            if (txtnoofadys.Text == "")
            {
                txtnoofadys.Text = "1";
                txtnoofadys.Focus();
                dateTimePicker2.Text = DateTime.Now.ToShortDateString();

            }
            else
            {
                DateTime dt = Convert.ToDateTime(dateTimePicker1.Value);
                int a = int.Parse(txtnoofadys.Text);
                dateTimePicker2.Value = dt.AddDays(a);
                txtperdsay.Text = "Phí thuê "+txtnoofadys.Text+"ngày:";
                txtperdaycharges.Text = (Convert.ToDouble(txtnoofadys.Text) * s).ToString();
                txtrs.Text = "VND";
                total();
                remained();         
                txtroomchargess.Text = txtperdaycharges.Text ;
            }
        }

        private void txtextraadult_TextChanged(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("Data Source=LAPTOPOFNGUYEN;Initial Catalog=resort;Integrated Security=True"))
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter();
                if (int.TryParse(txtextraadult.Text, out int ac))
                {
                    txtadultcharges.Text = (ac * adult).ToString();
                }
                else
                {
                    txtextraadult.Text = "0";
                }
                total();
                remained();
            }
        }

        private void txtnoextrachild_TextChanged(object sender, EventArgs e)
        {
            if (txtnoextrachild.Text == "")
            {
                txtnoextrachild.Text = "0";
            }
            else
            {
                txtchildcharges.Text = (Convert.ToDouble(txtnoextrachild.Text) * child).ToString();
            }
            total();
            remained();
        }

        private void txtnoextrrbed_TextChanged(object sender, EventArgs e)
        {
            if (txtnoextrrbed.Text == "")
            {
                txtnoextrrbed.Text = "0";
            }
            else
            {
                txtbedcharges.Text = (Convert.ToDouble(txtnoextrrbed.Text) * bed).ToString();
            }
            total();
            remained();
        }

        private void txtothercharge_TextChanged(object sender, EventArgs e)
        {

            if (txtothercharge.Text == "")
            {
                txtothercharge.Text = "0";
            }
            else
            {
                total();
                remained();
            }
          
        }

        private void txtextracharges_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txttotalextracharge_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtperdsay_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtperdaycharges_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtprepaid_TextChanged(object sender, EventArgs e)
        {
            if (txtprepaid.Text == "")
            {
                txtprepaid.Text="0";
            }
            else
            {
            remained();
            }
        }

        private void btncheckin_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("Data Source=LAPTOPOFNGUYEN;Initial Catalog=resort;Integrated Security=True"))
            {
                con.Open();
                if (string.IsNullOrWhiteSpace(txtnoofadys.Text) ||
                    string.IsNullOrWhiteSpace(txtprepaid.Text) ||
                    string.IsNullOrWhiteSpace(txtname.Text) ||
                    string.IsNullOrWhiteSpace(ccmbgender.Text) ||
                    string.IsNullOrWhiteSpace(txtlastname.Text) ||
                    string.IsNullOrWhiteSpace(txtaddress.Text) ||
                    string.IsNullOrWhiteSpace(txtidno.Text) ||
                    string.IsNullOrWhiteSpace(txtphnum.Text) ||
                    string.IsNullOrWhiteSpace(txtemail.Text))
                {
                    MessageBox.Show("Hãy điền đủ thông tin");
                    return;
                }
                try
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO details (room_no, room_Type, floorr, check_in_date, check_out_date, no_of_days, extra_adult, extra_child, extra_bed, adult_charge, child_charge, bed_charge, room_charge, extra_charge, prepaid, discount, total, namee, last_name, gender, dob, address, id_proof, id_no, ph_no, payment_type, card_no, email, receptionist) " +
                 "VALUES (@room_no, @room_Type, @floorr, @check_in_date, @check_out_date, @no_of_days, @extra_adult, @extra_child, @extra_bed, @adult_charge, @child_charge, @bed_charge, @room_charge, @extra_charge, @prepaid, @discount, @total, @namee, @last_name, @gender, @dob, @address, @id_proof, @id_no, @ph_no, @payment_type, @card_no, @email, @receptionist)", con);
                    cmd.Parameters.AddWithValue("@room_no", txtroomno.Text);
                    cmd.Parameters.AddWithValue("@room_Type", ttxtroomtype.Text);
                    cmd.Parameters.AddWithValue("@floorr", txtfloor.Text);
                    cmd.Parameters.AddWithValue("@check_in_date", dateTimePicker1.Value);
                    cmd.Parameters.AddWithValue("@check_out_date", dateTimePicker2.Value);
                    cmd.Parameters.AddWithValue("@no_of_days", txtnoofadys.Text);
                    cmd.Parameters.AddWithValue("@extra_adult", txtextraadult.Text);
                    cmd.Parameters.AddWithValue("@extra_child", txtnoextrachild.Text);
                    cmd.Parameters.AddWithValue("@extra_bed", txtnoextrrbed.Text);
                    cmd.Parameters.AddWithValue("@adult_charge", txtadultcharges.Text);
                    cmd.Parameters.AddWithValue("@child_charge", txtchildcharges.Text);
                    cmd.Parameters.AddWithValue("@bed_charge", txtbedcharges.Text);
                    cmd.Parameters.AddWithValue("@room_charge", txtroomchargess.Text);
                    cmd.Parameters.AddWithValue("@extra_charge", txtextracharges.Text);
                    cmd.Parameters.AddWithValue("@prepaid", txtprepaid.Text);
                    cmd.Parameters.AddWithValue("@discount", txtdiscount.Text);
                    cmd.Parameters.AddWithValue("@total", txttotal.Text);
                    cmd.Parameters.AddWithValue("@namee", txtname.Text);
                    cmd.Parameters.AddWithValue("@last_name", txtlastname.Text);
                    cmd.Parameters.AddWithValue("@gender", ccmbgender.Text);
                    cmd.Parameters.AddWithValue("@dob", dateTimePickerdob.Value);
                    cmd.Parameters.AddWithValue("@address", txtaddress.Text);
                    cmd.Parameters.AddWithValue("@id_proof", cmmidprooff.Text);
                    cmd.Parameters.AddWithValue("@id_no", txtidno.Text);
                    cmd.Parameters.AddWithValue("@ph_no", txtphnum.Text);
                    cmd.Parameters.AddWithValue("@payment_type", cmbpaymenttype.Text);
                    cmd.Parameters.AddWithValue("@card_no", txtcardnum.Text);
                    cmd.Parameters.AddWithValue("@email", txtemail.Text);
                    cmd.Parameters.AddWithValue("@receptionist", TXTRECEPTIPNIST.Text);
                    int affectedRows = cmd.ExecuteNonQuery();

                    if (affectedRows > 0)
                    {
                        MessageBox.Show("Check-In thành công");
                    }
                    else
                    {
                        MessageBox.Show("Check-In Thất bại");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("Data Source=LAPTOPOFNGUYEN;Initial Catalog=resort;Integrated Security=True"))
            {
                con.Open();
                if (string.IsNullOrWhiteSpace(txtnoofadys.Text) ||
                    string.IsNullOrWhiteSpace(txtprepaid.Text) ||
                    string.IsNullOrWhiteSpace(txtname.Text) ||
                    string.IsNullOrWhiteSpace(ccmbgender.Text) ||
                    string.IsNullOrWhiteSpace(txtlastname.Text) ||
                    string.IsNullOrWhiteSpace(txtaddress.Text) ||
                    string.IsNullOrWhiteSpace(txtidno.Text) ||
                    string.IsNullOrWhiteSpace(txtphnum.Text) ||
                    string.IsNullOrWhiteSpace(txtemail.Text))
                {
                    MessageBox.Show("Hãy điền đủ thông tin");
                    return;
                }
                string updateQuery = "UPDATE details SET room_no = @room_no, room_Type = @room_Type, floorr = @floorr, " +
                    "check_in_date = @check_in_date, check_out_date = @check_out_date, " +
                    "no_of_days = @no_of_days, extra_adult = @extra_adult, " +
                    "extra_child = @extra_child, extra_bed = @extra_bed, " +
                    "adult_charge = @adult_charge, child_charge = @child_charge, " +
                    "bed_charge = @bed_charge, room_charge = @room_charge, " +
                    "extra_charge = @extra_charge, prepaid = @prepaid, " +
                    "discount = @discount, total = @total, namee = @namee, " +
                    "last_name = @last_name, gender = @gender, " +
                    "dob = @dob, address = @address, id_proof = @id_proof, " +
                    "id_no = @id_no, ph_no = @ph_no, payment_type = @payment_type, " +
                    "card_no = @card_no, email = @email, receptionist = @receptionist ";
                SqlCommand cmd2 = new SqlCommand(updateQuery, con);
                cmd2.Parameters.AddWithValue("@room_no", txtroomno.Text);
                cmd2.Parameters.AddWithValue("@room_Type", ttxtroomtype.Text);
                cmd2.Parameters.AddWithValue("@floorr", txtfloor.Text);
                cmd2.Parameters.AddWithValue("@check_in_date", dateTimePicker1.Value);
                cmd2.Parameters.AddWithValue("@check_out_date", dateTimePicker2.Value);
                cmd2.Parameters.AddWithValue("@no_of_days", txtnoofadys.Text);
                cmd2.Parameters.AddWithValue("@extra_adult", txtextraadult.Text);
                cmd2.Parameters.AddWithValue("@extra_child", txtnoextrachild.Text);
                cmd2.Parameters.AddWithValue("@extra_bed", txtnoextrrbed.Text);
                cmd2.Parameters.AddWithValue("@adult_charge", txtadultcharges.Text);
                cmd2.Parameters.AddWithValue("@child_charge", txtchildcharges.Text);
                cmd2.Parameters.AddWithValue("@bed_charge", txtbedcharges.Text);
                cmd2.Parameters.AddWithValue("@room_charge", txtroomchargess.Text);
                cmd2.Parameters.AddWithValue("@extra_charge", txtextracharges.Text);
                cmd2.Parameters.AddWithValue("@prepaid", txtprepaid.Text);
                cmd2.Parameters.AddWithValue("@discount", txtdiscount.Text);
                cmd2.Parameters.AddWithValue("@total", txttotal.Text);
                cmd2.Parameters.AddWithValue("@namee", txtname.Text);
                cmd2.Parameters.AddWithValue("@last_name", txtlastname.Text);
                cmd2.Parameters.AddWithValue("@gender", ccmbgender.Text);
                cmd2.Parameters.AddWithValue("@dob", dateTimePickerdob.Value);
                cmd2.Parameters.AddWithValue("@address", txtaddress.Text);
                cmd2.Parameters.AddWithValue("@id_proof", cmmidprooff.Text);
                cmd2.Parameters.AddWithValue("@id_no", txtidno.Text);
                cmd2.Parameters.AddWithValue("@ph_no", txtphnum.Text);
                cmd2.Parameters.AddWithValue("@payment_type", cmbpaymenttype.Text);
                cmd2.Parameters.AddWithValue("@card_no", txtcardnum.Text);
                cmd2.Parameters.AddWithValue("@email", txtemail.Text);
                cmd2.Parameters.AddWithValue("@receptionist", TXTRECEPTIPNIST.Text);
                int k = cmd2.ExecuteNonQuery();
                if (k > 0)
                {
                    MessageBox.Show("Cập nhật thành công");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Không thể cập nhật");
                }
            }
        }
        private void btncheckout_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("Data Source=LAPTOPOFNGUYEN;Initial Catalog=resort;Integrated Security=True"))
            {
                con.Open();
                DialogResult result = MessageBox.Show("Check out phòng", "CheckOut", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
                if (DialogResult.Yes.Equals(result))
                {
                    string insertQuery = "INSERT INTO checkout (room_no, room_Type, floorr, check_in_date, check_out_date, " +
                        "no_of_days, extra_adult, extra_child, extra_bed, adult_charge, child_charge, bed_charge, " +
                        "room_charge, extra_charge, prepaid, discount, total, namee, last_name, gender, " +
                        "dob, address, id_proof, id_no, ph_no, payment_type, card_no, email, receptionist) " +
                        "VALUES (@room_no, @room_Type, @floorr, @check_in_date, @check_out_date, @no_of_days, " +
                        "@extra_adult, @extra_child, @extra_bed, @adult_charge, @child_charge, @bed_charge, " +
                        "@room_charge, @extra_charge, @prepaid, @discount, @total, @namee, @last_name, @gender, " +
                        "@dob, @address, @id_proof, @id_no, @ph_no, @payment_type, @card_no, @email, @receptionist)";
                    SqlCommand cmd = new SqlCommand(insertQuery, con);
                    cmd.Parameters.AddWithValue("@room_no", txtroomno.Text);
                    cmd.Parameters.AddWithValue("@room_Type", ttxtroomtype.Text);
                    cmd.Parameters.AddWithValue("@floorr", txtfloor.Text);
                    cmd.Parameters.AddWithValue("@check_in_date", dateTimePicker2.Value);
                    cmd.Parameters.AddWithValue("@check_out_date", dateTimePicker1.Value);
                    cmd.Parameters.AddWithValue("@no_of_days", txtnoofadys.Text);
                    cmd.Parameters.AddWithValue("@extra_adult", txtextraadult.Text);
                    cmd.Parameters.AddWithValue("@extra_child", txtnoextrachild.Text);
                    cmd.Parameters.AddWithValue("@extra_bed", txtnoextrrbed.Text);
                    cmd.Parameters.AddWithValue("@adult_charge", txtadultcharges.Text);
                    cmd.Parameters.AddWithValue("@child_charge", txtchildcharges.Text);
                    cmd.Parameters.AddWithValue("@bed_charge", txtbedcharges.Text);
                    cmd.Parameters.AddWithValue("@room_charge", txtroomchargess.Text);
                    cmd.Parameters.AddWithValue("@extra_charge", txtextracharges.Text);
                    cmd.Parameters.AddWithValue("@prepaid", txtprepaid.Text);
                    cmd.Parameters.AddWithValue("@discount", txtdiscount.Text);
                    cmd.Parameters.AddWithValue("@total", txttotal.Text);
                    cmd.Parameters.AddWithValue("@namee", txtname.Text);
                    cmd.Parameters.AddWithValue("@last_name", txtlastname.Text);
                    cmd.Parameters.AddWithValue("@gender", ccmbgender.Text);
                    cmd.Parameters.AddWithValue("@dob", dateTimePickerdob.Value);
                    cmd.Parameters.AddWithValue("@address", txtaddress.Text);
                    cmd.Parameters.AddWithValue("@id_proof", cmmidprooff.Text);
                    cmd.Parameters.AddWithValue("@id_no", txtidno.Text);
                    cmd.Parameters.AddWithValue("@ph_no", txtphnum.Text);
                    cmd.Parameters.AddWithValue("@payment_type", cmbpaymenttype.Text);
                    cmd.Parameters.AddWithValue("@card_no", txtcardnum.Text);
                    cmd.Parameters.AddWithValue("@email", txtemail.Text);
                    cmd.Parameters.AddWithValue("@receptionist", TXTRECEPTIPNIST.Text);
                    int a = cmd.ExecuteNonQuery();
                    if (a > 0)
                    {
                        MessageBox.Show("Check out thành công");
                        dateTimePicker2.Value = DateTime.Now;
                        dateTimePicker1.Value = DateTime.Now;
                        txtnoofadys.Text = "0";
                        txtextraadult.Text = "";
                        txtnoextrachild.Text = "";
                        txtnoextrrbed.Text = "";
                        txtadultcharges.Text = "";
                        txtchildcharges.Text = "";
                        txtbedcharges.Text = "";
                        txtroomchargess.Text = "";
                        txtextracharges.Text = "";
                        txtprepaid.Text = "";
                        txtdiscount.Text = "";
                        txttotal.Text = "";
                        txtname.Text = "";
                        txtlastname.Text = "";
                        ccmbgender.Text = "";
                        dateTimePickerdob.Value = DateTime.Now;
                        txtaddress.Text = "";
                        cmmidprooff.Text = "";
                        txtidno.Text = "";
                        txtphnum.Text = "";
                        cmbpaymenttype.Text = "";
                        txtcardnum.Text = "";
                        txtemail.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Không thể check out");
                    }
                }
                else
                {
                }
            }
        }
        private void btnpayment_Click(object sender, EventArgs e)
        {
            if (txtcardnum.Text == "")
            {
                MessageBox.Show("Nhập số thẻ");
                txtcardnum.Focus();
                return;
            }         
            //Check_In_Out.bnn = btncheckout;          
            Check_In_Out.renmmm = txtremained.Text;
                     this.Hide();
            Gatway frm = new Gatway();
            frm.Show();
        }
        private void chkclearbalance_CheckStateChanged(object sender, EventArgs e)
        {
            chk();
        }
        private void txtnoofadys_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (nonNumberEntered == true)
            {
                MessageBox.Show("Vui lòng chỉ nhập số", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }
        private void txtnoofadys_KeyDown(object sender, KeyEventArgs e)
        {
            nonNumberEntered = false;
            if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
            {
                if ((e.KeyCode < Keys.NumPad0) || e.KeyCode > Keys.NumPad9)
                {
                    if (e.KeyCode != Keys.Back)
                    {
                        nonNumberEntered = true;
                    }
                }
            }
        }
        private void txtextraadult_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (nonNumberEntered == true)
            {
                MessageBox.Show("Vui lòng chỉ nhập số", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }
        private void txtextraadult_KeyDown(object sender, KeyEventArgs e)
        {
            nonNumberEntered = false;
            if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
            {
                if ((e.KeyCode < Keys.NumPad0) || e.KeyCode > Keys.NumPad9)
                {
                    if (e.KeyCode != Keys.Back)
                    {
                        nonNumberEntered = true;
                    }
                }
            }
        }
        private void txtnoextrachild_KeyDown(object sender, KeyEventArgs e)
        {
            nonNumberEntered = false;
            if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
            {
                if ((e.KeyCode < Keys.NumPad0) || e.KeyCode > Keys.NumPad9)
                {
                    if (e.KeyCode != Keys.Back)
                    {
                        nonNumberEntered = true;
                    }
                }
            }
        }
        private void txtnoextrachild_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (nonNumberEntered == true)
            {
                MessageBox.Show("Vui lòng chỉ nhập số", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }
        private void txtnoextrrbed_KeyDown(object sender, KeyEventArgs e)
        {
            nonNumberEntered = false;
            if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
            {
                if ((e.KeyCode < Keys.NumPad0) || e.KeyCode > Keys.NumPad9)
                {
                    if (e.KeyCode != Keys.Back)
                    {
                        nonNumberEntered = true;
                    }
                }
            }
        }
        private void txtnoextrrbed_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (nonNumberEntered == true)
            {
                MessageBox.Show("Vui lòng chỉ nhập số", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }
        private void txtothercharge_KeyDown(object sender, KeyEventArgs e)
        {
            nonNumberEntered = false;
            if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
            {
                if ((e.KeyCode < Keys.NumPad0) || e.KeyCode > Keys.NumPad9)
                {
                    if (e.KeyCode != Keys.Back)
                    {
                        nonNumberEntered = true;
                    }
                }
            }
        }
        private void txtothercharge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (nonNumberEntered == true)
            {
                MessageBox.Show("Vui lòng chỉ nhập số", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }
        private void txtdiscount_KeyDown(object sender, KeyEventArgs e)
        {
            nonNumberEntered = false;
            if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
            {
                if ((e.KeyCode < Keys.NumPad0) || e.KeyCode > Keys.NumPad9)
                {
                    if (e.KeyCode != Keys.Back)
                    {
                        nonNumberEntered = true;
                    }
                }
            }
        }
        private void txtdiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (nonNumberEntered == true)
            {
                MessageBox.Show("Vui lòng chỉ nhập số", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }
        private void txtprepaid_KeyDown(object sender, KeyEventArgs e)
        {
            nonNumberEntered = false;
            if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
            {
                if ((e.KeyCode < Keys.NumPad0) || e.KeyCode > Keys.NumPad9)
                {
                    if (e.KeyCode != Keys.Back)
                    {
                        nonNumberEntered = true;
                    }
                }
            }
        }
        private void txtprepaid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (nonNumberEntered == true)
            {
                MessageBox.Show("Vui lòng chỉ nhập số", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }
        private void txtname_KeyDown(object sender, KeyEventArgs e)
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
        private void txtname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != (char)Keys.Back)
            {
                MessageBox.Show("Tên không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }

        private void txtlastname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != (char)Keys.Back)
            {
                MessageBox.Show("Họ không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }

        private void txtlastname_KeyDown(object sender, KeyEventArgs e)
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
        private void txtphnum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (nonNumberEntered == true)
            {
                MessageBox.Show("Vui lòng chỉ nhập số", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }
        private void txtphnum_KeyDown(object sender, KeyEventArgs e)
        {
            nonNumberEntered = false;
            if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
            {
                if ((e.KeyCode < Keys.NumPad0) || e.KeyCode > Keys.NumPad9)
                {
                    if (e.KeyCode != Keys.Back)
                    {
                        nonNumberEntered = true;
                    }
                }
            }
        }
        private void txtcardnum_KeyDown(object sender, KeyEventArgs e)
        {
            nonNumberEntered = false;
            if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
            {
                if ((e.KeyCode < Keys.NumPad0) || e.KeyCode > Keys.NumPad9)
                {
                    if (e.KeyCode != Keys.Back)
                    {
                        nonNumberEntered = true;
                    }
                }
            }
        }
        private void txtcardnum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (nonNumberEntered == true)
            {
                MessageBox.Show("Vui lòng chỉ nhập số", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }
        private void txtemail_Validated(object sender, EventArgs e)
        {
            errorProvider2.SetError(txtemail, "");
        }

        private void txtemail_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidEmailAddress(txtemail.Text, out errorMsg))
            {
                e.Cancel = true;
                txtemail.Select(0, txtemail.Text.Length); 
                this.errorProvider2.SetError(txtemail, errorMsg);
            }
        }

        private void txtidno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (isCCCDSelected || isCMNDSelected || isPassportSelected)
            {
                if (!char.IsLetterOrDigit(e.KeyChar) || txtname.Text.Length >= (isCCCDSelected ? 12 : (isCMNDSelected ? 10 : 8)))
                {
                    MessageBox.Show(GetErrorMessage(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e.Handled = true;
                }
            }
        }
        private string GetErrorMessage()
        {
            if (isCCCDSelected)
            {
                return "Vui lòng nhập tối đa 12 chữ số không có ký tự đặc biệt!";
            }
            else if (isCMNDSelected)
            {
                return "Vui lòng nhập tối đa 10 chữ số không có ký tự đặc biệt!";
            }
            else if (isPassportSelected)
            {
                return "Vui lòng nhập tối đa 8 ký tự chữ và số không có ký tự đặc biệt!";
            }
            else
            {
                return "Loại định danh không hợp lệ!";
            }
        }
        private bool isCCCDSelected = false;
        private bool isCMNDSelected = false;
        private bool isPassportSelected = false;
        private void cmmidprooff_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedDocumentType = cmmidprooff.SelectedItem.ToString();
            isCCCDSelected = selectedDocumentType == "CCCD";
            isCMNDSelected = selectedDocumentType == "CMND";
            isPassportSelected = selectedDocumentType == "PASSPORT";
        }

        public bool ValidEmailAddress(string emailAddress, out string errorMessage)
        {
            if (emailAddress.Length == 0)
            {
                errorMessage = "Địa chỉ e-mail là bắt buộc.";
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
               "Ví dụ: 'someone@example.com' ";
            return false;
        }
       private void tabPage2_Click(object sender, EventArgs e)
       {

       }       
    }   
}
