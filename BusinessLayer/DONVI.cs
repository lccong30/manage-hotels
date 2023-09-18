using DataLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class DONVI
    {
        Entities db;
        public DONVI()
        {
            db = Entities.CreateEntities();
        }

        public tb_DonVi getOne(string madvi)
        {
            tb_DonVi dvi = db.tb_DonVi.FirstOrDefault(x => x.MADVI == madvi);
            return dvi;
        }

        public List<tb_DonVi> getAll()
        {
            return db.tb_DonVi.ToList();
        }

       
        public List<tb_DonVi> getAll(string macty)
        {
            return db.tb_DonVi.Where(x => x.MACTY == macty).ToList();
        }

        public void add(tb_DonVi dvi)
        {
            try
            {
                db.tb_DonVi.Add(dvi);
                db.SaveChanges();
            }catch (Exception ex)
            {
                throw new Exception("Erorr is " + ex.Message);
            }
        }

        public void delete(string dvi)
        {
            tb_DonVi xx = db.tb_DonVi.FirstOrDefault(x => x.MADVI == dvi);
            xx.DISABLED = true;
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Erorr is " + ex.Message);
            }
        }

        public void update(tb_DonVi newdvi)
        {
            tb_DonVi dvi = db.tb_DonVi.FirstOrDefault(x => x.MADVI == newdvi.MADVI);
            dvi.TENDVI = newdvi.TENDVI;
            dvi.DISABLED = newdvi.DISABLED;
            dvi.DIENTHOAI = newdvi.DIENTHOAI;
            dvi.EMAIL = newdvi.EMAIL;
            dvi.FAX = newdvi.FAX;
            dvi.DIACHI = newdvi.DIACHI;
            dvi.MACTY = newdvi.MACTY;
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Erorr is " + ex.Message);
            }
        }

        public void delete(int id)
        {
            tb_DatPhong x = db.tb_DatPhong.FirstOrDefault(u => u.IDDP == id);
            x.DISABLED = true;
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Erorr is " + ex.Message);
            }
        }
    }
}
