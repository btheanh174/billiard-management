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
using MetroFramework;
using MetroFramework.Forms;

namespace Bida
{
    public partial class frmBienLai : MetroForm
    {
        public BienLai bienlai;
        
        public frmBienLai(BienLai bl)
        {
            this.bienlai = bl;
            InitializeComponent();
        }

        private void frmBienLai_Load(object sender, EventArgs e)
        {
            lblBan.Text = ""+bienlai.Ban.Maban1;
            lblGiobd.Text = bienlai.GioBd.ToString("HH:mm:ss dd/MM/yyyy");
            lblGiokt.Text = bienlai.GioKt.ToString("HH:mm:ss dd/MM/yyyy");
            lblKH.Text = "" + bienlai.Kh.Tenkh;
            lblTongTien.Text = bienlai.TongTien1;
            lblthoigan.Text = bienlai.Thoigian;
           

        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MetroMessageBox.Show(this, "In thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Question);
            frmMain a = new frmMain(bienlai.Nhanvien);
            a.Show();
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMain a = new frmMain(bienlai.Nhanvien);
            a.Show();
            this.Close();
        }
    }
}
