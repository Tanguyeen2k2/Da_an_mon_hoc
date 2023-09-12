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
    public partial class frmTimKiemDocgia : Form
    {
        public frmTimKiemDocgia()
        {
            InitializeComponent();
        }
        themxoasua t = new themxoasua();
        private void loaddata()
        {
            DataTable dt = t.docdulieu("select * from docgia");
            l.Text = dt.Rows.Count.ToString();

            if (dt != null)
            {
                dgv_TKDocGia.DataSource = dt;
            }
            dgv_TKDocGia.Columns[0].HeaderText = "Mã độc giả";
            dgv_TKDocGia.Columns[1].HeaderText = "Họ và tên";
            dgv_TKDocGia.Columns[2].HeaderText = "Ngày sinh";
            dgv_TKDocGia.Columns[3].HeaderText = "Giới tính";
            dgv_TKDocGia.Columns[4].HeaderText = "Địa chỉ";
            dgv_TKDocGia.Columns[5].HeaderText = "SDT";
            dgv_TKDocGia.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
           dgv_TKDocGia.Enabled = true;

        }

        private void frmTimKiemDocgia_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            DataTable dt5 = t.docdulieu("select * from docgia where madg like '%" + txttimkiem.Text + "%'");
            DataTable dt6 = t.docdulieu("select * from docgia where TenDG like '%" + txttimkiem.Text + "%'");
            if (ramasach.Checked == true)
            {
                dgv_TKDocGia.DataSource = dt5;
            }
            else dgv_TKDocGia.DataSource = dt6;
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new frmMain();
            f.Show();
        }
    }
}
