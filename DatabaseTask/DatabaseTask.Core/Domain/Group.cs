using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Group
    {
        public Guid Id { get; set; }
        public bool Nursery { get; set; }
        public string Name { get; set; }
        public DateTime Vintage { get; set; }
        public List<Child>? Childs { get; set;}

    }
}
