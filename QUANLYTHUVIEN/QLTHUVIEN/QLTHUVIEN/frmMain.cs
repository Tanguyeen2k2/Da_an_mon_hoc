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
    public partial class frmMain : Form
    {
        LoginAccount account = null;
        public frmMain()
        {
            InitializeComponent();
        }
        public void SaveData(LoginAccount loginAccount)
        {
            account = loginAccount;
        }

        private void dangXuatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            //Form m = new Formchinh();
            //m.Hide();
            Form f = new frmDangNhap();
            f.Show();
        }

        private void thoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (DialogResult == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void docGiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new frmDocgia();
            f.Show();
        }

        private void nhanVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new frmNhanvien();
            f.Show();
        }

        private void quanLySachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new frmSach();
            f.Show();
        }

        private void theLoaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new frmtheloai();
            f.Show();
        }

        private void tacGiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new frmTacgia();
            f.Show();
        }

        private void nhaXuatBanToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new frmNXB();
            f.Show();
        }

        private void muonSachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new frmPhieuMuon();
            f.Show();
        }

        private void timSachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new frmTimkiemSach();
            f.Show();
        }

        private void timDocGiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new frmTimKiemDocgia();
            f.Show();
        }

        private void thongKeSachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new frmThongkesach();
            f.Show();
        }

        private void thongKeDocGiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new frmThongKeDocgia();
            f.Show();
        }
    }
}
