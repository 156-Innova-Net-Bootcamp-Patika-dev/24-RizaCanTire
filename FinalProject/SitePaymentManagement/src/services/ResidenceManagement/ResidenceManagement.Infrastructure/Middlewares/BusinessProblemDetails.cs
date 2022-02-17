using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ResidenceManagement.Infrastructure.Middlewares
{
    public class BusinessProblemDetails : ProblemDetails
    {
        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
