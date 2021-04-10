using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MummyMadness.Models;
using MummyMadness.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MummyMadness.Controllers
{

    //I need to still add in authorization based on the policies (pretty easy)
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private OfficialContext context { get; set; }

        public HomeController(ILogger<HomeController> logger, OfficialContext ctx)
        {
            _logger = logger;
            context = ctx;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult BurialSummaryAll(string sex, int pageNum = 5)
        {
            int pageSize = 100;

            return View(new BurialSummaryAllViewModel
            {
                Burial = (context.Officials.OrderBy(m => m.BurialId).Skip((pageNum - 1) * pageSize).Take(pageSize).ToList()),
                PageNumberingInfo = new PageNumberingInfo
                {
                    NumItemsPerPage = pageSize,
                    CurrentPage = pageNum,
                    TotalNumItems = (context.Officials.Count())
                },
                GenderCategory = sex

            });
        }
        //This passes the itemId to be able to be edited in the Edit view
        
        [HttpPost]
        public IActionResult BurialSummaryAll(string Id)
        {

            return View("BurialRecordAll", new BurialSummaryAllViewModel
            {
                Burials = context.Officials.Where(x => x.Id == Id),

            }); ;
        }

        
        [HttpGet]
        public IActionResult BurialRecordAll()
        {
            return View();
        }
        
        [HttpGet]
        public IActionResult BurialSummaryAuth(string sex, int pageNum = 5)
        {
            int pageSize = 100;

            return View(new BurialSummaryAllViewModel
            {
                Burial = (context.Officials.OrderBy(m => m.BurialId).Skip((pageNum - 1) * pageSize).Take(pageSize).ToList()),
                PageNumberingInfo = new PageNumberingInfo
                {
                    NumItemsPerPage = pageSize,
                    CurrentPage = pageNum,
                    TotalNumItems = (context.Officials.Count())
                },
                GenderCategory = sex

            });
        }

        //This passes the itemId to be able to be edited in the Edit view
        
        [HttpPost]
        public IActionResult BurialSummaryAuth(string Id)
        {

            return View("BurialRecordAll", new BurialSummaryAllViewModel
            {
                Burials = context.Officials.Where(x => x.Id == Id),

            }); ;
        }
        
        [HttpGet]
        public IActionResult BurialRecordAuth()
        {
            return View();
        }

        [HttpGet]
        public IActionResult About()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
