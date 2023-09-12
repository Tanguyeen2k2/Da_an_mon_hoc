namespace QLTHUVIEN
{
    partial class frmSach
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.ramasach = new System.Windows.Forms.RadioButton();
            this.ratensach = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSotrang = new System.Windows.Forms.TextBox();
            this.txtSoluong = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnimport = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.commatacgia = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comtheloai = new System.Windows.Forms.ComboBox();
            this.comnhaxb = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtnamxb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txttensach = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmasach = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_Sach = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnluucs = new System.Windows.Forms.Button();
            this.btnthoatcs = new System.Windows.Forms.Button();
            this.btnxoacs = new System.Windows.Forms.Button();
            this.btnsuacs = new System.Windows.Forms.Button();
            this.btnthemcs = new System.Windows.Forms.Button();
            this.comTS = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCS = new System.Windows.Forms.TextBox();
            this.dgv_CS = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Sach)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CS)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btntimkiem);
            this.groupBox1.Controls.Add(this.txttimkiem);
            this.groupBox1.Controls.Add(this.ramasach);
            this.groupBox1.Controls.Add(this.ratensach);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(35, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(823, 96);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm sách";
            // 
            // btntimkiem
            // 
            this.btntimkiem.Location = new System.Drawing.Point(509, 44);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(75, 26);
            this.btntimkiem.TabIndex = 3;
            this.btntimkiem.Text = "Tìm";
            this.btntimkiem.UseVisualStyleBackColor = true;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // txttimkiem
            // 
            this.txttimkiem.Location = new System.Drawing.Point(197, 44);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(293, 26);
            this.txttimkiem.TabIndex = 2;
            // 
            // ramasach
            // 
            this.ramasach.AutoSize = true;
            this.ramasach.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ramasach.Location = new System.Drawing.Point(60, 25);
            this.ramasach.Name = "ramasach";
            this.ramasach.Size = new System.Drawing.Size(99, 28);
            this.ramasach.TabIndex = 1;
            this.ramasach.TabStop = true;
            this.ramasach.Text = "Mã sách";
            this.ramasach.UseVisualStyleBackColor = true;
            // 
            // ratensach
            // 
            this.ratensach.AutoSize = true;
            this.ratensach.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ratensach.Location = new System.Drawing.Point(60, 61);
            this.ratensach.Name = "ratensach";
            this.ratensach.Size = new System.Drawing.Size(107, 28);
            this.ratensach.TabIndex = 0;
            this.ratensach.TabStop = true;
            this.ratensach.Text = "Tên sách";
            this.ratensach.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtSotrang);
            this.groupBox2.Controls.Add(this.txtSoluong);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.btnimport);
            this.groupBox2.Controls.Add(this.btnluu);
            this.groupBox2.Controls.Add(this.btnthoat);
            this.groupBox2.Controls.Add(this.btnxoa);
            this.groupBox2.Controls.Add(this.btnsua);
            this.groupBox2.Controls.Add(this.btnthem);
            this.groupBox2.Controls.Add(this.commatacgia);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.comtheloai);
            this.groupBox2.Controls.Add(this.comnhaxb);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtnamxb);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txttensach);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtmasach);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(6, 108);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(832, 218);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cập nhật sách";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(535, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 24);
            this.label8.TabIndex = 41;
            this.label8.Text = "Số trang";
            // 
            // txtSotrang
            // 
            this.txtSotrang.Location = new System.Drawing.Point(651, 122);
            this.txtSotrang.Name = "txtSotrang";
            this.txtSotrang.Size = new System.Drawing.Size(133, 26);
            this.txtSotrang.TabIndex = 40;
            this.txtSotrang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSotrang_KeyPress);
            // 
            // txtSoluong
            // 
            this.txtSoluong.Location = new System.Drawing.Point(389, 122);
            this.txtSoluong.Name = "txtSoluong";
            this.txtSoluong.Size = new System.Drawing.Size(121, 26);
            this.txtSoluong.TabIndex = 39;
            this.txtSoluong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoluong_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(266, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 24);
            this.label7.TabIndex = 38;
            this.label7.Text = "Số lượng";
            // 
            // btnimport
            // 
            this.btnimport.Enabled = false;
            this.btnimport.Location = new System.Drawing.Point(579, 170);
            this.btnimport.Name = "btnimport";
            this.btnimport.Size = new System.Drawing.Size(75, 31);
            this.btnimport.TabIndex = 37;
            this.btnimport.Text = "Import ";
            this.btnimport.UseVisualStyleBackColor = true;
            // 
            // btnluu
            // 
            this.btnluu.Enabled = false;
            this.btnluu.Location = new System.Drawing.Point(458, 170);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(75, 31);
            this.btnluu.TabIndex = 36;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(682, 171);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 31);
            this.btnthoat.TabIndex = 35;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(336, 170);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 31);
            this.btnxoa.TabIndex = 34;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(207, 170);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 29);
            this.btnsua.TabIndex = 33;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(99, 170);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(73, 29);
            this.btnthem.TabIndex = 32;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // commatacgia
            // 
            this.commatacgia.FormattingEnabled = true;
            this.commatacgia.Location = new System.Drawing.Point(651, 88);
            this.commatacgia.Name = "commatacgia";
            this.commatacgia.Size = new System.Drawing.Size(133, 28);
            this.commatacgia.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(544, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 24);
            this.label6.TabIndex = 10;
            this.label6.Text = "Mã tác giả";
            // 
            // comtheloai
            // 
            this.comtheloai.FormattingEnabled = true;
            this.comtheloai.Location = new System.Drawing.Point(651, 37);
            this.comtheloai.Name = "comtheloai";
            this.comtheloai.Size = new System.Drawing.Size(133, 28);
            this.comtheloai.TabIndex = 9;
            // 
            // comnhaxb
            // 
            this.comnhaxb.FormattingEnabled = true;
            this.comnhaxb.Location = new System.Drawing.Point(389, 83);
            this.comnhaxb.Name = "comnhaxb";
            this.comnhaxb.Size = new System.Drawing.Size(121, 28);
            this.comnhaxb.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(266, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mã nhà XB";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(544, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Mã thể loại";
            // 
            // txtnamxb
            // 
            this.txtnamxb.Location = new System.Drawing.Point(389, 37);
            this.txtnamxb.Name = "txtnamxb";
            this.txtnamxb.Size = new System.Drawing.Size(121, 26);
            this.txtnamxb.TabIndex = 5;
            this.txtnamxb.Enter += new System.EventHandler(this.txtnamxb_Enter);
            this.txtnamxb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnamxb_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(256, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Năm xuất bản";
            // 
            // txttensach
            // 
            this.txttensach.Location = new System.Drawing.Point(110, 82);
            this.txttensach.Name = "txttensach";
            this.txttensach.Size = new System.Drawing.Size(123, 26);
            this.txttensach.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(15, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên sách";
            // 
            // txtmasach
            // 
            this.txtmasach.Location = new System.Drawing.Point(110, 36);
            this.txtmasach.Name = "txtmasach";
            this.txtmasach.Size = new System.Drawing.Size(123, 26);
            this.txtmasach.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(15, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sách";
            // 
            // dgv_Sach
            // 
            this.dgv_Sach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Sach.Location = new System.Drawing.Point(75, 334);
            this.dgv_Sach.Name = "dgv_Sach";
            this.dgv_Sach.Size = new System.Drawing.Size(741, 152);
            this.dgv_Sach.TabIndex = 23;
            this.dgv_Sach.SelectionChanged += new System.EventHandler(this.dgv_Sach_SelectionChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(866, 518);
            this.tabControl1.TabIndex = 24;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.dgv_Sach);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(858, 492);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Sách";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnluucs);
            this.tabPage2.Controls.Add(this.btnthoatcs);
            this.tabPage2.Controls.Add(this.btnxoacs);
            this.tabPage2.Controls.Add(this.btnsuacs);
            this.tabPage2.Controls.Add(this.btnthemcs);
            this.tabPage2.Controls.Add(this.comTS);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.txtCS);
            this.tabPage2.Controls.Add(this.dgv_CS);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(858, 492);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "cuốn sách";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnluucs
            // 
            this.btnluucs.Enabled = false;
            this.btnluucs.Location = new System.Drawing.Point(462, 141);
            this.btnluucs.Name = "btnluucs";
            this.btnluucs.Size = new System.Drawing.Size(75, 31);
            this.btnluucs.TabIndex = 42;
            this.btnluucs.Text = "Lưu";
            this.btnluucs.UseVisualStyleBackColor = true;
            this.btnluucs.Click += new System.EventHandler(this.btnluucs_Click);
            // 
            // btnthoatcs
            // 
            this.btnthoatcs.Location = new System.Drawing.Point(572, 141);
            this.btnthoatcs.Name = "btnthoatcs";
            this.btnthoatcs.Size = new System.Drawing.Size(75, 31);
            this.btnthoatcs.TabIndex = 41;
            this.btnthoatcs.Text = "Thoát";
            this.btnthoatcs.UseVisualStyleBackColor = true;
            this.btnthoatcs.Click += new System.EventHandler(this.btnthoatcs_Click);
            // 
            // btnxoacs
            // 
            this.btnxoacs.Location = new System.Drawing.Point(340, 141);
            this.btnxoacs.Name = "btnxoacs";
            this.btnxoacs.Size = new System.Drawing.Size(75, 31);
            this.btnxoacs.TabIndex = 40;
            this.btnxoacs.Text = "Xóa";
            this.btnxoacs.UseVisualStyleBackColor = true;
            this.btnxoacs.Click += new System.EventHandler(this.btnxoacs_Click);
            // 
            // btnsuacs
            // 
            this.btnsuacs.Location = new System.Drawing.Point(211, 141);
            this.btnsuacs.Name = "btnsuacs";
            this.btnsuacs.Size = new System.Drawing.Size(75, 29);
            this.btnsuacs.TabIndex = 39;
            this.btnsuacs.Text = "Sửa";
            this.btnsuacs.UseVisualStyleBackColor = true;
            this.btnsuacs.Click += new System.EventHandler(this.btnsuacs_Click);
            // 
            // btnthemcs
            // 
            this.btnthemcs.Location = new System.Drawing.Point(103, 141);
            this.btnthemcs.Name = "btnthemcs";
            this.btnthemcs.Size = new System.Drawing.Size(73, 29);
            this.btnthemcs.TabIndex = 38;
            this.btnthemcs.Text = "Thêm";
            this.btnthemcs.UseVisualStyleBackColor = true;
            this.btnthemcs.Click += new System.EventHandler(this.btnthemcs_Click);
            // 
            // comTS
            // 
            this.comTS.FormattingEnabled = true;
            this.comTS.Location = new System.Drawing.Point(226, 87);
            this.comTS.Name = "comTS";
            this.comTS.Size = new System.Drawing.Size(121, 21);
            this.comTS.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10.Location = new System.Drawing.Point(77, 87);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 24);
            this.label10.TabIndex = 4;
            this.label10.Text = "Mã tựa sách";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.Location = new System.Drawing.Point(77, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(129, 24);
            this.label9.TabIndex = 3;
            this.label9.Text = "Mã cuốn sách";
            // 
            // txtCS
            // 
            this.txtCS.Location = new System.Drawing.Point(226, 37);
            this.txtCS.Name = "txtCS";
            this.txtCS.Size = new System.Drawing.Size(123, 20);
            this.txtCS.TabIndex = 2;
            // 
            // dgv_CS
            // 
            this.dgv_CS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_CS.Location = new System.Drawing.Point(75, 189);
            this.dgv_CS.Name = "dgv_CS";
            this.dgv_CS.Size = new System.Drawing.Size(372, 247);
            this.dgv_CS.TabIndex = 0;
            this.dgv_CS.SelectionChanged += new System.EventHandler(this.dgv_CS_SelectionChanged);
            // 
            // frmSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 543);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý sách";
            this.Load += new System.EventHandler(this.frmSach_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Sach)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton ratensach;
        private System.Windows.Forms.RadioButton ramasach;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comnhaxb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtnamxb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txttensach;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtmasach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comtheloai;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox commatacgia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.DataGridView dgv_Sach;
        private System.Windows.Forms.Button btnimport;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSotrang;
        private System.Windows.Forms.TextBox txtSoluong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnluucs;
        private System.Windows.Forms.Button btnthoatcs;
        private System.Windows.Forms.Button btnxoacs;
        private System.Windows.Forms.Button btnsuacs;
        private System.Windows.Forms.Button btnthemcs;
        private System.Windows.Forms.ComboBox comTS;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCS;
        private System.Windows.Forms.DataGridView dgv_CS;
    }
}