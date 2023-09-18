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
    public partial class frmDonVi : DevExpress.XtraEditors.XtraForm
    {
        public frmDonVi()
        {
            InitializeComponent();
        }
        DONVI _dvi;
        bool _them;
        string _maDvi;

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
           // cboCty.Enabled = t;
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
            //cboCty.Text = cboCty.SelectedValue.ToString();
            chkDisabled.Checked = false;
        }
       
        private void frmDonVi_Load(object sender, EventArgs e)
        {
            _dvi = new DONVI();
            toggleControl(true);
            loadData();
            loadCty();
        }

        void loadData()
        {
            gcDanhSach.DataSource = _dvi.getAll();
            gvDanhSach.OptionsBehavior.Editable = false;
            txtMa.Enabled = false;

            enableInput(false);
            loadCty();
            resetInput();
         cboCty.SelectedIndexChanged += cboCty_SelectedIndexChanged;
           
        }

        

        private void cboCty_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadDviByCty();
        }

        void loadCty()
        {
            CONGTY cty = new CONGTY();
            cboCty.DataSource = cty.getAll();
            cboCty.DisplayMember = "TENCTY";
            cboCty.ValueMember = "MACTY";
        }
        void loadDviByCty()
        {
            gcDanhSach.DataSource = _dvi.getAll(cboCty.SelectedValue.ToString());
            gvDanhSach.OptionsBehavior.Editable = false;
            txtMa.Enabled = false;

            enableInput(false);
            resetInput();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            _them = true;
            resetInput();
            enableInput(true);
            toggleControl(false);
            cboCty.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            _them = false;
            enableInput(true);
            toggleControl(false);
            txtMa.Enabled = false;
            cboCty.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn Có muốn xóa","Thông báo", MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _dvi.delete(_maDvi);
                loadData();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

            if (_them)
            {
                tb_DonVi cty = new tb_DonVi();
                cty.MADVI = txtMa.Text;
                cty.TENDVI = txtTen.Text;
                cty.DIENTHOAI = txtDienThoai.Text;
                cty.FAX = txtFax.Text;
                cty.EMAIL = txtEmail.Text;
                cty.DIACHI = txtDiaChi.Text;
                cty.MACTY = cboCty.SelectedValue.ToString();
                cty.DISABLED = chkDisabled.Checked;
                _dvi.add(cty);
            }
            else
            {
                tb_DonVi cty = _dvi.getOne(_maDvi);
                cty.TENDVI = txtTen.Text;
                cty.DIENTHOAI = txtDienThoai.Text;
                cty.FAX = txtFax.Text;
                cty.EMAIL = txtEmail.Text;
                cty.DIACHI = txtDiaChi.Text;
                cty.MACTY = cboCty.SelectedValue.ToString();
                cty.DISABLED = chkDisabled.Checked;
                _dvi.update(cty);
            }
            cboCty.Enabled = true;
            // loadData();
            resetInput();
            loadDviByCty();
            enableInput(false);
            toggleControl(true);
        }

        private void btnSkip_Click(object sender, EventArgs e)
        {
            enableInput(false);
            toggleControl(true);
            cboCty.Enabled = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gvDanhSach_Click(object sender, EventArgs e)
        {
            if(gvDanhSach.RowCount > 0)
            {
                _maDvi = gvDanhSach.GetFocusedRowCellValue("MADVI").ToString();
                txtMa.Text = gvDanhSach.GetFocusedRowCellValue("MADVI").ToString();
                txtTen.Text = gvDanhSach.GetFocusedRowCellValue("TENDVI").ToString();
                txtDienThoai.Text = gvDanhSach.GetFocusedRowCellValue("DIENTHOAI").ToString(); ;
                txtFax.Text = gvDanhSach.GetFocusedRowCellValue("FAX").ToString();
                txtEmail.Text = gvDanhSach.GetFocusedRowCellValue("EMAIL").ToString();
                txtDiaChi.Text = gvDanhSach.GetFocusedRowCellValue("DIACHI").ToString();
                cboCty.SelectedValue = gvDanhSach.GetFocusedRowCellValue("MACTY").ToString();
                chkDisabled.Checked = bool.Parse(gvDanhSach.GetFocusedRowCellValue("DISABLED").ToString());
            }
            // tb_DonVi cty = _dvi.getOne(_maDvi);
           
        }

        
    }
}