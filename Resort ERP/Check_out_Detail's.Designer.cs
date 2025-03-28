namespace Resort_ERP
{
    partial class Check_out_Detail_s
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Check_out_Detail_s));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Srno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.room_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.room_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.floorr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.check_in_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.check_out_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.last_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ph_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receptionist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Srno,
            this.room_no,
            this.room_type,
            this.floorr,
            this.check_in_date,
            this.check_out_date,
            this.total,
            this.namee,
            this.last_name,
            this.ph_no,
            this.receptionist});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 104);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1924, 833);
            this.dataGridView1.TabIndex = 0;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(115, 34);
            this.txtsearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(309, 22);
            this.txtsearch.TabIndex = 1;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtsearch);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(432, 84);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Số phòng:";
            // 
            // Srno
            // 
            this.Srno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Srno.HeaderText = "STT";
            this.Srno.MinimumWidth = 6;
            this.Srno.Name = "Srno";
            // 
            // room_no
            // 
            this.room_no.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.room_no.HeaderText = "Số phòng";
            this.room_no.MinimumWidth = 6;
            this.room_no.Name = "room_no";
            // 
            // room_type
            // 
            this.room_type.HeaderText = "Kiểu phòng";
            this.room_type.MinimumWidth = 6;
            this.room_type.Name = "room_type";
            // 
            // floorr
            // 
            this.floorr.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.floorr.HeaderText = "Tầng";
            this.floorr.MinimumWidth = 6;
            this.floorr.Name = "floorr";
            // 
            // check_in_date
            // 
            this.check_in_date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.check_in_date.HeaderText = "Ngày check-in";
            this.check_in_date.MinimumWidth = 6;
            this.check_in_date.Name = "check_in_date";
            // 
            // check_out_date
            // 
            this.check_out_date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.check_out_date.HeaderText = "Ngày check-out";
            this.check_out_date.MinimumWidth = 6;
            this.check_out_date.Name = "check_out_date";
            // 
            // total
            // 
            this.total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.total.HeaderText = "Tổng tiền";
            this.total.MinimumWidth = 6;
            this.total.Name = "total";
            // 
            // namee
            // 
            this.namee.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.namee.HeaderText = "Tên";
            this.namee.MinimumWidth = 6;
            this.namee.Name = "namee";
            // 
            // last_name
            // 
            this.last_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.last_name.HeaderText = "Họ";
            this.last_name.MinimumWidth = 6;
            this.last_name.Name = "last_name";
            // 
            // ph_no
            // 
            this.ph_no.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ph_no.HeaderText = "SDT";
            this.ph_no.MinimumWidth = 6;
            this.ph_no.Name = "ph_no";
            // 
            // receptionist
            // 
            this.receptionist.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.receptionist.HeaderText = "Lễ tân";
            this.receptionist.MinimumWidth = 6;
            this.receptionist.Name = "receptionist";
            // 
            // Check_out_Detail_s
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 937);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Check_out_Detail_s";
            this.Text = "Chi Tiết Check-out";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Check_out_Detail_s_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Srno;
        private System.Windows.Forms.DataGridViewTextBoxColumn room_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn room_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn floorr;
        private System.Windows.Forms.DataGridViewTextBoxColumn check_in_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn check_out_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewTextBoxColumn namee;
        private System.Windows.Forms.DataGridViewTextBoxColumn last_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn ph_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn receptionist;
    }
}