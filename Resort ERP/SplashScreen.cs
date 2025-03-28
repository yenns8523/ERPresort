using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Resort_ERP
{
    public partial class SplashScreen : Form
    {
        private int counter;
       
        public SplashScreen()
        {
            InitializeComponent();
           
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            counter++;
            progressBar1.Value = counter * 5;
            // label2.Text = (5*counter).ToString();
            if (counter == 20)
            {
                timer1.Stop();

                this.Hide();
                Login obj = new Login();
                obj.Show();
                
               
            }

            
        }

        public void SplashScreen_Load(object sender, EventArgs e)
        {
           
        }
    }
}
