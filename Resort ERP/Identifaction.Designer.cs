namespace Resort_ERP
{
    partial class Identifaction
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnremove = new System.Windows.Forms.Button();
            this.cmbidproof = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Loại định danh:";
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(115, 60);
            this.btnadd.Margin = new System.Windows.Forms.Padding(4);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(83, 28);
            this.btnadd.TabIndex = 2;
            this.btnadd.Text = "Thêm";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnremove
            // 
            this.btnremove.Location = new System.Drawing.Point(268, 60);
            this.btnremove.Margin = new System.Windows.Forms.Padding(4);
            this.btnremove.Name = "btnremove";
            this.btnremove.Size = new System.Drawing.Size(83, 28);
            this.btnremove.TabIndex = 3;
            this.btnremove.Text = "Xóa";
            this.btnremove.UseVisualStyleBackColor = true;
            this.btnremove.Click += new System.EventHandler(this.btnremove_Click);
            // 
            // cmbidproof
            // 
            this.cmbidproof.FormattingEnabled = true;
            this.cmbidproof.Location = new System.Drawing.Point(132, 19);
            this.cmbidproof.Margin = new System.Windows.Forms.Padding(4);
            this.cmbidproof.Name = "cmbidproof";
            this.cmbidproof.Size = new System.Drawing.Size(236, 24);
            this.cmbidproof.TabIndex = 4;
            this.cmbidproof.SelectedIndexChanged += new System.EventHandler(this.cmbidproof_SelectedIndexChanged);
            this.cmbidproof.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbidproof_KeyDown);
            this.cmbidproof.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbidproof_KeyPress);
            // 
            // Identifaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 94);
            this.Controls.Add(this.cmbidproof);
            this.Controls.Add(this.btnremove);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Identifaction";
            this.Text = "Cài đặt loại định danh";
            this.Load += new System.EventHandler(this.Identifaction_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnremove;
        private System.Windows.Forms.ComboBox cmbidproof;
    }
}