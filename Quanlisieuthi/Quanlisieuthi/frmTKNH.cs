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
    public partial class frmTKNH : Form
    {
        public frmTKNH()
        {
            InitializeComponent();
        }
        ConnectData con = new ConnectData();
        private void frmTKNH_Load(object sender, EventArgs e)
        {
            con.KhoiTao(dataGridView1, @"select * from PhieuNhap");
        }
    }
}
