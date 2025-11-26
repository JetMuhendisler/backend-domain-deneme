using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoCare.Domain.Entitites
{
    // Bir İş Emri Hizmeti (OperationService) ile Araç Parçası (VehiclePart) ilişkisi
    public class OperationServicePart
    {
        public int Id { get; set; }

        public int OperationServiceId { get; set; }
        public OperationService OperationService { get; set; }

        public int VehiclePartId { get; set; }
        public VehiclePart VehiclePart { get; set; }

        public decimal Price { get; set; } // Parçanın o anki fiyatı
    }
}
