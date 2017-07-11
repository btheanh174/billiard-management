using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bida.DTO
{
    public class BienLai
    {
        private int _mabl;
        private NhanVien nhanvien;
        private Ban ban;
        private KhachHang _kh;
        private DateTime GioBD;
        private DateTime GioKT;
        private String thoigian;
        private String TongTien;

        public BienLai(NhanVien nhanvien, Ban ban, KhachHang kh, DateTime gioBd, DateTime gioKt, string thoigian, string tongTien)
        {
            this.nhanvien = nhanvien;
            this.ban = ban;
            _kh = kh;
            GioBD = gioBd;
            GioKT = gioKt;
            this.thoigian = thoigian;
            TongTien = tongTien;
        }

        public int Mabl
        {
            get { return _mabl; }
            set { _mabl = value; }
        }

        public NhanVien Nhanvien
        {
            get { return nhanvien; }
            set { nhanvien = value; }
        }

        public Ban Ban
        {
            get { return ban; }
            set { ban = value; }
        }

        public KhachHang Kh
        {
            get { return _kh; }
            set { _kh = value; }
        }

        public DateTime GioBd
        {
            get { return GioBD; }
            set { GioBD = value; }
        }

        public DateTime GioKt
        {
            get { return GioKT; }
            set { GioKT = value; }
        }

        public string Thoigian
        {
            get { return thoigian; }
            set { thoigian = value; }
        }

        public string TongTien1
        {
            get { return TongTien; }
            set { TongTien = value; }
        }
    }
}

