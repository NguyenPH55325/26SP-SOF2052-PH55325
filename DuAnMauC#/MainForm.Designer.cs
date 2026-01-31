namespace DuAnMauC_
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            chiTietHoaDonBindingSource = new BindingSource(components);
            chiTietHoaDonBindingSource1 = new BindingSource(components);
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            NhanVientoolStripMenuItem = new ToolStripMenuItem();
            KhachHangtoolStripMenuItem = new ToolStripMenuItem();
            SanPhamToolStripMenuItem = new ToolStripMenuItem();
            tabPage6 = new TabPage();
            dgvSanPhamChiTiet = new DataGridView();
            label30 = new Label();
            tabPageHDCT = new TabPage();
            dgvDsChiTietHoaDon = new DataGridView();
            tabPage1 = new TabPage();
            dgvDsHoaDon = new DataGridView();
            Column8 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            label1 = new Label();
            txtMaHoaDon = new TextBox();
            label2 = new Label();
            txtNgayTao = new TextBox();
            btnThem = new Button();
            label8 = new Label();
            rdoChoXacNhan = new RadioButton();
            rdoDaThanhToan = new RadioButton();
            btnXoa = new Button();
            btnSua = new Button();
            btnLamMoi = new Button();
            btnThanhToan = new Button();
            label3 = new Label();
            groupBox2 = new GroupBox();
            label5 = new Label();
            txtMaSanPham = new TextBox();
            label4 = new Label();
            txtTenSanPham = new TextBox();
            label6 = new Label();
            label7 = new Label();
            txtDonGia = new TextBox();
            txtSoLuong = new TextBox();
            btnThemCT = new Button();
            btnSuaCT = new Button();
            btnXoaCT = new Button();
            label31 = new Label();
            txtThanhTien = new TextBox();
            tabControl1 = new TabControl();
            ((System.ComponentModel.ISupportInitialize)chiTietHoaDonBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chiTietHoaDonBindingSource1).BeginInit();
            menuStrip1.SuspendLayout();
            tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSanPhamChiTiet).BeginInit();
            tabPageHDCT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDsChiTietHoaDon).BeginInit();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDsHoaDon).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // chiTietHoaDonBindingSource
            // 
            chiTietHoaDonBindingSource.DataSource = typeof(DAO.ChiTietHoaDon);
            // 
            // chiTietHoaDonBindingSource1
            // 
            chiTietHoaDonBindingSource1.DataSource = typeof(DAO.ChiTietHoaDon);
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ActiveCaption;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, NhanVientoolStripMenuItem, KhachHangtoolStripMenuItem, SanPhamToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(84, 24);
            toolStripMenuItem1.Text = "Hóa Đơn";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // NhanVientoolStripMenuItem
            // 
            NhanVientoolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NhanVientoolStripMenuItem.Name = "NhanVientoolStripMenuItem";
            NhanVientoolStripMenuItem.Size = new Size(96, 24);
            NhanVientoolStripMenuItem.Text = "Nhân Viên";
            NhanVientoolStripMenuItem.Click += NhanVientoolStripMenuItem_Click;
            // 
            // KhachHangtoolStripMenuItem
            // 
            KhachHangtoolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            KhachHangtoolStripMenuItem.Name = "KhachHangtoolStripMenuItem";
            KhachHangtoolStripMenuItem.Size = new Size(107, 24);
            KhachHangtoolStripMenuItem.Text = "Khách Hàng";
            KhachHangtoolStripMenuItem.Click += KhachHangtoolStripMenuItem_Click;
            // 
            // SanPhamToolStripMenuItem
            // 
            SanPhamToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SanPhamToolStripMenuItem.Name = "SanPhamToolStripMenuItem";
            SanPhamToolStripMenuItem.Size = new Size(92, 24);
            SanPhamToolStripMenuItem.Text = "Sản Phẩm";
            SanPhamToolStripMenuItem.Click += SanPhamToolStripMenuItem_Click;
            // 
            // tabPage6
            // 
            tabPage6.Controls.Add(label30);
            tabPage6.Controls.Add(dgvSanPhamChiTiet);
            tabPage6.Location = new Point(4, 29);
            tabPage6.Name = "tabPage6";
            tabPage6.Padding = new Padding(3);
            tabPage6.Size = new Size(776, 365);
            tabPage6.TabIndex = 5;
            tabPage6.Text = "Sản Phẩm Chi Tiết";
            tabPage6.UseVisualStyleBackColor = true;
            // 
            // dgvSanPhamChiTiet
            // 
            dgvSanPhamChiTiet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSanPhamChiTiet.Location = new Point(1, 291);
            dgvSanPhamChiTiet.Name = "dgvSanPhamChiTiet";
            dgvSanPhamChiTiet.RowHeadersWidth = 51;
            dgvSanPhamChiTiet.Size = new Size(772, 118);
            dgvSanPhamChiTiet.TabIndex = 1;
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label30.ForeColor = SystemColors.HotTrack;
            label30.Location = new Point(247, 26);
            label30.Name = "label30";
            label30.Size = new Size(258, 35);
            label30.TabIndex = 7;
            label30.Text = "SẢN PHẨM CHI TIẾT";
            // 
            // tabPageHDCT
            // 
            tabPageHDCT.Controls.Add(dgvDsChiTietHoaDon);
            tabPageHDCT.Location = new Point(4, 29);
            tabPageHDCT.Name = "tabPageHDCT";
            tabPageHDCT.Padding = new Padding(3);
            tabPageHDCT.Size = new Size(776, 365);
            tabPageHDCT.TabIndex = 1;
            tabPageHDCT.Text = "Hóa Đơn Chi Tiết";
            tabPageHDCT.UseVisualStyleBackColor = true;
            // 
            // dgvDsChiTietHoaDon
            // 
            dgvDsChiTietHoaDon.BackgroundColor = SystemColors.ActiveBorder;
            dgvDsChiTietHoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDsChiTietHoaDon.Location = new Point(3, 3);
            dgvDsChiTietHoaDon.Name = "dgvDsChiTietHoaDon";
            dgvDsChiTietHoaDon.RowHeadersWidth = 51;
            dgvDsChiTietHoaDon.Size = new Size(616, 266);
            dgvDsChiTietHoaDon.TabIndex = 0;
            dgvDsChiTietHoaDon.CellContentClick += dgvDsChiTietHoaDon_CellContentClick;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.Transparent;
            tabPage1.Controls.Add(groupBox2);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Controls.Add(dgvDsHoaDon);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(776, 365);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Hóa Đơn";
            // 
            // dgvDsHoaDon
            // 
            dgvDsHoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDsHoaDon.Columns.AddRange(new DataGridViewColumn[] { Column6, Column7, Column8 });
            dgvDsHoaDon.Location = new Point(6, 310);
            dgvDsHoaDon.Name = "dgvDsHoaDon";
            dgvDsHoaDon.RowHeadersWidth = 51;
            dgvDsHoaDon.Size = new Size(767, 102);
            dgvDsHoaDon.TabIndex = 1;
            // 
            // Column8
            // 
            Column8.DataPropertyName = "trang_thai";
            Column8.HeaderText = "Trạng thái";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            Column8.Width = 125;
            // 
            // Column7
            // 
            Column7.DataPropertyName = "ngay_tao";
            Column7.HeaderText = "Ngày Tạo";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.Width = 125;
            // 
            // Column6
            // 
            Column6.DataPropertyName = "ma_hd";
            Column6.HeaderText = "Mã hóa Đơn";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 125;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnThanhToan);
            groupBox1.Controls.Add(btnLamMoi);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(rdoDaThanhToan);
            groupBox1.Controls.Add(rdoChoXacNhan);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(txtNgayTao);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtMaHoaDon);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(16, 41);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(365, 226);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Hóa Đơn";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 41);
            label1.Name = "label1";
            label1.Size = new Size(94, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã Hóa Đơn";
            // 
            // txtMaHoaDon
            // 
            txtMaHoaDon.Location = new Point(106, 41);
            txtMaHoaDon.Name = "txtMaHoaDon";
            txtMaHoaDon.Size = new Size(227, 27);
            txtMaHoaDon.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 79);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 2;
            label2.Text = "Ngày tạo";
            label2.Click += label2_Click;
            // 
            // txtNgayTao
            // 
            txtNgayTao.Location = new Point(106, 79);
            txtNgayTao.Name = "txtNgayTao";
            txtNgayTao.Size = new Size(227, 27);
            txtNgayTao.TabIndex = 3;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(60, 154);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 4;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(22, 120);
            label8.Name = "label8";
            label8.Size = new Size(78, 20);
            label8.TabIndex = 5;
            label8.Text = "Trạng Thái";
            // 
            // rdoChoXacNhan
            // 
            rdoChoXacNhan.AutoSize = true;
            rdoChoXacNhan.Location = new Point(107, 121);
            rdoChoXacNhan.Name = "rdoChoXacNhan";
            rdoChoXacNhan.Size = new Size(123, 24);
            rdoChoXacNhan.TabIndex = 6;
            rdoChoXacNhan.TabStop = true;
            rdoChoXacNhan.Text = "Chờ Xác Nhận";
            rdoChoXacNhan.UseVisualStyleBackColor = true;
            // 
            // rdoDaThanhToan
            // 
            rdoDaThanhToan.AutoSize = true;
            rdoDaThanhToan.Location = new Point(236, 121);
            rdoDaThanhToan.Name = "rdoDaThanhToan";
            rdoDaThanhToan.Size = new Size(129, 24);
            rdoDaThanhToan.TabIndex = 7;
            rdoDaThanhToan.TabStop = true;
            rdoDaThanhToan.Text = "Đã Thanh Toán";
            rdoDaThanhToan.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(265, 151);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 8;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(160, 151);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 9;
            btnSua.Text = "Sửa ";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(88, 185);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(94, 29);
            btnLamMoi.TabIndex = 10;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click_1;
            // 
            // btnThanhToan
            // 
            btnThanhToan.Location = new Point(197, 186);
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.Size = new Size(94, 29);
            btnThanhToan.TabIndex = 11;
            btnThanhToan.Text = "Thanh Toán";
            btnThanhToan.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.HotTrack;
            label3.Location = new Point(275, 3);
            label3.Name = "label3";
            label3.Size = new Size(238, 35);
            label3.TabIndex = 3;
            label3.Text = "Hóa Đơn Bán Hàng";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtThanhTien);
            groupBox2.Controls.Add(label31);
            groupBox2.Controls.Add(btnXoaCT);
            groupBox2.Controls.Add(btnSuaCT);
            groupBox2.Controls.Add(btnThemCT);
            groupBox2.Controls.Add(txtSoLuong);
            groupBox2.Controls.Add(txtDonGia);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(txtTenSanPham);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtMaSanPham);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(405, 50);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(365, 254);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chi Tiết Hóa Đơn";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 41);
            label5.Name = "label5";
            label5.Size = new Size(99, 20);
            label5.TabIndex = 0;
            label5.Text = "Mã Sản Phẩm";
            // 
            // txtMaSanPham
            // 
            txtMaSanPham.Location = new Point(114, 41);
            txtMaSanPham.Name = "txtMaSanPham";
            txtMaSanPham.Size = new Size(219, 27);
            txtMaSanPham.TabIndex = 1;
            txtMaSanPham.TextChanged += txtMaSanPham_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 79);
            label4.Name = "label4";
            label4.Size = new Size(101, 20);
            label4.TabIndex = 2;
            label4.Text = "Tên Sản Phẩm";
            // 
            // txtTenSanPham
            // 
            txtTenSanPham.Location = new Point(114, 79);
            txtTenSanPham.Name = "txtTenSanPham";
            txtTenSanPham.Size = new Size(219, 27);
            txtTenSanPham.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(38, 151);
            label6.Name = "label6";
            label6.Size = new Size(72, 20);
            label6.TabIndex = 4;
            label6.Text = "Số Lượng";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(41, 112);
            label7.Name = "label7";
            label7.Size = new Size(67, 20);
            label7.TabIndex = 5;
            label7.Text = "Đơn Giá ";
            label7.Click += label7_Click;
            // 
            // txtDonGia
            // 
            txtDonGia.Location = new Point(114, 112);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(219, 27);
            txtDonGia.TabIndex = 6;
            // 
            // txtSoLuong
            // 
            txtSoLuong.Location = new Point(116, 151);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(217, 27);
            txtSoLuong.TabIndex = 7;
            // 
            // btnThemCT
            // 
            btnThemCT.Location = new Point(28, 219);
            btnThemCT.Name = "btnThemCT";
            btnThemCT.Size = new Size(94, 29);
            btnThemCT.TabIndex = 12;
            btnThemCT.Text = "Thêm";
            btnThemCT.UseVisualStyleBackColor = true;
            btnThemCT.Click += btnThemCT_Click;
            // 
            // btnSuaCT
            // 
            btnSuaCT.Location = new Point(139, 219);
            btnSuaCT.Name = "btnSuaCT";
            btnSuaCT.Size = new Size(94, 29);
            btnSuaCT.TabIndex = 13;
            btnSuaCT.Text = "Sửa";
            btnSuaCT.UseVisualStyleBackColor = true;
            btnSuaCT.Click += btnSuaCT_Click;
            // 
            // btnXoaCT
            // 
            btnXoaCT.Location = new Point(239, 219);
            btnXoaCT.Name = "btnXoaCT";
            btnXoaCT.Size = new Size(94, 29);
            btnXoaCT.TabIndex = 14;
            btnXoaCT.Text = "Xóa";
            btnXoaCT.UseVisualStyleBackColor = true;
            btnXoaCT.Click += btnXoaCT_Click;
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Location = new Point(36, 186);
            label31.Name = "label31";
            label31.Size = new Size(81, 20);
            label31.TabIndex = 15;
            label31.Text = "Thành Tiền";
            // 
            // txtThanhTien
            // 
            txtThanhTien.Location = new Point(116, 186);
            txtThanhTien.Name = "txtThanhTien";
            txtThanhTien.ReadOnly = true;
            txtThanhTien.Size = new Size(125, 27);
            txtThanhTien.TabIndex = 16;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPageHDCT);
            tabControl1.Controls.Add(tabPage6);
            tabControl1.Location = new Point(12, 31);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(784, 398);
            tabControl1.TabIndex = 1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)chiTietHoaDonBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)chiTietHoaDonBindingSource1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tabPage6.ResumeLayout(false);
            tabPage6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSanPhamChiTiet).EndInit();
            tabPageHDCT.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDsChiTietHoaDon).EndInit();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDsHoaDon).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private CheckBox checkBox1;
        private TextBox textBox4;
        private TextBox textBox5;
        private BindingSource chiTietHoaDonBindingSource;
        private BindingSource chiTietHoaDonBindingSource1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem NhanVientoolStripMenuItem;
        private ToolStripMenuItem KhachHangtoolStripMenuItem;
        private ToolStripMenuItem SanPhamToolStripMenuItem;
        private TabPage tabPage6;
        private Label label30;
        private DataGridView dgvSanPhamChiTiet;
        private TabPage tabPageHDCT;
        private DataGridView dgvDsChiTietHoaDon;
        private TabPage tabPage1;
        private GroupBox groupBox2;
        private TextBox txtThanhTien;
        private Label label31;
        private Button btnXoaCT;
        private Button btnSuaCT;
        private Button btnThemCT;
        private TextBox txtSoLuong;
        private TextBox txtDonGia;
        private Label label7;
        private Label label6;
        private TextBox txtTenSanPham;
        private Label label4;
        private TextBox txtMaSanPham;
        private Label label5;
        private Label label3;
        private GroupBox groupBox1;
        private Button btnThanhToan;
        private Button btnLamMoi;
        private Button btnSua;
        private Button btnXoa;
        private RadioButton rdoDaThanhToan;
        private RadioButton rdoChoXacNhan;
        private Label label8;
        private Button btnThem;
        private TextBox txtNgayTao;
        private Label label2;
        private TextBox txtMaHoaDon;
        private Label label1;
        private DataGridView dgvDsHoaDon;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private TabControl tabControl1;
    }
}