using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class LOAIPHONG
    {
        Entities db;

        public LOAIPHONG()
        {
            db = Entities.CreateEntities();
        }

        public tb_LoaiPhong getOne(int id)
        {
            return db.tb_LoaiPhong.FirstOrDefault(x => x.IDLOAIPHONG == id);
        }

        public List<tb_LoaiPhong> getAll()
        {
            return db.tb_LoaiPhong.ToList();
        }
    }
}
