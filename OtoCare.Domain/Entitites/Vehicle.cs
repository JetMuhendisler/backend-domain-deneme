using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoCare.Domain.Entitites
{
    public class Vehicle
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public string Plate { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int? Year { get; set; }
        public string? Color { get; set; }
        public DateTime EntryDate { get; set; } //

        // Bir aracın birden fazla işlemi olabilir
        public ICollection<Operation> Operations { get; set; } = new List<Operation>();
    }
}
