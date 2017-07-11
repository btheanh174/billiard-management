using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bida.DTO;
using Bida.BUS;
using MetroFramework;
using MetroFramework.Forms;

namespace Bida
{

    public partial class frmBan : MetroForm
    {
        public Ban ban;
        public NhanVien nhanvien;
        public frmBan(Ban a, NhanVien nv)
        {
            InitializeComponent();
            this.ban = a;
            this.nhanvien = nv;
        }

        public void Refesh()
        {
            this.lblBan.Text = "Bàn " + ban.Maban1;
            if (ban.TinhTrang1 == false)
            {
                btnEnd.Enabled = false;
                btnChange.Enabled = false;
                if (ban.LoaiBan1 == false)
                {
                    picBan.Image = global::Bida.Properties.Resources.bidafrace;
                }
                else
                {
                    picBan.Image = global::Bida.Properties.Resources.bida;
                }
            }
            else
            {
                btnChange.Enabled = true;
                var date = ban.GioBd;
                int h = date.Hour;
                int m = date.Minute;
                txtTimeStart.Text = h + ":" + m;
                txtTimeStart.Enabled = false;
                btnStart.Enabled = false;
                btnEnd.Enabled = true;
                if (ban.LoaiBan1 == false)
                {
                    picBan.Image = global::Bida.Properties.Resources.bidafrance_s;
                }
                else
                {
                    picBan.Image = global::Bida.Properties.Resources.bida_s;
                }
            }
        }
        private void frmBan_Load(object sender, EventArgs e)
        {
            
            lblnv.Text = nhanvien.TenNv;
            var date1 = DateTime.Now;
            lblDate.Text = date1.ToString("dd/MM/yyyy");
            this.lblBan.Text = "Bàn " + ban.Maban1;
            
            comKH.DataSource = new KhachHangBUS().GetListKH();

            comKH.SelectedIndex = ban.Kh.Makh-1;
          
            if (ban.TinhTrang1 == false)
            {
                 btnEnd.Enabled = false;
                 btnStart.Enabled = true;
                btnChange.Enabled = false;
                if (ban.LoaiBan1 == false)
                {
                    picBan.Image = global::Bida.Properties.Resources.bidafrace;
                }
                else
                {
                    picBan.Image = global::Bida.Properties.Resources.bida;
                }
            }
            else
            {
                btnChange.Enabled = true;
                var date = ban.GioBd;
                int h= date.Hour;
                int m = date.Minute;
                txtTimeStart.Text = h + ":" + m;
                txtTimeStart.Enabled = false;
                btnStart.Enabled = false;
                btnEnd.Enabled = true;
                if (ban.LoaiBan1 == false)
                {
                    picBan.Image = global::Bida.Properties.Resources.bidafrance_s;
                }
                else
                {
                    picBan.Image = global::Bida.Properties.Resources.bida_s;
                }
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        { 
            var date = DateTime.Now;
            var date2 = ban.GioBd;
            int h= date.Hour;
            int m = date.Minute;
            txtTimeStart.Text = h + ":" + m;
            txtTimeEnd.Text = "";
            ban.TinhTrang1 = true;
            ban.GioBd = date;
            btnTinh.Enabled = false;
            //var hours = (date - date2).TotalMinutes;
            //txtTimeStart.Text = hours.ToString();
            ////  txtTimeEnd.Text = date2.ToString();


            //ban.GioBd = date;
            

           new BanBUS().updateBan(ban);

           this.Refesh();


        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            

            var date = DateTime.Now;
            int h = date.Hour;
            int m = date.Minute;
            txtTimeEnd.Text = h + ":" + m;
            ban.GioKt = date;
            ban.TinhTrang1 = false;
            new BanBUS().updateBan(ban);
            this.Refesh();
            txtTimeEnd.Enabled = false;
            btnTinh.Enabled = true;


        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMain a = new frmMain(nhanvien);
            a.Show();
            this.Close();
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmChuyen a = new frmChuyen(nhanvien, ban);
            a.Show();
            this.Close();
            //if (comKH.Text == "")
            //{
            //    lblBan.Text = "test" + comKH.Text;
            //}
            //else
            //{
            //    lblBan.Text = "k fai" + comKH.Text;

            //}
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            DateTime date = ban.GioBd;
            DateTime date2 = ban.GioKt;
            double m = (date2 - date).TotalMinutes;

            int hour = (int) (m/60);

            int minute = (int) (m%60);

            txtGio.Text = hour + " giờ "+minute +" phút";

            int gia =(int) (m*20)/60;
            txtGia.Text = gia + ".000 VND";

            btnPay.Enabled = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            int makh = comKH.SelectedValue.GetHashCode();
            new BanBUS().updatemakh(ban,makh);

            MetroMessageBox.Show(this, "Đã thêm khách hàng vào Bàn " + ban.Maban1, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Question);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAdd a= new frmAdd(ban, nhanvien);
            a.Show();
            this.Close();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            int makh = comKH.SelectedValue.GetHashCode();
            KhachHang kh = new KhachHangBUS().GetKhachHangbyID(makh);

            String thoigian = txtGio.Text;
            String gia = txtGia.Text;

            BienLai a = new BienLai(nhanvien,ban,kh,ban.GioBd,ban.GioKt,thoigian,gia);

            new BienLaiBUS().addBienLai(a);
            frmBienLai bl = new frmBienLai(a);
            bl.Show();
            this.Close();


        }
    }
}
