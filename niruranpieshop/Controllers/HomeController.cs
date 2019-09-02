using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using niruranpieshop.Models;
using niruranpieshop.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace niruranpieshop.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/

        private readonly IPieRepository _pieRepository;

        public HomeController(IPieRepository pieRepository)
        {

            _pieRepository = pieRepository;
        }

        public IActionResult Index()
        {

            //ViewResult. = "Pie Overview";
            var pies = _pieRepository.GetAllPies().OrderBy(p => p.Name);
            var homeViewModel = new HomeViewModel()
            {
                Title = "Welcome to Niru Rana Cake Shop",


                Pies = pies.ToList()



            };

            return View(homeViewModel);
        }

        public IActionResult Details(int Id)
        {
            var pie = _pieRepository.GetPieByID(Id);
            if (pie == null) return NotFound();

            return View(pie);
        }

    }
}
