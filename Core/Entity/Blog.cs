using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entity
{
    public class Blog:BaseEntity
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
    }
}
