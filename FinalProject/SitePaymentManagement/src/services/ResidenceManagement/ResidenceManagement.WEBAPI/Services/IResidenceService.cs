using ResidenceManagement.WEBAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ResidenceManagement.WEBAPI.Services
{
    public interface IResidenceService
    {
        Task<ResidenceViewModel> GetResidenceById(int Id);
        Task<IReadOnlyList<ResidenceViewModel>> GetAll();

    }
}
