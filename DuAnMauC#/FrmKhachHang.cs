using DuAnMauC_.DAO;
using DuAnMauC_.DAL;
using System;
using System.Windows.Forms;

namespace DuAnMauC_
{
    public partial class FrmKhachHang : Form
    {
        public FrmKhachHang()
        {
            InitializeComponent();
            WireEvents();
            SelectAll();

            txtMaKH.ReadOnly = true;
            txtMaKH.Text = KhachHangDAL.TaoMaTuDong();
            chkTrangThai.Checked = true;
        }

        private void WireEvents()
        {
            btnThem.Click += btnThem_Click;
            btnSua.Click += btnSua_Click;
            btnXoa.Click += btnXoa_Click;
            dgvDsKhachHang.CellClick += dgvDsKhachHang_CellClick;
        }

        private void SelectAll()
        {
            dgvDsKhachHang.AutoGenerateColumns = true;
            dgvDsKhachHang.DataSource = KhachHangDAL.SelectAll();
        }

        private KhachHang ReadForm()
        {
            return new KhachHang
            {
                MaKhachHang = txtMaKH.Text.Trim(),
                TenKhachHang = txtTenKH.Text.Trim(),
                SoDienThoai = txtSDT.Text.Trim(),
                TrangThai = chkTrangThai.Checked
            };
        }

        private void ClearForm()
        {
            txtMaKH.Text = KhachHangDAL.TaoMaTuDong();
            txtTenKH.Clear();
            txtSDT.Clear();
            chkTrangThai.Checked = true;
            txtTenKH.Focus();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                var kh = ReadForm();

                if (string.IsNullOrWhiteSpace(kh.TenKhachHang))
                {
                    MessageBox.Show("Tên khách hàng không được để trống.");
                    return;
                }

                KhachHangDAL.TaoMoi(kh);
                MessageBox.Show("Thêm khách hàng thành công ✅");

                SelectAll();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm khách hàng: " + ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                var kh = ReadForm();
                KhachHangDAL.CapNhat(kh);
                MessageBox.Show("Sửa khách hàng thành công ✅");
                SelectAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi sửa khách hàng: " + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string ma = txtMaKH.Text.Trim();
                if (string.IsNullOrWhiteSpace(ma)) return;

                if (MessageBox.Show("Xóa khách hàng này?", "Xác nhận",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
                    return;

                KhachHangDAL.Xoa(ma);
                MessageBox.Show("Xóa thành công ✅");
                SelectAll();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xóa khách hàng: " + ex.Message);
            }
        }

        private void dgvDsKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dgvDsKhachHang.Rows[e.RowIndex];
            txtMaKH.Text = row.Cells["MaKhachHang"].Value.ToString();
            txtTenKH.Text = row.Cells["TenKhachHang"].Value.ToString();
            txtSDT.Text = row.Cells["SoDienThoai"].Value.ToString();

            var tt = row.Cells["TrangThai"].Value.ToString();
            chkTrangThai.Checked = (tt == "True" || tt == "1");
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }
    }
}
