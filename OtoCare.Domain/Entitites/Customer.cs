using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoCare.Domain.Entitites
{
    public class Customer
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }

        // Bir müşterinin birden fazla aracı olabilir
        public ICollection<Vehicle> Vehicles { get; set; } = new List<Vehicle>();
        // Bir müşterinin birden fazla işlemi olabilir
        public ICollection<Operation> Operations { get; set; } = new List<Operation>();
    }
}
