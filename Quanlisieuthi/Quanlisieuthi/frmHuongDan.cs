using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlisieuthi
{
    public partial class frmHuongDan : Form
    {
        public frmHuongDan()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeView1.SelectedNode.Name == "rGioiThieu")
            {
                txtHD.Text = @"Đây là phần mềm hỗ trợ cho việc quản lý bán hàng siêu thị, bao gồm các công việc quản lý nhân viên, hàng hóa, khách hàng, và các hóa đơn trong mua bán hàng hóa ở siêu thị. Phần mềm sẽ giúp cho công việc quản lí bán hàng của chúng ta đạt hiệu quả cao hơn.";
            }
            else if (treeView1.SelectedNode.Name == "rLienHe")
            {
                txtHD.Text = "Mọi thông tin hay thắc mắc về phần mềm liên hệ \r\nSĐT: 0985585046 \r\nEmail: vubeo8294@gmail.com";
            }
            else if (treeView1.SelectedNode.Name == "nDangNhap")
            {
                txtHD.Text = "Để sử dụng phần mềm bạn cần có tài khoản. Bạn có thể liên hệ với tác giả trong phần thông tin liên hệ để đăng kí tài khoản";
            }
            else if (treeView1.SelectedNode.Name == "nadd")
            {
                txtHD.Text = @"Để thêm mới nội dung, bạn click vào ô 'Thêm mới', sau đó điền đầy đủ thông tin và click vào ô 'OK'";
            }
            else if (treeView1.SelectedNode.Name == "nfix")
            {
                txtHD.Text = @"Để sửa nội dung, bạn chọn nội dung cần sửa trong danh sách ở dưới, sau đó sửa lại thông tin và click vào ô 'Chỉnh sửa' để hoàn tất";
            }
            else if (treeView1.SelectedNode.Name == "ndel")
            {
                txtHD.Text = @"Để xóa nội dung, bạn chọn nội dung cần xóa trong danh sách ở dưới, sau đó click vào ô 'Xóa' và tiến hành xác nhận để hoàn tất";
            }
            else if (treeView1.SelectedNode.Name == "nfind")
            {
                txtHD.Text = @"Để tìm kiếm nội dung nào đó, bạn nhập thông tin vào ô trống trong phần tìm kiếm sau đó click vào ô 'Tìm kiếm'";
            }
        }

        private void frmHuongDan_Load(object sender, EventArgs e)
        {

        }
    }
}
