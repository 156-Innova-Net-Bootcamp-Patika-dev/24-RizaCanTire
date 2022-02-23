using ResidenceManagement.WEBAPI.Extensions;
using ResidenceManagement.WEBAPI.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace ResidenceManagement.WEBAPI.Services
{
    public class ResidenceService : IResidenceService
    {
        private HttpClient _client;

        public ResidenceService(HttpClient client)
        {
            _client = client ?? throw new ArgumentNullException(nameof(client));

        }
        //https://localhost:44326/api/Residences
        public async Task<ResidenceViewModel> GetResidenceById(int Id)
        {
            var response = await _client.GetAsync($"/api/Residences/{Id}");
            return await response.ReadContentAs<ResidenceViewModel>();

        }
        public async Task<IReadOnlyList<ResidenceViewModel>> GetAll()
        {
            var response = await _client.GetAsync("/api/Residences");
            return await response.ReadContentAs<IReadOnlyList<ResidenceViewModel>>();
        }
       
    }
}
