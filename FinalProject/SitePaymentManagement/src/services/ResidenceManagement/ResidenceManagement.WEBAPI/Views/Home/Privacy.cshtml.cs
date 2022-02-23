using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using ResidenceManagement.WEBAPI.Models;
using ResidenceManagement.WEBAPI.Services;
using System.Collections.Generic;

namespace ResidenceManagement.WEBAPI.Views.Home
{
    public class PrivacyModel : PageModel
    {
        private readonly IResidenceService _residenceService;
        private readonly ILogger<PrivacyModel> _logger;

        public PrivacyModel(IResidenceService residenceService, ILogger<PrivacyModel> logger)
        {
            _residenceService = residenceService;
            _logger = logger;
        }

        public IReadOnlyList<ResidenceViewModel> ResidenceViewModel { get; set; }

        public void OnGet()
        {
            ResidenceViewModel = _residenceService.GetAll().Result;
        }


    }

}
