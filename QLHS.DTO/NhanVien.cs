using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bida.DTO
{
    public class NhanVien
    {
        private string _manv;
        private string tenNV;
        private bool _calam;
        private string _pass;

        public NhanVien(string tenNv, bool calam, string pass)
        {
            
            this.tenNV = tenNv;
            _calam = calam;
            _pass = pass;
        }

        public string Manv
        {
            get { return _manv; }
            set { _manv = value; }
        }

        public string TenNv
        {
            get { return tenNV; }
            set { tenNV = value; }
        }

        public bool Calam
        {
            get { return _calam; }
            set { _calam = value; }
        }

        public string Pass
        {
            get { return _pass; }
            set { _pass = value; }
        }
    }
}
