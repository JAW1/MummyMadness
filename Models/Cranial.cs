using System;
using System.Collections.Generic;

#nullable disable

namespace MummyMadness.Models
{
    public partial class Cranial
    {
        public int Burialid { get; set; }
        public int? SampleNumber { get; set; }
        public string MaximumCranialLength { get; set; }
        public string MaximumCranialBreadth { get; set; }
        public string BasionBregmaHeight { get; set; }
        public string BasionNasion { get; set; }
        public string BasionProsthionLength { get; set; }
        public string BizygomaticDiameter { get; set; }
        public string NasionProsthion { get; set; }
        public string MaximumNasalBreadth { get; set; }
        public string InterorbitalBreadth { get; set; }
        public int? BurialPositioningNorthNumber { get; set; }
        public int? BurialPositioningSouthNumber { get; set; }
        public string BurialPositioningNorthsouthDirection { get; set; }
        public int? BurialPositioningEastNumber { get; set; }
        public int? BurialPositioningWestNumber { get; set; }
        public string BurialPositioningEastwestDirection { get; set; }
        public int? BurialNumber { get; set; }
        public string BurialDepth { get; set; }
        public string BurialSubplotDirection { get; set; }
        public string BurialArtifactDescription { get; set; }
        public string Buriedwithartifacts { get; set; }
        public string Gilesgender { get; set; }
        public string Bodygender { get; set; }
    }
}
