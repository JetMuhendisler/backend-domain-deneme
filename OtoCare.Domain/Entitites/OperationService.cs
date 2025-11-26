using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoCare.Domain.Entitites
{
    public class OperationService
    {
        public int Id { get; set; }
        public int OperationId { get; set; }
        public Operation Operation { get; set; }

        public int ServiceProductId { get; set; }
        public ServiceProduct ServiceProduct { get; set; }

        public int? ServiceOptionId { get; set; } // örn: 190 micron (opsiyonel)
        public ServiceOption? ServiceOption { get; set; }

        public decimal Price { get; set; } // Bu hizmetin bu iş emrindeki nihai fiyatı

        // Bu hizmet (örn: PPF) için hangi parçalar seçildi?
        public ICollection<OperationServicePart> SelectedParts { get; set; } = new List<OperationServicePart>();
    }
}
