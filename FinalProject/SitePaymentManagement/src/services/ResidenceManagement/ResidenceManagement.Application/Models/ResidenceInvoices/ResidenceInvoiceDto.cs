using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResidenceManagement.Application.Models.ResidenceInvoices
{
    public class ResidenceInvoiceDto
    {
        public int Id { get; set; }
        public int InvoiceId { get; set; }
        public int UserResidenceId { get; set; }
        public bool IsPaid { get; set; }
        public string ResidentTypeType { get; set; }
    }
}
