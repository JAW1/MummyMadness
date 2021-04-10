using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MummyMadness.Models.ViewModels
{
    public class BurialSummaryAllViewModel
    {
        public List<Official> Burial { get; set; }
        public IEnumerable<Official> Burials { get; set; }
        public PageNumberingInfo PageNumberingInfo { get; set; }
        //public Official Official { get; set; }

        public Official Officials { get; set; }
        public string GenderCategory { get; set; }

    }
}
