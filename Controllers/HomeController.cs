using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        [AllowAnonymous]
        public IActionResult ChangesConfirmed()
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
        public IActionResult AddBurial(Official m)
        {
            var rand = new Random();
            m.Burialid = rand.Next();
            context.Officials.Add(m);
            context.SaveChanges();
            return View("ChangesConfirmed");
        }

        [Authorize(Policy = "writepolicy")]
        [HttpPost]
        public IActionResult DeleteBurial(int DeleteId)
        {
            var removeItem = context.Officials.FirstOrDefault(x => x.Burialid == DeleteId);
            context.Officials.Remove(removeItem);
            context.SaveChanges();
            return View("ChangesConfirmed");
        }

        [AllowAnonymous]
        [HttpGet]

        public IActionResult BurialSummaryAll(string? gender, string? yearEvac, int pageNum = 1)

        {
            string category;
            if (gender != null)
            {
                category = gender;
            }
            else if (yearEvac != null)
            {
                category = yearEvac;
            }
            else
            {
                category = null;
            }

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
                    //    TotalNumItems = (gender == null ? context.Officials.Count() :
                    //context.Officials.Where(x => x.GenderGe == gender).Count())
                        
                        TotalNumItems = gender == null ? context.Officials.Count() : 
                            context.Officials.Where(x => x.GenderGe == gender).Count()
                    },
                    //GenderCategory = sex

                });;
            }

            else
            {
                return View(new BurialSummaryAllViewModel
                {

                    Burial = context.Officials
                   .Where(x => x.YearExcav == yearEvac || yearEvac == null)
                   //.FromSqlInterpolated($"Select * from Official where YearExcav == {yearEvac}")
                   .OrderBy(m => m.YearExcav)
                   .Skip((pageNum - 1) * pageSize)
                   .Take(pageSize)
                   .ToList(),


                    PageNumberingInfo = new PageNumberingInfo
                    {
                        NumItemsPerPage = pageSize,
                        CurrentPage = pageNum,
                        //TotalNumItems = (context.Officials.Count())
                        TotalNumItems = yearEvac == null ? context.Officials.Count() :
                            context.Officials.Where(x => x.YearExcav == yearEvac).Count()
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

        

        public IActionResult BurialSummaryAuth(string? gender, string? yearEvac, int pageNum = 1)

        {
            int pageSize = 100;
            if (yearEvac is null)
            {
                return View(new BurialSummaryAllViewModel
                {

                    Burials = context.Officials
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
                        //TotalNumItems = (context.Officials.Count())
                        TotalNumItems = gender == null ? context.Officials.Count() :
                            context.Officials.Where(x => x.GenderGe == gender).Count()
                    },
                    //GenderCategory = sex

                });
            }

            else
            {
                return View(new BurialSummaryAllViewModel

                
                {

                    Burials = context.Officials
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
                        TotalNumItems = yearEvac == null ? context.Officials.Count() :
                            context.Officials.Where(x => x.YearExcav == yearEvac).Count()
                    },
                    //GenderCategory = sex
                });
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
                ) ;
        }
        //[Authorize(Policy = "writepolicy")]
        [HttpPost]
        public IActionResult EditBurial(Official official, int editedBurial)
            
        {
            int pageSize = 100;
            int pageNum = 1;
            var removeBurial = context.Officials.FirstOrDefault(x => x.Burialid == editedBurial);
            official.Burialid = removeBurial.Burialid;
            //var addBurial = context.Officials.FirstOrDefault(x => x.Burialid == official.Burialid);
            
            context.Officials.Remove(removeBurial);
            context.Officials.Add(official);

            context.SaveChanges();



            return View("BurialRecordAuth",


            new BurialSummaryAllViewModel
            {


                Burials = context.Officials

                //.FromSqlInterpolated($"Select * from Official where GenderGe == {gender}")
                .Where(x => x.Burialid == removeBurial.Burialid)
                .OrderBy(m => m.GenderGe)
                .Skip((pageNum - 1) * pageSize)
                .Take(pageSize)
                .ToList(),


                PageNumberingInfo = new PageNumberingInfo
                {
                    NumItemsPerPage = pageSize,
                    CurrentPage = pageNum,
                    //    TotalNumItems = (gender == null ? context.Officials.Count() :
                    //context.Officials.Where(x => x.GenderGe == gender).Count())
                    TotalNumItems = (context.Officials.Count())
                },
            }) ;

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

