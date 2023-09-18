using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Func
    {
        Entities db;
        public Func()
        {
            db = Entities.CreateEntities();
        }

        public List<tb_Func> getParents()
        {
            return db.tb_Func.Where(x => x.ISGROUP == true && x.MENU == true).OrderBy(s => s.SORT).ToList();
        }

        public List<tb_Func> getChilds(string parent)
        {
            return db.tb_Func.Where(x => x.ISGROUP == false && x.PARENT == parent).OrderBy(s => s.SORT).ToList();
        }
    }
}
