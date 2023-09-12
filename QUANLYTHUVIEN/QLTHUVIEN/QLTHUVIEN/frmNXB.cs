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
    public partial class frmNXB : Form
    {
        public frmNXB()
        {
            InitializeComponent();
        }
        themxoasua t = new themxoasua();
        private void loaddata()
        {
            DataTable dt = t.docdulieu("select * from NXB");

            if (dt != null)
            {
                dgv_NXB.DataSource = dt;
            }
            dgv_NXB.Columns[0].HeaderText = "Mã nhà XB";
            dgv_NXB.Columns[1].HeaderText = "Tên nhà XB";
            dgv_NXB.Columns[2].HeaderText = "Địa chỉ";
            dgv_NXB.Columns[3].HeaderText = "Điện thoại";
            dgv_NXB.Columns[4].HeaderText = "Email";
            dgv_NXB.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
            btnxoa.Enabled = true;
            btnsua.Text = "Sửa";
            btnthem.Enabled = true;
            btnsua.Enabled = true;
            btnxoa.Enabled = true;
            btnluu.Enabled = false;
            dgv_NXB.Enabled = true;

        }

        private void frmNXB_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        private void dgv_NXB_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            if (dgv != null && dgv.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgv.SelectedRows[0];
                if (row != null)
                {
                    txtmanhaxb.Text = row.Cells[0].Value.ToString();
                    txttennhaxb.Text = row.Cells[1].Value.ToString();
                    txtdiachi.Text = row.Cells[2].Value.ToString();
                    txtphone.Text = row.Cells[3].Value.ToString();
                    txtEmail.Text = row.Cells[4].Value.ToString();
                }
            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            txtmanhaxb.Text = "";
            txttennhaxb.Text = "";
            txtdiachi.Text = "";
            txtphone.Text = "";
            txtEmail.Text = "";
            btnluu.Enabled = true;
            btnxoa.Enabled = false;
            btnsua.Text = "hủy";
            btnthem.Enabled = false;
            dgv_NXB.Enabled = false;
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (txtmanhaxb.Text == "")
            {
                MessageBox.Show("Chưa nhập mã nhà xuất bản");
                txtmanhaxb.Focus();
            }
            else if (txttennhaxb.Text == "")
            {
                MessageBox.Show("Chưa nhập tên nhà xuất bản");
                txttennhaxb.Focus();
            }
            else if (txtdiachi.Text == "")
            {
                MessageBox.Show("Chưa nhập địa chỉ");
                txtdiachi.Focus();
            }
            else if (txtphone.Text == "")
            {
                MessageBox.Show("Chưa nhập số điện thoại");
                txtphone.Focus();
            }
            else if (txtEmail.Text == "")
            {
                MessageBox.Show("Chưa nhập số điện thoại");
                txtEmail.Focus();
            }
            else if (t.thucthidulieu("INSERT INTO NXB VALUES (N'" + txtmanhaxb.Text + "','" + txttennhaxb.Text + "',N'" + txtdiachi.Text + "','" + txtphone.Text + "','" + txtEmail.Text +"')") == true)
            {
                MessageBox.Show("Thêm thành công");
                loaddata();
            }
            else MessageBox.Show("Lỗi");
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (btnsua.Text == "hủy")
            {
                btnluu.Enabled = false;
                btnsua.Enabled = true;
                btnxoa.Enabled = true;
                btnxoa.Text = "Xóa";
                btnsua.Text = "Sửa";
                btnthem.Enabled = true;
                loaddata();
                dgv_NXB.Enabled = true;
            }
            else
            {
                if (txttennhaxb.Text == "")
                {
                    MessageBox.Show("Nhà xuất bản chưa có thông tin");
                    txttennhaxb.Focus();
                }
                else if (txtdiachi.Text == "")
                {
                    MessageBox.Show("Chưa nhập địa chỉ");
                    txtdiachi.Focus();
                }
                else if (t.thucthidulieu("update  NXB set TenNXB=N'" + txttennhaxb.Text + "', DiaChi=N'" + txtdiachi.Text + "', SDT='" + txtphone.Text + "', Email='" + txtEmail.Text + "'where manxb=N'" + txtmanhaxb.Text + "'") == true)
                {
                    MessageBox.Show("Cập nhật dữ liệu thành công");
                    loaddata();
                }
                else MessageBox.Show("Không thể cập nhật dữ liệu");
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new frmMain();
            f.Show();
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
                dgv_NXB.Enabled = true;

            }
            else
            {
                DialogResult chon = MessageBox.Show("Bạn có muốn xóa " + txtmanhaxb.Text + "", "thông báo", MessageBoxButtons.YesNo);
                if (chon == DialogResult.Yes)
                {
                    try
                    {
                        if (t.thucthidulieu("delete from NXB where MaNXB='" + txtmanhaxb.Text + "'") == true)
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

        private void txtphone_KeyPress(object sender, KeyPressEventArgs e)
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
