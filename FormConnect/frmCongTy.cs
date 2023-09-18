using BusinessLayer;
using DataLayer;
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
    public partial class frmCongTy : DevExpress.XtraEditors.XtraForm
    {
        public frmCongTy()
        {
            InitializeComponent();
        }
        CONGTY _congty;
        bool _them;
        string _maCty;
        private void frmCongTy_Load(object sender, EventArgs e)
        {
            _congty = new CONGTY();
            loadData();
            enableInput(false);
            toggleControl(true);
        }

        void toggleControl(bool t)
        {
            btnThem.Visible = t;
            btnSua.Visible = t;
            btnXoa.Visible = t;
            btnThoat.Visible = t;
            btnSkip.Visible = !t;
            btnLuu.Visible = !t;
        }

        void enableInput(bool t)
        {
            txtTen.Enabled = t;
            txtDiaChi.Enabled = t;
            txtDienThoai.Enabled = t;
            txtEmail.Enabled = t;
            txtFax.Enabled = t;
            txtMa.Enabled = t;
            chkDisabled.Enabled = t;
        }

        void resetInput()
        {
            string t = "";
            txtTen.Text = "";
            txtDiaChi.Text = t;
            txtDienThoai.Text = t;
            txtEmail.Text = t;
            txtFax.Text = t;
            txtMa.Text = t;
            chkDisabled.Checked = false;
        }

        void loadData()
        {
            gcDanhSach.DataSource = _congty.getAll();
            gvDanhSach.OptionsBehavior.Editable = false;
            txtMa.Enabled = false;
            enableInput(false);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMa.Enabled = true;
            _them = true;
            enableInput(true);
            resetInput();
            toggleControl(false);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            enableInput(true);
            _them = false;
            txtMa.Enabled = false;
            toggleControl(false);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc xóa không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _congty.delete(_maCty);
                loadData();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            toggleControl(true);


            if (_them)
            {
                tb_CongTy cty = new tb_CongTy();
                cty.MACTY = txtMa.Text;
                cty.TENCTY = txtTen.Text;
                cty.DIENTHOAI = txtDienThoai.Text;
                cty.FAX = txtFax.Text;
                cty.EMAIL = txtEmail.Text;
                cty.DIACHI = txtDiaChi.Text;
                cty.DISABLED = chkDisabled.Checked;
                _congty.add(cty);
            }
            else
            {
                tb_CongTy cty = _congty.getItem(_maCty);
                cty.TENCTY = txtTen.Text;
                cty.DIENTHOAI = txtDienThoai.Text;
                cty.FAX = txtFax.Text;
                cty.EMAIL = txtEmail.Text;
                cty.DIACHI = txtDiaChi.Text;
                cty.DISABLED = chkDisabled.Checked;
                _congty.update(cty, _maCty);

            }
            _them = false;
            _maCty = null;
            resetInput();
            loadData();
            toggleControl(true);

        }

        private void btnSkip_Click(object sender, EventArgs e)
        {
            enableInput(false);
            toggleControl(true);
            txtMa.Enabled = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gvDanhSach_Click(object sender, EventArgs e)
        {
            if (gvDanhSach.RowCount > 0)
            {
                _maCty = gvDanhSach.GetFocusedRowCellValue("MACTY").ToString();
                tb_CongTy cty = _congty.getItem(_maCty);

                txtMa.Text = gvDanhSach.GetFocusedRowCellValue("MACTY").ToString();
                txtTen.Text = gvDanhSach.GetFocusedRowCellValue("TENCTY").ToString();
                txtDienThoai.Text = gvDanhSach.GetFocusedRowCellValue("DIENTHOAI").ToString(); ;
                txtFax.Text = gvDanhSach.GetFocusedRowCellValue("FAX").ToString();
                txtEmail.Text = gvDanhSach.GetFocusedRowCellValue("EMAIL").ToString();
                txtDiaChi.Text = gvDanhSach.GetFocusedRowCellValue("DIACHI").ToString();
                chkDisabled.Checked = bool.Parse(gvDanhSach.GetFocusedRowCellValue("DISABLED").ToString());
                //txtMaCty.Text = cty.MACTY;
                //txtTen.Text = cty.TENCTY;
                //txtDienThoai.Text = cty.DIENTHOAI;
                //txtFax.Text = cty.FAX;
                //txtEmail.Text = cty.EMAIL;
                //txtDiaChi.Text = cty.DIACHI;
                //chkDisabled.Checked = cty.DISABLED == true ? chkDisabled.Checked = true : chkDisabled.Checked = false;

            }
        }
    }
}