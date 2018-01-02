using Microsoft.AspNetCore.Mvc;
using sitenames.Services;
using sitenames.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sitenames.Controllers
{
    public class HomeController : Controller
    {
        private ISiteRepository _siteRepo;
        public HomeController(ISiteRepository SiteRepository)
        {
            _siteRepo = SiteRepository;
        }
        public IActionResult Index()
        {
            var model = new HomePageViewModel();
            model.Sites = _siteRepo.GetSites();
            return View(model);
        }
        public IActionResult Site()
        {
            var model = new HomePageViewModel();
            model.Sites = _siteRepo.GetSites();
            return View(model);
        }
    }
}
