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
    public partial class frmSach : Form
    {
        public frmSach()
        {
            InitializeComponent();
        }
        themxoasua t = new themxoasua();
        private void loaddata()
        {
            DataTable dt = t.docdulieu("select * from TuaSach");

            if (dt != null)
            {
                dgv_Sach.DataSource = dt;
            }
            dgv_Sach.Columns[0].HeaderText = "Mã sách ";
            


            dgv_Sach.Columns[1].HeaderText = "Tên sách";
            dgv_Sach.Columns[2].HeaderText = "Năm xuất bản";
            dgv_Sach.Columns[3].HeaderText = "Mã nhà xuất bản";
            dgv_Sach.Columns[4].HeaderText = "Mã thể loại";
            dgv_Sach.Columns[5].HeaderText = "Mã tác giả";
            dgv_Sach.Columns[6].HeaderText = "Số lượng";
            dgv_Sach.Columns[7].HeaderText = "Số trang";
            dgv_Sach.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
            btnxoa.Enabled = true;
            btnsua.Text = "Sửa";
            btnthem.Enabled = true;
            btnsua.Enabled = true;
            btnxoa.Enabled = true;
            btnluu.Enabled = false;
            dgv_Sach.Enabled = true;

        }
        
        private void loaddata3()
        {
            DataTable dt = t.docdulieu("select * from CuonSach");
            //l.Text = dt.Rows.Count.ToString();
            loadcombo1();
            if (dt != null)
            {
                dgv_CS.DataSource = dt;
            }
            dgv_CS.Columns[0].HeaderText = "Mã Cuốn sách";
            dgv_CS.Columns[1].HeaderText = "Mã tựa sách";

            dgv_CS.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            btnxoa.Enabled = true;
            btnsua.Text = "Sửa";
            btnthem.Enabled = true;
            btnsua.Enabled = true;
            btnxoa.Enabled = true;
            btnluu.Enabled = false;
            dgv_CS.Enabled = true;
        }
        private void loadcombo1()
        {
            DataTable dt = t.docdulieu("select * from TuaSach");          

            comTS.DataSource = dt;
            comTS.DisplayMember = "TenTS";
            comTS.ValueMember = "MaTS";
            //comnhaxb.DisplayMember = "tennxb";
            //comnhaxb.ValueMember = "manxb";
           

        }

        private void loadcombo()
        {
            DataTable dt = t.docdulieu("select * from NXB");
            DataTable dt1 = t.docdulieu("select * from TheLoai");
            DataTable dt2 = t.docdulieu("select * from  TacGia");


            comnhaxb.DataSource = dt;
            comnhaxb.DisplayMember = "TenNXB";
            comnhaxb.ValueMember = "MaNXB";
            //comnhaxb.DisplayMember = "tennxb";
            //comnhaxb.ValueMember = "manxb";
            comtheloai.DataSource = dt1;

            comtheloai.DisplayMember = "tenloai";
            comtheloai.ValueMember = "maloai";
            commatacgia.DataSource = dt2;

            commatacgia.DisplayMember = "TenTG";
            commatacgia.ValueMember = "MaTG";

        }

        private void frmSach_Load(object sender, EventArgs e)
        {
            loaddata();
            loadcombo();
            loadcombo1();
            loaddata3();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            txtmasach.Text = "";
            txttensach.Text = "";

            btnluu.Enabled = true;
            btnxoa.Enabled = false;
            btnsua.Text = "hủy";
            btnthem.Enabled = false;
            dgv_Sach.Enabled = false;
            loadcombo();
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (txtmasach.Text == "")
            {
                MessageBox.Show("Chưa nhập mã sách");
                txtmasach.Focus();
            }
            else if (txttensach.Text == "")
            {
                MessageBox.Show("Chưa nhập tên sách");
                txttensach.Focus();
            }
            else if (txtnamxb.Text == "")
            {
                MessageBox.Show("Chưa nhập năm xuất bản");
                txtnamxb.Focus();
            }
            else if (t.thucthidulieu("INSERT INTO TuaSach VALUES (N'" + txtmasach.Text + "',N'" + txttensach.Text + "','" + txtnamxb.Text + "','" + comnhaxb.SelectedValue.ToString() + "','" + comtheloai.SelectedValue.ToString() + "','" + commatacgia.SelectedValue.ToString() + "','" + txtSoluong.Text + "','" + txtSotrang.Text + "')") == true)
            {
                MessageBox.Show("Thêm thành công");
                loaddata();
            }
            else MessageBox.Show("Lỗi");
        }

        private void txtnamxb_Enter(object sender, EventArgs e)
        {
            int n;
            try
            {
                n = int.Parse(txtnamxb.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi");

            }
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
                dgv_Sach.Enabled = true;
            }
            else
            {
                txtmasach.Enabled = false;

                if (txttensach.Text == "")
                {
                    txttensach.Focus();
                }
                else if (txtnamxb.Text == "")
                {
                    MessageBox.Show("Chưa nhập địa chỉ");
                    txtnamxb.Focus();

                    // else if (t.thucthidulieu("update  SACH set tensach=N'" + txttensach.Text + "', namxb=N'" + txtnamxb.Text + "', manxb='" + comnhaxb.Text + "', matheloai='" + comtheloai.SelectedValue.ToString() + "', matacgia='" + commatacgia.SelectedValue.ToString() + "'where masach=N'" + txtmasach.Text + "'") == true)
                }
                else if (t.thucthidulieu("update  TuaSach set tents=N'" + txttensach.Text + "', namxb=N'" + txtnamxb.Text + "', manxb='" + comnhaxb.SelectedValue.ToString() + "', maloai='" + comtheloai.SelectedValue.ToString() +  "', matg='" + commatacgia.SelectedValue.ToString() + "', soluong='" + txtSoluong.Text + "', sotrang='" + txtSotrang.Text + "'where mats=N'" + txtmasach.Text + "'") == true)
                {
                    MessageBox.Show("Cập nhật dữ liệu thành công");
                    loaddata();
                    txtmasach.Enabled = true;
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
                dgv_Sach.Enabled = true;

            }
            else
            {
                DialogResult chon = MessageBox.Show("Bạn có muốn xóa sách có mã số " + txtmasach.Text + "", "thông báo", MessageBoxButtons.YesNo);
                if (chon == DialogResult.Yes)
                {
                    try
                    {
                        t.thucthidulieu("delete from TuaSach where MaTS='" + txtmasach.Text + "'");
                        MessageBox.Show("Xóa thành Công", "Thông báo");
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

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new frmMain();
            f.Show();
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            DataTable dt5 = t.docdulieu("select * from tuasach where mats like '%" + txttimkiem.Text + "%'");
            DataTable dt6 = t.docdulieu("select * from tuasach where tents like '%" + txttimkiem.Text + "%'");
            if (ramasach.Checked == true)
            {
                dgv_Sach.DataSource = dt5;
            }
            else dgv_Sach.DataSource = dt6;
        }

        private void dgv_Sach_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            if (dgv != null && dgv.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgv.SelectedRows[0];
                if (row != null)
                {
                    txtmasach.Text = row.Cells[0].Value.ToString();
                    txttensach.Text = row.Cells[1].Value.ToString();
                    txtnamxb.Text = row.Cells[2].Value.ToString();
                    comnhaxb.Text = row.Cells[3].Value.ToString();
                    comtheloai.Text = row.Cells[4].Value.ToString();
                    commatacgia.Text = row.Cells[5].Value.ToString();
                    txtSoluong.Text = row.Cells[6].Value.ToString();
                    txtSotrang.Text = row.Cells[7].Value.ToString();

                }      
            }  
        }

        private void txtSoluong_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtSotrang_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtnamxb_KeyPress(object sender, KeyPressEventArgs e)
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
        public int dem1;
        private void btnthemcs_Click(object sender, EventArgs e)
        {
            DataTable dt = t.docdulieu("select * from CuonSach");

            dem1 = dt.Rows.Count;
            dem1 = dem1 + 1;
            txtCS.Text = dem1.ToString();
            //l.Text = dt.Rows.Count.ToString();
            btnluucs.Enabled = true;
            //sua.Enabled = false;
            btnxoacs.Enabled = false;
            btnsuacs.Text = "hủy";
            btnthemcs.Enabled = false;
            dgv_CS.Enabled = false;

            loadcombo1();
        }

        private void dgv_CS_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            if (dgv != null && dgv.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgv.SelectedRows[0];
                if (row != null)
                {
                    txtCS.Text = row.Cells[0].Value.ToString();
                    comTS.Text = row.Cells[1].Value.ToString();
                   
                }
            }
        }

        private void btnsuacs_Click(object sender, EventArgs e)
        {
            if (btnsuacs.Text == "hủy")
            {
                btnluucs.Enabled = false;
                btnsuacs.Enabled = true;
                btnxoacs.Enabled = true;
                btnxoacs.Text = "Xóa";
                btnsuacs.Text = "Sửa";
                btnthemcs.Enabled = true;
                loaddata3();
                dgv_CS.Enabled = true;
            }
            else
            {
                txtCS.Enabled = false;

                if (comTS.Text == "")
                {
                    comTS.Focus();
                }
               
                else if (t.thucthidulieu("update  CuonSach set Mats=N'" +comTS.SelectedValue.ToString()+ "'where maCS=N'" + txtCS.Text + "'") == true)
                {
                    MessageBox.Show("Cập nhật dữ liệu thành công");
                    loaddata3();
                    txtCS.Enabled = true;
                }
                else MessageBox.Show("Không thể cập nhật dữ liệu");
            }
        }

        private void btnxoacs_Click(object sender, EventArgs e)
        {
            if (btnxoacs.Text == "hủy")
            {

                btnluucs.Enabled = false;
                btnsuacs.Enabled = true;
                btnxoacs.Enabled = true;
                btnxoacs.Text = "Xóa";
                btnsuacs.Text = "Sửa";
                btnthemcs.Enabled = true;
                loaddata3();
                dgv_CS.Enabled = true;

            }
            else
            {
                DialogResult chon = MessageBox.Show("Bạn có muốn xóa sách có mã số " + txtCS.Text + "", "thông báo", MessageBoxButtons.YesNo);
                if (chon == DialogResult.Yes)
                {
                    try
                    {
                        t.thucthidulieu("delete from CuonSach where MaCS='" + txtCS.Text + "'");
                        MessageBox.Show("Xóa thành Công", "Thông báo");
                        loaddata3();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Không thể xóa", "Thông báo");
                        throw;
                    }
                }
                else loaddata3();
            }
        }

        private void btnluucs_Click(object sender, EventArgs e)
        {
            if (txtCS.Text == "")
            {
                MessageBox.Show("Chưa nhập mã cuốn sách");
                txtCS.Focus();
            }
            else if (comTS.Text == "")
            {
                MessageBox.Show("Chưa nhập tên mã tựa sách");
                comTS.Focus();
            }
           
            else if (t.thucthidulieu("INSERT INTO CuonSach VALUES (N'" + txtCS.Text + "',N'" + comTS.SelectedValue.ToString()+"')") == true)
            {
                MessageBox.Show("Thêm thành công");
                loaddata3();
            }
            else MessageBox.Show("Lỗi");
        }

        private void btnthoatcs_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new frmMain();
            f.Show();
        }
    }
}
