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
    public partial class frmTacgia : Form
    {
        public frmTacgia()
        {
            InitializeComponent();
        }
        themxoasua t = new themxoasua();
        private void loaddata()
        {
            DataTable dt = t.docdulieu("select * from tacgia");

            if (dt != null)
            {
                dgv_TacGia.DataSource = dt;
            }
            dgv_TacGia.Columns[0].HeaderText = "Mã tác giả";
            dgv_TacGia.Columns[1].HeaderText = "Tên tác giả";
            dgv_TacGia.Columns[2].HeaderText = "Ngày sinh";
            dgv_TacGia.Columns[3].HeaderText = "Giới tính";
            dgv_TacGia.Columns[4].HeaderText = "Quê quán";
            dgv_TacGia.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
            btnxoa.Enabled = true;
            btnsua.Text = "Sửa";
            btnthem.Enabled = true;
            btnsua.Enabled = true;
            btnxoa.Enabled = true;
            btnluu.Enabled = false;
            dgv_TacGia.Enabled = true;
        }

        private void frmTacgia_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        private void dgv_TacGia_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            if (dgv != null && dgv.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgv.SelectedRows[0];
                if (row != null)
                {
                    txtmatacgia.Text = row.Cells[0].Value.ToString();
                    txttentacgia.Text = row.Cells[1].Value.ToString();
                    datengaysinhtg.Text = row.Cells[2].Value.ToString();
                    comgioitinh.Text = row.Cells[3].Value.ToString();
                    txtquequan.Text = row.Cells[4].Value.ToString();
                }
            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            txtmatacgia.Text = "";
            txttentacgia.Text = "";
            btnluu.Enabled = true;
            //sua.Enabled = false;
            btnxoa.Enabled = false;
            btnsua.Text = "hủy";
            btnthem.Enabled = false;
            dgv_TacGia.Enabled = false;
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
                dgv_TacGia.Enabled = true;


            }
            else
            {
                string ngayhh = datengaysinhtg.Value.ToString("yyyy/MM/dd");

                if (txtmatacgia.Text == "")
                {
                    MessageBox.Show("Chưa nhập mã tác giả");
                    txtmatacgia.Focus();
                }
                else if (txttentacgia.Text == "")
                {
                    MessageBox.Show("Chưa nhập tên tác giả");
                    txttentacgia.Focus();

                }
                else if (t.thucthidulieu("update  tacgia set TenTG=N'" + txttentacgia.Text + "',NgaySinh=CAST(N'" + ngayhh + "' AS Date),GioiTinh=N'"+comgioitinh.Text+"',QueQuan=N'"+txtquequan.Text+"' where MaTG=N'" + txtmatacgia.Text + "'") == true)
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
                dgv_TacGia.Enabled = true;
            }
            else
            {
                DialogResult chon = MessageBox.Show("Bạn có muốn xóa " + txtmatacgia.Text + "", "thông báo", MessageBoxButtons.YesNo);
                if (chon == DialogResult.Yes)
                {
                    try
                    {
                        if (t.thucthidulieu("delete from tacgia where maTG='" + txtmatacgia.Text + "'") == true)
                            MessageBox.Show("Xóa thành Công", "Thông báo");
                        else MessageBox.Show("Không thể xóa", "Thông báo");
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

        private void btnluu_Click(object sender, EventArgs e)
        {
            string ngayhh = datengaysinhtg.Value.ToString("yyyy/MM/dd");
            if (txtmatacgia.Text == "")
            {
                MessageBox.Show("Chưa nhập mã tác giả");
                txtmatacgia.Focus();
            }
            else if (txttentacgia.Text == "")
            {
                MessageBox.Show("Chưa nhập tên tác giả");
                txttentacgia.Focus();
            }
            else if (t.thucthidulieu("INSERT INTO tacgia VALUES (N'" + txtmatacgia.Text + "', '" + txttentacgia.Text + "',CAST(N'"+ngayhh+"' AS Date),N'"+comgioitinh.Text+"',N'"+txtquequan.Text+"')") == true)
            {
                MessageBox.Show("Thêm thành công");
                loaddata();
            }
            else MessageBox.Show("Lỗi");
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new frmMain();
            f.Show();
        }
    }
}
