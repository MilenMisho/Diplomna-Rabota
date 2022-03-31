using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlaneTicketsApp.Domain
{
    public class Brand
    {
        public int Id { get; set; }
        public string BrandName { get; set; }
        public virtual IEnumerable<Plane> Planes { get; set; }
    }
}
