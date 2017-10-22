using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Quanlisieuthi
{
    public partial class frmĐăngNhập : Form
    {
        public frmĐăngNhập()
        {
            InitializeComponent();
        }
        ConnectData conn = new ConnectData();
        public string str = @"select * from tblUser";

        private void label1_Click(object sender, EventArgs e)
        {

        }




        private void label6_Click(object sender, EventArgs e)
        {

        }


        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void but_join_Click(object sender, EventArgs e)
        {
            conn.MoKetNoi();
            SqlDataAdapter da = new SqlDataAdapter(str, conn.conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            bool check = false;
            foreach (DataRow row in dt.Rows)
            {
                if (row[0].ToString() == txtUser.Text && row[1].ToString() == txtPass.Text)
                {
                    check = true;
                    break;
                }
                else
                {
                    check = false;
                }
            }
            if (check == true)
            {
                MessageBox.Show("Đăng nhập thành công");
                txtPass.ReadOnly = txtUser.ReadOnly = true;
                pAcc.Enabled = true;
            }
            else
            {
                MessageBox.Show("Tài khoản đăng nhập không hợp lệ không hợp lệ");
                txtUser.Text = txtPass.Text = string.Empty;
            }
            conn.DongKetNoi();
        }


        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void but_HangHoa_Click(object sender, EventArgs e)
        {
            frmHangHoa frmdg = new frmHangHoa();
            frmdg.ShowDialog();
        }

        private void but_HoaDon_Click(object sender, EventArgs e)
        {
            frmHoaDon frmdg = new frmHoaDon();
            frmdg.ShowDialog();
        }

        private void but_KhachHang_Click(object sender, EventArgs e)
        {
            frmKhachHang frmdg = new frmKhachHang();
            frmdg.ShowDialog();
        }

        private void but_NhanVien_Click(object sender, EventArgs e)
        {
            frmNhanVien frmdg = new frmNhanVien();
            frmdg.ShowDialog();
        }

        private void but_QuanLi_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void but_out_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void pAcc_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmHuongDan frmhd = new frmHuongDan();
            frmhd.ShowDialog();
        }
    }
}
