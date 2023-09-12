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
    public partial class frmTimkiemSach : Form
    {
        public frmTimkiemSach()
        {
            InitializeComponent();
        }
        themxoasua t = new themxoasua();
        private void loaddata()
        {
            DataTable dt = t.docdulieu("select * from TuaSach");

            if (dt != null)
            {
                dgv_timkiemsach.DataSource = dt;
            }
            dgv_timkiemsach.Columns[0].HeaderText = "Mã sách";
            dgv_timkiemsach.Columns[1].HeaderText = "Tên sách";
            dgv_timkiemsach.Columns[2].HeaderText = "Năm xuất bản";
            dgv_timkiemsach.Columns[3].HeaderText = "Mã nhà xuất bản";
            dgv_timkiemsach.Columns[4].HeaderText = "Mã thể loại";
            dgv_timkiemsach.Columns[5].HeaderText = "Mã tác giả";
            dgv_timkiemsach.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);

            dgv_timkiemsach.Enabled = true;

        }

        private void frmTimkiemSach_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            DataTable dt5 = t.docdulieu("select * from tuasach where mats like '%" + txttimkiem.Text + "%'");
            DataTable dt6 = t.docdulieu("select * from tuasach where tents like '%" + txttimkiem.Text + "%'");
            if (ramasach.Checked == true)
            {
                dgv_timkiemsach.DataSource = dt5;
            }
            else dgv_timkiemsach.DataSource = dt6;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new frmMain();
            f.Show();
        }
    }
}
