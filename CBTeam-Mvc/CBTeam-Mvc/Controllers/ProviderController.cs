using CBTeam_Mvc.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;
using System.Collections.Generic;
using System.Linq;

namespace CBTeam_Mvc.Controllers
{
    [Microsoft.AspNetCore.Mvc.Route("providers")]
    public class ProviderController : Controller
    {
        private List<ProviderModel> GetAllProviders()
        {
            return new List<ProviderModel>
            {
                new ProviderModel { Id = 1, ProviderName = "Piamontesa S.A", Locality = "Las Varillas" },
                new ProviderModel { Id = 2, ProviderName = "Paladinni S.A", Locality = "La Plata" },
                new ProviderModel { Id = 3, ProviderName = "La Casona S.R.L", Locality = "Buenos Aires" },
                new ProviderModel { Id = 4, ProviderName = "Las Moras S.A", Locality = "San Francisco" },
                new ProviderModel { Id = 5, ProviderName = "Friar S.R.L", Locality = "San Luis" }
            };
        }

        [HttpGet]
        [Route("")]
        public IActionResult GetProviderList()
        {
            var providers = GetAllProviders();
            return View("Index", providers);
        }

        [HttpGet]
        [Route("SearchByName")]
        public IActionResult SearchByName(string Nombre)
        {
            var providers = GetAllProviders();
            var filteredProviders = providers.Where(provider => provider.ProviderName.Contains(Nombre)).ToList();
            return PartialView("_ProviderList", filteredProviders);
        }
    }
}
