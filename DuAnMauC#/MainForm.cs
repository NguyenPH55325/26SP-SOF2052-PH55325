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
            SelectAll();
        }
        public void SelectAll()
        {

            dgvDsHoaDon.DataSource = HoaDonDAL.SelectAll();
            dgvNhanVien.DataSource = NhanVienDAL.SelectAll();
            dgvKhachHang.DataSource = KhachHangDAL.SelectAll();
           
            dgvSanPham.DataSource = SanPhamDAL.SelectAll();
            dgvSanPhamChiTiet.DataSource = SanPhamChiTietDAL.SelectAll();


        }



        private void dgvDsHoaDon_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDsHoaDon.CurrentRow == null) return;

            int row = dgvDsHoaDon.CurrentRow.Index;
            DataTable tmp = dgvDsHoaDon.DataSource as DataTable;

            if (tmp == null || tmp.Rows.Count == 0) return;

            HoaDon hoaDon = new()
            {
                MaHoaDon = Convert.ToString(tmp.Rows[row][0]),
                NgayTao = Convert.ToDateTime(tmp.Rows[row][1]),
                TrangThai = Convert.ToBoolean(tmp.Rows[row][2])
            };
         
            txtMaHoaDon.Text = hoaDon.MaHoaDon;
            txtNgayTao.Text = hoaDon.NgayTao.ToString("yyyy-MM-dd");

            var test = ChiTietHoaDonDAL.SelectAll(hoaDon.MaHoaDon);

           

            dgvDsChiTietHoaDon.Columns.Clear();
            
            dgvDsChiTietHoaDon.DataSource = test; 


            rdoDaThanhToan.Checked = hoaDon.TrangThai;
            rdoChoXacNhan.Checked = !hoaDon.TrangThai;
        }





        //private void dgvDsHoaDon_SelectionChanged(object sender, EventArgs e)
        //{

        //    int row = dgvDsHoaDon.CurrentRow.Index;

        //    DataTable tmp = (DataTable)dgvDsHoaDon.DataSource;

        //    if (tmp != null && tmp.Rows.Count > 0)
        //    {
        //        HoaDon hoaDon = new()
        //        {
        //            MaHoaDon = Convert.ToString(tmp.Rows[row][0]),
        //            NgayTao = Convert.ToDateTime(tmp.Rows[row][1]),
        //            TrangThai = Convert.ToBoolean(tmp.Rows[row][2])
        //        };

        //        txtMaHoaDon.Text = hoaDon.MaHoaDon;
        //        int idHoaDon = Convert.ToInt32(
        //              dgvDsHoaDon.CurrentRow.Cells["id"].Value
        //                                                        );
        //        dgvDsChiTietHoaDon.DataSource =
        //        ChiTietHoaDonDAL.SelectAll(idHoaDon);
        //        txtNgayTao.Text = hoaDon.NgayTao.ToString("yyyy-MM-dd");
        //        if (hoaDon.TrangThai)
        //        {
        //            rdoDaThanhToan.Checked = true;
        //        }
        //        else
        //        {
        //            rdoChoXacNhan.Checked = true;
        //        }
        //    }

        //}
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

        //private void btnLamMoi_Click(object sender, EventArgs e)
        //{
        //    SelectAll();
        //}

        //private void btnThanhToan_Click(object sender, EventArgs e)
        //{
        //    DialogResult dialogResult = MessageBox.Show(this, "Xác nhận khách hàng đã thanh toán đầy đủ", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        //    if (dialogResult == DialogResult.OK)
        //    {
        //        HoaDonDAL.ThanhToan(txtMaHoaDon.Text);
        //    }
        //}

        //private void btnThem_Click(object sender, EventArgs e)
        //{
        //    DialogResult dialogResult = MessageBox.Show(this, "Tạo hóa đơn mới", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        //    if (dialogResult == DialogResult.OK)
        //    {
        //        HoaDonDAL.TaoMoi(new HoaDon()
        //        {
        //            MaHoaDon = txtMaHoaDon.Text,
        //            NgayTao = DateTime.ParseExact(txtNgayTao.Text, "yyyy-MM-dd", null),
        //            TrangThai = rdoDaThanhToan.Checked
        //        });
        //    }
        //}

        //private void btnSua_Click(object sender, EventArgs e)
        //{
        //    DialogResult dialogResult = MessageBox.Show(this, "Sửa hóa đơn", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        //    if (dialogResult == DialogResult.OK)
        //    {
        //        HoaDonDAL.CapNhat(new HoaDon()
        //        {
        //            MaHoaDon = txtMaHoaDon.Text,
        //            NgayTao = DateTime.ParseExact(txtNgayTao.Text, "yyyy-MM-dd", null),
        //            TrangThai = rdoDaThanhToan.Checked
        //        });
        //    }
        //}

        //private void btnXoa_Click(object sender, EventArgs e)
        //{
        //    DialogResult dialogResult = MessageBox.Show(this, "Xóa hóa đơn", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        //    if (dialogResult == DialogResult.OK)
        //    {
        //        HoaDonDAL.Xoa(txtMaHoaDon.Text);
        //    }
        //}

        //private void btnThemCT_Click(object sender, EventArgs e)
        //{
        //    DialogResult dialogResult = MessageBox.Show(this, "Thêm chi tiết hóa đơn", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        //    if (dialogResult == DialogResult.OK)
        //    {
        //        ChiTietHoaDonDAL.TaoMoi(new ChiTietHoaDon()
        //        {
        //            MaHoaDon = txtMaHoaDon.Text,
        //            MaHangHoa = txtMaHangHoa.Text,
        //            DonGia = Convert.ToDouble(txtDonGia.Text),
        //            SoLuongXuat = Convert.ToSingle(txtSoLuong.Text)
        //        });
        //    }
        //}

        //private void btnSuaCT_Click(object sender, EventArgs e)
        //{
        //    DialogResult dialogResult = MessageBox.Show(this, "Sửa chi tiết hóa đơn", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        //    if (dialogResult == DialogResult.OK)
        //    {
        //        ChiTietHoaDonDAL.CapNhat(new ChiTietHoaDon()
        //        {
        //            MaHoaDon = txtMaHoaDon.Text,
        //            MaHangHoa = txtMaHangHoa.Text,
        //            DonGia = Convert.ToDouble(txtDonGia.Text),
        //            SoLuongXuat = Convert.ToSingle(txtSoLuong.Text)
        //        });
        //    }
        //}

        //private void btnXoaCT_Click(object sender, EventArgs e)
        //{
        //    DialogResult dialogResult = MessageBox.Show(this, "Xóa chi tiết hóa đơn", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        //    if (dialogResult == DialogResult.OK)
        //    {
        //        ChiTietHoaDonDAL.Xoa(txtMaHoaDon.Text, txtMaHangHoa.Text);
        //    }
        //}

        //private void txtMaHangHoa_TextChanged(object sender, EventArgs e)
        //{
        //    DataTable tmp = HangHoaDAL.SelectHangHoa(txtMaHangHoa.Text);
        //    if (tmp != null && tmp.Rows.Count > 0)
        //    {
        //        txtTenHangHoa.Text = Convert.ToString(tmp.Rows[0]["TEN_HANG_HOA"]);
        //        txtDonGia.Text = Convert.ToString(tmp.Rows[0]["DON_GIA"]);
        //        txtSoLuong.Text = "1";
        //    }
        //}
    }

}
