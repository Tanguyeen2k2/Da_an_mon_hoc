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
    public partial class frmThongKeDocgia : Form
    {
        public frmThongKeDocgia()
        {
            InitializeComponent();
        }
        themxoasua t = new themxoasua();
        private void loaddata()
        {
            DataTable dt = t.docdulieu("select * from docgia");

            if (dt != null)
            {
                dgv_thongkedocgia.DataSource = dt;
            }
            dgv_thongkedocgia.Columns[0].HeaderText = "Mã độc giả";
            dgv_thongkedocgia.Columns[1].HeaderText = "Tên độc giả";
            dgv_thongkedocgia.Columns[2].HeaderText = "Ngày sinh";
            dgv_thongkedocgia.Columns[3].HeaderText = "Giới";
            dgv_thongkedocgia.Columns[4].HeaderText = "Địa chỉ";
            dgv_thongkedocgia.Columns[5].HeaderText = "SDT";
            //  luoi.Columns[5].HeaderText = "Mã tác giả";
            dgv_thongkedocgia.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);

            dgv_thongkedocgia.Enabled = true;

        }
        private void loaddata2()
        {
            DataTable dt = t.docdulieu("select distinct docgia.madg,docgia.TenDG, docgia.ngaysinh,docgia.gioitinh, docgia.DiaChi, DocGia.SDT from docgia, phieumuon,chitietmuon where (docgia.madg=phieumuon.madg and phieumuon.MaPM=chitietmuon.mapm and PhieuMuon.NgayTra<GETDATE())");


            if (dt != null)
            {
                dgv_thongkedocgia.DataSource = dt;
            }
            dgv_thongkedocgia.Columns[0].HeaderText = "Mã độc giả";
            dgv_thongkedocgia.Columns[1].HeaderText = "Tên độc giả";
            dgv_thongkedocgia.Columns[2].HeaderText = "Ngày sinh";
            dgv_thongkedocgia.Columns[3].HeaderText = "Giới";
            dgv_thongkedocgia.Columns[4].HeaderText = "Địa chỉ";
            dgv_thongkedocgia.Columns[5].HeaderText = "SDT";
            //  luoi.Columns[5].HeaderText = "Mã tác giả";
            dgv_thongkedocgia.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);

            dgv_thongkedocgia.Enabled = true;

        }

        private void frmThongKeDocgia_Load(object sender, EventArgs e)
        {
            loaddata();
            comtuychon.Text = "Tất cả độc giả";
        }

        private void btnthongke_Click(object sender, EventArgs e)
        {
            if (comtuychon.Text == "Tất cả độc giả")
                loaddata();
            else loaddata2();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new frmMain();
            f.Show();
        }

        private void btnExcel_Click(object sender, EventArgs e)
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
            for (int i = 1; i < dgv_thongkedocgia.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dgv_thongkedocgia.Columns[i - 1].HeaderText;
            }
            // lưu trữ từng giá trị hàng và cột vào bảng tính excel  
            for (int i = 0; i < dgv_thongkedocgia.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dgv_thongkedocgia.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dgv_thongkedocgia.Rows[i].Cells[j].Value.ToString();
                }
            }
            // save the application  
            //workbook.SaveAs("c:\\output.xls", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            // Exit from the application  
            app.Quit();
        }
    }
}
