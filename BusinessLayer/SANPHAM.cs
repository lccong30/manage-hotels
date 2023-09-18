using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class SANPHAM
    {
        Entities db;
        public SANPHAM()
        {
            db = Entities.CreateEntities();
        }

        public tb_SanPham getOne(int id)
        {
            return db.tb_SanPham.FirstOrDefault(x => x.IDSP == id);
        }

        public List< tb_SanPham> getAll()
        {
            return db.tb_SanPham.ToList();
        }
    }
}
