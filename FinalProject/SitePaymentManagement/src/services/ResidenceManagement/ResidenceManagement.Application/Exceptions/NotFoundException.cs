using System;

namespace ResidenceManagement.Application.Exceptions
{
    public class NotFoundException : ApplicationException
    {
        public NotFoundException(string name, object key)
            : base($"Entity \"{name}\" ({key.GetType().Name}) was not found.")
        {

        }
        public NotFoundException(object key)
            : base($"Entity \"{key.GetType().Name.ToString()}\"  was not found.")
        {
        }
    }
}
