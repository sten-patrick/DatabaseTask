using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Hint
    {
        public Guid Id { get; set; }
        public string Comment { get; set; }
        public IEnumerable<Child> Childs { get; set; } = new List<Child>();
    }
}
