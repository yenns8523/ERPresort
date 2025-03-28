namespace Resort_ERP
{
    partial class RoomConfiguration
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnupdate = new System.Windows.Forms.Button();
            this.cmbconffigroomtype = new System.Windows.Forms.ComboBox();
            this.cmbroomnum = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtroomconfigcharges = new System.Windows.Forms.TextBox();
            this.cmbconfigroomtype = new System.Windows.Forms.ComboBox();
            this.blcharges = new System.Windows.Forms.Label();
            this.lblroomtype = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtchar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbtr = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnset = new System.Windows.Forms.Button();
            this.cmbrtconfig = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbrmcon = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.cmbconffigroomtype);
            this.groupBox1.Controls.Add(this.cmbroomnum);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtroomconfigcharges);
            this.groupBox1.Controls.Add(this.cmbconfigroomtype);
            this.groupBox1.Controls.Add(this.blcharges);
            this.groupBox1.Controls.Add(this.lblroomtype);
            this.groupBox1.ForeColor = System.Drawing.Color.OliveDrab;
            this.groupBox1.Location = new System.Drawing.Point(11, 7);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(465, 144);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cài đặt phòng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label5.Location = new System.Drawing.Point(219, 71);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "VND";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnupdate);
            this.groupBox2.Location = new System.Drawing.Point(288, 44);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(147, 64);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(21, 21);
            this.btnupdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(100, 28);
            this.btnupdate.TabIndex = 0;
            this.btnupdate.Text = "Cập nhật";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click_1);
            // 
            // cmbconffigroomtype
            // 
            this.cmbconffigroomtype.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbconffigroomtype.FormattingEnabled = true;
            this.cmbconffigroomtype.Items.AddRange(new object[] {
            "Gia đình",
            "Đơn",
            "Đôi",
            "VIP",
            "SVIP"});
            this.cmbconffigroomtype.Location = new System.Drawing.Point(111, 103);
            this.cmbconffigroomtype.Margin = new System.Windows.Forms.Padding(4);
            this.cmbconffigroomtype.Name = "cmbconffigroomtype";
            this.cmbconffigroomtype.Size = new System.Drawing.Size(152, 24);
            this.cmbconffigroomtype.TabIndex = 7;
            this.cmbconffigroomtype.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbconffigroomtype_KeyDown);
            this.cmbconffigroomtype.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbconffigroomtype_KeyPress);
            // 
            // cmbroomnum
            // 
            this.cmbroomnum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbroomnum.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbroomnum.FormattingEnabled = true;
            this.cmbroomnum.Location = new System.Drawing.Point(109, 31);
            this.cmbroomnum.Margin = new System.Windows.Forms.Padding(4);
            this.cmbroomnum.Name = "cmbroomnum";
            this.cmbroomnum.Size = new System.Drawing.Size(104, 24);
            this.cmbroomnum.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Số phòng:";
            // 
            // txtroomconfigcharges
            // 
            this.txtroomconfigcharges.Location = new System.Drawing.Point(109, 68);
            this.txtroomconfigcharges.Margin = new System.Windows.Forms.Padding(4);
            this.txtroomconfigcharges.Name = "txtroomconfigcharges";
            this.txtroomconfigcharges.Size = new System.Drawing.Size(107, 22);
            this.txtroomconfigcharges.TabIndex = 3;
            this.txtroomconfigcharges.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtroomconfigcharges_KeyDown);
            this.txtroomconfigcharges.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtroomconfigcharges_KeyPress);
            // 
            // cmbconfigroomtype
            // 
            this.cmbconfigroomtype.FormattingEnabled = true;
            this.cmbconfigroomtype.Items.AddRange(new object[] {
            "AC",
            "Non/Ac",
            "Double",
            "Royal Suit"});
            this.cmbconfigroomtype.Location = new System.Drawing.Point(1253, 185);
            this.cmbconfigroomtype.Margin = new System.Windows.Forms.Padding(4);
            this.cmbconfigroomtype.Name = "cmbconfigroomtype";
            this.cmbconfigroomtype.Size = new System.Drawing.Size(133, 24);
            this.cmbconfigroomtype.TabIndex = 2;
            // 
            // blcharges
            // 
            this.blcharges.AutoSize = true;
            this.blcharges.Location = new System.Drawing.Point(35, 71);
            this.blcharges.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.blcharges.Name = "blcharges";
            this.blcharges.Size = new System.Drawing.Size(31, 16);
            this.blcharges.TabIndex = 1;
            this.blcharges.Text = "Giá:";
            // 
            // lblroomtype
            // 
            this.lblroomtype.AutoSize = true;
            this.lblroomtype.Location = new System.Drawing.Point(13, 108);
            this.lblroomtype.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblroomtype.Name = "lblroomtype";
            this.lblroomtype.Size = new System.Drawing.Size(85, 16);
            this.lblroomtype.TabIndex = 0;
            this.lblroomtype.Text = "Room Type :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtchar);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.cmbtr);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.groupBox3.Location = new System.Drawing.Point(11, 159);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(464, 113);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cài đặt giá tiền theo kiểu phòng";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Location = new System.Drawing.Point(288, 36);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(147, 58);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 18);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "Lưu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label4.Location = new System.Drawing.Point(223, 75);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "VND";
            // 
            // txtchar
            // 
            this.txtchar.Location = new System.Drawing.Point(111, 71);
            this.txtchar.Margin = new System.Windows.Forms.Padding(4);
            this.txtchar.Name = "txtchar";
            this.txtchar.Size = new System.Drawing.Size(107, 22);
            this.txtchar.TabIndex = 11;
            this.txtchar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtchar_KeyDown);
            this.txtchar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtchar_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 75);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Giá:";
            // 
            // cmbtr
            // 
            this.cmbtr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbtr.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbtr.FormattingEnabled = true;
            this.cmbtr.Items.AddRange(new object[] {
            "Gia đình",
            "Đơn",
            "Đôi",
            "VIP",
            "SVIP"});
            this.cmbtr.Location = new System.Drawing.Point(111, 38);
            this.cmbtr.Margin = new System.Windows.Forms.Padding(4);
            this.cmbtr.Name = "cmbtr";
            this.cmbtr.Size = new System.Drawing.Size(152, 24);
            this.cmbtr.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Kiểu phòng :";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.groupBox6);
            this.groupBox5.Controls.Add(this.cmbrtconfig);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.cmbrmcon);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.groupBox5.Location = new System.Drawing.Point(11, 273);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(464, 101);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Cài đặt kiểu phòng";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnset);
            this.groupBox6.Location = new System.Drawing.Point(288, 26);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox6.Size = new System.Drawing.Size(147, 58);
            this.groupBox6.TabIndex = 14;
            this.groupBox6.TabStop = false;
            // 
            // btnset
            // 
            this.btnset.Location = new System.Drawing.Point(23, 18);
            this.btnset.Margin = new System.Windows.Forms.Padding(4);
            this.btnset.Name = "btnset";
            this.btnset.Size = new System.Drawing.Size(100, 28);
            this.btnset.TabIndex = 0;
            this.btnset.Text = "Cài";
            this.btnset.UseVisualStyleBackColor = true;
            this.btnset.Click += new System.EventHandler(this.btnset_Click);
            // 
            // cmbrtconfig
            // 
            this.cmbrtconfig.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbrtconfig.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbrtconfig.FormattingEnabled = true;
            this.cmbrtconfig.Items.AddRange(new object[] {
            "Gia đình",
            "Đơn",
            "Đôi",
            "VIP",
            "SVIP"});
            this.cmbrtconfig.Location = new System.Drawing.Point(109, 65);
            this.cmbrtconfig.Margin = new System.Windows.Forms.Padding(4);
            this.cmbrtconfig.Name = "cmbrtconfig";
            this.cmbrtconfig.Size = new System.Drawing.Size(152, 24);
            this.cmbrtconfig.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 70);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Kiểu phòng:";
            // 
            // cmbrmcon
            // 
            this.cmbrmcon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbrmcon.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbrmcon.FormattingEnabled = true;
            this.cmbrmcon.Location = new System.Drawing.Point(109, 32);
            this.cmbrmcon.Margin = new System.Windows.Forms.Padding(4);
            this.cmbrmcon.Name = "cmbrmcon";
            this.cmbrmcon.Size = new System.Drawing.Size(104, 24);
            this.cmbrmcon.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 36);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Số phòng:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(184, 377);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 3;
            this.button2.Text = "Đóng";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // RoomConfiguration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 411);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Location = new System.Drawing.Point(896, 138);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RoomConfiguration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Cài đặt phòng";
            this.Load += new System.EventHandler(this.RoomConfiguration_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtroomconfigcharges;
        private System.Windows.Forms.ComboBox cmbconfigroomtype;
        private System.Windows.Forms.Label blcharges;
        private System.Windows.Forms.Label lblroomtype;
        private System.Windows.Forms.ComboBox cmbroomnum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbconffigroomtype;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtchar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbtr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnset;
        private System.Windows.Forms.ComboBox cmbrtconfig;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbrmcon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
    }
}