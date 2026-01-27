using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuAnMauC_.DAO
{
    public class SanPhamChiTiet
    {
        public string MaSanPhamChiTiet { get; set; }
        public string MaSanPham { get; set; }
        public string MaMau { get; set; }
        public string MaSize { get; set; }
        public decimal GiaBan { get; set; }
        public int SoLuong { get; set; }
        public bool TrangThai { get; set; }
    }
}
