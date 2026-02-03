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
    public partial class FrmSanPham : Form
    {
        public FrmSanPham()
        {
            InitializeComponent();
            SelectAll();
            WireEvents();
        }
        private void WireEvents()
        {
            btnThemSanPham.Click += btnThemSanPham_Click;
            btnSuaSanPham.Click += btnSuaSanPham_Click;
            btnXoaSanPham.Click += btnXoaSanPham_Click;
            dgvDsSanPham.CellClick += dgvDsSanPham_CellClick;
        }
        public void SelectAll()
        {
            dgvDsSanPham.DataSource = DAL.SanPhamDAL.SelectAll();
            dgvDsSanPhamChiTiet.DataSource = DAL.SanPhamChiTietDAL.SelectAll();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnThemSanPham_Click(object sender, EventArgs e)
        {
            try
            {
                var sp = ReadForm();

                if (string.IsNullOrWhiteSpace(sp.MaSanPham) ||
                    string.IsNullOrWhiteSpace(sp.TenSanPham))
                {
                    MessageBox.Show("Mã SP và Tên SP không được để trống.");
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
        private SanPham ReadForm()
        {
            return new SanPham
            {
                MaSanPham = txtMaSanPham.Text.Trim(),
                TenSanPham = txtTenSanPham.Text.Trim(),
                TrangThai = chkTrangThai.Checked
            };
        }

        private void ClearForm()
        {
            txtMaSanPham.Clear();
            txtTenSanPham.Clear();
            chkTrangThai.Checked = true;
            txtMaSanPham.Focus();
        }

        // ===================== THÊM =====================
        //private void btnThemSanPham_Click(object sender, EventArgs e)
        //{
            
        //}

        // ===================== SỬA =====================
        private void btnSuaSanPham_Click(object sender, EventArgs e)
        {
            try
            {
                var sp = ReadForm();

                if (string.IsNullOrWhiteSpace(sp.MaSanPham))
                {
                    MessageBox.Show("Vui lòng chọn sản phẩm cần sửa.");
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

        // ===================== XÓA =====================
        private void btnXoaSanPham_Click(object sender, EventArgs e)
        {
            try
            {
                string ma = txtMaSanPham.Text.Trim();
                if (string.IsNullOrWhiteSpace(ma))
                {
                    MessageBox.Show("Vui lòng chọn sản phẩm cần xóa.");
                    return;
                }

                var confirm = MessageBox.Show(
                    "Xóa sản phẩm này sẽ xóa luôn SP chi tiết. Tiếp tục?",
                    "Xác nhận",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (confirm != DialogResult.Yes) return;

                SanPhamDAL.Xoa(ma);
                MessageBox.Show("Xóa sản phẩm thành công ✅");

                SelectAll();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xóa sản phẩm: " + ex.Message);
            }
        }

        // ===================== CLICK GRID =====================
        private void dgvDsSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dgvDsSanPham.Rows[e.RowIndex];
            txtMaSanPham.Text = row.Cells["MaSanPham"].Value?.ToString();
            txtTenSanPham.Text = row.Cells["TenSanPham"].Value?.ToString();

            var tt = row.Cells["TrangThai"].Value?.ToString();
            chkTrangThai.Checked = (tt == "True" || tt == "1");
        }
    }
}
