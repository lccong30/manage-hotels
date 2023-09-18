using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class USER
    {
        Entities db;
        public USER()
        {
            db = Entities.CreateEntities();
        }

        public tb_Users getOne(int id)
        {
            return db.tb_Users.FirstOrDefault(x => x.UID == id);
        }

        public List<tb_Users> getAll()
        {
            return db.tb_Users.ToList();
        }
    }
}
