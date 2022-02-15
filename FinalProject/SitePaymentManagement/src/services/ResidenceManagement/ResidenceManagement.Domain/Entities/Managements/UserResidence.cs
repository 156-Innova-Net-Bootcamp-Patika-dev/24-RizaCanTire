﻿using ResidenceManagement.Domain.Commons;
using ResidenceManagement.Domain.Entities.Auths;
using ResidenceManagement.Domain.Enums;

namespace ResidenceManagement.Domain.Entities.Managements
{
    public class UserResidence : EntityBase
    {
        public int UserId { get; set; }
        public User User { get; set; }
        public int ResidenceId { get; set; }
        public Residence Residence { get; set; }
        public ResidentType ResidentType { get; set; }

    }
}