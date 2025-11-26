using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoCare.Domain.Entitites
{
    public class ServiceCategory
    {
        public int Id { get; set; }
        public string Name { get; set; } // "PPF", "Cam Filmi", "Seramik Kaplama"
        public ICollection<ServiceProduct> Products { get; set; } = new List<ServiceProduct>();
    }
}
