using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoCare.Domain.Entitites
{
    public class Transaction
    {
        public int Id { get; set; }
        public TransactionType Type { get; set; } // Gelir veya Gider
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public string Category { get; set; } // "Hizmet", "Malzeme", "Fatura"

        // Bir işlemi opsiyonel olarak bir iş emrine bağlayabiliriz
        public int? OperationId { get; set; }
        public Operation? Operation { get; set; }
    }
}
