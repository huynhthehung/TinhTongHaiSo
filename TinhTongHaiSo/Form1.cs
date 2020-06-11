using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TinhTongHaiSo
{
    public partial class frmTinhTong : Form
    {
        public frmTinhTong()
        {
            InitializeComponent();
        }

        private void btnTInhTong_Click(object sender, EventArgs e)
        {
            int SoHang1 = int.Parse(txtSoHang1.Text);
            int SoHang2 = int.Parse(txtSoHang2.Text);
            int Tong = SoHang1 + SoHang2;
            txtTong.Text = Tong.ToString();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
