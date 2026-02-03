using DuAnMauC_.DAO;
using DuAnMauC_.DAL;
using System;
using System.Windows.Forms;

namespace DuAnMauC_
{
    public partial class FrmNhanVien : Form
    {
        public FrmNhanVien()
        {
            InitializeComponent();
            InitTrangThai();
            SelectAll();
            WireEvents();

            // Auto mã
            txtMaNV.ReadOnly = true;
            txtMaNV.Text = NhanVienDAL.TaoMaTuDong();
        }

        private void WireEvents()
        {
            btnThem.Click += btnThem_Click;
            btnSua.Click += btnSua_Click;
            btnXoa.Click += btnXoa_Click;
            dgvDsNhanVien.CellClick += dgvDsNhanVien_CellClick;
        }

        private void InitTrangThai()
        {
            // ComboBox: hiển thị text, lưu bool qua SelectedIndex
            cboTrangThai.Items.Clear();
            cboTrangThai.Items.Add("Đang làm"); // true
            cboTrangThai.Items.Add("Nghỉ");     // false
            cboTrangThai.SelectedIndex = 0;

            // Email + Chức vụ hiện chưa lưu theo DAO -> disable cho khỏi gây hiểu nhầm
            //if (txtEmail != null) txtEmail.Enabled = false;
            //if (txtChucVu != null) txtChucVu.Enabled = false;
        }

        public void SelectAll()
        {
            dgvDsNhanVien.AutoGenerateColumns = true;
            dgvDsNhanVien.DataSource = NhanVienDAL.SelectAll();
        }

        private bool GetTrangThaiFromCombo()
        {
            // index 0 = đang làm (true), 1 = nghỉ (false)
            return cboTrangThai.SelectedIndex == 0;
        }

        private void SetTrangThaiToCombo(bool trangThai)
        {
            cboTrangThai.SelectedIndex = trangThai ? 0 : 1;
        }

        private NhanVien ReadForm()
        {
            bool gioiTinh = rdoNam.Checked; // true = Nam, false = Nữ

            return new NhanVien
            {
                MaNhanVien = txtMaNV.Text.Trim(),
                TenNhanVien = txtTen.Text.Trim(),
                GioiTinh = gioiTinh,
                SoDienThoai = txtSDT.Text.Trim(),
                TrangThai = GetTrangThaiFromCombo()
            };
        }

        private void ClearForm()
        {
            txtMaNV.Text = NhanVienDAL.TaoMaTuDong();
            txtTen.Clear();
            txtSDT.Clear();
            rdoNam.Checked = true;
            cboTrangThai.SelectedIndex = 0;

            txtTen.Focus();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                var nv = ReadForm();

                if (string.IsNullOrWhiteSpace(nv.TenNhanVien))
                {
                    MessageBox.Show("Tên nhân viên không được để trống.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(nv.SoDienThoai))
                {
                    MessageBox.Show("SĐT không được để trống.");
                    return;
                }

                NhanVienDAL.TaoMoi(nv);
                MessageBox.Show("Thêm nhân viên thành công ✅");

                SelectAll();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm nhân viên: " + ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                var nv = ReadForm();

                if (string.IsNullOrWhiteSpace(nv.MaNhanVien))
                {
                    MessageBox.Show("Chọn nhân viên cần sửa.");
                    return;
                }

                NhanVienDAL.CapNhat(nv);
                MessageBox.Show("Sửa nhân viên thành công ✅");

                SelectAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi sửa nhân viên: " + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string ma = txtMaNV.Text.Trim();
                if (string.IsNullOrWhiteSpace(ma))
                {
                    MessageBox.Show("Chọn nhân viên cần xóa.");
                    return;
                }

                var confirm = MessageBox.Show("Xóa nhân viên này luôn hả?", "Xác nhận",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirm != DialogResult.Yes) return;

                NhanVienDAL.Xoa(ma);
                MessageBox.Show("Xóa nhân viên thành công ✅");

                SelectAll();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xóa nhân viên: " + ex.Message);
            }
        }

        private void dgvDsNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dgvDsNhanVien.Rows[e.RowIndex];

            txtMaNV.Text = row.Cells["MaNhanVien"].Value?.ToString();
            txtTen.Text = row.Cells["TenNhanVien"].Value?.ToString();
            txtSDT.Text = row.Cells["SoDienThoai"].Value?.ToString();

            var gt = row.Cells["GioiTinh"].Value?.ToString(); // True/False hoặc 1/0
            bool gioiTinh = (gt == "True" || gt == "1");
            rdoNam.Checked = gioiTinh;
            rdoNu.Checked = !gioiTinh;

            var tt = row.Cells["TrangThai"].Value?.ToString();
            bool trangThai = (tt == "True" || tt == "1");
            SetTrangThaiToCombo(trangThai);

            // Khi chọn dòng -> không cho đổi mã
            txtMaNV.ReadOnly = true;
        }
    }
}
