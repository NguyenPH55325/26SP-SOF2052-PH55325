using DuAnMauC_.DAL;
using System;
using System.Windows.Forms;

namespace DuAnMauC_
{
    public partial class FrmSanPhamChiTiet : Form
    {
        public FrmSanPhamChiTiet()
        {
            InitializeComponent();
            WireEvents();
            LoadCombos();
            SelectAll();

            txtMaSPCT.Focus();
        }

        private void WireEvents()
        {
            btnThem.Click += btnThem_Click;
            btnSua.Click += btnSua_Click;
            btnXoa.Click += btnXoa_Click;
            dgvDsSPCT.CellClick += dgvDsSPCT_CellClick;
        }

        // ===================== LOAD COMBO =====================
        private void LoadCombos()
        {
            // Màu
            cbMau.DisplayMember = "TenMau";
            cbMau.ValueMember = "MaMau";
            cbMau.DataSource = MauSacDAL.SelectAll();

            // Size
            cbSize.DisplayMember = "TenSize";
            cbSize.ValueMember = "MaSize";
            cbSize.DataSource = SizeDAL.SelectAll();
        }

        // ===================== LOAD GRID =====================
        private void SelectAll()
        {
            dgvDsSPCT.AutoGenerateColumns = true;
            dgvDsSPCT.DataSource = SanPhamChiTietDAL.SelectAll();
        }

        // ===================== VALIDATE =====================
        private bool ValidateInput(out string maSpct, out string maSp, out string maMau, out string maSize,
                                   out decimal donGia, out int soLuong, out bool trangThai)
        {
            maSpct = txtMaSPCT.Text.Trim();
            maSp = txtTenSanPham.Text.Trim(); // ⚠️ hiện nhập MÃ SP vào đây
            maMau = cbMau.SelectedValue?.ToString();
            maSize = cbSize.SelectedValue?.ToString();
            trangThai = chkTrangThai.Checked;

            if (string.IsNullOrWhiteSpace(maSpct))
            {
                MessageBox.Show("Vui lòng nhập Mã SPCT.");
                donGia = 0; soLuong = 0;
                return false;
            }

            if (string.IsNullOrWhiteSpace(maSp))
            {
                MessageBox.Show("Vui lòng nhập Mã SP (đang để ở ô Tên Sản Phẩm).");
                donGia = 0; soLuong = 0;
                return false;
            }

            if (string.IsNullOrWhiteSpace(maMau) || string.IsNullOrWhiteSpace(maSize))
            {
                MessageBox.Show("Vui lòng chọn Màu và Size.");
                donGia = 0; soLuong = 0;
                return false;
            }

            if (!decimal.TryParse(txtGiaBan.Text.Trim(), out donGia) || donGia < 0)
            {
                MessageBox.Show("Giá bán không hợp lệ.");
                soLuong = 0;
                return false;
            }

            if (!int.TryParse(txtSoLuong.Text.Trim(), out soLuong) || soLuong < 0)
            {
                MessageBox.Show("Số lượng không hợp lệ.");
                return false;
            }

            return true;
        }

        private void ClearForm()
        {
            txtMaSPCT.Clear();
            txtTenSanPham.Clear();
            txtGiaBan.Clear();
            txtSoLuong.Clear();
            chkTrangThai.Checked = true;

            if (cbMau.Items.Count > 0) cbMau.SelectedIndex = 0;
            if (cbSize.Items.Count > 0) cbSize.SelectedIndex = 0;

            txtMaSPCT.Focus();
        }

        // ===================== THÊM =====================
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateInput(out string maSpct, out string maSp, out string maMau, out string maSize,
                                   out decimal donGia, out int soLuong, out bool trangThai))
                    return;

                // Check trùng biến thể (SP + Màu + Size)
                var dtCheck = SanPhamChiTietDAL.KiemTraTrungBienThe(maSp, maMau, maSize);
                if (dtCheck.Rows.Count > 0)
                {
                    MessageBox.Show("Biến thể (SP + Màu + Size) đã tồn tại!");
                    return;
                }

                SanPhamChiTietDAL.TaoMoi(maSpct, maSp, maMau, maSize, donGia, soLuong, trangThai);

                MessageBox.Show("Thêm SPCT thành công ✅");
                SelectAll();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm SPCT: " + ex.Message);
            }
        }

        // ===================== SỬA =====================
        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateInput(out string maSpct, out string maSp, out string maMau, out string maSize,
                                   out decimal donGia, out int soLuong, out bool trangThai))
                    return;

                SanPhamChiTietDAL.CapNhat(maSpct, maSp, maMau, maSize, donGia, soLuong, trangThai);

                MessageBox.Show("Sửa SPCT thành công ✅");
                SelectAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi sửa SPCT: " + ex.Message);
            }
        }

        // ===================== XÓA =====================
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string maSpct = txtMaSPCT.Text.Trim();
                if (string.IsNullOrWhiteSpace(maSpct))
                {
                    MessageBox.Show("Vui lòng chọn SPCT cần xóa.");
                    return;
                }

                var confirm = MessageBox.Show("Xóa SPCT này luôn hả?", "Xác nhận",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirm != DialogResult.Yes) return;

                SanPhamChiTietDAL.Xoa(maSpct);

                MessageBox.Show("Xóa SPCT thành công ✅");
                SelectAll();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xóa SPCT: " + ex.Message);
            }
        }

        // ===================== CLICK GRID -> ĐỔ LÊN FORM =====================
        private void dgvDsSPCT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dgvDsSPCT.Rows[e.RowIndex];

            txtMaSPCT.Text = row.Cells["MaSPCT"].Value?.ToString();

            // tuỳ SelectAll() của m đang trả MaSP hay TenSanPham
            if (dgvDsSPCT.Columns.Contains("MaSP"))
                txtTenSanPham.Text = row.Cells["MaSP"].Value?.ToString();
            else if (dgvDsSPCT.Columns.Contains("TenSanPham"))
                txtTenSanPham.Text = row.Cells["TenSanPham"].Value?.ToString();

            txtGiaBan.Text = row.Cells["DonGia"].Value?.ToString();
            txtSoLuong.Text = row.Cells["SoLuong"].Value?.ToString();

            var maMau = row.Cells["MaMau"].Value?.ToString();
            var maSize = row.Cells["MaSize"].Value?.ToString();

            if (!string.IsNullOrWhiteSpace(maMau)) cbMau.SelectedValue = maMau;
            if (!string.IsNullOrWhiteSpace(maSize)) cbSize.SelectedValue = maSize;

            var tt = row.Cells["TrangThai"].Value?.ToString();
            chkTrangThai.Checked = (tt == "True" || tt == "1");
        }
    }
}
