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
    public partial class frmPhieuMuon : Form
    {
        public DateTime date1, date2;
        public TimeSpan time;
        public int day;
        public frmPhieuMuon()
        {
            InitializeComponent();
        }
        themxoasua t = new themxoasua(); public int dem;
        private void loaddata()
        {
            DataTable dt = t.docdulieu("select * from PhieuMuon");
            //l.Text = dt.Rows.Count.ToString();
            loadcombo();
            if (dt != null)
            {
                dgv_PhieuMuon.DataSource = dt;
            }
            dgv_PhieuMuon.Columns[0].HeaderText = "Mã phiếu mượn";
            dgv_PhieuMuon.Columns[1].HeaderText = "Ngày Mượn";
            dgv_PhieuMuon.Columns[2].HeaderText = "Ngày Trả";
            dgv_PhieuMuon.Columns[3].HeaderText = "Mã độc giả";
            dgv_PhieuMuon.Columns[4].HeaderText = "Mã nhân viên";
            dgv_PhieuMuon.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            btnxoa.Enabled = true;
            btnsua.Text = "Sửa";
            btnthem.Enabled = true;
            btnsua.Enabled = true;
            btnxoa.Enabled = true;
            btnluu.Enabled = false;
            dgv_PhieuMuon.Enabled = true;
        }
        private void loadcombo()
        {
            DataTable dt = t.docdulieu("select * from DocGia");
            DataTable dt1 = t.docdulieu("select * from ThuThu");
            DataTable dt2 = t.docdulieu("select * from PhieuMuon");
            DataTable dt3 = t.docdulieu("select * from CuonSach");
            comdocgia.DataSource = dt;
            comdocgia.DisplayMember = "TenDG";
            comdocgia.ValueMember = "MaDG";

            comnhanvien.DataSource = dt1;
            comnhanvien.DisplayMember = "TenTT";
            comnhanvien.ValueMember = "MaTT";

            commaphieumuon.DataSource = dt2;
            commaphieumuon.DisplayMember = "MaPM";
            commaphieumuon.ValueMember = "MaPM";

            commasach.DataSource = dt3;
            commasach.DisplayMember = "MaCS";
            commasach.ValueMember = "MaCS";
        }

        private void frmPhieuMuon_Load(object sender, EventArgs e)
        {
            loaddata();
            loaddata1();
        }

        private void dgv_PhieuMuon_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            if (dgv != null && dgv.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgv.SelectedRows[0];
                if (row != null)
                {
                    txtmaphieu.Text = row.Cells[0].Value.ToString();
                    datengaymuon.Text = row.Cells[1].Value.ToString();
                    datengaytra.Text = row.Cells[2].Value.ToString();
                    comdocgia.Text = row.Cells[3].Value.ToString();
                    comnhanvien.Text = row.Cells[4].Value.ToString();
                  
                }
            }
        }

        private void dgv_CTPhieuMuon_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            if (dgv != null && dgv.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgv.SelectedRows[0];
                if (row != null)
                {
                    commaphieumuon.Text = row.Cells[0].Value.ToString();
                    commasach.Text = row.Cells[1].Value.ToString();                 
                    txtghichu.Text = row.Cells[2].Value.ToString();
                }
            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            DataTable dt = t.docdulieu("select * from PhieuMuon");

            dem = dt.Rows.Count;
            dem = dem + 1;
            txtmaphieu.Text = dem.ToString();
            //l.Text = dt.Rows.Count.ToString();
            btnluu.Enabled = true;
            //sua.Enabled = false;
            btnxoa.Enabled = false;
            btnsua.Text = "hủy";
            btnthem.Enabled = false;
            dgv_PhieuMuon.Enabled = false;
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new frmMain();
            f.Show();
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            string ngaymuon = datengaymuon.Value.ToString("yyyy/MM/dd");
            string ngaytra = datengaytra.Value.ToString("yyyy/MM/dd");
            date1 = Convert.ToDateTime(datengaymuon.Text);//lấy thông tin ngày mượn ngày trả để kiêm tra đk ngày mượn<=ngày trả.
            date2 = Convert.ToDateTime(datengaytra.Text);
            time = date2.Subtract(date1);
            day = time.Days;
             if (day < 0)
            {
                MessageBox.Show("Lỗi, ngày hẹn trả không hợp lý", "Thông báo");
                datengaytra.Focus();
            }
            if (t.thucthidulieu("exec Insert_PM '"+dem+"','"+ ngaymuon + "','"+ ngaytra + "','"+comdocgia.SelectedValue.ToString()+"','"+comnhanvien.SelectedValue.ToString()+"'") == true)
            {
                MessageBox.Show("Thêm thành công");
                loaddata();
            }
            else
            {
                MessageBox.Show("Lỗi không thể thêm");
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
                dgv_PhieuMuon.Enabled = true;
            }
            else
            {
                string ngaymuon = datengaymuon.Value.ToString("yyyy/MM/dd");
                string ngaytra = datengaytra.Value.ToString("yyyy/MM/dd");
                date1 = Convert.ToDateTime(datengaymuon.Text);//lấy thông tin ngày mượn ngày trả để kiêm tra đk ngày mượn<=ngày trả.
                date2 = Convert.ToDateTime(datengaytra.Text);
                time = date2.Subtract(date1);
                day = time.Days;
                if (day < 0)
                {
                    MessageBox.Show("Lỗi, ngày hẹn trả không hợp lý", "Thông báo");
                    datengaytra.Focus();
                }
                if (comdocgia.Text == "")
                {
                    MessageBox.Show("Chưa chọn mã độc giả");
                }
                else if (comnhanvien.Text == "")
                {
                    MessageBox.Show("Chưa nhập địa chỉ");
                }
                else if (t.thucthidulieu("update PhieuMuon set NgayMuon=CAST(N'"+ngaymuon+"' AS Date), NgayTra =CAST(N'"+ngaytra+"' AS Date), MaDG = N'"+comdocgia.SelectedValue.ToString()+"', MaTT = N'"+comnhanvien.SelectedValue.ToString()+"' where MaPM = '"+txtmaphieu.Text+"'") == true)
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
                dgv_PhieuMuon.Enabled = true;
            }
            else
            {
                DialogResult chon = MessageBox.Show("Bạn có muốn xóa nhân viên có mã số " + txtmaphieu.Text + "", "thông báo", MessageBoxButtons.YesNo);
                if (chon == DialogResult.Yes)
                {
                    try
                    {
                       if( t.thucthidulieu("delete from PhieuMuon where MaPM='" + txtmaphieu.Text + "'"))

                            MessageBox.Show("Xóa thành Công", "Thông báo");
                       else
                            MessageBox.Show("Lỗi không thể xóa dữ liệu", "Thông báo");
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

        private void btnthemct_Click(object sender, EventArgs e)
        {
            
            btnluuct.Enabled = true;

            btnxoact.Enabled = false;
            btnsuact.Text = "hủy";
            btnthemct.Enabled = false;
            dgv_CTPhieuMuon.Enabled = false;
        }

        private void btnluuct_Click(object sender, EventArgs e)
        {
              
            time = date2.Subtract(date1);
            day = time.Days;
            DataTable dt = t.docdulieu("select * from ChiTietMuon where MaCS= N'" + commasach.Text + "'");

            if (dt.Rows.Count == 1)
            {
                MessageBox.Show("Sách đã được mượn, vui lòng chọn cuốn khác", "Thông báo");
                commasach.Focus();
            }
           
            else if (t.thucthidulieu("INSERT INTO ChiTietMuon VALUES ( N'" + commaphieumuon.SelectedValue.ToString()+"','"+commasach.SelectedValue.ToString()+"',N'"+txtghichu.Text+"')") == true)
            {
                MessageBox.Show("Thêm thành công");
                loaddata1();
            }
            else
            {
                MessageBox.Show("Lỗi không thể thực hiện được");
            }
        }

        private void btnxoact_Click(object sender, EventArgs e)
        {
            if (btnxoact.Text == "hủy")
            {
                btnluuct.Enabled = false;
                btnsuact.Enabled = true;
                btnxoact.Enabled = true;
                btnxoact.Text = "Trả sách";
                btnsuact.Text = "Sửa";
                btnthemct.Enabled = true;
                loaddata1();
                dgv_CTPhieuMuon.Enabled = true;
            }
            else
            {
                DialogResult chon = MessageBox.Show("Bạn có muốn xóa trả sách có mã " + commasach.Text + "", "thông báo", MessageBoxButtons.YesNo);
                if (chon == DialogResult.Yes)
                {
                    try
                    {
                        t.thucthidulieu("delete from chitietmuon where MaCS='" + commasach.Text + "'");
                        MessageBox.Show("Đã trả sach" + commasach.Text + "", "Thông báo");
                        loaddata1();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Không thể xóa", "Thông báo");
                        throw;
                    }
                }
                else loaddata1();
            }
        }

        private void btngiahan_Click(object sender, EventArgs e)
        {
            string ngayhhh = datengaytra.Value.ToString("yyyy/MM/dd");
            date1 = Convert.ToDateTime(datengaymuon.Text);//lấy thông tin ngày mượn ngày trả để kiêm tra đk ngày mượn<=ngày trả.
            date2 = Convert.ToDateTime(datengaytra.Text);
            time = date2.Subtract(date1);
            day = time.Days;
            if (btnsua.Text == "hủy")
            {
                btnluu.Enabled = false;
                btnsua.Enabled = true;
                btnxoa.Enabled = true;
                btnxoa.Text = "Xóa";
                btnsua.Text = "Gia hạn";
                btnthem.Enabled = true;
                loaddata1();
                dgv_PhieuMuon.Enabled = true;
            }
            else if (day < 0)
            {
                MessageBox.Show("Lỗi, ngày hẹn trả không hợp lý", "Thông báo");
                datengaytra.Focus();

            }
            else if (t.thucthidulieu("update  PhieuMuon set NgayTra=CAST(N'" + ngayhhh + "' AS Date) where MaPM=N'" + txtmaphieu.Text + "'") == true)
            {

                MessageBox.Show("Gia hạn thành công");
                loaddata();


            }
            else MessageBox.Show("Không thể gia hạn sách");
        }

        private void btnsuact_Click(object sender, EventArgs e)
        {
            if (btnsuact.Text == "hủy")
            {
                btnluuct.Enabled = false;
                btnsuact.Enabled = true;
                btnxoact.Enabled = true;
                btnxoact.Text = "Xóa";
                btnsuact.Text = "Sửa";
                btnthemct.Enabled = true;
                loaddata();
                dgv_CTPhieuMuon.Enabled = true;
            }
            else
            {
                if (commaphieumuon.Text == "")
                {
                    MessageBox.Show("Chưa chọn mã phiếu mượn");
                }
                else if (commasach.Text == "")
                {
                    MessageBox.Show("Chưa chọn sách");
                }
                else if (t.thucthidulieu("update  ChiTietMuon set TinhTrang=N'"+txtghichu.Text+"' where MaPM=N'"+commaphieumuon.SelectedValue.ToString()+"'") == true)
                {
                    MessageBox.Show("Cập nhật dữ liệu thành công");
                    loaddata1();
                }
                else MessageBox.Show("Không thể cập nhật dữ liệu");
            }
        }

        private void loaddata1()
        {
            DataTable dt = t.docdulieu("select * from ChiTietMuon");
            l.Text = dt.Rows.Count.ToString();
            //l.Text = dt.Rows.Count.ToString();
            //loadcombo();
            if (dt != null)
            {
                dgv_CTPhieuMuon.DataSource = dt;
            }
            dgv_CTPhieuMuon.Columns[0].HeaderText = "Mã phiếu mượn";
            dgv_CTPhieuMuon.Columns[1].HeaderText = "Mã sách";
       
            dgv_CTPhieuMuon.Columns[2].HeaderText = "Ghi chú";


            btnxoact.Enabled = true;
            btnsuact.Text = "Sửa";
            btnthemct.Enabled = true;
            btnsuact.Enabled = true;
            btnxoact.Enabled = true;
            btnluuct.Enabled = false;
            dgv_CTPhieuMuon.Enabled = true;

        }
    }
}
