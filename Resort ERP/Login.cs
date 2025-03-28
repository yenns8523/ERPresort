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
    public partial class Login : Form
    {
        public static string username;
        public static string role;
        SqlConnection con = new SqlConnection("Data Source=LAPTOPOFNGUYEN;Initial Catalog=resort;Integrated Security=True");
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkBox1.Checked == true)
                {
                    con.Close();
                    con.Open();
                    SqlCommand cs = new SqlCommand("update Login_Details set Remember_Me='true' where user_name='" + textBox1.Text + "'", con);
                    cs.ExecuteNonQuery();
                }
                else
                {
                    con.Close();
                    con.Open();
                    SqlCommand cds = new SqlCommand("update Login_Details set Remember_Me='false' where user_name='" + textBox1.Text + "'", con);
                    cds.ExecuteNonQuery();
                }
               SqlDataAdapter cdds=new SqlDataAdapter("select * from Login_Details where user_Name='" + textBox1.Text.ToString() + "'  AND  User_Password='" + textBox2.Text.ToString() + "'",con);
               DataSet ds = new DataSet();
               cdds.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0 && ds.Tables[0].Rows != null)
                {
                    username = ds.Tables[0].Rows[0][0].ToString().Trim();
                    role = ds.Tables[0].Rows[0][2].ToString().Trim();                                 
                    if (MDI.strstatus != "C")
                    {
                        MDI fr = new MDI();
                        fr.Show();
                    }
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Sai thông tin đăng nhập");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void Form7_Load(object sender, EventArgs e)
        {
         try
            {
                SqlDataAdapter aa =new SqlDataAdapter( "select * from Login_Details",con);
                DataSet ds = new DataSet();
                aa.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0 && ds.Tables[0].Rows != null)
                {
                    string pass = ds.Tables[0].Rows[0]["Remember_Me"].ToString();
                    if (pass == "true")
                    {
                        checkBox1.Checked = true;
                        textBox1.Text = ds.Tables[0].Rows[0]["user_Name"].ToString();
                        textBox2.Text = ds.Tables[0].Rows[0]["User_Password"].ToString();
                    }
                    else
                    {

                    }
                }
                else
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                if (MDI.strstatus == "C")
                {
                    Application.Exit();
                }
                else
                {
                    //this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            con.Close();

        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
