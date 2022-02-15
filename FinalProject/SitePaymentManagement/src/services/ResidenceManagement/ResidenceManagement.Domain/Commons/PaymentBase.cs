﻿using ResidenceManagement.Domain.Entities.Managements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResidenceManagement.Domain.Commons
{
    public class PaymentBase : EntityBase
    {
        public int UserResidenceId { get; set; }
        public UserResidence UserResidence { get; set; }
        public int Fee { get; set; }
        public bool IsPaid { get; set; }
        public DateTime Period { get; set; }

    }
}