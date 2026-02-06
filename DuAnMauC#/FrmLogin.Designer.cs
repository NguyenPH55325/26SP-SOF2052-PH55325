namespace DuAnMauC_
{
    partial class FrmLogin
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
            groupBox1 = new GroupBox();
            btnExit = new Button();
            btnLogin = new Button();
            chkShowPass = new CheckBox();
            txtPass = new TextBox();
            label2 = new Label();
            txtUser = new TextBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnExit);
            groupBox1.Controls.Add(btnLogin);
            groupBox1.Controls.Add(chkShowPass);
            groupBox1.Controls.Add(txtPass);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtUser);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(59, 34);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(459, 252);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Đăng Nhập";
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.IndianRed;
            btnExit.ForeColor = SystemColors.ButtonHighlight;
            btnExit.Location = new Point(299, 192);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(59, 29);
            btnExit.TabIndex = 6;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.Highlight;
            btnLogin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = SystemColors.ButtonHighlight;
            btnLogin.Location = new Point(128, 192);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(100, 29);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Đăng Nhập";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // chkShowPass
            // 
            chkShowPass.AutoSize = true;
            chkShowPass.Location = new Point(123, 143);
            chkShowPass.Name = "chkShowPass";
            chkShowPass.Size = new Size(129, 24);
            chkShowPass.TabIndex = 4;
            chkShowPass.Text = "Hiện Mật Khẩu";
            chkShowPass.UseVisualStyleBackColor = true;
            chkShowPass.CheckedChanged += chkShowPass_CheckedChanged;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(126, 97);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(232, 27);
            txtPass.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 97);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 2;
            label2.Text = "Mật Khẩu";
            // 
            // txtUser
            // 
            txtUser.Location = new Point(126, 59);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(232, 27);
            txtUser.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 62);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 0;
            label1.Text = "Tài Khoản";
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "FrmLogin";
            Text = "FrmDangNhap";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnExit;
        private Button btnLogin;
        private CheckBox chkShowPass;
        private TextBox txtPass;
        private Label label2;
        private TextBox txtUser;
        private Label label1;
    }
}