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
            dgvDsChiTietHoaDon.Dock = DockStyle.Fill;

            SelectAll(); // ✅ GỌI Ở ĐÂY

        }
        public void SelectAll()
        {

            dgvDsHoaDon.DataSource = HoaDonDAL.SelectAll();
            //dgvNhanVien.DataSource = NhanVienDAL.SelectAll();
            //dgvKhachHang.DataSource = KhachHangDAL.SelectAll();

            //    dgvSanPham.DataSource = SanPhamDAL.SelectAll();
            //   dgvSanPhamChiTiet.DataSource = SanPhamChiTietDAL.SelectAll();


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

            rdoDaThanhToan.Checked = hoaDon.TrangThai;
            rdoChoXacNhan.Checked = !hoaDon.TrangThai;
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(this, "Xác nhận khách hàng đã thanh toán đầy đủ", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.OK)
            {
                HoaDonDAL.ThanhToan(txtMaHoaDon.Text);
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(this, "Tạo hóa đơn mới", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.OK)
            {
                HoaDonDAL.TaoMoi(new HoaDon()
                {
                    MaHoaDon = txtMaHoaDon.Text,
                    NgayTao = DateTime.ParseExact(txtNgayTao.Text, "yyyy-MM-dd", null),
                    TrangThai = rdoDaThanhToan.Checked
                });
            }
        }



        private void label1_Click(object sender, EventArgs e)
        {
            // ấn nhầm
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

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

        private void btnLamMoi_Click_1(object sender, EventArgs e)
        {

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
            DialogResult dialogResult = MessageBox.Show(this, "Xóa hóa đơn", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.OK)
            {
                HoaDonDAL.Xoa(txtMaHoaDon.Text);
            }
        }
        private void btnThemCT_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(this, "Thêm chi tiết hóa đơn", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.OK)
            {
                ChiTietHoaDonDAL.TaoMoi(new ChiTietHoaDon()
                {
                    MaHoaDon = txtMaHoaDon.Text,
                    MaSanPhamChiTiet = txtMaSanPham.Text,
                    DonGia = Decimal.Parse(txtDonGia.Text),
                    SoLuong = int.Parse(txtSoLuong.Text),

                });
            }
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

        private void btnXoaCT_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(this, "Xóa chi tiết hóa đơn", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.OK)
            {
                ChiTietHoaDonDAL.Xoa(txtMaHoaDon.Text, txtMaSanPham.Text);
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
                txtTenSanPham.Text = dt.Rows[0]["ten_sp"].ToString();
                txtDonGia.Text = dt.Rows[0]["don_gia"].ToString();
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

        private void toolStripMenuItem1_Click(object sender, EventArgs e) //hóa đơn
        {
            tabControl1.SelectedIndex = 0;
        }

        private void NhanVientoolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FrmNhanVien frm = new FrmNhanVien();
            //frm.Show(); // hoặc ShowDialog()
        }

        private void SanPhamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSanPham frm = new FrmSanPham();
            frm.Show();
        }

        private void KhachHangtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FrmKhachHang frm = new FrmKhachHang();
            //frm.Show();
        }
    }

}
