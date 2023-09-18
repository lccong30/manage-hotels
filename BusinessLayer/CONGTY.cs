using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class CONGTY
    {
        Entities db;

        public CONGTY()
        {
            db = Entities.CreateEntities();
        }

        public tb_CongTy getItem(string maCty)
        {
            return db.tb_CongTy.FirstOrDefault(x => x.MACTY == maCty);
        }

        public List<tb_CongTy> getAll()
        {
            return db.tb_CongTy.ToList();
        }

        public void add(tb_CongTy cty)
        {
            try
            {
                db.tb_CongTy.Add(cty);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Erorr is " + ex.Message);
            }
        }

        public void update(tb_CongTy cty, string  mct)
        {
            tb_CongTy _cty = db.tb_CongTy.FirstOrDefault(x => x.MACTY == mct);
            _cty.TENCTY = cty.TENCTY;
            _cty.DIENTHOAI = cty.DIENTHOAI;
            _cty.FAX = cty.FAX;
            _cty.EMAIL = cty.EMAIL;
            _cty.DIACHI = cty.DIACHI;
            _cty.DISABLED = cty.DISABLED;
           
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Erorr is " + ex.Message);
            }
        }

        public void delete(string maCty)
        {
            tb_CongTy cty = db.tb_CongTy.FirstOrDefault(x => x.MACTY == maCty);
            cty.DISABLED = true;
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
