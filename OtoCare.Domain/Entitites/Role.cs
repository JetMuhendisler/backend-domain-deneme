using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoCare.Domain.Entitites
{
    public class Role
    {
        public int Id { get; set; }
        public string Name { get; set; } // "Admin", "PPF Uzmanı"
        public ICollection<User> Users { get; set; } = new List<User>();
    }
}
