namespace DuAnMauC_
{
    partial class FrmNhanVien
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
            label9 = new Label();
            groupBox3 = new GroupBox();
            cboTrangThai = new ComboBox();
            txtSDT = new TextBox();
            label25 = new Label();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            label16 = new Label();
            rdoNu = new RadioButton();
            rdoNam = new RadioButton();
            txtTen = new TextBox();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            txtMaNV = new TextBox();
            label10 = new Label();
            dgvDsNhanVien = new DataGridView();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDsNhanVien).BeginInit();
            SuspendLayout();
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.HotTrack;
            label9.Location = new Point(252, 38);
            label9.Name = "label9";
            label9.Size = new Size(267, 35);
            label9.TabIndex = 5;
            label9.Text = "Danh Sách Nhân Viên";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(cboTrangThai);
            groupBox3.Controls.Add(txtSDT);
            groupBox3.Controls.Add(label25);
            groupBox3.Controls.Add(btnXoa);
            groupBox3.Controls.Add(btnSua);
            groupBox3.Controls.Add(btnThem);
            groupBox3.Controls.Add(label16);
            groupBox3.Controls.Add(rdoNu);
            groupBox3.Controls.Add(rdoNam);
            groupBox3.Controls.Add(txtTen);
            groupBox3.Controls.Add(label13);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(txtMaNV);
            groupBox3.Controls.Add(label10);
            groupBox3.Location = new Point(16, 121);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(769, 209);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            groupBox3.Text = "Nhân Viên";
            // 
            // cboTrangThai
            // 
            cboTrangThai.FormattingEnabled = true;
            cboTrangThai.Location = new Point(454, 160);
            cboTrangThai.Name = "cboTrangThai";
            cboTrangThai.Size = new Size(151, 28);
            cboTrangThai.TabIndex = 19;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(439, 46);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(256, 27);
            txtSDT.TabIndex = 18;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(397, 53);
            label25.Name = "label25";
            label25.Size = new Size(36, 20);
            label25.TabIndex = 17;
            label25.Text = "SĐT";
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
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(371, 163);
            label16.Name = "label16";
            label16.Size = new Size(78, 20);
            label16.TabIndex = 12;
            label16.Text = "Trạng Thái";
            // 
            // rdoNu
            // 
            rdoNu.AutoSize = true;
            rdoNu.Location = new Point(172, 119);
            rdoNu.Name = "rdoNu";
            rdoNu.Size = new Size(50, 24);
            rdoNu.TabIndex = 9;
            rdoNu.TabStop = true;
            rdoNu.Text = "Nữ";
            rdoNu.UseVisualStyleBackColor = true;
            // 
            // rdoNam
            // 
            rdoNam.AutoSize = true;
            rdoNam.Location = new Point(95, 119);
            rdoNam.Name = "rdoNam";
            rdoNam.Size = new Size(62, 24);
            rdoNam.TabIndex = 8;
            rdoNam.TabStop = true;
            rdoNam.Text = "Nam";
            rdoNam.UseVisualStyleBackColor = true;
            // 
            // txtTen
            // 
            txtTen.Location = new Point(76, 83);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(256, 27);
            txtTen.TabIndex = 7;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(305, 176);
            label13.Name = "label13";
            label13.Size = new Size(0, 20);
            label13.TabIndex = 4;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(24, 86);
            label12.Name = "label12";
            label12.Size = new Size(36, 20);
            label12.TabIndex = 3;
            label12.Text = "Tên ";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(11, 119);
            label11.Name = "label11";
            label11.Size = new Size(68, 20);
            label11.TabIndex = 2;
            label11.Text = "Giới Tính";
            // 
            // txtMaNV
            // 
            txtMaNV.Location = new Point(76, 42);
            txtMaNV.Name = "txtMaNV";
            txtMaNV.Size = new Size(256, 27);
            txtMaNV.TabIndex = 1;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 49);
            label10.Name = "label10";
            label10.Size = new Size(54, 20);
            label10.TabIndex = 0;
            label10.Text = "Mã NV";
            // 
            // dgvDsNhanVien
            // 
            dgvDsNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDsNhanVien.Location = new Point(16, 336);
            dgvDsNhanVien.Name = "dgvDsNhanVien";
            dgvDsNhanVien.RowHeadersWidth = 51;
            dgvDsNhanVien.Size = new Size(772, 79);
            dgvDsNhanVien.TabIndex = 7;
            dgvDsNhanVien.CellClick += dgvDsNhanVien_CellClick;
            // 
            // FrmNhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvDsNhanVien);
            Controls.Add(groupBox3);
            Controls.Add(label9);
            Name = "FrmNhanVien";
            Text = "FrmNhanVien";
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDsNhanVien).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label9;
        private GroupBox groupBox3;
        private ComboBox cboTrangThai;
        private TextBox txtSDT;
        private Label label25;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private Label label16;
        private RadioButton rdoNu;
        private RadioButton rdoNam;
        private TextBox txtTen;
        private Label label13;
        private Label label12;
        private Label label11;
        private TextBox txtMaNV;
        private Label label10;
        private DataGridView dgvDsNhanVien;
    }
}