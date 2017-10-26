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
    public partial class frmThongKe : Form
    {
        public frmThongKe()
        {
            InitializeComponent();
        }
        ConnectData con = new ConnectData();

        private void butOut_Click(object sender, EventArgs e)
        {
            frmTKNH frm = new frmTKNH();
            frm.ShowDialog();
        }

        private void butIn_Click(object sender, EventArgs e)
        {
            frmTKBH frm = new frmTKBH();
            frm.ShowDialog();
        }

        private void butShow_Click(object sender, EventArgs e)
        {
            bool check = false;
            DateTime a, b;
            a = Convert.ToDateTime(dateTimePicker1.Text);
            b = Convert.ToDateTime(dateTimePicker2.Text);
            if (b.Year < a.Year)
            {
                check = true;
            }
            else
            {
                if (b.Month < a.Month)
                {
                    check = true;
                }
                else if (b.Day < a.Day)
                {
                    check = true;
                }
            }
            if (check == true)
            {
                MessageBox.Show("Khoảng thời gian không đúng");
            }
            else
            {
                con.MoKetNoi();
                SqlCommand sqlcm = new SqlCommand("LuuLuong", con.conn);
                sqlcm.CommandType = CommandType.StoredProcedure;
                sqlcm.Parameters.AddWithValue("@ngaybatdau", a);
                sqlcm.Parameters.AddWithValue("@ngayketthuc", b);
                SqlDataAdapter da = new SqlDataAdapter(sqlcm);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataView dv = new DataView(dt);
                dataGridView1.DataSource = dv;
                con.DongKetNoi();
            }
        }

        private void frmThongKe_Load(object sender, EventArgs e)
        {

        }
    }
}
