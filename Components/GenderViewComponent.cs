using Microsoft.AspNetCore.Mvc;
using MummyMadness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MummyMania.Components
{
    public class GenderViewComponent : ViewComponent
    {
        private INTEX2Context context;
        public GenderViewComponent(INTEX2Context ctx)
        {
            context = ctx;
        }
        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedGender = RouteData?.Values["Sex"];

            return View(context.Officials.Distinct().OrderBy(x => x));
        }
    }
}
