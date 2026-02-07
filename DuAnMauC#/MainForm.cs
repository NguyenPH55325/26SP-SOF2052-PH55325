using DuAnMauC_.DAL;
using DuAnMauC_.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuAnMauC_
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            this.Load += MainForm_Load;
            dgvDsHoaDon.SelectionChanged += dgvDsHoaDon_SelectionChanged;
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            dgvDsChiTietHoaDon.AutoGenerateColumns = true;
          //  dgvDsChiTietHoaDon.Dock = DockStyle.Fill;

            SelectAll(); // ✅ GỌI Ở ĐÂY

        }
        public void SelectAll()
        {

            dgvDsHoaDon.DataSource = HoaDonDAL.SelectAll();
         
        }
        private void TinhTongTienHoaDon()
        {
            decimal tong = 0;

            foreach (DataGridViewRow row in dgvDsChiTietHoaDon.Rows)
            {
                if (row.IsNewRow) continue;

                if (row.Cells["ThanhTien"].Value != null &&
                    decimal.TryParse(row.Cells["ThanhTien"].Value.ToString(), out decimal tien))
                {
                    tong += tien;
                }
            }

            txtTongTien.Text = tong.ToString("N0"); // 240,000
        }



        private void dgvDsHoaDon_SelectionChanged(object sender, EventArgs e)
        {
            if (!this.IsHandleCreated) return;
            if (dgvDsHoaDon.CurrentRow == null) return;
            if (dgvDsHoaDon.DataSource == null) return;

            DataTable tmp = dgvDsHoaDon.DataSource as DataTable;
            if (tmp == null || tmp.Rows.Count == 0) return;

            int row = dgvDsHoaDon.CurrentRow.Index;
            if (row < 0 || row >= tmp.Rows.Count) return;

            HoaDon hoaDon = new HoaDon
            {
                MaHoaDon = tmp.Rows[row][0].ToString(),
                NgayTao = Convert.ToDateTime(tmp.Rows[row][1]),
                TrangThai = Convert.ToBoolean(tmp.Rows[row][2])
            };

            txtMaHoaDon.Text = hoaDon.MaHoaDon;
            txtNgayTao.Text = hoaDon.NgayTao.ToString("yyyy-MM-dd");

            DataTable data = ChiTietHoaDonDAL.SelectAll(hoaDon.MaHoaDon);


            dgvDsChiTietHoaDon.DataSource = null;
            dgvDsChiTietHoaDon.DataSource = data;
            TinhTongTienHoaDon();
            rdoDaThanhToan.Checked = hoaDon.TrangThai;
            rdoChoXacNhan.Checked = !hoaDon.TrangThai;

            // vô hiệu hóa nút thêm, sửa, xóa chi tiết hóa đơn nếu đã thanh toán
            bool daThanhToan = hoaDon.TrangThai;

            btnThemCT.Enabled = !daThanhToan;
            btnSuaCT.Enabled = !daThanhToan;
            btnXoaCT.Enabled = !daThanhToan;

            //txtMaSanPham.Enabled = !daThanhToan;
            txtSoLuong.Enabled = !daThanhToan;
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(this,
                "Xác nhận khách hàng đã thanh toán đầy đủ",
                "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (dialogResult != DialogResult.OK) return;

            string maHD = txtMaHoaDon.Text.Trim();
            if (string.IsNullOrWhiteSpace(maHD)) return;

            DataTable ct = ChiTietHoaDonDAL.SelectAll(maHD);
            if (ct == null || ct.Rows.Count == 0)
            {
                MessageBox.Show("Hóa đơn chưa có sản phẩm!");
                return;
            }

            // 1) check tồn lần cuối
            foreach (DataRow r in ct.Rows)
            {
                string maSpct = r["MaSanPhamChiTiet"].ToString(); // nếu DAL ct alias khác thì sửa đúng tên cột
                int sl = Convert.ToInt32(r["SoLuong"]);

                var dtSp = SanPhamChiTietDAL.SelectByMaSPCT(maSpct);
                int ton = int.Parse(dtSp.Rows[0]["SoLuongTon"].ToString());

                if (ton < sl)
                {
                    MessageBox.Show($"SPCT {maSpct} không đủ tồn kho để thanh toán!");
                    return;
                }
            }

            // 2) trừ tồn
            foreach (DataRow r in ct.Rows)
            {
                string maSpct = r["MaSanPhamChiTiet"].ToString();
                int sl = Convert.ToInt32(r["SoLuong"]);

                SanPhamChiTietDAL.TruTon(maSpct, sl); // hàm update so_luong = so_luong - sl
            }

            // 3) chốt hóa đơn
            HoaDonDAL.ThanhToan(maHD);

            MessageBox.Show("Thanh toán thành công ✅");
            SelectAll();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(this, "Tạo hóa đơn mới", "Xác nhận",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (dialogResult != DialogResult.OK) return;

            string maHD = HoaDonDAL.TaoMaTuDong();
            DateTime ngayTao = DateTime.Now;

            HoaDonDAL.TaoMoi(new HoaDon()
            {
                MaHoaDon = maHD,
                NgayTao = ngayTao,
                TrangThai = false // chờ xác nhận
            });

            txtMaHoaDon.Text = maHD;
            txtMaHoaDon.ReadOnly = true;

            txtNgayTao.Text = ngayTao.ToString("yyyy-MM-dd");
            rdoChoXacNhan.Checked = true;

            SelectAll();
        }



        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void dgvDsChiTietHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            SelectAll();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(this, "Sửa hóa đơn", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.OK)
            {
                HoaDonDAL.CapNhat(new HoaDon()
                {
                    MaHoaDon = txtMaHoaDon.Text,
                    NgayTao = DateTime.ParseExact(txtNgayTao.Text, "yyyy-MM-dd", null),
                    TrangThai = rdoDaThanhToan.Checked
                });
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maHD = txtMaHoaDon.Text.Trim();
            if (string.IsNullOrWhiteSpace(maHD))
            {
                MessageBox.Show("Vui lòng chọn hóa đơn cần xóa.");
                return;
            }

            // Nếu đã thanh toán thì không cho xóa (tuỳ m)
            if (rdoDaThanhToan.Checked)
            {
                MessageBox.Show("Hóa đơn đã thanh toán, không thể xóa.");
                return;
            }

            // ✅ check hóa đơn có chi tiết không
            DataTable ct = ChiTietHoaDonDAL.SelectAll(maHD);
            if (ct != null && ct.Rows.Count > 0)
            {
                MessageBox.Show("Hóa đơn đang có sản phẩm. Xóa hết chi tiết trước rồi mới xóa hóa đơn.");
                return;
            }

            var dialogResult = MessageBox.Show(this, "Xóa hóa đơn này?", "Xác nhận",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (dialogResult != DialogResult.OK) return;

            try
            {
                HoaDonDAL.Xoa(maHD);
                MessageBox.Show("Xóa hóa đơn thành công ✅");
                SelectAll();

                // clear UI
                txtMaHoaDon.Clear();
                txtNgayTao.Clear();
                rdoChoXacNhan.Checked = true;
                dgvDsChiTietHoaDon.DataSource = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xóa hóa đơn: " + ex.Message);
            }
        }

        private void btnThemCT_Click(object sender, EventArgs e)
        {
            if (rdoDaThanhToan.Checked)
            {
                MessageBox.Show("Hóa đơn đã thanh toán, không thể thêm sản phẩm.");
                return;
            }
            DialogResult dialogResult = MessageBox.Show(this, "Thêm chi tiết hóa đơn", "Xác nhận",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (dialogResult != DialogResult.OK) return;

            string maHD = txtMaHoaDon.Text.Trim();
            string maSpct = txtMaSanPham.Text.Trim();

            if (string.IsNullOrWhiteSpace(maHD))
            {
                MessageBox.Show("Tạo hóa đơn trước đã!");
                return;
            }
            if (string.IsNullOrWhiteSpace(maSpct))
            {
                MessageBox.Show("Nhập mã SPCT!");
                return;
            }

            if (!int.TryParse(txtSoLuong.Text, out int sl) || sl <= 0)
            {
                MessageBox.Show("Số lượng không hợp lệ!");
                return;
            }

            var dt = SanPhamChiTietDAL.SelectByMaSPCT(maSpct);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy SPCT!");
                return;
            }

            int ton = int.Parse(dt.Rows[0]["SoLuongTon"].ToString());
            if (ton < sl)
            {
                MessageBox.Show("Không đủ tồn kho!");
                return;
            }

            ChiTietHoaDonDAL.AddOrUpdate(new ChiTietHoaDon()
            {
                MaHoaDon = txtMaHoaDon.Text.Trim(),
                MaSanPhamChiTiet = txtMaSanPham.Text.Trim(),
                DonGia = decimal.Parse(txtDonGia.Text),
                SoLuong = int.Parse(txtSoLuong.Text),
            });

            dgvDsChiTietHoaDon.DataSource = ChiTietHoaDonDAL.SelectAll(maHD);
        }

        private void btnSuaCT_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(this, "Sửa chi tiết hóa đơn", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.OK)
            {
                ChiTietHoaDonDAL.CapNhat(new ChiTietHoaDon()
                {
                    MaHoaDon = txtMaHoaDon.Text,
                    MaSanPhamChiTiet = txtMaSanPham.Text,
                    DonGia = Decimal.Parse(txtDonGia.Text),
                    SoLuong = int.Parse(txtSoLuong.Text),
                });
            }
        }

        //private void btnXoaCT_Click(object sender, EventArgs e)
        //{
        //    DialogResult dialogResult = MessageBox.Show(this, "Xóa chi tiết hóa đơn", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        //    if (dialogResult == DialogResult.OK)
        //    {
        //        ChiTietHoaDonDAL.Xoa(txtMaHoaDon.Text, txtMaSanPham.Text);
        //    }
        //}
        private void btnXoaCT_Click(object sender, EventArgs e)
{
    // 1) chặn nếu đã thanh toán
    if (rdoDaThanhToan.Checked)
    {
        MessageBox.Show("Hóa đơn đã thanh toán, không thể xóa chi tiết.");
        return;
    }

    string maHD = txtMaHoaDon.Text.Trim();
    string maSpct = txtMaSanPham.Text.Trim();

    // 2) validate
    if (string.IsNullOrWhiteSpace(maHD) || string.IsNullOrWhiteSpace(maSpct))
    {
        MessageBox.Show("Vui lòng chọn hóa đơn và sản phẩm chi tiết cần xóa.");
        return;
    }

    // 3) confirm
    var dialogResult = MessageBox.Show(
        "Xóa chi tiết hóa đơn này?",
        "Xác nhận",
        MessageBoxButtons.OKCancel,
        MessageBoxIcon.Question);

    if (dialogResult != DialogResult.OK) return;

    try
    {
        ChiTietHoaDonDAL.Xoa(maHD, maSpct);

        // reload grid chi tiết
        dgvDsChiTietHoaDon.DataSource = ChiTietHoaDonDAL.SelectAll(maHD);

        // clear form chi tiết
        txtMaSanPham.Clear();
        txtTenSanPham.Clear();
        txtDonGia.Clear();
        txtSoLuong.Clear();
        txtThanhTien.Clear();
    }
    catch (Exception ex)
    {
        MessageBox.Show("Lỗi xóa chi tiết: " + ex.Message);
    }
}



        private void txtMaSanPham_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaSanPham.Text))
            {
                txtTenSanPham.Clear();
                txtDonGia.Clear();
                txtSoLuong.Clear();
                txtThanhTien.Clear();
                return;
            }

            DataTable dt = SanPhamChiTietDAL.SelectByMaSPCT(txtMaSanPham.Text.Trim());

            if (dt != null && dt.Rows.Count > 0)
            {
                txtTenSanPham.Text = dt.Rows[0]["TenSanPham"].ToString();
                txtDonGia.Text = dt.Rows[0]["DonGia"].ToString();
                txtSoLuong.Text = "1";

                TinhThanhTien();
            }
        }
        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            TinhThanhTien();
        }

        private void TinhThanhTien()
        {
            if (decimal.TryParse(txtDonGia.Text, out decimal donGia) &&
                int.TryParse(txtSoLuong.Text, out int soLuong))
            {
                txtThanhTien.Text = (donGia * soLuong).ToString();
            }
        }
        private void OpenSingleForm<T>() where T : Form, new()
        {
            // tìm form đang mở
            Form frm = Application.OpenForms
                .Cast<Form>()
                .FirstOrDefault(f => f is T);

            if (frm != null)
            {
                frm.Activate();          // đưa lên trước
                frm.WindowState = FormWindowState.Normal;
            }
            else
            {
                new T().Show();
            }
        }


        private void toolStripMenuItem1_Click(object sender, EventArgs e) //hóa đơn
        {
            tabControl1.SelectedIndex = 0;
        }

        private void NhanVientoolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenSingleForm<FrmNhanVien>();
            //FrmNhanVien frm = new FrmNhanVien();
            //frm.Show(); // hoặc ShowDialog()
        }

        private void SanPhamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenSingleForm<FrmSanPham>();
        }

        private void KhachHangtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenSingleForm<FrmKhachHang>();
        }

        private void sảnPhẩmChiTiếtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenSingleForm<FrmSanPhamChiTiet>();
        }
    }

}
