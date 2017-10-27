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
    public partial class frmBanHang : Form
    {
        public frmBanHang()
        {
            InitializeComponent();
        }
        ConnectData con = new ConnectData();
        private void frmBanHang_Load(object sender, EventArgs e)
        {
            txtNB.Text = DateTime.Now.ToShortDateString();
            txtNB.ReadOnly = true;
        }

        private void butSell_Click(object sender, EventArgs e)
        {
            con.MoKetNoi();
            SqlDataAdapter da = new SqlDataAdapter(@"select TenHang, SoLuong from HangHoa", con.conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            bool check = false;
            foreach (DataRow dr in dt.Rows)
            {
                if (txtTenHang.Text.Trim() == dr[0].ToString().Trim() && int.Parse(txtSL.Text) <= int.Parse(dr[1].ToString().Trim()))
                {
                    check = true;
                    break;
                }
            }
            if (check == true)
            {
                SqlCommand sqlcm = new SqlCommand("BanHang", con.conn);
                sqlcm.CommandType = CommandType.StoredProcedure;
                sqlcm.Parameters.AddWithValue("@tenhang", txtTenHang.Text);
                sqlcm.Parameters.AddWithValue("@soluong", int.Parse(txtSL.Text));
                sqlcm.Parameters.AddWithValue("@ngayban", Convert.ToDateTime(txtNB.Text).ToShortDateString());
                int test = (int)sqlcm.ExecuteNonQuery();
                if (test > 0)
                {
                    MessageBox.Show("Bán thành công");
                    txtNB.Text = txtSL.Text = txtTenHang.Text = string.Empty;
                }
                else MessageBox.Show("Có lỗi");
            }
            else MessageBox.Show("Có lỗi");
            con.DongKetNoi();
        }

        private void txtTenHang_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
