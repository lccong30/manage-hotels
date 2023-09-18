using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class OBJ_DATPHONG
    {
        public int IDDP { get; set; }
        public int IDKH { get; set; }
        public string HOTEN { get; set; }
        public string TENPHONG { get; set; }
        public DateTime? NGAYDAT { get; set; }
        public DateTime? NGAYTRA { get; set; }
        public double? SOTIEN { get; set; }
        public int? SONGUOI { get; set; }
        public int? IDUSER { get; set; }
        public string MACTY { get; set; }
        public string MADVI { get; set; }  
        public bool? STATUS { get; set; }
        public bool? THEODOAN { get; set; }
        public bool? DISABLED { get; set; }
        public string NOTE { get; set; }
    }
}
