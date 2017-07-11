using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bida.DTO;

namespace Bida.DAO
{
    public class KhachHangDAO
    {
        DataProvider provider;
        public KhachHangDAO()
        {
            provider= new DataProvider();
        }
        public List<KhachHang> getlstKhachHang()
        {
            List<KhachHang> lst = new List<KhachHang>();
            provider.Connect();
            string sql = "select * from KhachHang";
            SqlDataReader reader = provider.ExcuteReader(sql);

            while (reader.Read())
            {
                int makh = reader.GetInt32(0);
                string tenkh = reader.GetString(1);
                string sdt = reader.GetString(2);
                KhachHang b = new KhachHang(tenkh,sdt);
               
                b.Makh = makh;
                lst.Add(b);
            }
            return lst;
        }
        public KhachHang GetKhachHangbyID(int user)
        {
            List<KhachHang> lst = new List<KhachHang>(this.getlstKhachHang());
            KhachHang nv = null;
            for (int i = 0; i < lst.Count; i++)
            {
                if (lst[i].Makh == user)
                {
                    nv = lst[i];
                    break;
                }
            }
            return nv;
        }
        public void addKhachHang(KhachHang b)
        {
            provider.Connect();
            string sql = "insert into KHACHHANG(TENKH, SDT) VALUES ('"+ b.Tenkh + "','" + b.Sdt + "')";
            provider.executeNonQuery(sql);
        }


    }
}
