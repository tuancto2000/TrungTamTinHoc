using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Hocphan
    {
        public string IdHocphan { get; set; }
        public string Ten { get; set; }
        public Hocphan(string idHocphan, string ten)
        {
            IdHocphan = idHocphan;
            Ten = ten;
        }

      
    }

}

