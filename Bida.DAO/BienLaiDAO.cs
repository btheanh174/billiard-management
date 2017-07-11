using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bida.DTO;
namespace Bida.DAO
{
    public class BienLaiDAO
    {
        DataProvider provider;

        public BienLaiDAO()
        {
            provider= new DataProvider();
        }
        public void addKhachHang(BienLai b)
        {
            provider.Connect();
            string bd = b.GioBd.ToString("yyyy-MM-dd HH:mm:ss");
            string kt = b.GioKt.ToString("yyyy-MM-dd HH:mm:ss");
            string sql = "insert into BIENLAI(MANHANVIEN, MABAN, MAKH, THOIGIAN, TONGTIEN, GIOBD, GIOKT) VALUES ('"+b.Nhanvien.Manv+"',"+b.Ban.Maban1+","+b.Kh.Makh+",'"+b.Thoigian+"','"+b.TongTien1+"','" + bd + "','" + kt + "')";
            provider.executeNonQuery(sql);
        }
    }
}
