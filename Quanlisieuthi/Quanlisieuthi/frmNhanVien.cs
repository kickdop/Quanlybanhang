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
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }
        ConnectData conn = new ConnectData();
        public string constr = @"select * from dbo.NhanVien";
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void but_Ins_Click(object sender, EventArgs e)
        {

        }

        private void but_Del_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đuổi không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                conn.MoKetNoi();
                SqlCommand sqlcm = new SqlCommand("Delete_NhanVien", conn.conn);
                sqlcm.CommandType = CommandType.StoredProcedure;
                sqlcm.Parameters.AddWithValue("@ID_NhanVien", txtID.Text);
                int check = sqlcm.ExecuteNonQuery();
                if (check > 0)
                {
                    MessageBox.Show("Đã đuổi thành công");
                    conn.KhoiTao(dataGridView1, @"select * from NhanVien");
                    txtID.Text = txtHoTen.Text = txtQueQuan.Text = txtGioiTinh.Text = txtCMND.Text = txtNgaySinh.Text = txtFind.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("Có lỗi, không thể xóa dữ liệu");
                }
                conn.DongKetNoi();
            }
        }

        private void but_Find_Click(object sender, EventArgs e)
        {
            conn.MoKetNoi();
            SqlCommand sqlcm = new SqlCommand("timkiemnhanvien", conn.conn);
            sqlcm.CommandType = CommandType.StoredProcedure;

            sqlcm.Parameters.AddWithValue("@tim", txtFind.Text);

            // sqlcm.Parameters.Add("@tim", txtFind.Text);

            SqlDataAdapter da = new SqlDataAdapter(sqlcm);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DataView dv = new DataView(dt);
            dataGridView1.DataSource = dv;
            if (dataGridView1.RowCount <= 0) MessageBox.Show("Nội dung cần tìm không có");
            txtFind.Text = string.Empty;
            conn.DongKetNoi();
        }

        private void but_Up_Click(object sender, EventArgs e)
        {
            
        }

        private void but_OK_Click(object sender, EventArgs e)
        {
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
 
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                txtID.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value);
                txtHoTen.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
                txtQueQuan.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value);
                txtGioiTinh.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[3].Value);
                txtCMND.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[4].Value);
                DateTime dt;
                dt = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[5].Value);
                txtNgaySinh.Text = dt.ToShortDateString();
            }
            else
            {
                return;
            }
        }

        private void txtNgaySinh_TextChanged(object sender, EventArgs e)
        {

        }
    }

}