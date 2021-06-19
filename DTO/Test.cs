using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Test
    {
        private string id;
        private float point;

        public Test(string id, float point)
        {
            this.id = id;
            this.point = point;
        }

        public string Id { get => id; set => id = value; }
        public float Point { get => point; set => point = value; }
    }

}
