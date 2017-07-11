using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Bida.DTO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bida.DAO
{
    public class BanDAO
    {
        DataProvider provider;

        public BanDAO()
        {
            provider= new DataProvider();
        }

        public List<Ban> getlstBan()
        {
            List<Ban> lst = new List<Ban>();
            provider.Connect();
            string sql = "select * from Ban";
            SqlDataReader reader = provider.ExcuteReader(sql);

            while (reader.Read())
            {
                int maban = reader.GetInt32(0);
                bool LoaiBan = reader.GetBoolean(1);
                int KhuVuc = reader.GetInt32(2);
                bool TinhTrang = reader.GetBoolean(3);
                var GioBD =reader.GetDateTime(4);
                var GioKT = reader.GetDateTime(5);

                Ban b = new Ban(LoaiBan, KhuVuc, TinhTrang, GioBD, GioKT);
                b.Maban1 = maban;
                if (reader.IsDBNull(6))
                {
                    //nothing
                }
                else
                {
                    b.Kh = new KhachHangDAO().GetKhachHangbyID(reader.GetInt32(6));
                }
                lst.Add(b);
            }
            return lst;
        }

        public void updateBan(Ban b)
        {
            string bd = b.GioBd.ToString("yyyy-MM-dd HH:mm:ss");
            string kt = b.GioKt.ToString("yyyy-MM-dd HH:mm:ss");
            provider.Connect();

            int loaiban = b.LoaiBan1 ? 1 : 0;
            int tinhtrang = b.TinhTrang1 ? 1 : 0;
            
            string sql = "update ban set LOAIBAN = "+loaiban+", KHUVUC = " + b.KhuVuc1+", TINHTRANG = "+tinhtrang+", GIOBD= '"+bd+"',GIOKT = '"+kt+"' where MABAN = "+b.Maban1;
            provider.executeNonQuery(sql);
        }

        public void createBan(Ban b)
        {
            string bd = b.GioBd.ToString("yyyy-MM-dd HH:mm:ss");
            string kt = b.GioKt.ToString("yyyy-MM-dd HH:mm:ss");
            provider.Connect();

            int loaiban = b.LoaiBan1 ? 1 : 0;
            int tinhtrang = b.TinhTrang1 ? 1 : 0;

            string sql = "insert into BAN(LOAIBAN, KHUVUC, TINHTRANG, GIOBD, GIOKT,MAKH) VALUES (" + loaiban+ "," + b.KhuVuc1 + "," + tinhtrang + ",'"
                + bd + "','" + kt + "',"+1+")";
            provider.executeNonQuery(sql);
        }
        public void updateMakhB(Ban b, int makh)
        {
            provider.Connect();

            b.Kh = new KhachHangDAO().GetKhachHangbyID(makh);

            string sql = "update ban set MAKH = "+makh+" where MABAN = " + b.Maban1;
            provider.executeNonQuery(sql);
        }

      
    }
}
