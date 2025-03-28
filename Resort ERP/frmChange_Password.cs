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
    public partial class frmChange_Password : Form
    {
         SqlConnection con = new SqlConnection("Data Source=LAPTOPOFNGUYEN;Initial Catalog=resort;Integrated Security=True");

        public frmChange_Password()
        {
            InitializeComponent();
        }

        private void frmChange_Password_Load(object sender, EventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "" || textBox2.Text != "" || textBox3.Text != "" || textBox4.Text != "")
                { con.Open();
                        SqlDataAdapter cdd = new SqlDataAdapter( "select * from Login_Details where user_Name='" + textBox1.Text.Trim().ToString() + "'  AND  User_Password ='" + textBox2.Text.Trim().ToString() + "'",con);
                            DataSet ds = new DataSet();
                            cdd.Fill(ds);

                    if (ds.Tables[0].Rows.Count > 0 && ds.Tables[0].Rows != null)
                    {
                        if (textBox3.Text.Equals(textBox4.Text))
                        {
                            SqlCommand cc = new SqlCommand("update Login_Details set User_Password ='" + textBox3.Text.Trim().ToString() + "' where user_Name ='" + textBox1.Text.Trim().ToString() + "'",con);
                            cc.ExecuteNonQuery();
                            MessageBox.Show("Bạn đã đổi mật khẩu thành công", "Lưu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btncancel_Click(sender, e);
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Mật khẩu không khớp", "Sai mật khẩu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            textBox4.Select();
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu cũ không hợp lệ Vui lòng kiểm tra ...", "Không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        textBox2.Select();
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Hãy nhập tài khoản và mật khảu....", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
