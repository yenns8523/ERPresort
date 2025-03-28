namespace Resort_ERP
{
    partial class HotelConfiguration
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txthotelemail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txthotelphno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txthoteladdress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txthotelname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnhotelupdate = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txthotelemail);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txthotelphno);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txthoteladdress);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txthotelname);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(337, 240);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // txthotelemail
            // 
            this.txthotelemail.Location = new System.Drawing.Point(117, 202);
            this.txthotelemail.Margin = new System.Windows.Forms.Padding(4);
            this.txthotelemail.Name = "txthotelemail";
            this.txthotelemail.Size = new System.Drawing.Size(205, 22);
            this.txthotelemail.TabIndex = 7;
            this.txthotelemail.Validating += new System.ComponentModel.CancelEventHandler(this.txthotelemail_Validating);
            this.txthotelemail.Validated += new System.EventHandler(this.txthotelemail_Validated);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 208);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Email :";
            // 
            // txthotelphno
            // 
            this.txthotelphno.Location = new System.Drawing.Point(117, 162);
            this.txthotelphno.Margin = new System.Windows.Forms.Padding(4);
            this.txthotelphno.Name = "txthotelphno";
            this.txthotelphno.Size = new System.Drawing.Size(205, 22);
            this.txthotelphno.TabIndex = 5;
            this.txthotelphno.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txthotelphno_KeyDown);
            this.txthotelphno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txthotelphno_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 165);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "SDT:";
            // 
            // txthoteladdress
            // 
            this.txthoteladdress.Location = new System.Drawing.Point(117, 61);
            this.txthoteladdress.Margin = new System.Windows.Forms.Padding(4);
            this.txthoteladdress.Multiline = true;
            this.txthoteladdress.Name = "txthoteladdress";
            this.txthoteladdress.Size = new System.Drawing.Size(205, 85);
            this.txthoteladdress.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 61);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Địa chỉ:";
            // 
            // txthotelname
            // 
            this.txthotelname.Location = new System.Drawing.Point(117, 20);
            this.txthotelname.Margin = new System.Windows.Forms.Padding(4);
            this.txthotelname.Name = "txthotelname";
            this.txthotelname.Size = new System.Drawing.Size(205, 22);
            this.txthotelname.TabIndex = 1;
            this.txthotelname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txthotelname_KeyDown);
            this.txthotelname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txthotelname_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên khách sạn :";
            // 
            // btnhotelupdate
            // 
            this.btnhotelupdate.Location = new System.Drawing.Point(137, 263);
            this.btnhotelupdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnhotelupdate.Name = "btnhotelupdate";
            this.btnhotelupdate.Size = new System.Drawing.Size(100, 28);
            this.btnhotelupdate.TabIndex = 3;
            this.btnhotelupdate.Text = "Cập nhật";
            this.btnhotelupdate.UseVisualStyleBackColor = true;
            this.btnhotelupdate.Click += new System.EventHandler(this.btnhotelupdate_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // HotelConfiguration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 306);
            this.Controls.Add(this.btnhotelupdate);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HotelConfiguration";
            this.Text = "Thông tin khách sạn";
            this.Load += new System.EventHandler(this.HotelConfiguration_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txthoteladdress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txthotelname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnhotelupdate;
        private System.Windows.Forms.TextBox txthotelphno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txthotelemail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}