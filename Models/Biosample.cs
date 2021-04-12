using System;
using System.Collections.Generic;

#nullable disable

namespace MummyMadness.Models
{
    public partial class Biosample
    {
        public int Burialid { get; set; }
        public int? Rack { get; set; }
        public string Bag { get; set; }
        public int? Low1 { get; set; }
        public int? High1 { get; set; }
        public string NS { get; set; }
        public int? Low2 { get; set; }
        public int? High2 { get; set; }
        public string EW { get; set; }
        public string Area { get; set; }
        public string Burial { get; set; }
        public string Cluster { get; set; }
        public string Date { get; set; }
        public string PreviouslySampled { get; set; }
        public string Notes { get; set; }
        public string Initials { get; set; }
    }
}
