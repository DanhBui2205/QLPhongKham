using Quanlikho.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlikho
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void phiếuNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            SRM_PhieuNhap sRM_PhieuNhap = new SRM_PhieuNhap();
            sRM_PhieuNhap.ShowDialog();
        }

        private void beenhjToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            SRM_BenhNhan sRM_BenhNhan = new SRM_BenhNhan();
            sRM_BenhNhan.ShowDialog();

        }
    }
}
