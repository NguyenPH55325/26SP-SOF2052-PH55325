namespace DuAnMauC_
{
    partial class FrmSanPham
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
            label28 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtMaSanPham = new TextBox();
            txtThuongHieu = new TextBox();
            txtTrangThai = new TextBox();
            txtTenSanPham = new TextBox();
            btnThemSanPham = new Button();
            button1 = new Button();
            button2 = new Button();
            dgvDsSanPham = new DataGridView();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            label4 = new Label();
            textBox1 = new TextBox();
            button3 = new Button();
            button4 = new Button();
            label5 = new Label();
            label6 = new Label();
            button5 = new Button();
            label7 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvDsSanPham).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label26.ForeColor = SystemColors.HotTrack;
            label26.Location = new Point(259, 57);
            label26.Name = "label26";
            label26.Size = new Size(259, 35);
            label26.TabIndex = 7;
            label26.Text = "Danh Sách Sản Phẩm";
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Location = new Point(24, 113);
            label28.Name = "label28";
            label28.Size = new Size(92, 20);
            label28.TabIndex = 10;
            label28.Text = "Thương hiệu";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 76);
            label1.Name = "label1";
            label1.Size = new Size(101, 20);
            label1.TabIndex = 11;
            label1.Text = "Tên Sản Phẩm";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 44);
            label2.Name = "label2";
            label2.Size = new Size(99, 20);
            label2.TabIndex = 12;
            label2.Text = "Mã Sản Phẩm";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 145);
            label3.Name = "label3";
            label3.Size = new Size(78, 20);
            label3.TabIndex = 13;
            label3.Text = "Trạng Thái";
            // 
            // txtMaSanPham
            // 
            txtMaSanPham.Location = new Point(141, 41);
            txtMaSanPham.Name = "txtMaSanPham";
            txtMaSanPham.Size = new Size(243, 27);
            txtMaSanPham.TabIndex = 14;
            // 
            // txtThuongHieu
            // 
            txtThuongHieu.Location = new Point(141, 113);
            txtThuongHieu.Name = "txtThuongHieu";
            txtThuongHieu.Size = new Size(243, 27);
            txtThuongHieu.TabIndex = 15;
            // 
            // txtTrangThai
            // 
            txtTrangThai.Location = new Point(141, 146);
            txtTrangThai.Name = "txtTrangThai";
            txtTrangThai.Size = new Size(243, 27);
            txtTrangThai.TabIndex = 16;
            // 
            // txtTenSanPham
            // 
            txtTenSanPham.Location = new Point(141, 76);
            txtTenSanPham.Name = "txtTenSanPham";
            txtTenSanPham.Size = new Size(243, 27);
            txtTenSanPham.TabIndex = 17;
            // 
            // btnThemSanPham
            // 
            btnThemSanPham.Location = new Point(47, 188);
            btnThemSanPham.Name = "btnThemSanPham";
            btnThemSanPham.Size = new Size(94, 29);
            btnThemSanPham.TabIndex = 18;
            btnThemSanPham.Text = "Thêm";
            btnThemSanPham.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(290, 188);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 19;
            button1.Text = "Xóa";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(167, 188);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 20;
            button2.Text = "Sửa";
            button2.UseVisualStyleBackColor = true;
            // 
            // dgvDsSanPham
            // 
            dgvDsSanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDsSanPham.Location = new Point(12, 342);
            dgvDsSanPham.Name = "dgvDsSanPham";
            dgvDsSanPham.RowHeadersWidth = 51;
            dgvDsSanPham.Size = new Size(570, 138);
            dgvDsSanPham.TabIndex = 21;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtMaSanPham);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label28);
            groupBox1.Controls.Add(btnThemSanPham);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtTrangThai);
            groupBox1.Controls.Add(txtTenSanPham);
            groupBox1.Controls.Add(txtThuongHieu);
            groupBox1.Location = new Point(12, 109);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(412, 227);
            groupBox1.TabIndex = 22;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sản Phẩm";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(button4);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(button5);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(textBox4);
            groupBox2.Location = new Point(468, 109);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(412, 227);
            groupBox2.TabIndex = 23;
            groupBox2.TabStop = false;
            groupBox2.Text = "Sản Phẩm Chi Tiết";
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
            // textBox1
            // 
            textBox1.Location = new Point(141, 41);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(243, 27);
            textBox1.TabIndex = 14;
            // 
            // button3
            // 
            button3.Location = new Point(290, 188);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 19;
            button3.Text = "Xóa";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(167, 188);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 20;
            button4.Text = "Sửa";
            button4.UseVisualStyleBackColor = true;
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
            label6.Size = new Size(92, 20);
            label6.TabIndex = 10;
            label6.Text = "Thương hiệu";
            // 
            // button5
            // 
            button5.Location = new Point(47, 188);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 18;
            button5.Text = "Thêm";
            button5.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(38, 145);
            label7.Name = "label7";
            label7.Size = new Size(78, 20);
            label7.TabIndex = 13;
            label7.Text = "Trạng Thái";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(141, 146);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(243, 27);
            textBox2.TabIndex = 16;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(141, 76);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(243, 27);
            textBox3.TabIndex = 17;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(141, 113);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(243, 27);
            textBox4.TabIndex = 15;
            // 
            // FrmSanPham
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(955, 615);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dgvDsSanPham);
            Controls.Add(label26);
            Name = "FrmSanPham";
            Text = "FrmSanPham";
            ((System.ComponentModel.ISupportInitialize)dgvDsSanPham).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label26;
        private Label label28;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtMaSanPham;
        private TextBox txtThuongHieu;
        private TextBox txtTrangThai;
        private TextBox txtTenSanPham;
        private Button btnThemSanPham;
        private Button button1;
        private Button button2;
        private DataGridView dgvDsSanPham;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label4;
        private TextBox textBox1;
        private Button button3;
        private Button button4;
        private Label label5;
        private Label label6;
        private Button button5;
        private Label label7;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
    }
}