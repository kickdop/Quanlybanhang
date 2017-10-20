namespace Quanlisieuthi
{
    partial class frmKhachHang
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.but_Del = new System.Windows.Forms.Button();
            this.but_Up = new System.Windows.Forms.Button();
            this.but_Ins = new System.Windows.Forms.Button();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtGT = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.but_OK = new System.Windows.Forms.Button();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.but_Find = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.but_Del);
            this.panel1.Controls.Add(this.but_Up);
            this.panel1.Controls.Add(this.but_Ins);
            this.panel1.Controls.Add(this.txtTen);
            this.panel1.Controls.Add(this.txtSDT);
            this.panel1.Controls.Add(this.txtGT);
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(40, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(485, 272);
            this.panel1.TabIndex = 8;
            // 
            // but_Del
            // 
            this.but_Del.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_Del.Location = new System.Drawing.Point(297, 183);
            this.but_Del.Name = "but_Del";
            this.but_Del.Size = new System.Drawing.Size(88, 53);
            this.but_Del.TabIndex = 18;
            this.but_Del.Text = "Xóa Khách Hàng";
            this.but_Del.UseVisualStyleBackColor = true;
            
            // 
            // but_Up
            // 
            this.but_Up.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_Up.Location = new System.Drawing.Point(169, 183);
            this.but_Up.Name = "but_Up";
            this.but_Up.Size = new System.Drawing.Size(88, 53);
            this.but_Up.TabIndex = 17;
            this.but_Up.Text = "Sửa Khách Hàng";
            this.but_Up.UseVisualStyleBackColor = true;
            
            // 
            // but_Ins
            // 
            this.but_Ins.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_Ins.Location = new System.Drawing.Point(37, 183);
            this.but_Ins.Name = "but_Ins";
            this.but_Ins.Size = new System.Drawing.Size(88, 53);
            this.but_Ins.TabIndex = 16;
            this.but_Ins.Text = "Thêm Khách Hàng";
            this.but_Ins.UseVisualStyleBackColor = true;
            
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(210, 55);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(175, 20);
            this.txtTen.TabIndex = 15;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(210, 95);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(175, 20);
            this.txtSDT.TabIndex = 14;
            // 
            // txtGT
            // 
            this.txtGT.Location = new System.Drawing.Point(210, 139);
            this.txtGT.Name = "txtGT";
            this.txtGT.Size = new System.Drawing.Size(175, 20);
            this.txtGT.TabIndex = 13;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(210, 19);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(175, 20);
            this.txtID.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "GT_KhachHang";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "SDT_KhachHang";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Ten_KhachHang";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "ID_KhachHang";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.but_OK);
            this.panel2.Controls.Add(this.txtFind);
            this.panel2.Controls.Add(this.but_Find);
            this.panel2.Location = new System.Drawing.Point(77, 290);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(448, 48);
            this.panel2.TabIndex = 9;
            // 
            // but_OK
            // 
            this.but_OK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_OK.Location = new System.Drawing.Point(349, 8);
            this.but_OK.Name = "but_OK";
            this.but_OK.Size = new System.Drawing.Size(86, 31);
            this.but_OK.TabIndex = 2;
            this.but_OK.Text = "Xong";
            this.but_OK.UseVisualStyleBackColor = true;
            this.but_OK.Visible = false;
            
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(141, 12);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(175, 20);
            this.txtFind.TabIndex = 1;
            // 
            // but_Find
            // 
            this.but_Find.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_Find.Location = new System.Drawing.Point(18, 3);
            this.but_Find.Name = "but_Find";
            this.but_Find.Size = new System.Drawing.Size(90, 36);
            this.but_Find.TabIndex = 0;
            this.but_Find.Text = "Tìm Kiếm";
            this.but_Find.UseVisualStyleBackColor = true;
            
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(64, 364);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(448, 150);
            this.dataGridView1.TabIndex = 10;
            
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "ID_KhachHang";
            this.Column1.HeaderText = "ID_KhachHang";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "Ten_KhachHang";
            this.Column2.HeaderText = "Ten_KhachHang";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "SDT_KhachHang";
            this.Column3.HeaderText = "SDT_KhachHang";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "GioiTinh_KhachHang";
            this.Column4.HeaderText = "GT_KhachHang";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // frmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 514);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmKhachHang";
            this.Text = "KhachHang";
            
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtGT;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.Button but_Find;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button but_Del;
        private System.Windows.Forms.Button but_Up;
        private System.Windows.Forms.Button but_Ins;
        private System.Windows.Forms.Button but_OK;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;

    }
}