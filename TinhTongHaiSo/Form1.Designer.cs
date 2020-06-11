namespace TinhTongHaiSo
{
    partial class frmTinhTong
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtSoHang1 = new System.Windows.Forms.TextBox();
            this.txtSoHang2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTong = new System.Windows.Forms.TextBox();
            this.btnTInhTong = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số hạng thứ nhất";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số hạng thứ hai";
            // 
            // txtSoHang1
            // 
            this.txtSoHang1.Location = new System.Drawing.Point(148, 38);
            this.txtSoHang1.Name = "txtSoHang1";
            this.txtSoHang1.Size = new System.Drawing.Size(100, 20);
            this.txtSoHang1.TabIndex = 2;
            // 
            // txtSoHang2
            // 
            this.txtSoHang2.Location = new System.Drawing.Point(148, 73);
            this.txtSoHang2.Name = "txtSoHang2";
            this.txtSoHang2.Size = new System.Drawing.Size(100, 20);
            this.txtSoHang2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tổng";
            // 
            // txtTong
            // 
            this.txtTong.Location = new System.Drawing.Point(148, 109);
            this.txtTong.Name = "txtTong";
            this.txtTong.ReadOnly = true;
            this.txtTong.Size = new System.Drawing.Size(100, 20);
            this.txtTong.TabIndex = 5;
            // 
            // btnTInhTong
            // 
            this.btnTInhTong.Location = new System.Drawing.Point(58, 156);
            this.btnTInhTong.Name = "btnTInhTong";
            this.btnTInhTong.Size = new System.Drawing.Size(75, 23);
            this.btnTInhTong.TabIndex = 6;
            this.btnTInhTong.Text = "Tính Tổng";
            this.btnTInhTong.UseVisualStyleBackColor = true;
            this.btnTInhTong.Click += new System.EventHandler(this.btnTInhTong_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(160, 156);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmTinhTong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 211);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTInhTong);
            this.Controls.Add(this.txtTong);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSoHang2);
            this.Controls.Add(this.txtSoHang1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmTinhTong";
            this.Text = "Tính tổng hai số";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSoHang1;
        private System.Windows.Forms.TextBox txtSoHang2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTong;
        private System.Windows.Forms.Button btnTInhTong;
        private System.Windows.Forms.Button btnThoat;
    }
}

