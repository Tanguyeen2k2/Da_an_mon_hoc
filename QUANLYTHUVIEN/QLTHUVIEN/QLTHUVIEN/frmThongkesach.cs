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
    public partial class frmThongkesach : Form
    {
        public frmThongkesach()
        {
            InitializeComponent();
        }
        themxoasua t = new themxoasua();
        private void loaddata()
        {
            DataTable dt = t.docdulieu("select TuaSach.mats, tuasach.TenTS, nxb.tennxb,tuasach.namxb,theloai.tenloai from tuasach, nxb, theloai where (tuasach.manxb=nxb.manxb and tuasach.maloai=theloai.maloai)");

            if (dt != null)
            {
                dgv_thongkesach.DataSource = dt;
            }
            dgv_thongkesach.Columns[0].HeaderText = "Mã sách";
            dgv_thongkesach.Columns[1].HeaderText = "Tên sách";
            dgv_thongkesach.Columns[2].HeaderText = "Nhà xuất bản";
            dgv_thongkesach.Columns[3].HeaderText = "Năm xuất bản";
            dgv_thongkesach.Columns[4].HeaderText = "Thể loại";
            //  luoi.Columns[5].HeaderText = "Mã tác giả";
            dgv_thongkesach.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);

            dgv_thongkesach.Enabled = true;

        }
        private void loaddata1()
        {
            DataTable dt = t.docdulieu("select tuasach.mats,tuasach.tents, nxb.tennxb,tuasach.namxb,theloai.tenloai from tuasach, nxb,chitietmuon, theloai,CuonSach where (tuasach.manxb=nxb.manxb and tuasach.maloai=theloai.maloai and tuasach.mats=CuonSach.MaTS and CuonSach.MaCS=ChiTietMuon.MaCS)");

            if (dt != null)
            {
                dgv_thongkesach.DataSource = dt;
            }
            dgv_thongkesach.Columns[0].HeaderText = "Mã sách";
            dgv_thongkesach.Columns[1].HeaderText = "Tên sách";
            dgv_thongkesach.Columns[2].HeaderText = "Nhà xuất bản";
            dgv_thongkesach.Columns[3].HeaderText = "Năm xuất bản";
            dgv_thongkesach.Columns[4].HeaderText = "Thể loại";
            //  luoi.Columns[5].HeaderText = "Mã tác giả";
            dgv_thongkesach.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);

            dgv_thongkesach.Enabled = true;

        }
        private void loaddata2()
        {
            DataTable dt = t.docdulieu("select tuasach.mats,tuasach.tents, nxb.tennxb,tuasach.namxb,theloai.tenloai from tuasach, nxb,chitietmuon,PhieuMuon, theloai,cuonsach where (tuasach.manxb=nxb.manxb and tuasach.maloai=theloai.maloai and tuasach.mats=CuonSach.mats and CuonSach.MaTS=ChiTietMuon.MaCS and PhieuMuon.NgayTra<GETDATE())");

            if (dt != null)
            {
                dgv_thongkesach.DataSource = dt;
            }
            dgv_thongkesach.Columns[0].HeaderText = "Mã sách";
            dgv_thongkesach.Columns[1].HeaderText = "Tên sách";
            dgv_thongkesach.Columns[2].HeaderText = "Nhà xuất bản";
            dgv_thongkesach.Columns[3].HeaderText = "Năm xuất bản";
            dgv_thongkesach.Columns[4].HeaderText = "Thể loại";
            //  luoi.Columns[5].HeaderText = "Mã tác giả";
            dgv_thongkesach.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);

            dgv_thongkesach.Enabled = true;
        }

        private void frmThongkesach_Load(object sender, EventArgs e)
        {
            comtuychon.Text = "Tất cả sách ";

            loaddata();
        }

        private void btnthongke_Click(object sender, EventArgs e)
        {
            if (comtuychon.Text == "Tất cả sách ")
                loaddata();
            else if (comtuychon.Text == "Sách đang mượn ")
                loaddata1();
            else loaddata2();
        }

        private void btnexcel_Click(object sender, EventArgs e)
        {
            // tạo ứng dụng excel  
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            // tạo WorkBook mới trong ứng dụng Excel  
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            // tạo Sheet Excel mới trong workbook 
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            // xem bảng excel đằng sau chương trình  
            app.Visible = true;
            // lấy tham chiếu của tờ đầu tiên. Theo mặc định, tên của nó là Sheet1.  
            // lưu trữ tham chiếu của nó đến trang tính  
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            // đổi tên sheet đang hoạt động  
            worksheet.Name = "Exported from gridview";
            // lưu trữ phần tiêu đề trong Excel  
            for (int i = 1; i < dgv_thongkesach.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dgv_thongkesach.Columns[i - 1].HeaderText;
            }
            // lưu trữ từng giá trị hàng và cột vào bảng tính excel  
            for (int i = 0; i < dgv_thongkesach.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dgv_thongkesach.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dgv_thongkesach.Rows[i].Cells[j].Value.ToString();
                }
            }
            // save the application  
            //workbook.SaveAs("c:\\output.xls", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            // Exit from the application  
            app.Quit();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new frmMain();
            f.Show();
        }
    }
}
