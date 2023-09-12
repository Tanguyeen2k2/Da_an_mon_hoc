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
    public partial class frmtheloai : Form
    {
        public frmtheloai()
        {
            InitializeComponent();
        }
        themxoasua t = new themxoasua();
        private void loaddata()
        {
            DataTable dt = t.docdulieu("select * from TheLoai");

            if (dt != null)
            {
                dgv_theloai.DataSource = dt;
            }
            dgv_theloai.Columns[0].HeaderText = "Mã thể loại";
            dgv_theloai.Columns[1].HeaderText = "Tên thể loại";
            dgv_theloai.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
            btnXoa.Enabled = true;
            btnSua.Text = "Sửa";
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
            dgv_theloai.Enabled = true;

        }
        private void frmtheloai_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        private void dgv_theloai_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            if (dgv != null && dgv.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgv.SelectedRows[0];
                if (row != null)
                {
                    txtmatheloai.Text = row.Cells[0].Value.ToString();
                    txttentheloai.Text = row.Cells[1].Value.ToString();
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtmatheloai.Text = "";
            txttentheloai.Text = "";
            btnLuu.Enabled = true;
            //sua.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Text = "hủy";
            btnThem.Enabled = false;
            dgv_theloai.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (btnSua.Text == "hủy")
            {
                btnLuu.Enabled = false;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnXoa.Text = "Xóa";
                btnSua.Text = "Sửa";
                btnThem.Enabled = true;
                loaddata();
                dgv_theloai.Enabled = true;


            }
            else
            {
                ///them.Enabled = false;
                /// sua.Text = "Cập nhật";
                ///xoa.Text = "hủy";

                if (txtmatheloai.Text == "")
                {
                    MessageBox.Show("Chưa nhập mã thể loại");
                    txtmatheloai.Focus();

                }
                else if (txttentheloai.Text == "")
                {
                    MessageBox.Show("Chưa nhập tên thể loại");
                    txttentheloai.Focus();


                }
                else if (t.thucthidulieu("update  TheLoai set TenLoai=N'" + txttentheloai.Text + "'where MaLoai=N'" + txtmatheloai.Text + "'") == true)
                {

                    MessageBox.Show("Cập nhật dữ liệu thành công");
                    loaddata();


                }
                else MessageBox.Show("Không thể cập nhật dữ liệu");


            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtmatheloai.Text == "")
            {
                MessageBox.Show("Chưa nhập mã thể loại");
                txtmatheloai.Focus();

            }
            else if (txttentheloai.Text == "")
            {
                MessageBox.Show("Chưa nhập tên thể loại");
                txttentheloai.Focus();

            }
            else if (t.thucthidulieu("INSERT INTO TheLoai VALUES (N'" + txtmatheloai.Text + "', '" + txttentheloai.Text + "')") == true)
            {

                MessageBox.Show("Thêm thành công");
                loaddata();
            }
            else MessageBox.Show("Lỗi");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (btnXoa.Text == "hủy")
            {
                btnLuu.Enabled = false;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnXoa.Text = "Xóa";
                btnSua.Text = "Sửa";
                btnThem.Enabled = true;
                loaddata();
                dgv_theloai.Enabled = true;
            }
            else
            {
                DialogResult chon = MessageBox.Show("Bạn có muốn xóa " + txtmatheloai.Text + "", "thông báo", MessageBoxButtons.YesNo);
                if (chon == DialogResult.Yes)
                {
                    try
                    {
                        t.thucthidulieu("delete from TheLoai where MaLoai='" + txtmatheloai.Text + "'");
                        MessageBox.Show("Xóa thành Công", "Thông báo");
                        loaddata();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Không thể xóa", "Thông báo");
                        throw;
                    }
                }
                else
                { 
                    loaddata(); 
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new frmMain();
            f.Show();
        }
    }
}
