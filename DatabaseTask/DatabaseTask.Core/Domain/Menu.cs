using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Menu
    {
        public Guid Id { get; set; }
        public string Comment { get; set; }
        public string Appetizer { get; set; }
        public string MainCourse { get; set; }
        public string Desert { get; set; }
        public DateTime Date { get; set; }
        public int Portions { get; set; }
        public IEnumerable<Group> Groups { get; set; } = new List<Group>();
    }
}
