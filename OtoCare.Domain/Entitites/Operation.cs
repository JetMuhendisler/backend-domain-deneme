using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace OtoCare.Domain.Entitites
{
    public class Operation
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public int VehicleId { get; set; }
        public Vehicle Vehicle { get; set; }
        public string Status { get; set; } // "pending", "progress", "completed"
        public DateTime AppointmentDate { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public decimal TotalAmount { get; set; }
        public string PaymentStatus { get; set; } // "paid", "pending"
        public string? Notes { get; set; }
        public bool AddedToAccounting { get; set; } // Muhasebeye eklendi mi?

        // Bu iş emrinde hangi hizmetler satıldı?
        public ICollection<OperationService> Services { get; set; } = new List<OperationService>();
        // Bu iş emrinde kimler çalıştı?
        public ICollection<OperationEmployee> OperationEmployees { get; set; } = new List<OperationEmployee>();
        // Bu iş emri muhasebeye eklendiyse, ilgili kayıt
        public ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();
    }
}
