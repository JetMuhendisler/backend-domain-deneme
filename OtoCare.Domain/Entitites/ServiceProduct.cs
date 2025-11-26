using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoCare.Domain.Entitites
{
    public class ServiceProduct
    {
        public int Id { get; set; }
        public string Name { get; set; } // "OLEX Carat Series"
        public string Description { get; set; }
        public decimal BasePrice { get; set; } // Tam araç baz fiyatı
        public string? Duration { get; set; } // "3 Yıl" (Seramik için)

        public int ServiceCategoryId { get; set; }
        public ServiceCategory Category { get; set; }

        // Bu ürüne ait kalınlık vb. seçenekler
        public ICollection<ServiceOption> Options { get; set; } = new List<ServiceOption>();
        // Bu ürüne ait parça fiyatları
        public ICollection<ProductPartPrice> PartPrices { get; set; } = new List<ProductPartPrice>();
    }
}
