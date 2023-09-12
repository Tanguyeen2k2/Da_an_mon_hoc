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

namespace QLTHUVIEN
{
    public partial class frmDangNhap : Form
    {
        frmMain main;
        LoginAccount loginAccount = null;
        themxoasua themxoasua = new themxoasua();
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void txtLogin_Click(object sender, EventArgs e)
        {
            //kiểm tra nhập tài khoản mật khẩu
            if (txttaikhoan.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập tài khoản !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtmatkhau.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //kết nói sql
            DataTable dt = themxoasua.docdulieu("Select * from ThuThu where Username = '" + txttaikhoan.Text + "' and Password = '" + txtmatkhau.Text + "'");
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Xin chào: " + txttaikhoan.Text + "!\nBạn đã đăng nhập thành công!", "Thông báo");
                this.Hide();
                Form main = new frmMain();
                main.Show();
            }

            else
            {
                MessageBox.Show("Đăng nhập không thành công!", "Thông báo");
                txttaikhoan.Clear();
                txtmatkhau.Clear();
                txttaikhoan.Focus();
            }
        }

        private void txtClose_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
                Application.Exit();
            else if (dialog == DialogResult.No)
            {
                //
            }
        }
    }
}
