using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StartUpProject.Models
{
    public class City
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public Guid RegionId { get; set; }
    }
}
