using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StartUpProject.Models
{
    public class Action
    {
        public Guid Id { get; set; }
        public Guid PatienId { get; set; }
        public Guid TypeItemId { get; set; }

        public string LastTreatedDate { get; set; }

        public string LastTreatedPlace { get; set; }

        public string VoucherGivenDate { get; set; }

        public string VoucherGivenOrg { get; set; }

        public int VoucherNumber { get; set; }

        public string TreatmentStartTime { get; set; }

        public string TreatmentFinishTime { get; set; }

        public string CreatedAt { get; set; }

        public string UpdatedAt { get; set; }
    }
}
