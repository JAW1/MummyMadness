using Microsoft.AspNetCore.Authorization;
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
        private INTEX2Context context { get; set; }

        public HomeController(ILogger<HomeController> logger, INTEX2Context ctx)
        {
            _logger = logger;
            context = ctx;
        }
        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }
        [Authorize(Policy = "writepolicy")]
        [HttpGet]
        public IActionResult AddBurial()
        {
            return View();
        }

        [Authorize(Policy = "writepolicy")]
        [HttpPost]
        public IActionResult AddBurial(Official officialForm)
        {
            context.Officials.Add(officialForm);
            context.SaveChanges();

            return View("BurialSummaryAuth", new BurialSummaryAllViewModel
            {
                Burials = context.Officials
            });
        }

        [AllowAnonymous]
        [HttpGet]
        public IActionResult BurialSummaryAll(string? gender, int? yearEvac, int pageNum = 5)
        {
            int pageSize = 100;
            if (yearEvac is null)
            {
                return View(new BurialSummaryAllViewModel
                {

                    Burial = context.Officials
                    .Where(x => x.GenderGe == gender || gender == null)
                    //.FromSqlInterpolated($"Select * from Official where GenderGe == {gender}")
                    .OrderBy(m => m.GenderGe)
                    .Skip((pageNum - 1) * pageSize)
                    .Take(pageSize)
                    .ToList(),


                    PageNumberingInfo = new PageNumberingInfo
                    {
                        NumItemsPerPage = pageSize,
                        CurrentPage = pageNum,
                        TotalNumItems = (context.Officials.Count())
                    },
                    //GenderCategory = sex

                });
            }

            else
            {
                return View(new BurialSummaryAllViewModel
                {

                    Burial = context.Officials
                   .Where(x => x.YearExcav == yearEvac || yearEvac == null)
                   //.FromSqlInterpolated($"Select * from Official where GenderGe == {gender}")
                   .OrderBy(m => m.YearExcav)
                   .Skip((pageNum - 1) * pageSize)
                   .Take(pageSize)
                   .ToList(),


                    PageNumberingInfo = new PageNumberingInfo
                    {
                        NumItemsPerPage = pageSize,
                        CurrentPage = pageNum,
                        TotalNumItems = (context.Officials.Count())
                    },
                    //GenderCategory = sex
                });
            }
        }
        [AllowAnonymous]
        [HttpPost]
        public IActionResult BurialSummaryAll(int Id)
        {

            return View(
                "BurialRecordAll", new BurialSummaryAllViewModel
                {
                    Burials = context.Officials.Where(x => x.Burialid == Id),

                }
                ); ;
        }

        [AllowAnonymous]
        [HttpGet]
        public IActionResult BurialRecordAll()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Gallery()
        {
            return View();
        }

        [Authorize(Policy = "writepolicy")]
        [HttpGet]
        public IActionResult BurialSummaryAuth(string? gender, int? yearEvac, int pageNum = 5)
        {
            int pageSize = 100;
            if (yearEvac is null)
            {
                return View(new BurialSummaryAllViewModel
                {

                    Burial = context.Officials
                    .Where(x => x.GenderGe == gender || gender == null)
                    //.FromSqlInterpolated($"Select * from Official where GenderGe == {gender}")
                    .OrderBy(m => m.GenderGe)
                    .Skip((pageNum - 1) * pageSize)
                    .Take(pageSize)
                    .ToList(),


                    PageNumberingInfo = new PageNumberingInfo
                    {
                        NumItemsPerPage = pageSize,
                        CurrentPage = pageNum,
                        TotalNumItems = (context.Officials.Count())
                    },
                    //GenderCategory = sex

                });
            }

            else
            {
                return View();

                new BurialSummaryAllViewModel
                {

                    Burial = context.Officials
               .Where(x => x.YearExcav == yearEvac || yearEvac == null)
               //.FromSqlInterpolated($"Select * from Official where GenderGe == {gender}")
               .OrderBy(m => m.YearExcav)
               .Skip((pageNum - 1) * pageSize)
               .Take(pageSize)
               .ToList(),


                    PageNumberingInfo = new PageNumberingInfo
                    {
                        NumItemsPerPage = pageSize,
                        CurrentPage = pageNum,
                        TotalNumItems = (context.Officials.Count())
                    },
                    //GenderCategory = sex
                };
            }
        }

        //This passes the itemId to be able to be edited in the Edit view
        [Authorize(Policy = "writepolicy")]
        [HttpPost]
        public IActionResult BurialSummaryAuth(int Id)
        {

            return View(

                "BurialRecordAll", new BurialSummaryAllViewModel
                {
                    Burials = context.Officials.Where(x => x.Burialid == Id),

                }
                ); ;
        }
        [Authorize(Policy = "writepolicy")]
        [HttpPost]
        public IActionResult BurialSummaryAuthEdit(int EditId)
        {
            return View(
                "EditBurial", new BurialSummaryAllViewModel
                {
                    Burials = context.Officials.Where(x => x.Burialid == EditId)
                }
                );
        }
        [Authorize(Policy = "writepolicy")]
        [HttpPost]
        public IActionResult EditBurial(Official officialForm, int editedBurial)
            
        {
            return View();
            var removeBurial = context.Officials.FirstOrDefault(x => x.Burialid == editedBurial);
            context.Officials.Add(officialForm);
            context.Officials.Remove(removeBurial);
            context.SaveChanges();

            return View("BurialSummaryAuth", new BurialSummaryAllViewModel
            {
                Burials = context.Officials
            });
        }
        [Authorize(Policy = "writepolicy")]
        [HttpGet]
        public IActionResult BurialRecordAuth()
        {
            return View();
        }
        [AllowAnonymous]
        [HttpGet]
        public IActionResult About()
        {
            return View();
        }
        [AllowAnonymous]
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

