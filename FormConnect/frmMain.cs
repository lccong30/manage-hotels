using BusinessLayer;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Ribbon.ViewInfo;
using DevExpress.XtraEditors;
using DevExpress.XtraNavBar;
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
    public partial class frmMain : DevExpress.XtraEditors.XtraForm
    {
        public frmMain()
        {
            InitializeComponent();
        }
        Func _func;
        Tang _tang;
        Phong _phong;
        GalleryItem gItem = null;
        private void frmMain_Load(object sender, EventArgs e)
        {
            _func = new Func();
            _tang = new Tang();
            _phong = new Phong();
            leftMenu();
            showRoom();
        }
        void leftMenu()
        {
            var _lsParent = _func.getParents();
            int i = 0;
            int x = 0;
            foreach (var item in _lsParent)
            {
                NavBarGroup navGr = new NavBarGroup(item.DESCRIPTION);
                navGr.Tag = item.FUNC_CODE;
                navGr.Name = item.FUNC_CODE;
                navMain.Groups.Add(navGr);

                navGr.ImageOptions.LargeImageIndex = i;
                i++;

                var _lsChilds = _func.getChilds(item.FUNC_CODE);
                foreach (var child in _lsChilds)
                {
                    NavBarItem navBarItem = new NavBarItem(child.DESCRIPTION);
                    navBarItem.Tag = child.FUNC_CODE;

                    navBarItem.Name = child.FUNC_CODE;
                    navGr.ItemLinks.Add(navBarItem);
                    navBarItem.ImageOptions.SmallImageIndex = 1;
                    x++;
                }

                navMain.Groups[navGr.Name].Expanded = true;
            }
        }

        public void showRoom()
        {
            _tang = new Tang();
            _phong = new Phong();
            var lsTang = _tang.getAll();
            gControl.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.ZoomInside;
            gControl.Gallery.ImageSize = new Size(64, 64);
            gControl.Gallery.ShowItemText = true;
            gControl.Gallery.ShowGroupCaption = true;

            foreach (var item in lsTang)
            {
                var gItem = new GalleryItemGroup();
                gItem.Caption = item.TENTANG;
                gItem.CaptionAlignment = GalleryItemGroupCaptionAlignment.Stretch;
                var lsPhong = _phong.getByTang(item.ITTANG);
                foreach (var p in lsPhong)
                {
                    var gc_item = new GalleryItem();
                    gc_item.Caption = p.TENPHONG;
                    gc_item.Value = p.IDPHONG;
                    if (p.TRANGTHAI == true)
                        gc_item.ImageOptions.Image = imageList3.Images[1];
                    else
                        gc_item.ImageOptions.Image = imageList3.Images[0];
                    gItem.Items.Add(gc_item);
                }
                gControl.Gallery.Groups.Add(gItem);
            }

        }

        private void navMain_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            string func_code = e.Link.Item.Tag.ToString();
            switch (func_code)
            {
                case "CONGTY":
                    {
                        frmCongTy frm = new frmCongTy();
                        frm.ShowDialog();
                        break;
                    }
                case "DONVI":
                    {
                        frmDonVi frm = new frmDonVi();
                        frm.ShowDialog();
                        break;
                    }
                case "DATPHONG":
                    {
                        frmDatPhong frm = new frmDatPhong();
                        frm.ShowDialog();
                        break;
                    }
                case "KHACHHANG":
                    {
                        frmTest frm = new frmTest();
                        frm.ShowDialog();
                        break;
                    }
            }
            //MessageBox.Show(func_code);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void popupMenu1_Popup(object sender, EventArgs e)
        {
            Point point = gControl.PointToClient(Control.MousePosition);
            RibbonHitInfo hitInfo = gControl.CalcHitInfo(point);
            if (hitInfo.InGalleryItem || hitInfo.HitTest == RibbonHitTest.GalleryImage)
            {
                gItem = hitInfo.GalleryItem;
            }
        }

        private void btnDatPhong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var gc_item = new GalleryItem();
            string id = gItem.Value.ToString();
            MessageBox.Show(id);
        }
    }
}