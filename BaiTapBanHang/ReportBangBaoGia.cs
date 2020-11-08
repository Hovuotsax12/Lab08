using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapBanHang
{
    public partial class ReportBangBaoGia : Form
    {
        public ReportBangBaoGia()
        {
            InitializeComponent();
        }

        private void ReportBangBaoGia_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
