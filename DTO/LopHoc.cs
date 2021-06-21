using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LopHoc
    { 

        public string IdLop { get; set ; }
        public string Ten { get; set; }
        public int NamHoc { get; set; }

        public LopHoc(string idLop, string ten, int namHoc)
        {
            IdLop = idLop;
            Ten = ten;
            NamHoc = namHoc;
        }
    }
}
