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
    public partial class frmKhachHang : Form
    {
        public frmKhachHang()
        {
            InitializeComponent();
        }
        ConnectData conn = new ConnectData();
        public string constr = @"select * from dbo.KhachHang";

        private void but_Ins_Click(object sender, EventArgs e)
        {
            but_OK.Visible = true;
            but_Ins.Visible = false;
            txtTen.Text = txtSDT.Text = txtGT.Text = txtID.Text = "";
            dataGridView1.Enabled = false;
        }

        private void but_Up_Click(object sender, EventArgs e)
        {
            conn.MoKetNoi();
            SqlCommand sqlcm = new SqlCommand("Edit_KhachHang", conn.conn);
            sqlcm.CommandType = CommandType.StoredProcedure;
            sqlcm.Parameters.AddWithValue("@id_khachhang", txtID.Text);
            sqlcm.Parameters.AddWithValue("@ten_khachhang", txtTen.Text);
            sqlcm.Parameters.AddWithValue("@SDT_khachhang", txtSDT.Text);
            sqlcm.Parameters.AddWithValue("@gioitinh_khachhang", txtGT.Text);
            int check = sqlcm.ExecuteNonQuery();
            if (check > 0)
            {
                MessageBox.Show("Sửa thành công");
                conn.KhoiTao(dataGridView1, @"select * from KhachHang");
                txtID.Text = txtTen.Text = txtSDT.Text = txtGT.Text = String.Empty;
            }
            else
            {
                MessageBox.Show("Có lỗi");
            }
            conn.DongKetNoi();
        }
    }
}