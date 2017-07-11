using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bida.DTO
{
    public class KhachHang
    {
        private int _makh;
        private string _tenkh;
        private string _sdt;

        public KhachHang(string tenkh, string sdt)
        {
            _tenkh = tenkh;
            _sdt = sdt;
        }

        public int Makh
        {
            get { return _makh; }
            set { _makh = value; }

        }

        public string Tenkh
        {
            get { return _tenkh; }
            set { _tenkh = value; }
        }

        public string Sdt
        {
            get { return _sdt; }
            set { _sdt = value; }
        }
    }
}
