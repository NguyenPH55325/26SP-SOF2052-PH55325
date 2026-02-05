using DuAnMauC_.DAL;
using System;
using System.Data;
using System.Windows.Forms;

namespace DuAnMauC_
{
    public partial class FrmSanPhamChiTiet : Form
    {
        public FrmSanPhamChiTiet()
        {
            InitializeComponent();
            InitUI();
            LoadCombos();
            SelectAll();
            WireEvents();
        }

        private void InitUI()
        {
            txtMaSPCT.ReadOnly = true;
            txtMaSPCT.Text = SanPhamChiTietDAL.TaoMaTuDong();
            chkTrangThai.Checked = true;
        }

        private void WireEvents()
        {
            btnThem.Click += btnThem_Click;
            btnSua.Click += btnSua_Click;
            btnXoa.Click += btnXoa_Click;
            dgvDsSPCT.CellClick += dgvDsSPCT_CellClick;
            cbSanPham.SelectedIndexChanged += cbSanPham_SelectedIndexChanged;
        }

        // ===== LOAD COMBO =====
        private bool _loaded = false;

        private void LoadCombos()
        {
            // ===== SẢN PHẨM (có "Tất cả") =====
            DataTable dtSanPham = SanPhamDAL.SelectForCombo();

            DataRow allRow = dtSanPham.NewRow();
            allRow["MaSP"] = "";
            allRow["TenSP"] = "-- Tất cả sản phẩm --";
            dtSanPham.Rows.InsertAt(allRow, 0);

            cbSanPham.DisplayMember = "TenSP";
            cbSanPham.ValueMember = "MaSP";
            cbSanPham.DataSource = dtSanPham;
            cbSanPham.SelectedIndex = 0;

            // ===== MÀU =====
            cbMau.DisplayMember = "TenMau";
            cbMau.ValueMember = "MaMau";
            cbMau.DataSource = MauSacDAL.SelectAll();

            // ===== SIZE =====
            cbSize.DisplayMember = "TenSize";
            cbSize.ValueMember = "MaSize";
            cbSize.DataSource = SizeDAL.SelectAll();

            _loaded = true;
        }



        // ===== LOAD GRID =====
        private void SelectAll()
        {
            dgvDsSPCT.AutoGenerateColumns = true;
            dgvDsSPCT.DataSource = SanPhamChiTietDAL.SelectAll();
        }

        private void SelectBySanPham()
        {
            if (cbSanPham.SelectedValue == null) return;
            string maSp = cbSanPham.SelectedValue.ToString();
            dgvDsSPCT.DataSource = SanPhamChiTietDAL.SelectByMaSP(maSp);
        }

        // ===== READ FORM =====
        private bool ReadForm(out string maSpct, out string maSp, out string maMau,
                              out string maSize, out decimal donGia, out int soLuong, out bool trangThai)
        {
            maSpct = txtMaSPCT.Text.Trim();
            maSp = cbSanPham.SelectedValue?.ToString();
            maMau = cbMau.SelectedValue?.ToString();
            maSize = cbSize.SelectedValue?.ToString();
            trangThai = chkTrangThai.Checked;

            if (!decimal.TryParse(txtGiaBan.Text, out donGia) || donGia < 0)
            {
                MessageBox.Show("Giá bán không hợp lệ.");
                soLuong = 0;
                return false;
            }

            if (!int.TryParse(txtSoLuong.Text, out soLuong) || soLuong < 0)
            {
                MessageBox.Show("Số lượng không hợp lệ.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(maSp) || string.IsNullOrWhiteSpace(maMau) || string.IsNullOrWhiteSpace(maSize))
            {
                MessageBox.Show("Vui lòng chọn Sản phẩm, Màu và Size.");
                return false;
            }

            return true;
        }

        private void ClearForm()
        {
            txtMaSPCT.Text = SanPhamChiTietDAL.TaoMaTuDong();
            txtGiaBan.Clear();
            txtSoLuong.Clear();
            chkTrangThai.Checked = true;
            txtGiaBan.Focus();
        }

        // ===== THÊM =====
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!ReadForm(out string maSpct, out string maSp, out string maMau,
                          out string maSize, out decimal donGia, out int soLuong, out bool trangThai))
                return;

            // chặn trùng biến thể
            if (SanPhamChiTietDAL.KiemTraTrungBienThe(maSp, maMau, maSize).Rows.Count > 0)
            {
                MessageBox.Show("Biến thể này đã tồn tại.");
                return;
            }

            SanPhamChiTietDAL.TaoMoi(maSpct, maSp, maMau, maSize, donGia, soLuong, trangThai);
            MessageBox.Show("Thêm SPCT thành công ✅");

            SelectBySanPham();
            ClearForm();
        }

        // ===== SỬA =====
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!ReadForm(out string maSpct, out string maSp, out string maMau,
                          out string maSize, out decimal donGia, out int soLuong, out bool trangThai))
                return;

            SanPhamChiTietDAL.CapNhat(maSpct, maSp, maMau, maSize, donGia, soLuong, trangThai);
            MessageBox.Show("Sửa SPCT thành công ✅");

            SelectBySanPham();
        }

        // ===== XÓA =====
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaSPCT.Text)) return;

            if (MessageBox.Show("Xóa SPCT này?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
                return;

            SanPhamChiTietDAL.XoaMem(txtMaSPCT.Text.Trim());
            MessageBox.Show("Xóa thành công ✅");

            SelectBySanPham();
            ClearForm();
        }

        private bool _bindingGrid = false;

        private void LoadGridBySanPham()
        {
            if (cbSanPham.SelectedValue == null) return;

            _bindingGrid = true;
            try
            {
                string maSp = cbSanPham.SelectedValue.ToString();
                dgvDsSPCT.DataSource = string.IsNullOrEmpty(maSp)
                    ? SanPhamChiTietDAL.SelectAll()
                    : SanPhamChiTietDAL.SelectByMaSP(maSp);
            }
            finally
            {
                _bindingGrid = false;
            }
        }

        // ===== GRID CLICK =====
        private void dgvDsSPCT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvDsSPCT.AllowUserToAddRows = false;
            dgvDsSPCT.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDsSPCT.MultiSelect = false;
            // click header hoặc click ngoài data
            if (e.RowIndex < 0) return;
            if (e.RowIndex >= dgvDsSPCT.Rows.Count) return;

            var gridRow = dgvDsSPCT.Rows[e.RowIndex];

            // nếu click vào dòng rỗng (new row)
            if (gridRow.IsNewRow) return;

            // nếu grid đang reload/bind lại
            if (gridRow.DataBoundItem == null) return;

            if (gridRow.DataBoundItem is not DataRowView drv) return;

            txtMaSPCT.Text = drv["MaSPCT"]?.ToString();
            cbSanPham.SelectedValue = drv["MaSP"]?.ToString();
            cbMau.SelectedValue = drv["MaMau"]?.ToString();
            cbSize.SelectedValue = drv["MaSize"]?.ToString();
            txtGiaBan.Text = drv["DonGia"]?.ToString();
            txtSoLuong.Text = drv["SoLuong"]?.ToString();

            var tt = drv["TrangThai"]?.ToString();
            chkTrangThai.Checked = (tt == "True" || tt == "1");
        }


        private void cbSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!_loaded || cbSanPham.SelectedValue == null) return;

            string maSp = cbSanPham.SelectedValue.ToString();

            if (string.IsNullOrEmpty(maSp))
            {
                // chọn "-- Tất cả sản phẩm --"
                dgvDsSPCT.DataSource = SanPhamChiTietDAL.SelectAll();
            }
            else
            {
                // chọn 1 sản phẩm cụ thể
                dgvDsSPCT.DataSource = SanPhamChiTietDAL.SelectByMaSP(maSp);
            }
        }

    }
}
