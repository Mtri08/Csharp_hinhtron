using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Csharp_hinhtron
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCV_Click(object sender, EventArgs e)
        {
            Double chuvi, bankinh;
            bankinh = Convert.ToDouble(txtBK.Text);
                chuvi= bankinh*2*Math.PI;
            txtKQ.Text = chuvi.ToString();
        }

        private void btnDT_Click(object sender, EventArgs e)
        {
            Double dientich, bankinh;
            bankinh = Convert.ToDouble(txtBK.Text);
            dientich = bankinh * bankinh * Math.PI;
            txtKQ.Text = dientich.ToString();
        }

        private void btnTinhL1_Click(object sender, EventArgs e)
        {
            double bankinh=Convert.ToDouble(txtBK.Text);
            if (rdbCV.Checked) {
            double chuvi=bankinh*2*Math.PI;
                string thongbao = "Chu vi" + Convert.ToString(chuvi);
                MessageBox.Show(thongbao,"Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            if(rdbDT.Checked) 
            {
                double dientich=bankinh*bankinh * Math.PI;
                string thongbao = "Diện tích" + Convert.ToString(dientich);
                MessageBox.Show(thongbao, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }

        }

        private void btnTinhL2_Click(object sender, EventArgs e)
        {
            double bankinh= Convert.ToDouble(txtBK.Text);
            string thongbao = "";

            if (chkCV.Checked)
            {
                double chuvi = bankinh * 2 * Math.PI;
                
                thongbao=thongbao+"Chu vi"+Convert.ToString(chuvi)+Environment.NewLine;

            }
            if(chkDT.Checked)
            {
                double dientich= bankinh*bankinh*Math.PI;
                thongbao = thongbao + "Diện tích" + Convert.ToString(dientich) + Environment.NewLine;

            }
            if (thongbao.Length > 0)
            {
                MessageBox.Show(thongbao, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn tính năng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
