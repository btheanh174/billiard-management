using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bida.DTO;

namespace Bida.DAO
{
    public class NhanVienDAO
    {
        DataProvider provider;
        public NhanVienDAO()
        {
            provider= new DataProvider();
        }
        public List<NhanVien> getlsttNV()
        {
            List<NhanVien> lst = new List<NhanVien>();
            provider.Connect();
            string sql = "select * from NhanVien";
            SqlDataReader reader = provider.ExcuteReader(sql);

            while (reader.Read())
            {
                string manv = reader.GetString(0);
                string taikhoan = reader.GetString(1);
                bool calam = reader.GetBoolean(2);
                string pass = reader.GetString(3);


                NhanVien b = new NhanVien(taikhoan,calam,pass);
                lst.Add(b);
                b.Manv = manv;
            }
            return lst;
        }

        public Boolean validateNV(string user, string pass)
        {
            List<NhanVien> lst = new List<NhanVien>(this.getlsttNV());
            for(int i= 0 ; i<lst.Count;i++)
            {
                if (lst[i].Manv.Equals(user) & lst[i].Pass.Equals(pass))
                {
                    return true;
                }
            }
            return false;
        }

        public NhanVien GetNhanVienbyID(String user)
        {
            List<NhanVien> lst = new List<NhanVien>(this.getlsttNV());
            NhanVien nv = null;
            for (int i = 0; i < lst.Count; i++)
            {
                if (lst[i].Manv.Equals(user))
                {
                    nv = lst[i];
                    break;
                }
            }
            return nv;
        }
    }
}
