using BusinessLayer;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormConnect
{
    public partial class frmTest : DevExpress.XtraEditors.XtraForm
    {
        public frmTest()
        {
            InitializeComponent();
        }

        KHACHHANG KH;
        LOAIPHONG lp;
        SANPHAM sp;
        private void frmTest_Load(object sender, EventArgs e)
        {
            KH = new KHACHHANG();
            lp = new LOAIPHONG();
            sp = new SANPHAM();

            gvTest.DataSource = KH.getAll();
        }
    }
}