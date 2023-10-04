   using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class WorkingHistory
    {
        public Guid Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Comment { get; set; }
        public List<Employee> Employees { get; set; } = new List<Employee>();
        public List<Profession> Professions { get; set; } = new List<Profession>();

    }
}
