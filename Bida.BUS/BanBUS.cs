using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bida.DTO;
using Bida.DAO;


namespace Bida.BUS
{
    public class BanBUS
    {
        public List<Ban> GetListBan()
        {
            return new BanDAO().getlstBan();
        }

        public void updateBan(Ban b)
        {
            new BanDAO().updateBan(b);
        }

        public void chuyenban(Ban b1, Ban b2)
        {
            b2.TinhTrang1 = true;
            b2.GioBd = b1.GioBd;
            
            b1.TinhTrang1 = false;

            updatemakh(b1,1);
            updatemakh(b2, b1.Kh.Makh);
            updateBan(b1);
            updateBan(b2);

        }

        public void AddBan(Ban b)
        {
            new BanDAO().createBan(b);
        }

        public void updatemakh(Ban b, int makh)
        {
            new BanDAO().updateMakhB(b, makh);
        }
    }
}
