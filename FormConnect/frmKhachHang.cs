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
    public partial class frmKhachHang : DevExpress.XtraEditors.XtraForm
    {
        public frmKhachHang()
        {
            InitializeComponent();
        }
        frmDatPhong objDP = (frmDatPhong)Application.OpenForms["frmDatPhong"];
        KHACHHANG _khachhang;
        bool _them;
        int _idkh;

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            _khachhang = new KHACHHANG();
            loadKH();
            toggleControl(true);
            enableInput(false);
        }
        // --------------- func
        void loadKH()
        {
            gcDanhSach.DataSource = _khachhang.getAll();
            gvDanhSach.OptionsBehavior.Editable = false;
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
            txtCccd.Enabled = t;
            chkDisabled.Enabled = t;
        }

        void resetInput()
        {
            string t = "";
            _idkh = -1;
            txtTen.Text = "";
            txtDiaChi.Text = t;
            txtDienThoai.Text = t;
            txtEmail.Text = t;
            txtCccd.Text = t;
            chkGioiTinh.Checked = false;
            chkDisabled.Checked = false;
        }
        // --------------- // func

        private void btnThem_Click(object sender, EventArgs e)
        {
            _them = true;
            resetInput();
            toggleControl(false);
            enableInput(true);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            _them = false;
            toggleControl(false);
            enableInput(true);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            if (_idkh != -1)
            {
                _khachhang.delete(_idkh);
            }
            else
            {
                MessageBox.Show("Chua chon ");
            }

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (_them)
            {
                tb_KhachHang newKh = new tb_KhachHang();
                newKh.HOTEN = txtTen.Text;
                newKh.DIACHI = txtDiaChi.Text;
                newKh.EMAIL = txtEmail.Text;
                newKh.DIENTHOAI = txtDienThoai.Text;
                newKh.DISABLED = chkDisabled.Checked;
                newKh.GIOITINH = chkGioiTinh.Checked;
                newKh.CCCD = txtCccd.Text;
                _khachhang.add(newKh);
            }
            else
            {
                tb_KhachHang newKh = new tb_KhachHang();
                newKh.HOTEN = txtTen.Text;
                newKh.DIACHI = txtDiaChi.Text;
                newKh.EMAIL = txtEmail.Text;
                newKh.DIENTHOAI = txtDienThoai.Text;
                newKh.DISABLED = chkDisabled.Checked;
                newKh.GIOITINH = chkGioiTinh.Checked;
                newKh.CCCD = txtCccd.Text;
                _khachhang.update(newKh, _idkh);
            }
            loadKH();
            enableInput(false);
            toggleControl(true);
            resetInput();
        }

        private void btnSkip_Click(object sender, EventArgs e)
        {
            toggleControl(true);
            enableInput(false);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gvDanhSach_Click(object sender, EventArgs e)
        {
            if (gvDanhSach.RowCount > 0)
            {
                _idkh = int.Parse(gvDanhSach.GetFocusedRowCellValue("IDKH").ToString());
                txtTen.Text = gvDanhSach.GetFocusedRowCellValue("HOTEN").ToString();
                txtDienThoai.Text = gvDanhSach.GetFocusedRowCellValue("DIENTHOAI").ToString();
                txtDiaChi.Text = gvDanhSach.GetFocusedRowCellValue("DIACHI").ToString();
                txtEmail.Text = gvDanhSach.GetFocusedRowCellValue("EMAIL").ToString();
                txtCccd.Text = gvDanhSach.GetFocusedRowCellValue("CCCD").ToString();
                chkDisabled.Checked = bool.Parse(gvDanhSach.GetFocusedRowCellValue("DISABLED").ToString());
                chkGioiTinh.Checked = bool.Parse(gvDanhSach.GetFocusedRowCellValue("GIOITINH").ToString());
            }
        }

        private void gvDanhSach_DoubleClick(object sender, EventArgs e)
        {
            if(gvDanhSach.GetFocusedRowCellValue("IDKH") != null)
            {
                objDP.loadKh();
                objDP.setKhachHang(int.Parse(gvDanhSach.GetFocusedRowCellValue("IDKH").ToString()));
                this.Close();
            }
        }
    }
}