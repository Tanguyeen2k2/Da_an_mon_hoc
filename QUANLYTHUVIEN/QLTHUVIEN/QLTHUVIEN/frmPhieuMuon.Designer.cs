namespace QLTHUVIEN
{
    partial class frmPhieuMuon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab1 = new System.Windows.Forms.TabPage();
            this.btngiahan = new System.Windows.Forms.Button();
            this.datengaytra = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.datengaymuon = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.dgv_PhieuMuon = new System.Windows.Forms.DataGridView();
            this.comnhanvien = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comdocgia = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtmaphieu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tab2 = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.btnsuact = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.l = new System.Windows.Forms.Label();
            this.btnluuct = new System.Windows.Forms.Button();
            this.btnxoact = new System.Windows.Forms.Button();
            this.btnthemct = new System.Windows.Forms.Button();
            this.dgv_CTPhieuMuon = new System.Windows.Forms.DataGridView();
            this.txtghichu = new System.Windows.Forms.RichTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.commasach = new System.Windows.Forms.ComboBox();
            this.commaphieumuon = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tab1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PhieuMuon)).BeginInit();
            this.tab2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CTPhieuMuon)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab1);
            this.tabControl1.Controls.Add(this.tab2);
            this.tabControl1.Location = new System.Drawing.Point(24, 36);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(702, 505);
            this.tabControl1.TabIndex = 0;
            // 
            // tab1
            // 
            this.tab1.Controls.Add(this.btngiahan);
            this.tab1.Controls.Add(this.datengaytra);
            this.tab1.Controls.Add(this.label6);
            this.tab1.Controls.Add(this.datengaymuon);
            this.tab1.Controls.Add(this.label8);
            this.tab1.Controls.Add(this.btnluu);
            this.tab1.Controls.Add(this.btnthoat);
            this.tab1.Controls.Add(this.btnxoa);
            this.tab1.Controls.Add(this.btnsua);
            this.tab1.Controls.Add(this.btnthem);
            this.tab1.Controls.Add(this.dgv_PhieuMuon);
            this.tab1.Controls.Add(this.comnhanvien);
            this.tab1.Controls.Add(this.label5);
            this.tab1.Controls.Add(this.comdocgia);
            this.tab1.Controls.Add(this.label4);
            this.tab1.Controls.Add(this.txtmaphieu);
            this.tab1.Controls.Add(this.label3);
            this.tab1.Controls.Add(this.label2);
            this.tab1.Location = new System.Drawing.Point(4, 22);
            this.tab1.Name = "tab1";
            this.tab1.Padding = new System.Windows.Forms.Padding(3);
            this.tab1.Size = new System.Drawing.Size(694, 479);
            this.tab1.TabIndex = 0;
            this.tab1.Text = "Lập phiếu mượn";
            this.tab1.UseVisualStyleBackColor = true;
            // 
            // btngiahan
            // 
            this.btngiahan.Location = new System.Drawing.Point(529, 150);
            this.btngiahan.Name = "btngiahan";
            this.btngiahan.Size = new System.Drawing.Size(75, 32);
            this.btngiahan.TabIndex = 51;
            this.btngiahan.Text = "Gia hạn";
            this.btngiahan.UseVisualStyleBackColor = true;
            this.btngiahan.Click += new System.EventHandler(this.btngiahan_Click);
            // 
            // datengaytra
            // 
            this.datengaytra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datengaytra.Location = new System.Drawing.Point(507, 112);
            this.datengaytra.Name = "datengaytra";
            this.datengaytra.Size = new System.Drawing.Size(121, 20);
            this.datengaytra.TabIndex = 50;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(374, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 24);
            this.label6.TabIndex = 49;
            this.label6.Text = "Ngày hẹn trả";
            // 
            // datengaymuon
            // 
            this.datengaymuon.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datengaymuon.Location = new System.Drawing.Point(507, 61);
            this.datengaymuon.Name = "datengaymuon";
            this.datengaymuon.Size = new System.Drawing.Size(121, 20);
            this.datengaymuon.TabIndex = 48;
            this.datengaymuon.Value = new System.DateTime(2023, 5, 14, 3, 28, 9, 0);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(374, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 24);
            this.label8.TabIndex = 47;
            this.label8.Text = "Ngày mượn";
            // 
            // btnluu
            // 
            this.btnluu.Enabled = false;
            this.btnluu.Location = new System.Drawing.Point(475, 218);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(75, 31);
            this.btnluu.TabIndex = 46;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(589, 218);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 31);
            this.btnthoat.TabIndex = 45;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(367, 216);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 31);
            this.btnxoa.TabIndex = 44;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(256, 218);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 29);
            this.btnsua.TabIndex = 43;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(143, 218);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(73, 29);
            this.btnthem.TabIndex = 42;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // dgv_PhieuMuon
            // 
            this.dgv_PhieuMuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_PhieuMuon.Location = new System.Drawing.Point(35, 257);
            this.dgv_PhieuMuon.Name = "dgv_PhieuMuon";
            this.dgv_PhieuMuon.Size = new System.Drawing.Size(629, 199);
            this.dgv_PhieuMuon.TabIndex = 26;
            this.dgv_PhieuMuon.SelectionChanged += new System.EventHandler(this.dgv_PhieuMuon_SelectionChanged);
            // 
            // comnhanvien
            // 
            this.comnhanvien.FormattingEnabled = true;
            this.comnhanvien.Location = new System.Drawing.Point(210, 170);
            this.comnhanvien.Name = "comnhanvien";
            this.comnhanvien.Size = new System.Drawing.Size(121, 21);
            this.comnhanvien.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(31, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "Người lập phiếu";
            // 
            // comdocgia
            // 
            this.comdocgia.FormattingEnabled = true;
            this.comdocgia.Location = new System.Drawing.Point(210, 113);
            this.comdocgia.Name = "comdocgia";
            this.comdocgia.Size = new System.Drawing.Size(121, 21);
            this.comdocgia.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(31, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Mã độc giả";
            // 
            // txtmaphieu
            // 
            this.txtmaphieu.Location = new System.Drawing.Point(210, 61);
            this.txtmaphieu.Name = "txtmaphieu";
            this.txtmaphieu.Size = new System.Drawing.Size(121, 20);
            this.txtmaphieu.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(31, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mã phiếu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(206, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "TẠO PHIẾU MƯỢN";
            // 
            // tab2
            // 
            this.tab2.Controls.Add(this.label13);
            this.tab2.Controls.Add(this.btnsuact);
            this.tab2.Controls.Add(this.label12);
            this.tab2.Controls.Add(this.l);
            this.tab2.Controls.Add(this.btnluuct);
            this.tab2.Controls.Add(this.btnxoact);
            this.tab2.Controls.Add(this.btnthemct);
            this.tab2.Controls.Add(this.dgv_CTPhieuMuon);
            this.tab2.Controls.Add(this.txtghichu);
            this.tab2.Controls.Add(this.label11);
            this.tab2.Controls.Add(this.commasach);
            this.tab2.Controls.Add(this.commaphieumuon);
            this.tab2.Controls.Add(this.label9);
            this.tab2.Controls.Add(this.label10);
            this.tab2.Controls.Add(this.label7);
            this.tab2.Location = new System.Drawing.Point(4, 22);
            this.tab2.Name = "tab2";
            this.tab2.Padding = new System.Windows.Forms.Padding(3);
            this.tab2.Size = new System.Drawing.Size(694, 479);
            this.tab2.TabIndex = 1;
            this.tab2.Text = "Chi tiết mượn-trả";
            this.tab2.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(164, 167);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(117, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "*Lưu ý: ghi cũ hoặc tốt.";
            // 
            // btnsuact
            // 
            this.btnsuact.Location = new System.Drawing.Point(242, 247);
            this.btnsuact.Name = "btnsuact";
            this.btnsuact.Size = new System.Drawing.Size(75, 32);
            this.btnsuact.TabIndex = 25;
            this.btnsuact.Text = "Sửa";
            this.btnsuact.UseVisualStyleBackColor = true;
            this.btnsuact.Click += new System.EventHandler(this.btnsuact_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(79, 310);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(200, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "Tổng số quyển sách độc giả đang mượn";
            // 
            // l
            // 
            this.l.AutoSize = true;
            this.l.ForeColor = System.Drawing.Color.Red;
            this.l.Location = new System.Drawing.Point(285, 310);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(44, 13);
            this.l.TabIndex = 23;
            this.l.Text = "soluong";
            // 
            // btnluuct
            // 
            this.btnluuct.Location = new System.Drawing.Point(462, 247);
            this.btnluuct.Name = "btnluuct";
            this.btnluuct.Size = new System.Drawing.Size(75, 32);
            this.btnluuct.TabIndex = 22;
            this.btnluuct.Text = "Lưu";
            this.btnluuct.UseVisualStyleBackColor = true;
            this.btnluuct.Click += new System.EventHandler(this.btnluuct_Click);
            // 
            // btnxoact
            // 
            this.btnxoact.Location = new System.Drawing.Point(353, 247);
            this.btnxoact.Name = "btnxoact";
            this.btnxoact.Size = new System.Drawing.Size(75, 32);
            this.btnxoact.TabIndex = 21;
            this.btnxoact.Text = "Trả sách";
            this.btnxoact.UseVisualStyleBackColor = true;
            this.btnxoact.Click += new System.EventHandler(this.btnxoact_Click);
            // 
            // btnthemct
            // 
            this.btnthemct.Location = new System.Drawing.Point(121, 247);
            this.btnthemct.Name = "btnthemct";
            this.btnthemct.Size = new System.Drawing.Size(75, 32);
            this.btnthemct.TabIndex = 19;
            this.btnthemct.Text = "Thêm ";
            this.btnthemct.UseVisualStyleBackColor = true;
            this.btnthemct.Click += new System.EventHandler(this.btnthemct_Click);
            // 
            // dgv_CTPhieuMuon
            // 
            this.dgv_CTPhieuMuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_CTPhieuMuon.Location = new System.Drawing.Point(82, 329);
            this.dgv_CTPhieuMuon.Name = "dgv_CTPhieuMuon";
            this.dgv_CTPhieuMuon.Size = new System.Drawing.Size(553, 150);
            this.dgv_CTPhieuMuon.TabIndex = 18;
            this.dgv_CTPhieuMuon.SelectionChanged += new System.EventHandler(this.dgv_CTPhieuMuon_SelectionChanged);
            // 
            // txtghichu
            // 
            this.txtghichu.Location = new System.Drawing.Point(167, 183);
            this.txtghichu.Name = "txtghichu";
            this.txtghichu.Size = new System.Drawing.Size(412, 47);
            this.txtghichu.TabIndex = 17;
            this.txtghichu.Text = "";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label11.Location = new System.Drawing.Point(6, 183);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(155, 24);
            this.label11.TabIndex = 16;
            this.label11.Text = "Tình trạng sách";
            // 
            // commasach
            // 
            this.commasach.FormattingEnabled = true;
            this.commasach.Location = new System.Drawing.Point(451, 86);
            this.commasach.Name = "commasach";
            this.commasach.Size = new System.Drawing.Size(121, 21);
            this.commasach.TabIndex = 12;
            // 
            // commaphieumuon
            // 
            this.commaphieumuon.FormattingEnabled = true;
            this.commaphieumuon.Location = new System.Drawing.Point(165, 88);
            this.commaphieumuon.Name = "commaphieumuon";
            this.commaphieumuon.Size = new System.Drawing.Size(121, 21);
            this.commaphieumuon.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.Location = new System.Drawing.Point(318, 88);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 24);
            this.label9.TabIndex = 9;
            this.label9.Text = "Mã sách";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10.Location = new System.Drawing.Point(3, 83);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(156, 24);
            this.label10.TabIndex = 8;
            this.label10.Text = "Mã phiếu mượn";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(273, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(201, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Chi tiết mượn - trả  sách";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(305, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quản Lí Mượn Trả Sách";
            // 
            // frmPhieuMuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 554);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPhieuMuon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mượn trả sách";
            this.Load += new System.EventHandler(this.frmPhieuMuon_Load);
            this.tabControl1.ResumeLayout(false);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PhieuMuon)).EndInit();
            this.tab2.ResumeLayout(false);
            this.tab2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CTPhieuMuon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab1;
        private System.Windows.Forms.TabPage tab2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comnhanvien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comdocgia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtmaphieu;
        private System.Windows.Forms.DataGridView dgv_PhieuMuon;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox commasach;
        private System.Windows.Forms.ComboBox commaphieumuon;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RichTextBox txtghichu;
        private System.Windows.Forms.Button btnthemct;
        private System.Windows.Forms.DataGridView dgv_CTPhieuMuon;
        private System.Windows.Forms.Button btnxoact;
        private System.Windows.Forms.Button btnluuct;
        private System.Windows.Forms.Label l;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker datengaytra;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker datengaymuon;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btngiahan;
        private System.Windows.Forms.Button btnsuact;
        private System.Windows.Forms.Label label13;
    }
}