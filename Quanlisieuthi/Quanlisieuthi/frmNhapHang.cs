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
    public partial class frmNhapHang : Form
    {
        ConnectData con = new ConnectData();
        public frmNhapHang()
        {
            InitializeComponent();
        }

        private void frmNhapHang_Load(object sender, EventArgs e)
        {
            txtNN.Text = DateTime.Now.ToShortDateString();
            txtNN.ReadOnly = true;
        }

        private void butNhapHang_Click(object sender, EventArgs e)
        {
            con.MoKetNoi();
            SqlCommand sqlcm = new SqlCommand("NhapHang", con.conn);
            sqlcm.CommandType = CommandType.StoredProcedure;
            sqlcm.Parameters.AddWithValue("@tenhang", txtTenHang.Text);
            sqlcm.Parameters.AddWithValue("@giaban", int.Parse(txtGB.Text));
            sqlcm.Parameters.AddWithValue("@soluong", int.Parse(txtSL.Text));
            sqlcm.Parameters.AddWithValue("@ngaynhap",Convert.ToDateTime(txtNN.Text).ToShortDateString());
            int check = (int)sqlcm.ExecuteNonQuery();
            if (check > 0)
            {
                MessageBox.Show("Nhập thành công");
                txtGB.Text = txtNN.Text = txtTenHang.Text = txtSL.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Có lỗi");
            }
            con.DongKetNoi();
        }
    }
}
