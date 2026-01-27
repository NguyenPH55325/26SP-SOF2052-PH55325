using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuAnMauC_.DAO
{
    public class ChiTietHoaDon
    {
        public string MaHoaDon { get; set; }
        public string MaSanPhamChiTiet { get; set; }
        public decimal DonGia { get; set; }
        public int SoLuong { get; set; }
        public decimal ThanhTien => DonGia * SoLuong;
    }
}
