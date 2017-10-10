using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtTiengViet.Enabled = true;
        }

        private void btnTraTu_Click(object sender, EventArgs e)
        {
            WebService1Proxy.WebService1 a = new WebService1Proxy.WebService1();
            if (a.TraTuPhapAnh(txtTiengAnh.Text) == " ")
            {
                txtTiengViet.Text = "Pháp - Anh Không Có";
            }
            else
            {
                //txtTiengViet.Text = a.LayDanhSach(txtTiengAnh.Text);
                if (a.TraTuAnhViet(a.TraTuPhapAnh(txtTiengAnh.Text)) == " ")
                {
                    txtTiengViet.Text = "Anh - Việt Không Có";
                }
                else
                {
                    txtTiengViet.Text = a.TraTuAnhViet(a.TraTuPhapAnh(txtTiengAnh.Text));
                }
            }

        }
    }
}
