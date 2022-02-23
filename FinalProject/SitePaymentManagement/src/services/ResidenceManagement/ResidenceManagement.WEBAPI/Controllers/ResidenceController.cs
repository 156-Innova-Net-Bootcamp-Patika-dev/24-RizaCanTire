using Microsoft.AspNetCore.Mvc;
using ResidenceManagement.WEBAPI.Models;
using ResidenceManagement.WEBAPI.Services;
using System.Threading.Tasks;

namespace ResidenceManagement.WEBAPI.Controllers
{
    public class ResidenceController : Controller
    {
        private IResidenceService _residenceService;

        public ResidenceController(IResidenceService residenceService)
        {
            _residenceService = residenceService;
        }

        public async Task<IActionResult> Index()
        {
            var list = await _residenceService.GetAll();
            var str = "";
            str = list.ToString();
            return View(list);
        }
    }
}
