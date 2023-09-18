using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class THIETBI
    {
        Entities db;
        public THIETBI()
        {
            db = Entities.CreateEntities();
        }

        public tb_ThietBi getOne(int id)
        {
            return db.tb_ThietBi.FirstOrDefault(x => x.IDTB == id);
        }

        public List<tb_ThietBi> getAll()
        {
            return db.tb_ThietBi.ToList();
        }
    }
}
