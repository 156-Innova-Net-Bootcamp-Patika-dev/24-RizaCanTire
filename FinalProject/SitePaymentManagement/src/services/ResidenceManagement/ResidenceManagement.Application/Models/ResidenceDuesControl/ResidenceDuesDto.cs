using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResidenceManagement.Application.Models.ResidenceDuesControl
{
    public class ResidenceDuesDto
    {
        public int InvoiceId { get; set; }
        public int UserResidenceId { get; set; }

        public bool IsPaid { get; set; }

        public string ResidentType { get; set; }
    }
}
