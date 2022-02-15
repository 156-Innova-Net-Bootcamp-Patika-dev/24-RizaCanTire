using ResidenceManagement.Domain.Entities.Auths;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResidenceManagement.Domain.Entities.Managements
{
    public class Message
    {
        public User Sender { get; set; }
        public User Receiver { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
    }
}
