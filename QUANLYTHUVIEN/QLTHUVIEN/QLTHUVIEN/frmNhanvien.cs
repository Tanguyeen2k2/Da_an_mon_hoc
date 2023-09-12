using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QLTHUVIEN
{
    public partial class frmNhanvien : Form
    {
        public frmNhanvien()
        {
            InitializeComponent();
        }
        themxoasua t = new themxoasua();

        private void thoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new frmMain();
            f.Show();
        }
        private void loaddata()
        {
            DataTable dt = t.docdulieu("select * from ThuThu");
            l.Text = dt.Rows.Count.ToString();

            if (dt != null)
            {
                dgv_NhanVien.DataSource = dt;
            }
            dgv_NhanVien.Columns[0].HeaderText = "Mã nhân viên";
            dgv_NhanVien.Columns[1].HeaderText = "Họ và tên";
            dgv_NhanVien.Columns[2].HeaderText = "Ngày sinh";
            dgv_NhanVien.Columns[3].HeaderText = "Giới tính";
            dgv_NhanVien.Columns[4].HeaderText = "Địa chỉ";
            dgv_NhanVien.Columns[5].HeaderText = "Điện thoại";
            dgv_NhanVien.Columns[6].HeaderText = "Chức vụ";
            dgv_NhanVien.Columns[7].HeaderText = "Username";
            dgv_NhanVien.Columns[8].HeaderText = "Password";

            dgv_NhanVien.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
            btnxoa.Enabled = true;
            btnsua.Text = "Sửa";
            btnthem.Enabled = true;
            btnsua.Enabled = true;
            btnxoa.Enabled = true;
            btnluu.Enabled = false;
            dgv_NhanVien.Enabled = true;

        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            txtmanhanvien.Text = "";
            txttennhanvien.Text = "";
            txtdiachi.Text = "";
            txtdienthoai.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";
            btnluu.Enabled = true;
            //sua.Enabled = false;
            btnxoa.Enabled = false;
            btnsua.Text = "hủy";
            btnthem.Enabled = false;
            dgv_NhanVien.Enabled = false;
        }

        private void frmNhanvien_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        private void dgv_NhanVien_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            if (dgv != null && dgv.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgv.SelectedRows[0];
                if (row != null)
                {
                    txtmanhanvien.Text = row.Cells[0].Value.ToString();
                    txttennhanvien.Text = row.Cells[1].Value.ToString();
                    datengaysinh.Text = row.Cells[2].Value.ToString();
                    comgioitinh.Text = row.Cells[3].Value.ToString();
                    txtdiachi.Text = row.Cells[4].Value.ToString();
                    txtdienthoai.Text = row.Cells[5].Value.ToString();
                    comchucvu.Text = row.Cells[6].Value.ToString();
                    txtUsername.Text = row.Cells[7].Value.ToString();
                    txtPassword.Text = row.Cells[8].Value.ToString();
                }
            }
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            string ngayhh = datengaysinh.Value.ToString("yyyy/MM/dd");
            if (txtmanhanvien.Text == "")
            {
                MessageBox.Show("Chưa nhập mã nhân viên");
                txtmanhanvien.Focus();
            }
            else if (txttennhanvien.Text == "")
            {
                MessageBox.Show("Chưa nhập tên nhân viên");
                txttennhanvien.Focus();
            }
            else if (txtdiachi.Text == "")
            {
                MessageBox.Show("Chưa nhập địa chỉ");
                txtdiachi.Focus();
            }
            else if (txtdienthoai.Text == "")
            {
                MessageBox.Show("Chưa nhập điện thoại");
                txtdienthoai.Focus();
            }
            else if (txtUsername.Text == "")
            {
                MessageBox.Show("Chưa nhập username");
                txtUsername.Focus();
            }
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("Chưa nhập password");
                txtPassword.Focus();
            }
            else if (t.thucthidulieu("INSERT INTO ThuThu(MaTT,TenTT,NgaySinh,GioiTinh,DiaChi,SDT,Chucvu,username,password) VALUES ('" + txtmanhanvien.Text + "',N'" + txttennhanvien.Text + "',CAST(N'" + ngayhh + "' AS Date),N'" + comgioitinh.Text + "',N'" + txtdiachi.Text + "','" + txtdienthoai.Text + "','" + comchucvu.Text + "','" + txtUsername.Text + "','" + txtPassword.Text + "')") == true)
            {
                MessageBox.Show("Thêm thành công");
                loaddata();
            }
            else
            {
                MessageBox.Show("Lỗi trùng khhóa");
                txtmanhanvien.Focus();
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (btnxoa.Text == "hủy")
            {
                btnluu.Enabled = false;
                btnsua.Enabled = true;
                btnxoa.Enabled = true;
                btnxoa.Text = "Xóa";
                btnsua.Text = "Sửa";
                btnthem.Enabled = true;
                loaddata();
                dgv_NhanVien.Enabled = true;
            }
            else
            {
                DialogResult chon = MessageBox.Show("Bạn có muốn xóa nhân viên có mã số " + txtmanhanvien.Text + "", "thông báo", MessageBoxButtons.YesNo);
                if (chon == DialogResult.Yes)
                {
                    try
                    {
                        if (t.thucthidulieu("delete from ThuThu where MaTT='" + txtmanhanvien.Text + "'") == true)
                            MessageBox.Show("Xóa thành Công", "Thông báo");
                        else MessageBox.Show("Lỗi không thể xóa dữ liệu", "Thông báo");
                        loaddata();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Không thể xóa", "Thông báo");
                        throw;
                    }
                }
                else loaddata();
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string ngayhh = datengaysinh.Value.ToString("yyyy/MM/dd");

            if (btnsua.Text == "hủy")
            {
                btnluu.Enabled = false;
                btnsua.Enabled = true;
                btnxoa.Enabled = true;
                btnxoa.Text = "Xóa";
                btnsua.Text = "Sửa";
                btnthem.Enabled = true;
                loaddata();
                dgv_NhanVien.Enabled = true;
            }
            else
            {
                if (txttennhanvien.Text == "")
                {
                    MessageBox.Show("Chưa nhập địa chỉ");
                    txttennhanvien.Focus();

                }
                else if (txtdiachi.Text == "")
                {
                    MessageBox.Show("Chưa nhập địa chỉ");
                    txtdiachi.Focus();
                }
                else if (txtdienthoai.Text == "")
                {
                    MessageBox.Show("Chưa nhập số điện thoại");
                    txtdienthoai.Focus();
                }
                else if (txtUsername.Text == "")
                {
                    MessageBox.Show("Chưa nhập username");
                    txtdienthoai.Focus();
                }
                else if (txtPassword.Text == "")
                {
                    MessageBox.Show("Chưa nhập password");
                    txtdienthoai.Focus();
                }
                else if (t.thucthidulieu("update  ThuThu set TenTT=N'" + txttennhanvien.Text + "', NgaySinh=CAST(N'" + ngayhh + "' AS Date), DiaChi=N'" + txtdiachi.Text + "', SDT='" + txtdienthoai.Text + "', username='" + txtUsername.Text + "', password='" + txtPassword.Text + "'where MaTT=N'" + txtmanhanvien.Text + "'") == true)
                {
                    MessageBox.Show("Cập nhật dữ liệu thành công");
                    loaddata();
                }
                else MessageBox.Show("Không thể cập nhật dữ liệu");
            }
        }

        private void txtdienthoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Xác thực rằng phím vừa nhấn không phải CTRL hoặc không phải dạng số
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            // Nếu bạn muốn, bạn có thể cho phép nhập số thực với dấu chấm
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btnShowPass_MouseDown(object sender, MouseEventArgs e)
        {
            txtPassword.PasswordChar = (char)0;
        }

        private void btnShowPass_MouseUp(object sender, MouseEventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }
    }
}
