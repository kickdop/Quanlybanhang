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
    public partial class frmHoaDon : Form
    {
        public frmHoaDon()
        {
            InitializeComponent();
        }
        ConnectData conn = new ConnectData();
        public string constr = @"select * from dbo.HoaDon";

        private void but_Up_Click(object sender, EventArgs e)
        {
            conn.MoKetNoi();
            SqlCommand sqlcm = new SqlCommand("Edit_HoaDon", conn.conn);
            sqlcm.CommandType = CommandType.StoredProcedure;
            sqlcm.Parameters.AddWithValue("@id_hoadon", txtID.Text);
            sqlcm.Parameters.AddWithValue("@ten_hoadon", txtHoaDon.Text);
            sqlcm.Parameters.AddWithValue("@id_hanghoa", txtHangHoa.Text);
            sqlcm.Parameters.AddWithValue("@id_nhanvien", txtNhanVien.Text);
            sqlcm.Parameters.AddWithValue("@id_khachhang", txtKhachHang.Text);
            int check = sqlcm.ExecuteNonQuery();
            if (check > 0)
            {
                MessageBox.Show("Sửa thành công");
                conn.KhoiTao(dataGridView1, @"select * from HoaDon");
                txtID.Text = txtHoaDon.Text = txtKhachHang.Text = txtHangHoa.Text = txtNhanVien.Text = String.Empty;
            }
            else
            {
                MessageBox.Show("Có lỗi");
            }
            conn.DongKetNoi();
        }
    }
}
