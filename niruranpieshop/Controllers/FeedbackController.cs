using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using niruranpieshop.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace niruranpieshop.Controllers
{
    public class FeedbackController : Controller
    {

        private readonly IFeedbackRepository _feedbackrepository;

        public FeedbackController(IFeedbackRepository feedbackrepository)
        {
            _feedbackrepository = feedbackrepository;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Feedback feedback)
        {
            if (ModelState.IsValid)
            {
                _feedbackrepository.AddFeedback(feedback);
                return RedirectToAction("FeedbackComplete");
            }

            return View(feedback);
        }

        public IActionResult FeedbackComplete()
        {

           
            return View();
        }
    }
}
