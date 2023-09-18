using DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class DPSP
    {
        Entities db;
        public DPSP()
        {
            db = Entities.CreateEntities();
        }

        public tb_DatPhong_SanPham getOne(int _id)
        {
            return db.tb_DatPhong_SanPham.FirstOrDefault(x => x.IDDPSP == _id);
        }

        public List<tb_DatPhong_SanPham> getAll()
        {
            return db.tb_DatPhong_SanPham.ToList();
        }

        public List<OBJ_DPSP> getAllByDatPhong(int iddp)
        {
            var lst = db.tb_DatPhong_SanPham.Where(x => x.IDDP == iddp).ToList();
            List<OBJ_DPSP> lstDpSp = new List<OBJ_DPSP>();
            OBJ_DPSP sp;
            foreach (var item in lst)
            {
                sp = new OBJ_DPSP();
                sp.IDDPSP = item.IDDPSP;
                sp.IDDP = item.IDDP;
                sp.IDPHONG = item.IDPHONG;
                var p = db.tb_Phong.FirstOrDefault(x => item.IDPHONG == x.IDPHONG);
                sp.TENPHONG = p.TENPHONG;
                sp.IDSP = item.IDSP;
                var p1 = db.tb_SanPham.FirstOrDefault(x => x.IDSP == item.IDSP && item.IDSP != 0);
                sp.TENSP = p1 == null ? "Nothing" : p1.TENSP;
                sp.SOLUONG = item.SOLUONG;
                sp.DONGIA = item.DONGIA;
                sp.THANHTIEN = item.THANHTIEN;


                lstDpSp.Add(sp);
            }
            return lstDpSp;
        }

        public void add(tb_DatPhong_SanPham a)
        {
            try
            {
                db.tb_DatPhong_SanPham.Add(a);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void deleteAll(int _iddp)
        {
            List<tb_DatPhong_SanPham> dpsp = db.tb_DatPhong_SanPham.Where(x => x.IDDP == _iddp).ToList();
            try
            {
                db.tb_DatPhong_SanPham.RemoveRange(dpsp);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Loi o xoa all dpsp " + ex.Message);
            }

        }

        public void deleteAllByPhong(int _iddp, int _idPhong)
        {
            List<tb_DatPhong_SanPham> dpsp = db.tb_DatPhong_SanPham.Where(x => 
            x.IDDP == _iddp && x.IDPHONG == _idPhong)
            .ToList();
            try
            {
                db.tb_DatPhong_SanPham.RemoveRange(dpsp);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Loi o xoa all dpsp " + ex.Message);
            }

        }

        public void upate(tb_DatPhong_SanPham a)
        {
            tb_DatPhong_SanPham dpsp = db.tb_DatPhong_SanPham.FirstOrDefault(x => x.IDDPSP == a.IDDPSP);
            dpsp.IDDP = a.IDDP;
            dpsp.IDDPCT = a.IDDPCT;
            dpsp.IDPHONG = a.IDPHONG;
            dpsp.IDSP = a.IDSP;
            dpsp.NGAY = a.NGAY;
            dpsp.SOLUONG = a.SOLUONG;
            dpsp.DONGIA = a.DONGIA;
            dpsp.THANHTIEN = a.THANHTIEN;
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
