using DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Phong
    {
        Entities db;

        public Phong()
        {
            db = Entities.CreateEntities();
        }
        public List<tb_Phong> getAll()
        {
            return db.tb_Phong.ToList();
        }

        public void UpdateStatus (int _idPhong, bool t)
        {
            tb_Phong phong = db.tb_Phong.FirstOrDefault(x => x.IDPHONG == _idPhong);
            if (phong != null)
            {
                phong.TRANGTHAI = t;
                db.SaveChanges();
            }
        }

        public List<tb_Phong> getByTang(int id_tang)
        {
            return db.tb_Phong.Where(x => x.IDTANG == id_tang).ToList();
        }
    }
}
