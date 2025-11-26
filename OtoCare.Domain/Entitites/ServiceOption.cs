using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoCare.Domain.Entitites
{
    public class ServiceOption
    {
        public int Id { get; set; }
        public int ServiceProductId { get; set; }
        public ServiceProduct Product { get; set; }
        public string Name { get; set; } // "190 Micron"
        public decimal PriceModifier { get; set; } // Baz fiyata ek ücret (veya 0)
    }
}
