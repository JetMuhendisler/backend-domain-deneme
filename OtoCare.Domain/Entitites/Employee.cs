using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoCare.Domain.Entitites
{
    public class Employee
    {
        public int Id { get; set; }
        public string Phone { get; set; }
        public DateTime HireDate { get; set; }
        public decimal Salary { get; set; }

        // Bir personelin bir kullanıcı hesabı olmalı
        public int UserId { get; set; }
        public User User { get; set; }

        // Bir personel birden fazla işlemde çalışabilir
        public ICollection<OperationEmployee> OperationEmployees { get; set; } = new List<OperationEmployee>();
    }
}
