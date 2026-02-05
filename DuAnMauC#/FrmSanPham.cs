using DuAnMauC_.DAO;
using DuAnMauC_.DAL;
using System;
using System.Windows.Forms;

namespace DuAnMauC_
{
    public partial class FrmSanPham : Form
    {
        public FrmSanPham()
        {
            InitializeComponent();
            WireEvents();
            SelectAll();
            ClearForm();
        }

        private void WireEvents()
        {
            btnThemSanPham.Click += btnThemSanPham_Click;
            btnSuaSanPham.Click += btnSuaSanPham_Click;
            btnXoaSanPham.Click += btnXoaSanPham_Click;
            dgvDsSanPham.CellClick += dgvDsSanPham_CellClick;
        }

        private void SelectAll()
        {
            dgvDsSanPham.AutoGenerateColumns = true;
            dgvDsSanPham.DataSource = SanPhamDAL.SelectAll();

            // nếu form này có grid SPCT
            if (dgvDsSanPhamChiTiet != null)
            {
                dgvDsSanPhamChiTiet.AutoGenerateColumns = true;
                dgvDsSanPhamChiTiet.DataSource = SanPhamChiTietDAL.SelectAll();
            }
        }

        // ===== CLEAR =====
        private void ClearForm()
        {
            txtMaSanPham.Text = SanPhamDAL.TaoMaTuDong();
            txtMaSanPham.ReadOnly = true;

            txtTenSanPham.Clear();
            chkTrangThai.Checked = true;

            txtTenSanPham.Focus();
        }

        // ===== READ FORM =====
        private SanPham ReadForm_Them()
        {
            return new SanPham
            {
                MaSanPham = SanPhamDAL.TaoMaTuDong(),
                TenSanPham = txtTenSanPham.Text.Trim(),
                TrangThai = chkTrangThai.Checked
            };
        }

        private SanPham ReadForm_Sua()
        {
            return new SanPham
            {
                MaSanPham = txtMaSanPham.Text.Trim(), // ⭐ mã đang chọn
                TenSanPham = txtTenSanPham.Text.Trim(),
                TrangThai = chkTrangThai.Checked
            };
        }

        // ===== THÊM =====
        private void btnThemSanPham_Click(object sender, EventArgs e)
        {
            try
            {
                var sp = ReadForm_Them();

                if (string.IsNullOrWhiteSpace(sp.TenSanPham))
                {
                    MessageBox.Show("Tên sản phẩm không được để trống.");
                    return;
                }

                SanPhamDAL.TaoMoi(sp);
                MessageBox.Show("Thêm sản phẩm thành công ✅");

                SelectAll();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm sản phẩm: " + ex.Message);
            }
        }

        // ===== SỬA =====
        private void btnSuaSanPham_Click(object sender, EventArgs e)
        {
            try
            {
                var sp = ReadForm_Sua();

                if (string.IsNullOrWhiteSpace(sp.MaSanPham))
                {
                    MessageBox.Show("Vui lòng chọn sản phẩm cần sửa.");
                    return;
                }
                if (string.IsNullOrWhiteSpace(sp.TenSanPham))
                {
                    MessageBox.Show("Tên sản phẩm không được để trống.");
                    return;
                }

                SanPhamDAL.CapNhat(sp);
                MessageBox.Show("Sửa sản phẩm thành công ✅");

                SelectAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi sửa sản phẩm: " + ex.Message);
            }
        }

        // ===== XÓA (NGỪNG BÁN) =====
        private void btnXoaSanPham_Click(object sender, EventArgs e)
        {
            try
            {
                string ma = txtMaSanPham.Text.Trim();
                if (string.IsNullOrWhiteSpace(ma))
                {
                    MessageBox.Show("Vui lòng chọn sản phẩm cần ngừng bán.");
                    return;
                }

                var confirm = MessageBox.Show(
                    "Ngừng bán sản phẩm này? (Sẽ tắt luôn các SPCT thuộc sản phẩm)",
                    "Xác nhận",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (confirm != DialogResult.Yes) return;

                SanPhamDAL.NgungBan(ma);
                MessageBox.Show("Đã ngừng bán ✅");

                SelectAll();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ngừng bán: " + ex.Message);
            }
        }

        // ===== CLICK GRID =====
        private void dgvDsSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dgvDsSanPham.Rows[e.RowIndex];
            txtMaSanPham.Text = row.Cells["MaSanPham"].Value?.ToString();
            txtTenSanPham.Text = row.Cells["TenSanPham"].Value?.ToString();

            var tt = row.Cells["TrangThai"].Value?.ToString();
            chkTrangThai.Checked = (tt == "True" || tt == "1");

            // nếu có grid SPCT thì lọc theo SP đang chọn (tùy m thích)
            if (dgvDsSanPhamChiTiet != null)
            {
                string maSp = txtMaSanPham.Text.Trim();
                dgvDsSanPhamChiTiet.DataSource = SanPhamChiTietDAL.SelectByMaSP(maSp);
            }
        }
    }
}
