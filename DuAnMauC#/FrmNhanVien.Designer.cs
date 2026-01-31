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
            cbbTrangThaiNV = new ComboBox();
            txtSDT = new TextBox();
            label25 = new Label();
            btnXoaNhanVien = new Button();
            btnSuaNhanVien = new Button();
            btnThemNhanVien = new Button();
            label16 = new Label();
            txtChucVu = new TextBox();
            txtEmail = new TextBox();
            rdoNu = new RadioButton();
            rdoNam = new RadioButton();
            txtTenNhanVien = new TextBox();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            txtMaNhanVien = new TextBox();
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
            groupBox3.Controls.Add(cbbTrangThaiNV);
            groupBox3.Controls.Add(txtSDT);
            groupBox3.Controls.Add(label25);
            groupBox3.Controls.Add(btnXoaNhanVien);
            groupBox3.Controls.Add(btnSuaNhanVien);
            groupBox3.Controls.Add(btnThemNhanVien);
            groupBox3.Controls.Add(label16);
            groupBox3.Controls.Add(txtChucVu);
            groupBox3.Controls.Add(txtEmail);
            groupBox3.Controls.Add(rdoNu);
            groupBox3.Controls.Add(rdoNam);
            groupBox3.Controls.Add(txtTenNhanVien);
            groupBox3.Controls.Add(label15);
            groupBox3.Controls.Add(label14);
            groupBox3.Controls.Add(label13);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(txtMaNhanVien);
            groupBox3.Controls.Add(label10);
            groupBox3.Location = new Point(16, 121);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(769, 209);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            groupBox3.Text = "Nhân Viên";
            // 
            // cbbTrangThaiNV
            // 
            cbbTrangThaiNV.FormattingEnabled = true;
            cbbTrangThaiNV.Location = new Point(454, 160);
            cbbTrangThaiNV.Name = "cbbTrangThaiNV";
            cbbTrangThaiNV.Size = new Size(151, 28);
            cbbTrangThaiNV.TabIndex = 19;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(440, 120);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(256, 27);
            txtSDT.TabIndex = 18;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(398, 119);
            label25.Name = "label25";
            label25.Size = new Size(36, 20);
            label25.TabIndex = 17;
            label25.Text = "SĐT";
            // 
            // btnXoaNhanVien
            // 
            btnXoaNhanVien.Location = new Point(249, 167);
            btnXoaNhanVien.Name = "btnXoaNhanVien";
            btnXoaNhanVien.Size = new Size(94, 29);
            btnXoaNhanVien.TabIndex = 16;
            btnXoaNhanVien.Text = "Xóa";
            btnXoaNhanVien.UseVisualStyleBackColor = true;
            // 
            // btnSuaNhanVien
            // 
            btnSuaNhanVien.Location = new Point(128, 167);
            btnSuaNhanVien.Name = "btnSuaNhanVien";
            btnSuaNhanVien.Size = new Size(94, 29);
            btnSuaNhanVien.TabIndex = 15;
            btnSuaNhanVien.Text = "Sửa";
            btnSuaNhanVien.UseVisualStyleBackColor = true;
            // 
            // btnThemNhanVien
            // 
            btnThemNhanVien.Location = new Point(11, 167);
            btnThemNhanVien.Name = "btnThemNhanVien";
            btnThemNhanVien.Size = new Size(94, 29);
            btnThemNhanVien.TabIndex = 14;
            btnThemNhanVien.Text = "Thêm";
            btnThemNhanVien.UseVisualStyleBackColor = true;
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
            // txtChucVu
            // 
            txtChucVu.Location = new Point(440, 79);
            txtChucVu.Name = "txtChucVu";
            txtChucVu.Size = new Size(256, 27);
            txtChucVu.TabIndex = 11;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(440, 42);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(256, 27);
            txtEmail.TabIndex = 10;
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
            // txtTenNhanVien
            // 
            txtTenNhanVien.Location = new Point(76, 83);
            txtTenNhanVien.Name = "txtTenNhanVien";
            txtTenNhanVien.Size = new Size(256, 27);
            txtTenNhanVien.TabIndex = 7;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(388, 49);
            label15.Name = "label15";
            label15.Size = new Size(46, 20);
            label15.TabIndex = 6;
            label15.Text = "Email";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(371, 82);
            label14.Name = "label14";
            label14.Size = new Size(63, 20);
            label14.TabIndex = 5;
            label14.Text = "Chức Vụ";
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
            // txtMaNhanVien
            // 
            txtMaNhanVien.Location = new Point(76, 42);
            txtMaNhanVien.Name = "txtMaNhanVien";
            txtMaNhanVien.Size = new Size(256, 27);
            txtMaNhanVien.TabIndex = 1;
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
            dgvDsNhanVien.Location = new Point(48, 336);
            dgvDsNhanVien.Name = "dgvDsNhanVien";
            dgvDsNhanVien.RowHeadersWidth = 51;
            dgvDsNhanVien.Size = new Size(300, 79);
            dgvDsNhanVien.TabIndex = 7;
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
        private ComboBox cbbTrangThaiNV;
        private TextBox txtSDT;
        private Label label25;
        private Button btnXoaNhanVien;
        private Button btnSuaNhanVien;
        private Button btnThemNhanVien;
        private Label label16;
        private TextBox txtChucVu;
        private TextBox txtEmail;
        private RadioButton rdoNu;
        private RadioButton rdoNam;
        private TextBox txtTenNhanVien;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private TextBox txtMaNhanVien;
        private Label label10;
        private DataGridView dgvDsNhanVien;
    }
}