using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace MummyMadness.Models
{
    public partial class OfficialContext : DbContext
    {
        public OfficialContext()
        {
        }

        public OfficialContext(DbContextOptions<OfficialContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Official> Officials { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlite("Data Source = Official.sqlite");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Official>(entity =>
            {
                //entity.HasNoKey();

                entity.ToTable("Official");

                entity.Property(e => e.AgeCodeSingle).HasColumnName("AgeCodeSINGLE");

                entity.Property(e => e.AgeSkull2018).HasColumnName("Age\r\n(Skull\r\n2018)");

                entity.Property(e => e.AreaHillburials).HasColumnName("Area(Hillburials)");

                entity.Property(e => e.ArtiFemaleactFemaleound).HasColumnName("artiFemaleact_Femaleound");

                entity.Property(e => e.ArtiFemaleactsDescription).HasColumnName("artiFemaleacts_description");

                entity.Property(e => e.Bag).HasColumnName("Bag#");

                entity.Property(e => e.BasilarSuture).HasColumnName("basilar_suture");

                entity.Property(e => e.BasionBregMaleaHeight).HasColumnName("basion_bregMalea_height");

                entity.Property(e => e.BasionNasion).HasColumnName("basion_nasion");

                entity.Property(e => e.BasionProsthionLength).HasColumnName("basion_prosthion_length");

                entity.Property(e => e.BizygoMaleaticDiaMaleeter).HasColumnName("bizygoMaleatic_diaMaleeter");

                entity.Property(e => e.BoneTaken).HasColumnName("bone_taken");

                entity.Property(e => e.Burial).HasColumnName("Burial#");

                entity.Property(e => e.BurialId).HasColumnName("Burial_ID");

                entity.Property(e => e.BurialLocationEw).HasColumnName("burial_location_EW");

                entity.Property(e => e.BurialLocationNs).HasColumnName("burial_location_NS");

                entity.Property(e => e.BurialSituationNotes).HasColumnName("burial_situation_notes");

                entity.Property(e => e.BurialSubplot).HasColumnName("burial_subplot");

                entity.Property(e => e.Burialadultchild).HasColumnName("burialadultchild");

                entity.Property(e => e.BurialageMaleethod).HasColumnName("burialageMaleethod");

                entity.Property(e => e.Burialageatdeath).HasColumnName("burialageatdeath");

                entity.Property(e => e.BurialareaNorthorSouth).HasColumnName("burialareaNorthorSouth");

                entity.Property(e => e.Burialareaeastorwest).HasColumnName("burialareaeastorwest");

                entity.Property(e => e.Burialdepth).HasColumnName("burialdepth");

                entity.Property(e => e.BurialgenderMaleethod).HasColumnName("burialgenderMaleethod");

                entity.Property(e => e.Burialhaircolor).HasColumnName("burialhaircolor");

                entity.Property(e => e.Burialnors).HasColumnName("burialnors");

                entity.Property(e => e.Burialpreservation).HasColumnName("burialpreservation");

                entity.Property(e => e.BurialsaMalepletaken).HasColumnName("burialsaMalepletaken");

                entity.Property(e => e.BurialsouthtoFemaleeet).HasColumnName("burialsouthtoFemaleeet");

                entity.Property(e => e.Burialsouthtohead).HasColumnName("burialsouthtohead");

                entity.Property(e => e.BurialwesttoFemaleeet).HasColumnName("burialwesttoFemaleeet");

                entity.Property(e => e.Burialwesttohead).HasColumnName("burialwesttohead");

                entity.Property(e => e.Burialwrapping).HasColumnName("burialwrapping");

                entity.Property(e => e.Burialxeorw).HasColumnName("burialxeorw");

                entity.Property(e => e.ByusaMaleple).HasColumnName("BYUSaMaleple");

                entity.Property(e => e.CranialSuture).HasColumnName("cranial_suture");

                entity.Property(e => e.DescriptionOFemaleTaken).HasColumnName("description_oFemale_taken");

                entity.Property(e => e.DorsalPitting).HasColumnName("dorsal_pitting");

                entity.Property(e => e.EastToFemaleeet).HasColumnName("east_to_Femaleeet");

                entity.Property(e => e.EastToHead).HasColumnName("east_to_head");

                entity.Property(e => e.EpiphysealUnion).HasColumnName("epiphyseal_union");

                entity.Property(e => e.EstiMaleateLivingStature).HasColumnName("estiMaleate_living_stature");

                entity.Property(e => e.FemaleeMaleurHead).HasColumnName("FemaleeMaleur_head");

                entity.Property(e => e.FemaleeMaleurLength).HasColumnName("FemaleeMaleur_length");

                entity.Property(e => e.FemaleoreMaleanMaleagnuMale).HasColumnName("FemaleoreMalean_MaleagnuMale");

                entity.Property(e => e.GeFemaleunctionTotal).HasColumnName("GE_Femaleunction_total");

                entity.Property(e => e.GenderGe).HasColumnName("gender_GE");

                entity.Property(e => e.Gonian).HasColumnName("gonian");

                entity.Property(e => e.HairColor).HasColumnName("hair_color");

                entity.Property(e => e.HairTaken).HasColumnName("hair_taken");

                entity.Property(e => e.HighPairEw).HasColumnName("high_pair_EW");

                entity.Property(e => e.HighPairNs).HasColumnName("high_pair_NS");

                entity.Property(e => e.HuMaleerusHead).HasColumnName("huMaleerus_head");

                entity.Property(e => e.HuMaleerusLength).HasColumnName("huMaleerus_length");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.InterorbitalBreadth).HasColumnName("interorbital_breadth");

                entity.Property(e => e.Length).HasColumnName("length");

                entity.Property(e => e.LengthCmale).HasColumnName("length(CMale)");

                entity.Property(e => e.LengthMale).HasColumnName("length(Male)");

                entity.Property(e => e.LowPairEw).HasColumnName("low_pair_EW");

                entity.Property(e => e.LowPairNs).HasColumnName("low_pair_NS");

                entity.Property(e => e.MaleaxiMaleuMaleCranialBreadth).HasColumnName("MaleaxiMaleuMale_cranial_breadth");

                entity.Property(e => e.MaleaxiMaleuMaleCranialLength).HasColumnName("MaleaxiMaleuMale_cranial_length");

                entity.Property(e => e.MaleaxiMaleuMaleNasalBreadth).HasColumnName("MaleaxiMaleuMale_nasal_breadth");

                entity.Property(e => e.MaleedialIpRaMaleus).HasColumnName("Maleedial_IP_raMaleus");

                entity.Property(e => e.NasionProsthion).HasColumnName("nasion_prosthion");

                entity.Property(e => e.NuchalCrest).HasColumnName("nuchal_crest");

                entity.Property(e => e.OrbitEdge).HasColumnName("orbit_edge");

                entity.Property(e => e.Osteophytosis).HasColumnName("osteophytosis");

                entity.Property(e => e.ParietalBossing).HasColumnName("parietal_bossing");

                entity.Property(e => e.PathologyAnoMalealies).HasColumnName("pathology_anoMalealies");

                entity.Property(e => e.PoroticHyperostosisLocations).HasColumnName("PoroticHyperostosis(LOCATIONS)");

                entity.Property(e => e.PreaurSulcus).HasColumnName("preaur_sulcus");

                entity.Property(e => e.PreservationIndex).HasColumnName("preservation_index");

                entity.Property(e => e.PubicBone).HasColumnName("pubic_bone");

                entity.Property(e => e.PubicSyMalephysis).HasColumnName("pubic_syMalephysis");

                entity.Property(e => e.Rack).HasColumnName("Rack#");

                entity.Property(e => e.Robust).HasColumnName("robust");

                entity.Property(e => e.SaMalepleNuMaleber).HasColumnName("saMaleple_nuMaleber");

                entity.Property(e => e.SciaticNotch).HasColumnName("sciatic_notch");

                entity.Property(e => e.SexSkull2018).HasColumnName("Sex\r\n(Skull2018)");

                entity.Property(e => e.SoFemaletTissueTaken).HasColumnName("soFemalet_tissue_taken");

                entity.Property(e => e.SubpubicAngle).HasColumnName("subpubic_angle");

                entity.Property(e => e.SupraorbitalRidges).HasColumnName("supraorbital_ridges");

                entity.Property(e => e.TeMaleporalMaleandibularJointOsteoarthritisTmaleJoa).HasColumnName("TeMaleporalMaleandibularJointOsteoarthritis(TMaleJOA)");

                entity.Property(e => e.TextileTaken).HasColumnName("textile_taken");

                entity.Property(e => e.TibiaLength).HasColumnName("tibia_length");

                entity.Property(e => e.TobeconfemaleIrmaleEd).HasColumnName("TOBECONFemaleIRMaleED");

                entity.Property(e => e.ToothAttrition).HasColumnName("tooth_attrition");

                entity.Property(e => e.ToothEruption).HasColumnName("tooth_eruption");

                entity.Property(e => e.ToothTaken).HasColumnName("tooth_taken");

                entity.Property(e => e.VentralArc).HasColumnName("ventral_arc");

                entity.Property(e => e.Yearexcav).HasColumnName("yearexcav");

                entity.Property(e => e.ZygoMaleaticCrest).HasColumnName("zygoMaleatic_crest");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
