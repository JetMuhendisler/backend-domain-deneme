using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoCare.Domain.Entitites
{
    public class OperationEmployee
    {
        public int OperationId { get; set; }
        public Operation Operation { get; set; }

        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
    }
}
