using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace MummyMadness.Models
{
    public partial class INTEX2Context : DbContext
    {
        public INTEX2Context()
        {
        }

        public INTEX2Context(DbContextOptions<INTEX2Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Official> Officials { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)//!
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseNpgsql("Host=mummygummy.cuy6cls8yekj.us-east-1.rds.amazonaws.com;Port=5432;Username=postgres;Password=MummyIntexRox!312;database=INTEX2");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "en_US.UTF-8");

            modelBuilder.Entity<Official>(entity =>
            {
                entity.HasKey(e => e.Burialid)
                    .HasName("official_pkey");

                entity.ToTable("official");

                entity.Property(e => e.Burialid)
                    .ValueGeneratedNever()
                    .HasColumnName("burialid");

                entity.Property(e => e.AgeCodeSingle)
                    .HasColumnType("character varying")
                    .HasColumnName("age_code_single");

                entity.Property(e => e.Area)
                    .HasColumnType("character varying")
                    .HasColumnName("area");

                entity.Property(e => e.ArtifemaleactFemaleound)
                    .HasColumnType("character varying")
                    .HasColumnName("artifemaleact_femaleound");

                entity.Property(e => e.ArtifemaleactsDescription)
                    .HasColumnType("character varying")
                    .HasColumnName("artifemaleacts_description");

                entity.Property(e => e.Bag)
                    .HasColumnType("character varying")
                    .HasColumnName("bag");

                entity.Property(e => e.BasilarSuture)
                    .HasColumnType("character varying")
                    .HasColumnName("basilar_suture");

                entity.Property(e => e.BasionBregmaleaHeight)
                    .HasColumnType("character varying")
                    .HasColumnName("basion_bregmalea_height");

                entity.Property(e => e.BasionNasion)
                    .HasColumnType("character varying")
                    .HasColumnName("basion_nasion");

                entity.Property(e => e.BasionProsthionLength)
                    .HasColumnType("character varying")
                    .HasColumnName("basion_prosthion_length");

                entity.Property(e => e.BiologicalCluster)
                    .HasColumnType("character varying")
                    .HasColumnName("biological_cluster");

                entity.Property(e => e.BizygomaleaticDiamaleeter)
                    .HasColumnType("character varying")
                    .HasColumnName("bizygomaleatic_diamaleeter");

                entity.Property(e => e.BodyAnalysis)
                    .HasColumnType("character varying")
                    .HasColumnName("body_analysis");

                entity.Property(e => e.BoneTaken)
                    .HasColumnType("character varying")
                    .HasColumnName("bone_taken");

                entity.Property(e => e.Burial)
                    .HasColumnType("character varying")
                    .HasColumnName("burial");

                entity.Property(e => e.BurialAdultChild)
                    .HasColumnType("character varying")
                    .HasColumnName("burial_adult_child");

                entity.Property(e => e.BurialAreaEastorwest)
                    .HasColumnType("character varying")
                    .HasColumnName("burial_area_eastorwest");

                entity.Property(e => e.BurialAreaNorthorsouth)
                    .HasColumnType("character varying")
                    .HasColumnName("burial_area_northorsouth");

                entity.Property(e => e.BurialDepth)
                    .HasColumnType("character varying")
                    .HasColumnName("burial_depth");

                entity.Property(e => e.BurialDirection)
                    .HasColumnType("character varying")
                    .HasColumnName("burial_direction");

                entity.Property(e => e.BurialId1)
                    .HasColumnType("character varying")
                    .HasColumnName("burial_id");

                entity.Property(e => e.BurialLocationEw)
                    .HasColumnType("character varying")
                    .HasColumnName("burial_location_ew");

                entity.Property(e => e.BurialLocationNs)
                    .HasColumnType("character varying")
                    .HasColumnName("burial_location_ns");

                entity.Property(e => e.BurialNumaleber)
                    .HasColumnType("character varying")
                    .HasColumnName("burial_numaleber");

                entity.Property(e => e.BurialPreservation)
                    .HasColumnType("character varying")
                    .HasColumnName("burial_preservation");

                entity.Property(e => e.BurialSituationNotes)
                    .HasColumnType("character varying")
                    .HasColumnName("burial_situation_notes");

                entity.Property(e => e.BurialSouthtofemaleeet)
                    .HasColumnType("character varying")
                    .HasColumnName("burial_southtofemaleeet");

                entity.Property(e => e.BurialSouthtohead)
                    .HasColumnType("character varying")
                    .HasColumnName("burial_southtohead");

                entity.Property(e => e.BurialSubplot)
                    .HasColumnType("character varying")
                    .HasColumnName("burial_subplot");

                entity.Property(e => e.BurialWesttofemaleeet)
                    .HasColumnType("character varying")
                    .HasColumnName("burial_westtofemaleeet");

                entity.Property(e => e.BurialWesttohead)
                    .HasColumnType("character varying")
                    .HasColumnName("burial_westtohead");

                entity.Property(e => e.BurialWrapping)
                    .HasColumnType("character varying")
                    .HasColumnName("burial_wrapping");

                entity.Property(e => e.Burialageatdeath)
                    .HasColumnType("character varying")
                    .HasColumnName("burialageatdeath");

                entity.Property(e => e.Burialagemaleethod)
                    .HasColumnType("character varying")
                    .HasColumnName("burialagemaleethod");

                entity.Property(e => e.Burialgendermaleethod)
                    .HasColumnType("character varying")
                    .HasColumnName("burialgendermaleethod");

                entity.Property(e => e.Burialhaircolor)
                    .HasColumnType("character varying")
                    .HasColumnName("burialhaircolor");

                entity.Property(e => e.Burialnors)
                    .HasColumnType("character varying")
                    .HasColumnName("burialnors");

                entity.Property(e => e.Burialsamalepletaken)
                    .HasColumnType("character varying")
                    .HasColumnName("burialsamalepletaken");

                entity.Property(e => e.Burialxeorw)
                    .HasColumnType("character varying")
                    .HasColumnName("burialxeorw");

                entity.Property(e => e.ButtonOsteomalea)
                    .HasColumnType("character varying")
                    .HasColumnName("button_osteomalea");

                entity.Property(e => e.ByuSamaleple)
                    .HasColumnType("character varying")
                    .HasColumnName("byu_samaleple");

                entity.Property(e => e.Cluster)
                    .HasColumnType("character varying")
                    .HasColumnName("cluster");

                entity.Property(e => e.CranialSuture)
                    .HasColumnType("character varying")
                    .HasColumnName("cranial_suture");

                entity.Property(e => e.CribraOrbitala)
                    .HasColumnType("character varying")
                    .HasColumnName("cribra_orbitala");

                entity.Property(e => e.DateExcavated)
                    .HasColumnType("character varying")
                    .HasColumnName("date_excavated");

                entity.Property(e => e.DayOnSkull)
                    .HasColumnType("character varying")
                    .HasColumnName("day_on_skull");

                entity.Property(e => e.Description)
                    .HasColumnType("character varying")
                    .HasColumnName("description");

                entity.Property(e => e.DescriptionOfemaleTaken)
                    .HasColumnType("character varying")
                    .HasColumnName("description_ofemale_taken");

                entity.Property(e => e.DorsalPitting)
                    .HasColumnType("character varying")
                    .HasColumnName("dorsal_pitting");

                entity.Property(e => e.EastToFemaleeet)
                    .HasColumnType("character varying")
                    .HasColumnName("east_to_femaleeet");

                entity.Property(e => e.EastToHead)
                    .HasColumnType("character varying")
                    .HasColumnName("east_to_head");

                entity.Property(e => e.EstimaleateLivingStature)
                    .HasColumnType("character varying")
                    .HasColumnName("estimaleate_living_stature");

                entity.Property(e => e.FemaleaceBundle)
                    .HasColumnType("character varying")
                    .HasColumnName("femaleace_bundle");

                entity.Property(e => e.FemaleemaleurHead)
                    .HasColumnType("character varying")
                    .HasColumnName("femaleemaleur_head");

                entity.Property(e => e.FemaleemaleurLength)
                    .HasColumnType("character varying")
                    .HasColumnName("femaleemaleur_length");

                entity.Property(e => e.FemaleieldBook)
                    .HasColumnType("character varying")
                    .HasColumnName("femaleield_book");

                entity.Property(e => e.FemaleieldBookPageNumaleber)
                    .HasColumnType("character varying")
                    .HasColumnName("femaleield_book_page_numaleber");

                entity.Property(e => e.FemaleoremaleanMaleagnumale)
                    .HasColumnType("character varying")
                    .HasColumnName("femaleoremalean_maleagnumale");

                entity.Property(e => e.GeFemaleunctionTotal)
                    .HasColumnType("character varying")
                    .HasColumnName("ge_femaleunction_total");

                entity.Property(e => e.GenderCode)
                    .HasColumnType("character varying")
                    .HasColumnName("gender_code");

                entity.Property(e => e.GenderGe)
                    .HasColumnType("character varying")
                    .HasColumnName("gender_ge");

                entity.Property(e => e.Gonian)
                    .HasColumnType("character varying")
                    .HasColumnName("gonian");

                entity.Property(e => e.Goods)
                    .HasColumnType("character varying")
                    .HasColumnName("goods");

                entity.Property(e => e.HairColor)
                    .HasColumnType("character varying")
                    .HasColumnName("hair_color");

                entity.Property(e => e.HairColorCode)
                    .HasColumnType("character varying")
                    .HasColumnName("hair_color_code");

                entity.Property(e => e.HairTaken)
                    .HasColumnType("character varying")
                    .HasColumnName("hair_taken");

                entity.Property(e => e.HighPairEw)
                    .HasColumnType("character varying")
                    .HasColumnName("high_pair_ew");

                entity.Property(e => e.HighPairNs)
                    .HasColumnType("character varying")
                    .HasColumnName("high_pair_ns");

                entity.Property(e => e.HumaleerusHead)
                    .HasColumnType("character varying")
                    .HasColumnName("humaleerus_head");

                entity.Property(e => e.HumaleerusLength)
                    .HasColumnType("character varying")
                    .HasColumnName("humaleerus_length");

                entity.Property(e => e.InitialsOfemaleDataEntryChecker)
                    .HasColumnType("character varying")
                    .HasColumnName("initials_ofemale_data_entry_checker");

                entity.Property(e => e.InitialsOfemaleDataEntryExpert)
                    .HasColumnType("character varying")
                    .HasColumnName("initials_ofemale_data_entry_expert");

                entity.Property(e => e.InterorbitalBreadth)
                    .HasColumnType("character varying")
                    .HasColumnName("interorbital_breadth");

                entity.Property(e => e.Length)
                    .HasColumnType("character varying")
                    .HasColumnName("length");

                entity.Property(e => e.LengthMale)
                    .HasColumnType("character varying")
                    .HasColumnName("length_male");

                entity.Property(e => e.LinearHypoplasiaEnamaleel)
                    .HasColumnType("character varying")
                    .HasColumnName("linear_hypoplasia_enamaleel");

                entity.Property(e => e.LowPairEw)
                    .HasColumnType("character varying")
                    .HasColumnName("low_pair_ew");

                entity.Property(e => e.LowPairNs)
                    .HasColumnType("character varying")
                    .HasColumnName("low_pair_ns");

                entity.Property(e => e.MaleaximaleumaleCranialBreadth)
                    .HasColumnType("character varying")
                    .HasColumnName("maleaximaleumale_cranial_breadth");

                entity.Property(e => e.MaleaximaleumaleCranialLength)
                    .HasColumnType("character varying")
                    .HasColumnName("maleaximaleumale_cranial_length");

                entity.Property(e => e.MaleaximaleumaleNasalBreadth)
                    .HasColumnType("character varying")
                    .HasColumnName("maleaximaleumale_nasal_breadth");

                entity.Property(e => e.MaleedialIpRamaleus)
                    .HasColumnType("character varying")
                    .HasColumnName("maleedial_ip_ramaleus");

                entity.Property(e => e.MaleetopicSuture)
                    .HasColumnType("character varying")
                    .HasColumnName("maleetopic_suture");

                entity.Property(e => e.MaleonthExcavated)
                    .HasColumnType("character varying")
                    .HasColumnName("maleonth_excavated");

                entity.Property(e => e.MaleonthOnSkull)
                    .HasColumnType("character varying")
                    .HasColumnName("maleonth_on_skull");

                entity.Property(e => e.NasionProsthion)
                    .HasColumnType("character varying")
                    .HasColumnName("nasion_prosthion");

                entity.Property(e => e.NuchalCrest)
                    .HasColumnType("character varying")
                    .HasColumnName("nuchal_crest");

                entity.Property(e => e.OrbitEdge)
                    .HasColumnType("character varying")
                    .HasColumnName("orbit_edge");

                entity.Property(e => e.OsteologyNotes)
                    .HasColumnType("character varying")
                    .HasColumnName("osteology_notes");

                entity.Property(e => e.OsteologyUnknownComalemaleent)
                    .HasColumnType("character varying")
                    .HasColumnName("osteology_unknown_comalemaleent");

                entity.Property(e => e.Osteophytosis)
                    .HasColumnType("character varying")
                    .HasColumnName("osteophytosis");

                entity.Property(e => e.ParietalBossing)
                    .HasColumnType("character varying")
                    .HasColumnName("parietal_bossing");

                entity.Property(e => e.PathologyAnomalealies)
                    .HasColumnType("character varying")
                    .HasColumnName("pathology_anomalealies");

                entity.Property(e => e.PoroticHyperostosis)
                    .HasColumnType("character varying")
                    .HasColumnName("porotic_hyperostosis");

                entity.Property(e => e.PoroticHyperostosisLocations)
                    .HasColumnType("character varying")
                    .HasColumnName("porotic_hyperostosis_locations");

                entity.Property(e => e.PostcraniaAtMaleagazine)
                    .HasColumnType("character varying")
                    .HasColumnName("postcrania_at_maleagazine");

                entity.Property(e => e.PostcraniaTraumalea)
                    .HasColumnType("character varying")
                    .HasColumnName("postcrania_traumalea");

                entity.Property(e => e.PreaurSulcus)
                    .HasColumnType("character varying")
                    .HasColumnName("preaur_sulcus");

                entity.Property(e => e.PreservationIndex)
                    .HasColumnType("character varying")
                    .HasColumnName("preservation_index");

                entity.Property(e => e.PreviouslySamalepled)
                    .HasColumnType("character varying")
                    .HasColumnName("previously_samalepled");

                entity.Property(e => e.PubicBone)
                    .HasColumnType("character varying")
                    .HasColumnName("pubic_bone");

                entity.Property(e => e.PubicSymalephysis)
                    .HasColumnType("character varying")
                    .HasColumnName("pubic_symalephysis");

                entity.Property(e => e.Rack)
                    .HasColumnType("character varying")
                    .HasColumnName("rack");

                entity.Property(e => e.RackAndShelfemale)
                    .HasColumnType("character varying")
                    .HasColumnName("rack_and_shelfemale");

                entity.Property(e => e.Robust)
                    .HasColumnType("character varying")
                    .HasColumnName("robust");

                entity.Property(e => e.SamalepleNumaleber)
                    .HasColumnType("character varying")
                    .HasColumnName("samaleple_numaleber");

                entity.Property(e => e.SciaticNotch)
                    .HasColumnType("character varying")
                    .HasColumnName("sciatic_notch");

                entity.Property(e => e.SkullAtMaleagazine)
                    .HasColumnType("character varying")
                    .HasColumnName("skull_at_maleagazine");

                entity.Property(e => e.SkullTraumalea)
                    .HasColumnType("character varying")
                    .HasColumnName("skull_traumalea");

                entity.Property(e => e.SofemaletTissueTaken)
                    .HasColumnType("character varying")
                    .HasColumnName("sofemalet_tissue_taken");

                entity.Property(e => e.Square)
                    .HasColumnType("character varying")
                    .HasColumnName("square");

                entity.Property(e => e.SubpubicAngle)
                    .HasColumnType("character varying")
                    .HasColumnName("subpubic_angle");

                entity.Property(e => e.SupraorbitalRidges)
                    .HasColumnType("character varying")
                    .HasColumnName("supraorbital_ridges");

                entity.Property(e => e.TemaleporalMaleandibularJointOsteoarthritis)
                    .HasColumnType("character varying")
                    .HasColumnName("temaleporal_maleandibular_joint_osteoarthritis");

                entity.Property(e => e.TextileTaken)
                    .HasColumnType("character varying")
                    .HasColumnName("textile_taken");

                entity.Property(e => e.TibiaLength)
                    .HasColumnType("character varying")
                    .HasColumnName("tibia_length");

                entity.Property(e => e.ToBeConfemaleirmaleed)
                    .HasColumnType("character varying")
                    .HasColumnName("to_be_confemaleirmaleed");

                entity.Property(e => e.Tomaleb)
                    .HasColumnType("character varying")
                    .HasColumnName("tomaleb");

                entity.Property(e => e.ToothAttrition)
                    .HasColumnType("character varying")
                    .HasColumnName("tooth_attrition");

                entity.Property(e => e.ToothEruption)
                    .HasColumnType("character varying")
                    .HasColumnName("tooth_eruption");

                entity.Property(e => e.ToothTaken)
                    .HasColumnType("character varying")
                    .HasColumnName("tooth_taken");

                entity.Property(e => e.VentralArc)
                    .HasColumnType("character varying")
                    .HasColumnName("ventral_arc");

                entity.Property(e => e.YearExcav).HasColumnName("year_excav");

                entity.Property(e => e.YearOnSkull)
                    .HasColumnType("character varying")
                    .HasColumnName("year_on_skull");

                entity.Property(e => e.ZygomaleaticCrest)
                    .HasColumnType("character varying")
                    .HasColumnName("zygomaleatic_crest");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
