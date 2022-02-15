using ResidenceManagement.Domain.Entities.Managements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResidenceManagement.Application.Models.UserResidences
{
    public class UserResidenceAddVm
    {
        public int UserId { get; set; }
      
        public int ResidenceId { get; set; }
      
        public ResidentType ResidentType { get; set; }
    }
}
