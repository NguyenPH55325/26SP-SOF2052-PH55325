namespace DuAnMauC_
{
    partial class FrmKhachHang
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
            label17 = new Label();
            groupBox4 = new GroupBox();
            chkTrangThai = new CheckBox();
            txtTenKH = new TextBox();
            txtSDT = new TextBox();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            label18 = new Label();
            label19 = new Label();
            label21 = new Label();
            label22 = new Label();
            label23 = new Label();
            txtMaKH = new TextBox();
            label24 = new Label();
            dgvDsKhachHang = new DataGridView();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDsKhachHang).BeginInit();
            SuspendLayout();
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.ForeColor = SystemColors.HotTrack;
            label17.Location = new Point(230, 32);
            label17.Name = "label17";
            label17.Size = new Size(284, 35);
            label17.TabIndex = 6;
            label17.Text = "Danh Sách Khách Hàng";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(chkTrangThai);
            groupBox4.Controls.Add(txtTenKH);
            groupBox4.Controls.Add(txtSDT);
            groupBox4.Controls.Add(btnXoa);
            groupBox4.Controls.Add(btnSua);
            groupBox4.Controls.Add(btnThem);
            groupBox4.Controls.Add(label18);
            groupBox4.Controls.Add(label19);
            groupBox4.Controls.Add(label21);
            groupBox4.Controls.Add(label22);
            groupBox4.Controls.Add(label23);
            groupBox4.Controls.Add(txtMaKH);
            groupBox4.Controls.Add(label24);
            groupBox4.Location = new Point(22, 82);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(747, 209);
            groupBox4.TabIndex = 7;
            groupBox4.TabStop = false;
            groupBox4.Text = "Khách Hàng";
            groupBox4.Enter += groupBox4_Enter;
            // 
            // chkTrangThai
            // 
            chkTrangThai.AutoSize = true;
            chkTrangThai.Location = new Point(85, 122);
            chkTrangThai.Name = "chkTrangThai";
            chkTrangThai.Size = new Size(105, 24);
            chkTrangThai.TabIndex = 19;
            chkTrangThai.Text = "Hoạt Động";
            chkTrangThai.UseVisualStyleBackColor = true;
            // 
            // txtTenKH
            // 
            txtTenKH.Location = new Point(76, 89);
            txtTenKH.Name = "txtTenKH";
            txtTenKH.Size = new Size(256, 27);
            txtTenKH.TabIndex = 18;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(430, 49);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(256, 27);
            txtSDT.TabIndex = 17;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(249, 167);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 16;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(128, 167);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 15;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(11, 167);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 14;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(356, 98);
            label18.Name = "label18";
            label18.Size = new Size(0, 20);
            label18.TabIndex = 12;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(388, 56);
            label19.Name = "label19";
            label19.Size = new Size(36, 20);
            label19.TabIndex = 6;
            label19.Text = "SĐT";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(305, 176);
            label21.Name = "label21";
            label21.Size = new Size(0, 20);
            label21.TabIndex = 4;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(24, 86);
            label22.Name = "label22";
            label22.Size = new Size(36, 20);
            label22.TabIndex = 3;
            label22.Text = "Tên ";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(0, 122);
            label23.Name = "label23";
            label23.Size = new Size(78, 20);
            label23.TabIndex = 2;
            label23.Text = "Trạng Thái";
            // 
            // txtMaKH
            // 
            txtMaKH.Location = new Point(76, 49);
            txtMaKH.Name = "txtMaKH";
            txtMaKH.Size = new Size(256, 27);
            txtMaKH.TabIndex = 1;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(6, 49);
            label24.Name = "label24";
            label24.Size = new Size(54, 20);
            label24.TabIndex = 0;
            label24.Text = "Mã KH";
            // 
            // dgvDsKhachHang
            // 
            dgvDsKhachHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDsKhachHang.Location = new Point(22, 297);
            dgvDsKhachHang.Name = "dgvDsKhachHang";
            dgvDsKhachHang.RowHeadersWidth = 51;
            dgvDsKhachHang.Size = new Size(747, 141);
            dgvDsKhachHang.TabIndex = 8;
            dgvDsKhachHang.CellClick += dgvDsKhachHang_CellClick;
            // 
            // FrmKhachHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvDsKhachHang);
            Controls.Add(groupBox4);
            Controls.Add(label17);
            Name = "FrmKhachHang";
            Text = "FrmKhachHang";
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDsKhachHang).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label17;
        private GroupBox groupBox4;
        private TextBox txtTenKH;
        private TextBox txtSDT;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private Label label18;
        private Label label19;
        private Label label21;
        private Label label22;
        private Label label23;
        private TextBox txtMaKH;
        private Label label24;
        private DataGridView dgvDsKhachHang;
        private CheckBox chkTrangThai;
    }
}