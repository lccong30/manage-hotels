using BusinessLayer;
using DataLayer;
using DevExpress.Utils.Gesture;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraPrinting.Native;
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
    public partial class frmDatPhong : DevExpress.XtraEditors.XtraForm
    {
        public frmDatPhong()
        {
            InitializeComponent();
            DataTable dt = myFunc.layDuLieu("select A.IDPHONG, A.TENPHONG,B.ITTANG, B.TENTANG, C.DONGIA FROM  tb_Phong A,  tb_Tang B, tb_LoaiPhong C WHERE  A.IDTANG=B.ITTANG AND A.TRANGTHAI = 0  AND A.IDLOAIPHONG = C.IDLOAIPHONG");
            gcPhong.DataSource = dt;
            gcDatPhong.DataSource = dt.Clone();
        }

        frmMain objMain = (frmMain)Application.OpenForms["frmMain"];

        bool _them;
        int _idPhong;
        int _idKH;
        string _tenPhong;
        string _macty;
        string _madvi;
        int _idDatPhong;
        int _rowCountDP = 0;

        List<OBJ_DPSP> lstDpsp;

        SYS_PARAM _param;

        KHACHHANG _kh;
        DATPHONG _datphong;
        DPCT _dpct;
        DPSP _dpsp;
        Phong _phong;

        SANPHAM _sp;

        GridHitInfo downHitInfo = null;
        //TRANGTHAI _status;


        // ------------------------------------------ open func ------------------------------------------
        void toggleControl(bool t)
        {
            btnThem.Visible = t;
            btnSua.Visible = t;
            btnXoa.Visible = t;
            btnThoat.Visible = t;
            btnSkip.Visible = !t;
            btnLuu.Visible = !t;
            btnIn.Visible = !t;
        }

        void enableInput(bool t)
        {
            btnAddNew.Visible = t;
            cboKhachHang.Enabled = t;
            txtGhiChu.Enabled = t;
            dtNgayDat.Enabled = t;
            dtNgayTra.Enabled = t;
            spSoNguoi.Enabled = t;
            chkDoan.Enabled = t;
            cboTrangThai.Enabled = t;

            gcDatPhong.Enabled = t;
            gcSanPham.Enabled = t;
            gcPhong.Enabled = t;
            gcSPDV.Enabled = t;
        }

        void resetInput()
        {
            dtNgayDat.Value = DateTime.Now;
            dtNgayTra.Value = DateTime.Now.AddDays(1);
            spSoNguoi.Text = "1";

            chkDoan.Checked = true;
            // cboTrangThai.SelectedValue = false;

            txtGhiChu.Text = "";
            txtThanhTien.Text = "0";

            spSoNguoi.Text = "1";
            cboKhachHang.Enabled = true;

        }

        public void loadKh()
        {
            cboKhachHang.DataSource = _kh.getAll();
            cboKhachHang.DisplayMember = "HOTEN";
            cboKhachHang.ValueMember = "IDKH";
        }

        void loadSP()
        {
            gcSanPham.DataSource = _sp.getAll();
            gvSanPham.OptionsBehavior.Editable = false;
        }

        void loadStatus()
        {
            cboTrangThai.DataSource = TRANGTHAI.getList();
            cboTrangThai.DisplayMember = "_dis";
            cboTrangThai.ValueMember = "_val";
        }

        bool cal(Int32 _width, GridView _View)
        {
            _View.IndicatorWidth = _View.IndicatorWidth < _width ? _width : _View.IndicatorWidth;
            return true;
        }


        // ------------------------------------------ close func ------------------------------------------

        private void frmDatPhong_Load(object sender, EventArgs e)
        {
            _kh = new KHACHHANG();
            _sp = new SANPHAM();
            _dpct = new DPCT();
            _dpsp = new DPSP();
            _datphong = new DATPHONG();
            _param = new SYS_PARAM();
            _phong = new Phong();
            //  _status = new TRANGTHAI();
            // getParam()
            var _pr = _param.getOne();
            _macty = _pr.MACTY;
            _madvi = _pr.MADVI;

            lstDpsp = new List<OBJ_DPSP>();

            dtpFromDate.Value = myFunc.GetFirstDayOfMonth(DateTime.Now.Year, DateTime.Now.Month);

            dtpToDate.Value = DateTime.Now;
            tcDanhSach.SelectedTabPage = pageDanhSach;

            gvPhong.ExpandAllGroups();

            loadDanhSach();
            loadKh();
            loadSP();
            loadStatus();


            toggleControl(true);
            resetInput();


        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            _them = true;
            resetInput();
            initialOrder();
            enableInput(true);
            toggleControl(false);
            tcDanhSach.SelectedTabPage = pageChiTiet;
        }

        void initialOrder()
        {
            DataTable dt = myFunc.layDuLieu("select A.IDPHONG, A.TENPHONG,B.ITTANG, B.TENTANG, C.DONGIA FROM  tb_Phong A,  tb_Tang B, tb_LoaiPhong C WHERE  A.IDTANG=B.ITTANG AND A.TRANGTHAI = 0  AND A.IDLOAIPHONG = C.IDLOAIPHONG");
            gcPhong.DataSource = dt;
            gcDatPhong.DataSource = dt.Clone();
            gvPhong.ExpandAllGroups();
            gcSPDV.DataSource = null;
            txtThanhTien.Text = "0".ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            _them = false;
            enableInput(true);
            toggleControl(false);
            tcDanhSach.SelectedTabPage = pageChiTiet;

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn Có muốn xóa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _datphong.delete(_idDatPhong);
                var lstPhong = _dpct.getAllByDatPhong(_idDatPhong);
                foreach (var item in lstPhong)
                {
                    if(item.IDPHONG != null)
                        _phong.UpdateStatus(item.IDPHONG, false);
                }
                objMain.gControl.Gallery.Groups.Clear();
                objMain.showRoom();
                loadDanhSach();

            }

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            saveData();
            objMain.gControl.Gallery.Groups.Clear();
            objMain.showRoom();
            //resetInput();
            enableInput(false);
            toggleControl(true);

        }

        void loadDanhSach()
        {
            // gcDanhSach.DataSource = _datphong.getAll1();
            _datphong = new DATPHONG(); 
            gcDanhSach.DataSource = _datphong.getAll(dtpFromDate.Value, dtpToDate.Value, _macty, _madvi);
            gvDanhSach.OptionsBehavior.Editable = false;
        }

        void saveData()
        {
            if (_them)
            {
                tb_DatPhong dp = new tb_DatPhong();
                tb_DatPhong_SanPham dpsp;
                tb_DatPhong_CT dpct;
                dp.NGAYDAT = dtNgayDat.Value;
                dp.NGAYTRA = dtNgayTra.Value;
                dp.SONGUOI = int.Parse(spSoNguoi.Text);
                dp.SONGAYO = dtNgayTra.Value.Day - dtNgayDat.Value.Day;
                dp.STATUS = bool.Parse(cboTrangThai.SelectedValue.ToString());
                dp.THEODOAN = chkDoan.Checked;
                dp.IDKH = int.Parse(cboKhachHang.SelectedValue.ToString());
                dp.SOTIEN = float.Parse(txtThanhTien.Text);
                dp.NOTE = txtGhiChu.Text;
                dp.DISABLED = false;
                dp.IDUSER = 1;
                dp.MACTY = _macty;
                dp.MADVI = _madvi;
                dp.CREATED_AT = DateTime.Now;
                var _dp = _datphong.add(dp);
                _idDatPhong = _dp.IDDP;
                for (int i = 0; i < gvDatPhong.RowCount; i++)
                {
                    dpct = new tb_DatPhong_CT();
                    dpct.IDDP = _dp.IDDP;
                    dpct.IDPHONG = int.Parse(gvDatPhong.GetRowCellValue(i, "IDPHONG").ToString());
                    dpct.SONGAYO = dtNgayTra.Value.Day - dtNgayDat.Value.Day;
                    dpct.DONGIA = double.Parse(gvDatPhong.GetRowCellValue(i, "DONGIA").ToString());
                    dpct.NGAY = DateTime.Now;
                    dpct.THANHTIEN = dpct.SONGAYO * dpct.DONGIA;
                    var dpChiTiet = _dpct.add(dpct);
                    _phong.UpdateStatus(int.Parse(dpct.IDPHONG.ToString()), true);

                    if (gvSPDV.RowCount > 0)
                    {
                        for (int j = 0; j < gvSPDV.RowCount; j++)
                        {
                            if (dpct.IDPHONG == int.Parse(gvSPDV.GetRowCellValue(j, "IDPHONG").ToString()))
                            {
                                dpsp = new tb_DatPhong_SanPham();
                                dpsp.IDDP = _dp.IDDP;
                                dpsp.IDDPCT = dpChiTiet.IDDPCT;
                                dpsp.IDPHONG = int.Parse(gvSPDV.GetRowCellValue(j, "IDPHONG").ToString());
                                dpsp.IDSP = int.Parse(gvSPDV.GetRowCellValue(j, "IDSP").ToString());
                                dpsp.SOLUONG = int.Parse(gvSPDV.GetRowCellValue(j, "SOLUONG").ToString());
                                dpsp.DONGIA = int.Parse(gvSPDV.GetRowCellValue(j, "DONGIA").ToString());
                                dpsp.THANHTIEN = dpsp.SOLUONG * dpsp.DONGIA;
                                dpsp.NGAY = DateTime.Now;
                                _dpsp.add(dpsp);
                            }

                        }

                    }
                }

            }
            else
            {
                //update
                tb_DatPhong dp = _datphong.getOne(_idDatPhong);
                tb_DatPhong_SanPham dpsp;
                tb_DatPhong_CT dpct;
                dp.NGAYDAT = dtNgayDat.Value;
                dp.NGAYTRA = dtNgayDat.Value;
                dp.SONGAYO = dtNgayTra.Value.Day - dtNgayDat.Value.Day;
                dp.SONGUOI = int.Parse(spSoNguoi.Text);
                dp.STATUS = bool.Parse(cboTrangThai.SelectedValue.ToString());
                dp.IDKH = int.Parse(cboKhachHang.SelectedValue.ToString());
                dp.SOTIEN = double.Parse(txtThanhTien.Text);
                dp.NOTE = txtGhiChu.Text;
                dp.IDUSER = 1;
                dp.UPDATED_AT = DateTime.Now;
                var _dp = _datphong.update(dp);
                _idDatPhong = _dp.IDDP;
                _dpct.deleteAll(_idDatPhong);
                _dpsp.deleteAll((_dp.IDDP));

                for (int i = 0; i < gvDatPhong.RowCount; i++)
                {
                    dpct = new tb_DatPhong_CT();
                    dpct.IDDP = _dp.IDDP;
                    dpct.IDPHONG = int.Parse(gvDatPhong.GetRowCellValue(i, "IDPHONG").ToString());
                    dpct.SONGAYO = dtNgayTra.Value.Day - dtNgayDat.Value.Day;
                    dpct.DONGIA = double.Parse(gvDatPhong.GetRowCellValue(i, "DONGIA").ToString());
                    dpct.NGAY = DateTime.Now;
                    dpct.THANHTIEN = dpct.SONGAYO * dpct.DONGIA;
                    var dpChiTiet = _dpct.add(dpct);
                    _phong.UpdateStatus(int.Parse(dpct.IDPHONG.ToString()), true);

                    if (gvSPDV.RowCount > 0)
                    {
                        for (int j = 0; j < gvSPDV.RowCount; j++)
                        {
                            if (dpct.IDPHONG == int.Parse(gvSPDV.GetRowCellValue(j, "IDPHONG").ToString()))
                            {
                                dpsp = new tb_DatPhong_SanPham();
                                dpsp.IDDP = _dp.IDDP;
                                dpsp.IDDPCT = dpChiTiet.IDDPCT;
                                dpsp.IDPHONG = int.Parse(gvSPDV.GetRowCellValue(j, "IDPHONG").ToString());
                                dpsp.IDSP = int.Parse(gvSPDV.GetRowCellValue(j, "IDSP").ToString());
                                dpsp.SOLUONG = int.Parse(gvSPDV.GetRowCellValue(j, "SOLUONG").ToString());
                                dpsp.DONGIA = int.Parse(gvSPDV.GetRowCellValue(j, "DONGIA").ToString());
                                dpsp.NGAY = DateTime.Now;
                                dpsp.THANHTIEN = dpsp.SOLUONG * dpsp.DONGIA;

                                _dpsp.add(dpsp);
                            }

                        }

                    }

                }
            }
        }

        private void btnSkip_Click(object sender, EventArgs e)
        {
            enableInput(false);
            toggleControl(true);
            resetInput();
            tcDanhSach.SelectedTabPage = pageDanhSach;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {

        }

        private void gvDatPhong_MouseDown(object sender, MouseEventArgs e)
        {
            if (gvDatPhong.GetFocusedRowCellValue("IDPHONG") != null)
            {
                _idPhong = int.Parse(gvDatPhong.GetFocusedRowCellValue("IDPHONG").ToString());
                _tenPhong = gvDatPhong.GetFocusedRowCellValue("TENPHONG").ToString();
            }
            GridView view = sender as GridView;
            downHitInfo = null;
            GridHitInfo hitInfo = view.CalcHitInfo(new Point(e.X, e.Y));
            if (Control.ModifierKeys != Keys.None) return;
            if (e.Button == MouseButtons.Left && hitInfo.RowHandle >= 0)
            {
                downHitInfo = hitInfo;
            }
        }

        private void gvDatPhong_MouseMove(object sender, MouseEventArgs e)
        {
            GridView view = sender as GridView;
            if (e.Button == MouseButtons.Left && downHitInfo != null)
            {
                Size dragSize = SystemInformation.DragSize;
                Rectangle dragRect = new Rectangle(new Point(downHitInfo.HitPoint.X - dragSize.Width / 2,
                    downHitInfo.HitPoint.Y - dragSize.Height / 2), dragSize);
                if (!dragRect.Contains(new Point(e.X, e.Y)))
                {
                    DataRow row = view.GetDataRow(downHitInfo.RowHandle);
                    view.GridControl.DoDragDrop(row, DragDropEffects.Move);
                    downHitInfo = null;
                    DevExpress.Utils.DXMouseEventArgs.GetMouseArgs(e).Handled = true;
                }
            }

        }

        private void gvPhong_MouseDown(object sender, MouseEventArgs e)
        {
            GridView view = sender as GridView;
            downHitInfo = null;
            GridHitInfo hitInfo = view.CalcHitInfo(new Point(e.X, e.Y));
            if (Control.ModifierKeys != Keys.None) return;
            if (e.Button == MouseButtons.Left && hitInfo.RowHandle >= 0)
            {
                downHitInfo = hitInfo;
            }
        }

        private void gvPhong_MouseMove(object sender, MouseEventArgs e)
        {
            GridView view = sender as GridView;
            if (e.Button == MouseButtons.Left && downHitInfo != null)
            {
                Size dragSize = SystemInformation.DragSize;
                Rectangle dragRect = new Rectangle(new Point(downHitInfo.HitPoint.X - dragSize.Width / 2,
                    downHitInfo.HitPoint.Y - dragSize.Height / 2), dragSize);
                if (!dragRect.Contains(new Point(e.X, e.Y)))
                {
                    DataRow row = view.GetDataRow(downHitInfo.RowHandle);
                    view.GridControl.DoDragDrop(row, DragDropEffects.Move);
                    downHitInfo = null;
                    DevExpress.Utils.DXMouseEventArgs.GetMouseArgs(e).Handled = true;
                }
            }
        }

        private void gcPhong_DragDrop(object sender, DragEventArgs e)
        {
            GridControl grid = sender as GridControl;
            DataTable table = grid.DataSource as DataTable;
            DataRow row = e.Data.GetData(typeof(DataRow)) as DataRow;
            if (row != null && table != null && row.Table != table)
            {
                table.ImportRow(row);
                row.Delete();
            }
        }

        private void gcPhong_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(DataRow)))
            {
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void gvPhong_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
                e.Info.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
                e.Info.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            }
        }

        private void gvPhong_CustomDrawGroupRow(object sender, DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventArgs e)
        {
            GridView view = sender as GridView;
            GridGroupRowInfo info = e.Info as GridGroupRowInfo;
            string caption = info.Column.Caption;
            if (info.Column.Caption != string.Empty)
            {
                caption = info.Column.Caption;
            }
            info.GroupText = string.Format("{0}: {1} ({2} Phòng trống)", caption, info.GroupValueText, view.GetChildRowCount(e.RowHandle));
        }

        private void gcSanPham_DoubleClick(object sender, EventArgs e)
        {
            if (_idPhong == 0)
            {
                MessageBox.Show("Vui long chon phong", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (gvSanPham.GetFocusedRowCellValue("IDSP") != null)
            {
                OBJ_DPSP sp = new OBJ_DPSP();

                sp.IDSP = int.Parse(gvSanPham.GetFocusedRowCellValue("IDSP").ToString());
                sp.TENSP = gvSanPham.GetFocusedRowCellValue("TENSP").ToString();
                sp.IDPHONG = _idPhong;
                sp.TENPHONG = _tenPhong;
                sp.DONGIA = float.Parse(gvSanPham.GetFocusedRowCellValue("DONGIA").ToString());
                sp.SOLUONG = 1;
                sp.THANHTIEN = sp.DONGIA * sp.SOLUONG;

                foreach (var item in lstDpsp)
                {
                    if (item.IDSP == sp.IDSP && item.IDPHONG == sp.IDPHONG)
                    {
                        item.SOLUONG = item.SOLUONG + 1;
                        item.THANHTIEN = item.SOLUONG * item.DONGIA;
                        loadDPSP();
                        return;
                    }
                }
                lstDpsp.Add(sp);
            }
            loadDPSP();
            txtThanhTien.Text = (double.Parse(gvSPDV.Columns["THANHTIEN"].SummaryItem.SummaryValue.ToString()) + double.Parse(gvDatPhong.Columns["DONGIA"].SummaryItem.SummaryValue.ToString())).ToString("N0");

        }

        void loadDPSP()
        {
            List<OBJ_DPSP> dp = new List<OBJ_DPSP>();
            foreach (var item in lstDpsp)
            {
                dp.Add(item);
            }
            gcSPDV.DataSource = dp;
        }



        private void gvSPDV_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "SOLUONG")
            {
                int sl = int.Parse(e.Value.ToString());
                if (sl != 0)
                {
                    double gia = double.Parse(gvSPDV.GetRowCellValue(gvSPDV.FocusedRowHandle, "DONGIA").ToString());
                    gvSPDV.SetRowCellValue(gvSPDV.FocusedRowHandle, "THANHTIEN", sl * gia);
                }
                else
                {
                    gvSPDV.SetRowCellValue(gvSPDV.FocusedRowHandle, "THANHTIEN", 0);
                }
            }

            gvSPDV.UpdateTotalSummary();
            //   txtThanhTien.Text = gvSPDV.Columns["THANHTIEN"].SummaryItem.SummaryValue.ToString();
            txtThanhTien.Text = (double.Parse(gvSPDV.Columns["THANHTIEN"].SummaryItem.SummaryValue.ToString()) + double.Parse(gvDatPhong.Columns["DONGIA"].SummaryItem.SummaryValue.ToString())).ToString("N0");


        }

        private void gvDatPhong_RowCountChanged(object sender, EventArgs e)
        {
            if(gvDatPhong.RowCount < _rowCountDP && _them == false)
            {
                _phong.UpdateStatus(_idPhong, false);
                if(_idDatPhong != null && _idPhong != null)
                {
                    _dpct.delete(_idDatPhong, _idPhong);
                    _dpsp.deleteAllByPhong(_idDatPhong, _idPhong);
                }
                objMain.gControl.Gallery.Groups.Clear();
                loadCTDPSP();
                objMain.showRoom();
            }
            double t = 0;
            if (gvSPDV.Columns["THANHTIEN"].SummaryItem.SummaryValue == null)
                t = 0;
            else
                t = double.Parse(gvSPDV.Columns["THANHTIEN"].SummaryItem.SummaryValue.ToString());

            txtThanhTien.Text = (double.Parse(gvDatPhong.Columns["DONGIA"].SummaryItem.SummaryValue.ToString()) + t).ToString("N0");
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            frmKhachHang frm = new frmKhachHang();
            frm.ShowDialog();
        }

        public void setKhachHang(int id)
        {
            var kh = _kh.getOne(id);
            cboKhachHang.SelectedValue = kh.IDKH;
            cboKhachHang.Text = kh.HOTEN;
        }

        private void gvDanhSach_Click(object sender, EventArgs e)
        {
            if (gvDanhSach.RowCount > 0)
            {
                _idDatPhong = int.Parse(gvDanhSach.GetFocusedRowCellValue("IDDP").ToString());
                _idKH = int.Parse(gvDanhSach.GetFocusedRowCellValue("IDKH").ToString());
                var dp = _datphong.getOne(_idDatPhong);
                //cboKhachHang.SelectedValue = dp.IDKH;
                //dtNgayDat.Value = 
                //dp.NGAYDAT.Value;
                //dtNgayTra.Value = dp.NGAYTRA.Value;
                //spSoNguoi.Text = dp.SONGUOI.ToString();
                //// chkDoan.Checked = dp.THEODOAN.Value;
                //cboTrangThai.SelectedValue = dp.STATUS;
                //txtGhiChu.Text = dp.NOTE;
                //txtThanhTien.Text = dp.SOTIEN.Value.ToString("N0");
                loadCTDP();
                loadCTDPSP();
            }
        }

        void loadCTDP()
        {
            _rowCountDP = 0;
            gcDatPhong.DataSource = myFunc.layDuLieu(
                $"select A.IDPHONG, A.TENPHONG,B.ITTANG, B.TENTANG, C.DONGIA FROM tb_Phong A,  tb_Tang B, tb_LoaiPhong C, tb_DatPhong_CT D WHERE A.IDTANG=B.ITTANG AND  A.IDLOAIPHONG = C.IDLOAIPHONG AND D.IDPHONG = A.IDPHONG AND D.IDDP ={_idDatPhong}");
            _rowCountDP = gvDatPhong.RowCount;
        }
        void loadCTDPSP()
        {
            gcSPDV.DataSource = _dpsp.getAllByDatPhong(_idDatPhong);
        }
        private void dtNgayTra_ValueChanged(object sender, EventArgs e)
        {
            loadDanhSach();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
        }

        private void dtpFromDate_ValueChanged(object sender, EventArgs e)
        {
            if (dtpFromDate.Value > dtpToDate.Value)
            {
                MessageBox.Show("Ngay Khong hop le");
                return;
            }
            else
            {
                loadDanhSach();
            }
        }

        private void dtpFromDate_Leave(object sender, EventArgs e)
        {
            if (dtpFromDate.Value > dtpToDate.Value)
            {
                MessageBox.Show("Ngay Khong hop le");
                return;
            }
            else
            {
                loadDanhSach();
            }
        }

        private void dtpToDate_ValueChanged(object sender, EventArgs e)
        {
            if (dtpFromDate.Value > dtpToDate.Value)
            {
                MessageBox.Show("Ngay Khong hop le");
                return;
            }
            else
            {
                loadDanhSach();
            }
        }

        private void dtpToDate_Leave(object sender, EventArgs e)
        {
            if (dtpFromDate.Value > dtpToDate.Value)
            {
                MessageBox.Show("Ngay Khong hop le");
                return;
            }
            else
            {
                loadDanhSach();
            }
        }

        private void gvDanhSach_DoubleClick(object sender, EventArgs e)
        {
            enableInput(false);
            if (gvDanhSach.RowCount > 0)
            {
                _idKH = int.Parse(gvDanhSach.GetFocusedRowCellValue("IDKH").ToString());
                _idDatPhong = int.Parse(gvDanhSach.GetFocusedRowCellValue("IDDP").ToString());
                var dp = _datphong.getOne(_idDatPhong);
                cboKhachHang.SelectedValue = dp.IDKH;
                dtNgayDat.Value = dp.NGAYDAT.Value;
                dtNgayTra.Value = dp.NGAYTRA.Value;
                spSoNguoi.Text = dp.SONGUOI.ToString();
                cboTrangThai.SelectedValue = dp.STATUS;
                txtGhiChu.Text = dp.NOTE;
                txtThanhTien.Text = dp.SOTIEN.Value.ToString("N0");
                loadCTDP();
                loadCTDPSP();
            }
            tcDanhSach.SelectedTabPage = pageChiTiet;

        }

        private void gvDanhSach_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
                e.Info.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
                e.Info.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            }
        }
    }
}