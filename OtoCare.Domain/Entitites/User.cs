using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoCare.Domain.Entitites
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public string FullName { get; set; }
        public string? Email { get; set; }

        public int RoleId { get; set; }
        public Role Role { get; set; }

        // Her kullanıcının bir personel profili vardır
        public Employee EmployeeProfile { get; set; }
    }
}
