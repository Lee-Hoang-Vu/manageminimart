﻿namespace QuanLySieuThi.quanly
{
    partial class sanpham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sanpham));
            this.label11 = new System.Windows.Forms.Label();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.dta1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtNguoiNhap = new System.Windows.Forms.TextBox();
            this.txt_nsx = new System.Windows.Forms.TextBox();
            this.txt_mancc = new System.Windows.Forms.ComboBox();
            this.txt_tensp = new System.Windows.Forms.TextBox();
            this.txt_solg = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_dvt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_giaban = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_gianhap = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_hsd = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_masp = new System.Windows.Forms.TextBox();
            this.lbl_kq = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_in = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.bnt_sua = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lb_quyen = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dta1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(22, 385);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(199, 21);
            this.label11.TabIndex = 79;
            this.label11.Text = "Tìm kiếm tên sẩn phẩm : ";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // txt_search
            // 
            this.txt_search.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.Location = new System.Drawing.Point(245, 378);
            this.txt_search.Multiline = true;
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(180, 28);
            this.txt_search.TabIndex = 78;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(542, -52);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(234, 45);
            this.label14.TabIndex = 77;
            this.label14.Text = "Phiếu Nhập";
            // 
            // dta1
            // 
            this.dta1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dta1.Location = new System.Drawing.Point(10, 410);
            this.dta1.Name = "dta1";
            this.dta1.RowHeadersWidth = 51;
            this.dta1.Size = new System.Drawing.Size(1066, 224);
            this.dta1.TabIndex = 74;
            this.dta1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dta1_CellContentClick);
            this.dta1.Click += new System.EventHandler(this.dta1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtNguoiNhap);
            this.groupBox1.Controls.Add(this.txt_nsx);
            this.groupBox1.Controls.Add(this.txt_mancc);
            this.groupBox1.Controls.Add(this.txt_tensp);
            this.groupBox1.Controls.Add(this.txt_solg);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txt_dvt);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_giaban);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_gianhap);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_hsd);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_masp);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(28, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(694, 292);
            this.groupBox1.TabIndex = 73;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sản phẩm";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(407, 257);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(109, 23);
            this.label13.TabIndex = 45;
            this.label13.Text = "Người nhập";
            // 
            // txtNguoiNhap
            // 
            this.txtNguoiNhap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNguoiNhap.Location = new System.Drawing.Point(518, 249);
            this.txtNguoiNhap.Name = "txtNguoiNhap";
            this.txtNguoiNhap.Size = new System.Drawing.Size(174, 29);
            this.txtNguoiNhap.TabIndex = 44;
            // 
            // txt_nsx
            // 
            this.txt_nsx.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nsx.Location = new System.Drawing.Point(518, 152);
            this.txt_nsx.Name = "txt_nsx";
            this.txt_nsx.Size = new System.Drawing.Size(174, 29);
            this.txt_nsx.TabIndex = 43;
            // 
            // txt_mancc
            // 
            this.txt_mancc.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mancc.FormattingEnabled = true;
            this.txt_mancc.Location = new System.Drawing.Point(217, 151);
            this.txt_mancc.Name = "txt_mancc";
            this.txt_mancc.Size = new System.Drawing.Size(149, 30);
            this.txt_mancc.TabIndex = 42;
            this.txt_mancc.SelectedIndexChanged += new System.EventHandler(this.txt_mancc_SelectedIndexChanged);
            // 
            // txt_tensp
            // 
            this.txt_tensp.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tensp.Location = new System.Drawing.Point(218, 91);
            this.txt_tensp.Name = "txt_tensp";
            this.txt_tensp.Size = new System.Drawing.Size(147, 29);
            this.txt_tensp.TabIndex = 41;
            // 
            // txt_solg
            // 
            this.txt_solg.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_solg.Location = new System.Drawing.Point(518, 39);
            this.txt_solg.Name = "txt_solg";
            this.txt_solg.Size = new System.Drawing.Size(79, 29);
            this.txt_solg.TabIndex = 5;
            this.txt_solg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_solg_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(407, 209);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 23);
            this.label10.TabIndex = 40;
            this.label10.Text = "Đơn vị tính";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // txt_dvt
            // 
            this.txt_dvt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dvt.Location = new System.Drawing.Point(518, 202);
            this.txt_dvt.Name = "txt_dvt";
            this.txt_dvt.Size = new System.Drawing.Size(174, 29);
            this.txt_dvt.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(392, 95);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 23);
            this.label9.TabIndex = 38;
            this.label9.Text = "Hạn sử dụng";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(407, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 23);
            this.label8.TabIndex = 35;
            this.label8.Text = "Số lượng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(65, 258);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 23);
            this.label7.TabIndex = 33;
            this.label7.Text = "Giá Bán";
            // 
            // txt_giaban
            // 
            this.txt_giaban.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_giaban.Location = new System.Drawing.Point(218, 252);
            this.txt_giaban.Name = "txt_giaban";
            this.txt_giaban.Size = new System.Drawing.Size(147, 29);
            this.txt_giaban.TabIndex = 4;
            this.txt_giaban.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_giaban_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(65, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 23);
            this.label4.TabIndex = 31;
            this.label4.Text = "Giá nhập";
            // 
            // txt_gianhap
            // 
            this.txt_gianhap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_gianhap.Location = new System.Drawing.Point(218, 202);
            this.txt_gianhap.Name = "txt_gianhap";
            this.txt_gianhap.Size = new System.Drawing.Size(147, 29);
            this.txt_gianhap.TabIndex = 3;
            this.txt_gianhap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_gianhap_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 23);
            this.label3.TabIndex = 29;
            this.label3.Text = "Mã nhà cung cấp";
            // 
            // txt_hsd
            // 
            this.txt_hsd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_hsd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txt_hsd.Location = new System.Drawing.Point(518, 91);
            this.txt_hsd.Name = "txt_hsd";
            this.txt_hsd.Size = new System.Drawing.Size(171, 29);
            this.txt_hsd.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(407, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 23);
            this.label6.TabIndex = 22;
            this.label6.Text = "Nơi sản xuất";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 23);
            this.label1.TabIndex = 12;
            this.label1.Text = "Mã sản phẩm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 23);
            this.label2.TabIndex = 13;
            this.label2.Text = "Tên sản phẩm";
            // 
            // txt_masp
            // 
            this.txt_masp.Enabled = false;
            this.txt_masp.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_masp.Location = new System.Drawing.Point(218, 39);
            this.txt_masp.Name = "txt_masp";
            this.txt_masp.Size = new System.Drawing.Size(147, 29);
            this.txt_masp.TabIndex = 0;
            // 
            // lbl_kq
            // 
            this.lbl_kq.AutoSize = true;
            this.lbl_kq.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_kq.Location = new System.Drawing.Point(861, 388);
            this.lbl_kq.Name = "lbl_kq";
            this.lbl_kq.Size = new System.Drawing.Size(130, 21);
            this.lbl_kq.TabIndex = 86;
            this.lbl_kq.Text = "........................";
            this.lbl_kq.Click += new System.EventHandler(this.lbl_kq_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(687, 385);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(168, 21);
            this.label15.TabIndex = 85;
            this.label15.Text = "Số lượng sản phẩm : ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_in);
            this.groupBox2.Controls.Add(this.btn_them);
            this.groupBox2.Controls.Add(this.bnt_sua);
            this.groupBox2.Controls.Add(this.btn_Thoat);
            this.groupBox2.Controls.Add(this.btn_xoa);
            this.groupBox2.Controls.Add(this.btn_reset);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(728, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(332, 292);
            this.groupBox2.TabIndex = 84;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thực Hiện Công việc";
            // 
            // btn_in
            // 
            this.btn_in.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_in.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_in.Location = new System.Drawing.Point(184, 54);
            this.btn_in.Name = "btn_in";
            this.btn_in.Size = new System.Drawing.Size(129, 42);
            this.btn_in.TabIndex = 5;
            this.btn_in.Text = "In";
            this.btn_in.UseVisualStyleBackColor = true;
            this.btn_in.Click += new System.EventHandler(this.btn_in_Click);
            // 
            // btn_them
            // 
            this.btn_them.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_them.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_them.Location = new System.Drawing.Point(15, 54);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(129, 44);
            this.btn_them.TabIndex = 0;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // bnt_sua
            // 
            this.bnt_sua.Enabled = false;
            this.bnt_sua.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnt_sua.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.bnt_sua.Location = new System.Drawing.Point(15, 117);
            this.bnt_sua.Name = "bnt_sua";
            this.bnt_sua.Size = new System.Drawing.Size(129, 44);
            this.bnt_sua.TabIndex = 1;
            this.bnt_sua.Text = "Sửa";
            this.bnt_sua.UseVisualStyleBackColor = true;
            this.bnt_sua.Click += new System.EventHandler(this.bnt_sua_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Thoat.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_Thoat.Location = new System.Drawing.Point(184, 188);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(129, 44);
            this.btn_Thoat.TabIndex = 6;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Enabled = false;
            this.btn_xoa.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_xoa.Location = new System.Drawing.Point(15, 188);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(129, 44);
            this.btn_xoa.TabIndex = 2;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reset.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_reset.Location = new System.Drawing.Point(184, 117);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(129, 44);
            this.btn_reset.TabIndex = 4;
            this.btn_reset.Text = "Nhập lại";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(412, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(401, 45);
            this.label5.TabIndex = 95;
            this.label5.Text = "Thông Tin Sản phẩm";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Green;
            this.label12.Location = new System.Drawing.Point(-1, 7);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 21);
            this.label12.TabIndex = 97;
            this.label12.Text = "Xin Chào";
            // 
            // lb_quyen
            // 
            this.lb_quyen.AutoSize = true;
            this.lb_quyen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_quyen.ForeColor = System.Drawing.Color.Green;
            this.lb_quyen.Location = new System.Drawing.Point(86, 7);
            this.lb_quyen.Name = "lb_quyen";
            this.lb_quyen.Size = new System.Drawing.Size(20, 21);
            this.lb_quyen.TabIndex = 96;
            this.lb_quyen.Text = "..";
            // 
            // sanpham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1079, 666);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lb_quyen);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_kq);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.dta1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "sanpham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý siêu thị";
            this.Load += new System.EventHandler(this.sanpham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dta1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_search;
        internal System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dta1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_solg;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_dvt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_giaban;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_gianhap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker txt_hsd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_masp;
        private System.Windows.Forms.TextBox txt_nsx;
        private System.Windows.Forms.ComboBox txt_mancc;
        private System.Windows.Forms.TextBox txt_tensp;
        private System.Windows.Forms.Label lbl_kq;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox2;
        internal System.Windows.Forms.Button btn_in;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button bnt_sua;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_reset;
        internal System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label12;
        public System.Windows.Forms.Label lb_quyen;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtNguoiNhap;
    }
}