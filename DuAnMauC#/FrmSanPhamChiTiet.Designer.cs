namespace DuAnMauC_
{
    partial class FrmSanPhamChiTiet
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
            label26 = new Label();
            dgvDsSPCT = new DataGridView();
            groupBox2 = new GroupBox();
            cbSize = new ComboBox();
            cbMau = new ComboBox();
            txtSoLuong = new TextBox();
            label3 = new Label();
            chkTrangThai = new CheckBox();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            txtMaSPCT = new TextBox();
            btnXoa = new Button();
            btnSua = new Button();
            label5 = new Label();
            label6 = new Label();
            btnThem = new Button();
            label7 = new Label();
            txtTenSanPham = new TextBox();
            txtGiaBan = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvDsSPCT).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label26.ForeColor = SystemColors.HotTrack;
            label26.Location = new Point(260, 9);
            label26.Name = "label26";
            label26.Size = new Size(228, 35);
            label26.TabIndex = 8;
            label26.Text = "Sản Phẩm Chi Tiết";
            // 
            // dgvDsSPCT
            // 
            dgvDsSPCT.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDsSPCT.Location = new Point(10, 291);
            dgvDsSPCT.Name = "dgvDsSPCT";
            dgvDsSPCT.RowHeadersWidth = 51;
            dgvDsSPCT.Size = new Size(754, 147);
            dgvDsSPCT.TabIndex = 26;
            dgvDsSPCT.CellClick += dgvDsSPCT_CellClick;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cbSize);
            groupBox2.Controls.Add(cbMau);
            groupBox2.Controls.Add(txtSoLuong);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(chkTrangThai);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtMaSPCT);
            groupBox2.Controls.Add(btnXoa);
            groupBox2.Controls.Add(btnSua);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(btnThem);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(txtTenSanPham);
            groupBox2.Controls.Add(txtGiaBan);
            groupBox2.Location = new Point(10, 58);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(754, 227);
            groupBox2.TabIndex = 25;
            groupBox2.TabStop = false;
            groupBox2.Text = "Sản Phẩm Chi Tiết";
            // 
            // cbSize
            // 
            cbSize.FormattingEnabled = true;
            cbSize.Location = new Point(456, 83);
            cbSize.Name = "cbSize";
            cbSize.Size = new Size(151, 28);
            cbSize.TabIndex = 29;
            // 
            // cbMau
            // 
            cbMau.FormattingEnabled = true;
            cbMau.Location = new Point(456, 44);
            cbMau.Name = "cbMau";
            cbMau.Size = new Size(151, 28);
            cbMau.TabIndex = 28;
            // 
            // txtSoLuong
            // 
            txtSoLuong.Location = new Point(454, 120);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(153, 27);
            txtSoLuong.TabIndex = 27;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(376, 123);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 26;
            label3.Text = "Số Lượng";
            // 
            // chkTrangThai
            // 
            chkTrangThai.AutoSize = true;
            chkTrangThai.Location = new Point(143, 153);
            chkTrangThai.Name = "chkTrangThai";
            chkTrangThai.Size = new Size(103, 24);
            chkTrangThai.TabIndex = 25;
            chkTrangThai.Text = "Hoạt động";
            chkTrangThai.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(412, 83);
            label2.Name = "label2";
            label2.Size = new Size(36, 20);
            label2.TabIndex = 23;
            label2.Text = "Size";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(412, 48);
            label1.Name = "label1";
            label1.Size = new Size(38, 20);
            label1.TabIndex = 22;
            label1.Text = "Màu";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 44);
            label4.Name = "label4";
            label4.Size = new Size(67, 20);
            label4.TabIndex = 12;
            label4.Text = "Mã SPCT";
            // 
            // txtMaSPCT
            // 
            txtMaSPCT.Location = new Point(141, 41);
            txtMaSPCT.Name = "txtMaSPCT";
            txtMaSPCT.Size = new Size(193, 27);
            txtMaSPCT.TabIndex = 14;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(290, 188);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 19;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(167, 188);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 20;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 76);
            label5.Name = "label5";
            label5.Size = new Size(101, 20);
            label5.TabIndex = 11;
            label5.Text = "Tên Sản Phẩm";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(24, 113);
            label6.Name = "label6";
            label6.Size = new Size(60, 20);
            label6.TabIndex = 10;
            label6.Text = "Giá Bán";
            // 
            // btnThem
            // 
            btnThem.Location = new Point(47, 188);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 18;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(59, 153);
            label7.Name = "label7";
            label7.Size = new Size(78, 20);
            label7.TabIndex = 13;
            label7.Text = "Trạng Thái";
            // 
            // txtTenSanPham
            // 
            txtTenSanPham.Location = new Point(141, 76);
            txtTenSanPham.Name = "txtTenSanPham";
            txtTenSanPham.Size = new Size(193, 27);
            txtTenSanPham.TabIndex = 17;
            // 
            // txtGiaBan
            // 
            txtGiaBan.Location = new Point(141, 113);
            txtGiaBan.Name = "txtGiaBan";
            txtGiaBan.Size = new Size(193, 27);
            txtGiaBan.TabIndex = 15;
            // 
            // FrmSanPhamChiTiet
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvDsSPCT);
            Controls.Add(groupBox2);
            Controls.Add(label26);
            Name = "FrmSanPhamChiTiet";
            Text = "FrmSanPhamChiTiet";
            ((System.ComponentModel.ISupportInitialize)dgvDsSPCT).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label26;
        private DataGridView dgvDsSPCT;
        private GroupBox groupBox2;
        private Label label4;
        private TextBox txtMaSPCT;
        private Button btnXoa;
        private Button btnSua;
        private Label label5;
        private Label label6;
        private Button btnThem;
        private Label label7;
        private TextBox txtTenSanPham;
        private TextBox txtGiaBan;
        private Label label1;
        private Label label2;
        private CheckBox chkTrangThai;
        private ComboBox cbSize;
        private ComboBox cbMau;
        private TextBox txtSoLuong;
        private Label label3;
    }
}