using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StartUpProject.Models
{
    public class Patient
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Birthdate { get; set; }

        public string Passport { get; set; }

        public Guid CityId { get; set; }
    }
}
