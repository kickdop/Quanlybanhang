namespace Quanlisieuthi
{
    partial class frmHuongDan
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Giới thiệu");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Đăng nhập");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Thêm mới");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Bán hàng, đuổi nhân viên, xóa khách");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Sửa thông tin");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Tìm kiếm");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Hướng dẫn", new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6});
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Liên hệ");
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.txtHD = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(38, 22);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "rGioiThieu";
            treeNode1.Text = "Giới thiệu";
            treeNode2.Name = "nDangNhap";
            treeNode2.Text = "Đăng nhập";
            treeNode3.Name = "nadd";
            treeNode3.Text = "Thêm mới";
            treeNode4.Name = "ndel";
            treeNode4.Text = "Bán hàng, đuổi nhân viên, xóa khách";
            treeNode5.Name = "nfix";
            treeNode5.Text = "Sửa thông tin";
            treeNode6.Name = "nfind";
            treeNode6.Text = "Tìm kiếm";
            treeNode7.Name = "rHuongDan";
            treeNode7.Text = "Hướng dẫn";
            treeNode8.Name = "rLienHe";
            treeNode8.Text = "Liên hệ";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode7,
            treeNode8});
            this.treeView1.Size = new System.Drawing.Size(253, 309);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // txtHD
            // 
            this.txtHD.Location = new System.Drawing.Point(297, 22);
            this.txtHD.Multiline = true;
            this.txtHD.Name = "txtHD";
            this.txtHD.Size = new System.Drawing.Size(373, 309);
            this.txtHD.TabIndex = 1;
            this.txtHD.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // frmHuongDan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 367);
            this.Controls.Add(this.txtHD);
            this.Controls.Add(this.treeView1);
            this.Name = "frmHuongDan";
            this.Text = "Hướng Dẫn";
            this.Load += new System.EventHandler(this.frmHuongDan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TextBox txtHD;
    }
}