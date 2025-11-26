using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoCare.Domain.Entitites
{
    public class ProductPartPrice
    {
        public int Id { get; set; }

        public int ServiceProductId { get; set; }
        public ServiceProduct ServiceProduct { get; set; }

        public int VehiclePartId { get; set; }
        public VehiclePart VehiclePart { get; set; }

        public decimal Price { get; set; } // örn: OLEX Carat için Kaput = 3000 TL
    }
}
