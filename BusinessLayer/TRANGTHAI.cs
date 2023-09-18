using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class TRANGTHAI
    {
        public bool _val { get; set; }
        public string _dis { get; set; }

        public TRANGTHAI() { }

        public TRANGTHAI(bool val, string dis)
        {
            this._val = val;
            this._dis = dis;
        }

        public static List<TRANGTHAI> getList() 
        {
            List<TRANGTHAI> lst = new List<TRANGTHAI>();

            TRANGTHAI[] collection = new TRANGTHAI[2]
            {
                new TRANGTHAI(true, "Đã hoàn tất"),
                new TRANGTHAI(false, "Chưa hoàn tất")
            };
            lst.AddRange(collection);

            return lst ;
        }
    }
}
