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
            txtTenKH = new TextBox();
            txtSDTKH = new TextBox();
            btnXoaKhachHang = new Button();
            btnSuaKhachHang = new Button();
            btnThemKhachHang = new Button();
            label18 = new Label();
            rdoNuKH = new RadioButton();
            rdoNamKH = new RadioButton();
            label19 = new Label();
            label21 = new Label();
            label22 = new Label();
            label23 = new Label();
            txtMaKhachHang = new TextBox();
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
            groupBox4.Controls.Add(txtTenKH);
            groupBox4.Controls.Add(txtSDTKH);
            groupBox4.Controls.Add(btnXoaKhachHang);
            groupBox4.Controls.Add(btnSuaKhachHang);
            groupBox4.Controls.Add(btnThemKhachHang);
            groupBox4.Controls.Add(label18);
            groupBox4.Controls.Add(rdoNuKH);
            groupBox4.Controls.Add(rdoNamKH);
            groupBox4.Controls.Add(label19);
            groupBox4.Controls.Add(label21);
            groupBox4.Controls.Add(label22);
            groupBox4.Controls.Add(label23);
            groupBox4.Controls.Add(txtMaKhachHang);
            groupBox4.Controls.Add(label24);
            groupBox4.Location = new Point(22, 82);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(747, 209);
            groupBox4.TabIndex = 7;
            groupBox4.TabStop = false;
            groupBox4.Text = "Khách Hàng";
            // 
            // txtTenKH
            // 
            txtTenKH.Location = new Point(76, 89);
            txtTenKH.Name = "txtTenKH";
            txtTenKH.Size = new Size(256, 27);
            txtTenKH.TabIndex = 18;
            // 
            // txtSDTKH
            // 
            txtSDTKH.Location = new Point(430, 49);
            txtSDTKH.Name = "txtSDTKH";
            txtSDTKH.Size = new Size(256, 27);
            txtSDTKH.TabIndex = 17;
            // 
            // btnXoaKhachHang
            // 
            btnXoaKhachHang.Location = new Point(249, 167);
            btnXoaKhachHang.Name = "btnXoaKhachHang";
            btnXoaKhachHang.Size = new Size(94, 29);
            btnXoaKhachHang.TabIndex = 16;
            btnXoaKhachHang.Text = "Xóa";
            btnXoaKhachHang.UseVisualStyleBackColor = true;
            // 
            // btnSuaKhachHang
            // 
            btnSuaKhachHang.Location = new Point(128, 167);
            btnSuaKhachHang.Name = "btnSuaKhachHang";
            btnSuaKhachHang.Size = new Size(94, 29);
            btnSuaKhachHang.TabIndex = 15;
            btnSuaKhachHang.Text = "Sửa";
            btnSuaKhachHang.UseVisualStyleBackColor = true;
            // 
            // btnThemKhachHang
            // 
            btnThemKhachHang.Location = new Point(11, 167);
            btnThemKhachHang.Name = "btnThemKhachHang";
            btnThemKhachHang.Size = new Size(94, 29);
            btnThemKhachHang.TabIndex = 14;
            btnThemKhachHang.Text = "Thêm";
            btnThemKhachHang.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(356, 98);
            label18.Name = "label18";
            label18.Size = new Size(0, 20);
            label18.TabIndex = 12;
            // 
            // rdoNuKH
            // 
            rdoNuKH.AutoSize = true;
            rdoNuKH.Location = new Point(172, 119);
            rdoNuKH.Name = "rdoNuKH";
            rdoNuKH.Size = new Size(50, 24);
            rdoNuKH.TabIndex = 9;
            rdoNuKH.TabStop = true;
            rdoNuKH.Text = "Nữ";
            rdoNuKH.UseVisualStyleBackColor = true;
            // 
            // rdoNamKH
            // 
            rdoNamKH.AutoSize = true;
            rdoNamKH.Location = new Point(95, 119);
            rdoNamKH.Name = "rdoNamKH";
            rdoNamKH.Size = new Size(62, 24);
            rdoNamKH.TabIndex = 8;
            rdoNamKH.TabStop = true;
            rdoNamKH.Text = "Nam";
            rdoNamKH.UseVisualStyleBackColor = true;
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
            label23.Location = new Point(11, 119);
            label23.Name = "label23";
            label23.Size = new Size(68, 20);
            label23.TabIndex = 2;
            label23.Text = "Giới Tính";
            // 
            // txtMaKhachHang
            // 
            txtMaKhachHang.Location = new Point(76, 49);
            txtMaKhachHang.Name = "txtMaKhachHang";
            txtMaKhachHang.Size = new Size(256, 27);
            txtMaKhachHang.TabIndex = 1;
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
            dgvDsKhachHang.Location = new Point(54, 297);
            dgvDsKhachHang.Name = "dgvDsKhachHang";
            dgvDsKhachHang.RowHeadersWidth = 51;
            dgvDsKhachHang.Size = new Size(300, 188);
            dgvDsKhachHang.TabIndex = 8;
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
        private TextBox txtSDTKH;
        private Button btnXoaKhachHang;
        private Button btnSuaKhachHang;
        private Button btnThemKhachHang;
        private Label label18;
        private RadioButton rdoNuKH;
        private RadioButton rdoNamKH;
        private Label label19;
        private Label label21;
        private Label label22;
        private Label label23;
        private TextBox txtMaKhachHang;
        private Label label24;
        private DataGridView dgvDsKhachHang;
    }
}