
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bida.DTO
{
    public class Ban
    {
        private int Maban;
        private bool LoaiBan;
        private int KhuVuc;
        private bool TinhTrang;
        private DateTime GioBD;
        private DateTime GioKT;
        private KhachHang KH;

        public Ban(bool loaiBan, int khuVuc, bool tinhTrang, DateTime gioBd, DateTime gioKt)
        {
            LoaiBan = loaiBan;
            KhuVuc = khuVuc;
            TinhTrang = tinhTrang;
            GioBD = gioBd;
            GioKT = gioKt;
        }

        public int Maban1
        {
            get { return Maban; }

            set { Maban = value; }
        }

        public bool LoaiBan1
        {
            get { return LoaiBan; }
            set { LoaiBan = value; }
        }

        public int KhuVuc1
        {
            get { return KhuVuc; }
            set { KhuVuc = value; }
        }

        public bool TinhTrang1
        {
            get { return TinhTrang; }
            set { TinhTrang = value; }
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

        public KhachHang Kh
        {
            get { return KH; }
            set { KH = value; }
        }
    }
            
    

}
