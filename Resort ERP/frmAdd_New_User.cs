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
    public partial class frmAdd_New_User : Form
    {
        public Boolean nonNumberEntered = false;
         SqlConnection con = new SqlConnection("Data Source=LAPTOPOFNGUYEN;Initial Catalog=resort;Integrated Security=True");
        

        public frmAdd_New_User()
        {
            InitializeComponent();
        }

        private void frmAdd_New_User_Load(object sender, EventArgs e)
        {

            comboBox1.SelectedIndex = 0;
            FilldgvUserDet();

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "" || textBox2.Text != "" || textBox3.Text != "")
                {
                    if (textBox2.Text.Equals(textBox3.Text))
                    {
                        con.Open();
                        SqlCommand cdd = new SqlCommand("insert into Login_Details(user_Name,User_Password,Role)values('" + textBox1.Text + "','" + textBox2.Text + "','" + comboBox1.SelectedItem.ToString() + "')", con);
                        cdd.ExecuteNonQuery();
                        MessageBox.Show("Người dùng đã được tạo thành công", "Lưu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btncancel_Click(sender, e);
                        FilldgvUserDet();
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu không khớp", "Sai mật khẩu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Hãy nhập tài khoản và mật khảu....", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            con.Close();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                comboBox1.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FilldgvUserDet()
        {
            try
            {
                con.Close();
                con.Open();
                SqlDataAdapter cc =new SqlDataAdapter( "Select * from Login_Details",con);
                DataSet ds = new DataSet();
                cc.Fill(ds);
                dgvUserDet.Rows.Clear();
                if (ds.Tables[0].Rows.Count > 0)
                {
                    dgvUserDet.Rows.Clear();
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        dgvUserDet.Rows.Add();
                        dgvUserDet.Rows[i].Cells[0].Value = i + 1 + " .";
                        dgvUserDet.Rows[i].Cells[1].Value = ds.Tables[0].Rows[i][0];
                        dgvUserDet.Rows[i].Cells[2].Value = ds.Tables[0].Rows[i][2];
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (nonNumberEntered == true)
            {
                MessageBox.Show("Vui lòng chỉ nhập kí tự...", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
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

        private void btnremoveuser_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "DELETE FROM Login_Details WHERE user_Name = @UserName";

            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@UserName", textBox1.Text);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Người dùng đã được xóa thành công", "Xóa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btncancel_Click(sender, e);
                    FilldgvUserDet();
                }
                else
                {
                    MessageBox.Show("Không thể xóa người dùng");
                    FilldgvUserDet();
                }
            }

            con.Close();
        }

        private void dgvUserDet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string userName = dgvUserDet.Rows[e.RowIndex].Cells[1].Value.ToString();
                string role = dgvUserDet.Rows[e.RowIndex].Cells[2].Value.ToString();
                textBox1.Text = userName;
                comboBox1.SelectedItem = role;
                textBox2.Text = "********";
                textBox3.Text = "********";
            }
        }
    }

}
