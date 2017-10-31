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

        private void but_Del_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa hóa đơn không ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                conn.MoKetNoi();
                SqlCommand sqlcm = new SqlCommand("Delete_HoaDon", conn.conn);
                sqlcm.CommandType = CommandType.StoredProcedure;
                sqlcm.Parameters.AddWithValue("@ID_HoaDon", txtID.Text);
                int check = sqlcm.ExecuteNonQuery();
                if (check > 0)
                {
                    MessageBox.Show("Đã bán thành công");
                    conn.KhoiTao(dataGridView1, @"select * from dbo.HoaDon");
                    txtID.Text = txtHoaDon.Text = txtKhachHang.Text = txtHangHoa.Text = txtNhanVien.Text = txtFind.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("Có lỗi, không thể xóa hóa đơn");
                }
                conn.DongKetNoi();
            }
        }

        private void TimKiem_Click(object sender, EventArgs e)
        {
            conn.MoKetNoi();
            SqlCommand sqlcm = new SqlCommand("timkiemhoadon", conn.conn);
            sqlcm.CommandType = CommandType.StoredProcedure;
            sqlcm.Parameters.AddWithValue("@tim", txtFind.Text);
            SqlDataAdapter da = new SqlDataAdapter(sqlcm);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DataView dv = new DataView(dt);
            dataGridView1.DataSource = dv;
            if (dataGridView1.RowCount <= 0) MessageBox.Show("Nội dung cần tìm không có");
            txtFind.Text = string.Empty;
            conn.DongKetNoi();
        }

        private void but_Ins_Click(object sender, EventArgs e)
        {
            but_OK.Visible = true;
            but_Ins.Visible = false;
            txtHoaDon.Text = txtKhachHang.Text = txtHangHoa.Text = txtNhanVien.Text = txtID.Text = String.Empty;
            dataGridView1.Enabled = false;
        }

       
        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            conn.KhoiTao(dataGridView1, constr);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                txtID.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value);
                txtHoaDon.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
                txtKhachHang.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value);
                txtHangHoa.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[3].Value);
                txtNhanVien.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[4].Value);
            }
            else { return; }
        }

        private void but_OK_Click(object sender, EventArgs e)
        {
            but_OK.Visible = false;
            but_Ins.Visible = true;
            dataGridView1.Enabled = true;
            conn.MoKetNoi();
            SqlCommand sqlcm = new SqlCommand("Add_HoaDon", conn.conn);
            sqlcm.CommandType = CommandType.StoredProcedure;
            sqlcm.Parameters.AddWithValue("@id", txtID.Text);
            sqlcm.Parameters.AddWithValue("@ten", txtHoaDon.Text);
            sqlcm.Parameters.AddWithValue("@idkh", txtKhachHang.Text);
            sqlcm.Parameters.AddWithValue("@idhh", txtHangHoa.Text);
            sqlcm.Parameters.AddWithValue("@idnv", txtNhanVien.Text);
            int check = sqlcm.ExecuteNonQuery();
            if (check > 0)
            {
                MessageBox.Show("Thêm dữ liệu thành công");
                conn.KhoiTao(dataGridView1, @"select * from HoaDon");
                txtNhanVien.Text = txtID.Text = txtHoaDon.Text = txtHangHoa.Text = txtKhachHang.Text = string.Empty;
            }
            else MessageBox.Show("Có lỗi");
            conn.DongKetNoi();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
