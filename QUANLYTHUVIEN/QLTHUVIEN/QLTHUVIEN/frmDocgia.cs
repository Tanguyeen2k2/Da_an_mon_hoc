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
    public partial class frmDocgia : Form
    {
        
        public frmDocgia()
        {
            InitializeComponent();
        }
        themxoasua t = new themxoasua();
        private void loaddata()
        {
            DataTable dt = t.docdulieu("select * from DocGia");
            l.Text = dt.Rows.Count.ToString();

            if (dt != null)
            {
                dgv_DocGia.DataSource = dt;
            }
            dgv_DocGia.Columns[0].HeaderText = "Mã độc giả";
            dgv_DocGia.Columns[1].HeaderText = "Họ và tên";
            dgv_DocGia.Columns[2].HeaderText = "Ngày sinh";
            dgv_DocGia.Columns[3].HeaderText = "Giới tính";
            dgv_DocGia.Columns[4].HeaderText = "Địa chỉ";
            dgv_DocGia.Columns[5].HeaderText = "SDT";

            dgv_DocGia.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
            btnxoa.Enabled = true;
            btnsua.Text = "Sửa";
            btnthem.Enabled = true;
            btnsua.Enabled = true;
            btnxoa.Enabled = true;
            btnluu.Enabled = false;
            dgv_DocGia.Enabled = true;

        }

        private void dgv_DocGia_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            if (dgv != null && dgv.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgv.SelectedRows[0];
                if (row != null)
                {
                    txtmadocgia.Text = row.Cells[0].Value.ToString();
                    txttendocgia.Text = row.Cells[1].Value.ToString();
                    date_ngaysinh.Text = row.Cells[2].Value.ToString();
                    comgioitinh.Text = row.Cells[3].Value.ToString();
                    txtdiachi.Text = row.Cells[4].Value.ToString();
                    txtSDT.Text = row.Cells[5].Value.ToString();
                }
            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            txtmadocgia.Text = "";
            txttendocgia.Text = "";
            btnluu.Enabled = true;
            //sua.Enabled = false;
            btnxoa.Enabled = false;
            btnsua.Text = "hủy";
            btnthem.Enabled = false;
            dgv_DocGia.Enabled = false;
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            string ngayhh = date_ngaysinh.Value.ToString("yyyy/MM/dd");

            if (txtmadocgia.Text == "")
            {
                MessageBox.Show("Chưa nhập mã độc giả");
                txtmadocgia.Focus();
            }
            else if (txttendocgia.Text == "")
            {
                MessageBox.Show("Chưa nhập tên độc giả");
                txttendocgia.Focus();
            }
            else if (txtdiachi.Text == "")
            {
                MessageBox.Show("Chưa nhập địa chỉ");
                txtdiachi.Focus();
            }
            else if (t.thucthidulieu("INSERT INTO DocGia VALUES (N'" + txtmadocgia.Text + "',N'" +txttendocgia.Text + "',CAST(N'" + ngayhh + "' AS Date),N'" +comgioitinh.Text+ "',N'" + txtdiachi.Text + "','" + txtSDT.Text + "')") == true)
            {
                MessageBox.Show("Thêm thành công");
                loaddata();
            }
            else MessageBox.Show("Lỗi trùng khhóa");


        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string ngayhh = date_ngaysinh.Value.ToString("yyyy/MM/dd");

            if (btnsua.Text == "hủy")
            {
                btnluu.Enabled = false;
                btnsua.Enabled = true;
                btnxoa.Enabled = true;
                btnxoa.Text = "Xóa";
                btnsua.Text = "Sửa";
                btnthem.Enabled = true;
                loaddata();
                dgv_DocGia.Enabled = true;
            }
            else
            {
                if (txttendocgia.Text == "")
                {
                    txttendocgia.Focus();

                }
                else if (txtdiachi.Text == "")
                {
                    MessageBox.Show("Chưa nhập địa chỉ");
                    txtdiachi.Focus();
                }
                else if (t.thucthidulieu("update  DocGia set TenDG=N'" + txttendocgia.Text + "', NgaySinh=N'" + ngayhh + "', GioiTinh=N'" + comgioitinh.Text + "', DiaChi=N'" + txtdiachi.Text + "', SDT='" + txtSDT.Text + "'where MaDG=N'" + txtmadocgia.Text + "'") == true)
                {
                    MessageBox.Show("Cập nhật dữ liệu thành công");
                    loaddata();
                }
                else MessageBox.Show("Không thể cập nhật dữ liệu");
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
                dgv_DocGia.Enabled = true;
            }
            else
            {
                DialogResult chon = MessageBox.Show("Bạn có muốn xóa độc giả có mã số " + txtmadocgia.Text + "", "thông báo", MessageBoxButtons.YesNo);
                if (chon == DialogResult.Yes)
                {
                    try
                    {
                        if (t.thucthidulieu("delete from DocGia where MaDG='" + txtmadocgia.Text + "'") == true)
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

        private void frmDocgia_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new frmMain();
            f.Show();
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
