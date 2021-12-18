using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StartUpProject.Models
{
    public class TypeItem
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public Guid TypeId { get; set; }
    }
}
