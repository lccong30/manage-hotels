using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Data.Entity.Infrastructure.Design.Executor;

namespace BusinessLayer
{
    public class DATPHONG
    {
        Entities db;
        public DATPHONG()
        {
            db = Entities.CreateEntities();
        }

        public tb_DatPhong getOne(int _id)
        {
            return db.tb_DatPhong.FirstOrDefault(x => x.IDDP == _id);
        }

        public List<tb_DatPhong> getAll()
        {
            return db.tb_DatPhong.ToList();
        }

        public List<OBJ_DATPHONG> getAll1()
        {
            var listDP = db.tb_DatPhong.ToList();
            List<OBJ_DATPHONG> lstDP = new List<OBJ_DATPHONG>();
            OBJ_DATPHONG dp;
            foreach (var item in listDP)
            {
                dp = new OBJ_DATPHONG();
                dp.IDDP = item.IDDP;
                dp.IDKH = item.IDKH;
                var kh = db.tb_KhachHang.FirstOrDefault(x => x.IDKH == item.IDKH);
                dp.HOTEN = kh.HOTEN;
                dp.IDUSER = item.IDUSER;
                dp.NGAYTRA = item.NGAYTRA;
                dp.NGAYDAT = item.NGAYDAT;
                dp.MACTY = item.MACTY;
                dp.MADVI = item.MADVI;
                dp.SONGUOI = item.SONGUOI;
                dp.SOTIEN = item.SOTIEN;
                dp.NOTE = item.NOTE;
                dp.STATUS = item.STATUS;
                dp.THEODOAN = item.THEODOAN;
                dp.DISABLED = item.DISABLED;

                lstDP.Add(dp);
            }
            return lstDP;
        }

        public List<OBJ_DATPHONG> getAll(DateTime fromDate, DateTime toDate, string macty, string madvi)
        {
            var listDP  = db.tb_DatPhong.Where(x => x.NGAYDAT >= fromDate && x.NGAYTRA < toDate ).ToList();
            List<OBJ_DATPHONG> lstDP = new List<OBJ_DATPHONG>();
            OBJ_DATPHONG dp;
            foreach (var item in listDP)
            {
                dp = new OBJ_DATPHONG();
                dp.IDDP = item.IDDP;
                dp.IDKH = item.IDKH;
                var kh = db.tb_KhachHang.FirstOrDefault(x => x.IDKH == item.IDKH);
                dp.HOTEN = kh.HOTEN;
                dp.IDUSER = item.IDUSER;
                dp.NGAYTRA = item.NGAYTRA;
                dp.NGAYDAT = item.NGAYDAT;
                dp.MACTY = item.MACTY;
                dp.MADVI = item.MADVI;
                dp.SONGUOI = item.SONGUOI;
                dp.SOTIEN = item.SOTIEN;
                dp.NOTE = item.NOTE;
                dp.STATUS = item.STATUS;
                dp.THEODOAN = item.THEODOAN;
                dp.DISABLED = item.DISABLED;

                lstDP.Add(dp);
            }
            return lstDP;
        }

        public tb_DatPhong add(tb_DatPhong dp)
        {
            db.tb_DatPhong.Add(dp);
            try
            {
                db.SaveChanges();
                return dp;  
            }catch(Exception ex)
            {
                throw new Exception("Error is " + ex.Message);
            }
        }

        public tb_DatPhong update(tb_DatPhong dp)
        {
            tb_DatPhong _dp = db.tb_DatPhong.FirstOrDefault(x => x.IDDP == dp.IDDP);
            if (_dp != null)
            {
                _dp.IDKH = dp.IDKH;
                _dp.NGAYDAT = dp.NGAYDAT;
                _dp.NGAYTRA = dp.NGAYTRA;
                _dp.SOTIEN = dp.SOTIEN;
                _dp.SONGAYO = dp.SONGAYO;
                _dp.IDUSER = dp.IDUSER;
                _dp.MACTY = dp.MACTY;
                _dp.MADVI = dp.MADVI;
                _dp.STATUS = dp.STATUS; 
                _dp.DISABLED = dp.DISABLED;
                _dp.CREATED_AT = dp.CREATED_AT;
                _dp.UPDATED_AT = dp.UPDATED_AT;
                _dp.UPDATED_BY = dp.UPDATED_BY;
                _dp.THEODOAN = dp.THEODOAN;
                _dp.NOTE = dp.NOTE;
                try
                {
                    db.SaveChanges();
                    return _dp;
                }catch (Exception ex)
                {
                    throw new Exception("Erorr is " + ex.Message);
                }
            }
            else
            {
                throw new Exception("Update is failed ");
            }
        }

        public void delete(int _id)
        {
            tb_DatPhong dp = db.tb_DatPhong.FirstOrDefault(x => x.IDDP == _id);
            try
            {
                dp.DISABLED = true;
                db.SaveChanges();
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
