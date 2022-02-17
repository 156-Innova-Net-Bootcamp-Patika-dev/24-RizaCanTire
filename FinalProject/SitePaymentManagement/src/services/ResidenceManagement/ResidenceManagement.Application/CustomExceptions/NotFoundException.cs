using MediatR;
using ResidenceManagement.Domain.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResidenceManagement.Application.CustomExceptions
{
    public class NotFoundException : ApplicationException
    {
        public NotFoundException(object entity, object key)
            : base($"Entity \"{entity}\" ({key}) was not found.")
        {
        }
    }
}
