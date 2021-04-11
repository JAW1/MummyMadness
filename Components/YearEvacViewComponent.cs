using Microsoft.AspNetCore.Mvc;
using MummyMadness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MummyMadness.Components
{
    public class YearEvacViewComponent : ViewComponent
    {
        private INTEX2Context context;



        public YearEvacViewComponent(INTEX2Context ctx)
        {
            context = ctx;
        }

        public IViewComponentResult Invoke()
        {
            //var uniqueYears = context.Officials.Select(x => x.Yearexcav).Distinct().OrderByDescending(x => x);

            return View(/*uniqueYears*/);
        }
    }
}
