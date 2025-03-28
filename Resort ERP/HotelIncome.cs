using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Resort_ERP
{
    public partial class HotelIncome : Form
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOPOFNGUYEN;Initial Catalog=resort;Integrated Security=True");
        public HotelIncome()
        {
            InitializeComponent();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select sum(total) from checkout where check_out_date>='" + monthCalendar1 + "'");
            con.Close();

        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            con.Open();
            string query = "SELECT SUM(total) FROM checkout WHERE check_out_date >= @StartDate";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@StartDate", e.Start);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                if (!reader.IsDBNull(0))
                {
                    if (decimal.TryParse(reader[0].ToString(), out decimal totalIncome))
                    {
                        textBox1.Text = totalIncome.ToString();
                        lbl_inwords.Text = words((int)totalIncome);
                        lbl_inwords.Show();
                    }
                    else
                    {
                        textBox1.Text = "0";
                        lbl_inwords.Text = "Không";
                        lbl_inwords.Show();
                    }
                }
                else
                {
                    textBox1.Text = "0";
                    lbl_inwords.Text = "Không";
                    lbl_inwords.Show();
                }
            }
            con.Close();
        }
        public string words(int numbers)
        {
            if (numbers == 0) return "Không";
            string[] currencyNames = { "Đồng ", "Nghìn ", "Triệu ", "Tỷ " };
            string[] words0 = { "", "Một ", "Hai ", "Ba ", "Bốn ", "Năm ", "Sáu ", "Bảy ", "Tám ", "Chín " };
            string[] words1 = { "", "Mười ", "Hai mươi ", "Ba mươi ", "Bốn mươi ", "Năm mươi ", "Sáu mươi ", "Bảy mươi ", "Tám mươi ", "Chín mươi " };
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            int number = Math.Abs(numbers); // Đảm bảo số dương
            for (int i = 0; i < 4; i++)
            {
                int num = number % 1000;
                if (num > 0)
                {
                    if (i > 0)
                    {
                        if (i == 2 && number % 1000 == 0)
                        {
                            sb.Insert(0, " Triệu ");
                        }
                        else
                        {
                            sb.Insert(0, " " + currencyNames[i]);
                        }
                    }
                    int u = num % 10;
                    int t = (num / 10) % 10;
                    int h = num / 100;
                    if (h > 0)
                    {
                        sb.Insert(0, words0[h] + " Trăm ");
                    }
                    if (t == 1)
                    {
                        sb.Insert(0, words1[u]);
                    }
                    else
                    {
                        if (u > 0)
                        {
                            sb.Insert(0, words0[u]);
                        }
                        if (t > 0)
                        {
                            sb.Insert(0, words1[t]);
                        }
                    }
                }
                number /= 1000;
                if (number == 0)
                {
                    break;
                }
            }
            if (numbers < 0)
            {
                sb.Insert(0, "Âm ");
            }
            return sb.ToString().Trim();
        }
    }
}
