using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bida.DTO;
using Bida.DAO;

namespace Bida.BUS
{
    public class BienLaiBUS
    {
        public void addBienLai(BienLai a)
        {
            new BienLaiDAO().addKhachHang(a);
        }
    }
}
