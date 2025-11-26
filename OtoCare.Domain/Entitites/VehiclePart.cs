using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoCare.Domain.Entitites
{
    // "Kaput", "Çatı", "Sol Ön Kapı" gibi araç parçalarının ana tanımı
    public class VehiclePart
    {
        public int Id { get; set; }
        public string Name { get; set; } // örn: "Kaput"
        public string PartCode { get; set; } // örn: "hood" (frontend'deki ID'ye karşılık)

        // Bu parçanın hangi hizmetlerde ne kadar fiyatı olduğunu tutar
        public ICollection<ProductPartPrice> ProductPartPrices { get; set; } = new List<ProductPartPrice>();
    }
}
