namespace Quanlisieuthi
{
    partial class frmNhapHang
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTenHang = new System.Windows.Forms.TextBox();
            this.txtGB = new System.Windows.Forms.TextBox();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.txtNN = new System.Windows.Forms.TextBox();
            this.butNhapHang = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày Nhập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số Lượng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Giá Bán";
            // 
            // txtTenHang
            // 
            this.txtTenHang.Location = new System.Drawing.Point(126, 12);
            this.txtTenHang.Name = "txtTenHang";
            this.txtTenHang.Size = new System.Drawing.Size(203, 20);
            this.txtTenHang.TabIndex = 4;
            // 
            // txtGB
            // 
            this.txtGB.Location = new System.Drawing.Point(126, 48);
            this.txtGB.Name = "txtGB";
            this.txtGB.Size = new System.Drawing.Size(203, 20);
            this.txtGB.TabIndex = 5;
            // 
            // txtSL
            // 
            this.txtSL.Location = new System.Drawing.Point(126, 87);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(203, 20);
            this.txtSL.TabIndex = 6;
            // 
            // txtNN
            // 
            this.txtNN.Location = new System.Drawing.Point(126, 121);
            this.txtNN.Name = "txtNN";
            this.txtNN.Size = new System.Drawing.Size(203, 20);
            this.txtNN.TabIndex = 7;
            // 
            // butNhapHang
            // 
            this.butNhapHang.Location = new System.Drawing.Point(254, 158);
            this.butNhapHang.Name = "butNhapHang";
            this.butNhapHang.Size = new System.Drawing.Size(75, 23);
            this.butNhapHang.TabIndex = 8;
            this.butNhapHang.Text = "Nhập hàng";
            this.butNhapHang.UseVisualStyleBackColor = true;
            
            // 
            // frmNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 201);
            this.Controls.Add(this.butNhapHang);
            this.Controls.Add(this.txtNN);
            this.Controls.Add(this.txtSL);
            this.Controls.Add(this.txtGB);
            this.Controls.Add(this.txtTenHang);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmNhapHang";
            this.Text = "frmNhapHang";
            
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTenHang;
        private System.Windows.Forms.TextBox txtGB;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.TextBox txtNN;
        private System.Windows.Forms.Button butNhapHang;
    }
}