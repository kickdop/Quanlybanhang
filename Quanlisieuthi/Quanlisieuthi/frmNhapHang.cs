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

        private void h()
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

        private void frmNhapHang_Load(object sender, EventArgs e)
        {
            txtNN.Text = DateTime.Now.ToShortDateString();
            txtNN.ReadOnly = true;
        }

        private void butNhapHang_Click(object sender, EventArgs e)
        {
            
        }
    }
}
