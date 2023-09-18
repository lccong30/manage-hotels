using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class DPCT
    {
        Entities db;
        public DPCT()
        {
            db = Entities.CreateEntities();
        }

        public tb_DatPhong_CT getOne(int id_dpct)
        {
            return db.tb_DatPhong_CT.FirstOrDefault(x => x.IDDPCT == id_dpct);
        }

        public List<tb_DatPhong_CT> getAll()
        {
            return db.tb_DatPhong_CT.ToList();
        }
        public List<tb_DatPhong_CT> getAllByDatPhong(int iddp)
        {
            return db.tb_DatPhong_CT.Where(x => x.IDDP == iddp).ToList();
        }

        public tb_DatPhong_CT add(tb_DatPhong_CT a)
        {
            try
            {
                db.tb_DatPhong_CT.Add(a);
                db.SaveChanges();
                return a;
            }
            catch (Exception ex)
            {
                throw new Exception("Error is " + ex.Message);
            }
        }

        public void deleteAll(int _iddp)
        {
            List<tb_DatPhong_CT> dpct = db.tb_DatPhong_CT.Where(x =>x.IDDP == _iddp).ToList();
            try
            {
                db.tb_DatPhong_CT.RemoveRange(dpct);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Loi o xoa all dpct " + ex.Message);
            }

        }
        public void update(tb_DatPhong_CT b)
        {
            tb_DatPhong_CT a = db.tb_DatPhong_CT.FirstOrDefault(x => x.IDDPCT == b.IDDPCT);
            a.IDDPCT = b.IDDPCT;
            a.IDPHONG = b.IDPHONG;
            a.NGAY = b.NGAY;
            a.DONGIA = b.DONGIA;
            a.SONGAYO = b.SONGAYO;
            a.THANHTIEN = b.THANHTIEN;
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Error is " + ex.Message);
            }

        }

        public void delete(int _idDP,int _idPhong)
        {
            tb_DatPhong_CT a = db.tb_DatPhong_CT.FirstOrDefault(x => x.IDDP == _idDP && x.IDPHONG == _idPhong);
            try
            {
                if(a != null)
                {
                    db.tb_DatPhong_CT.Remove(a);
                    db.SaveChanges();
                }
               
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
