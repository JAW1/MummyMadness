// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MummyMadness.Models;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace MummyMadness.Migrations.INTEX2
{
    [DbContext(typeof(INTEX2Context))]
    [Migration("20210412175747_new")]
    partial class @new
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:Collation", "en_US.UTF-8")
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("MummyMadness.Models.Official", b =>
                {
                    b.Property<int>("Burialid")
                        .HasColumnType("integer")
                        .HasColumnName("burialid");

                    b.Property<string>("AgeCodeSingle")
                        .HasColumnType("character varying")
                        .HasColumnName("age_code_single");

                    b.Property<string>("Area")
                        .HasColumnType("character varying")
                        .HasColumnName("area");

                    b.Property<string>("ArtifemaleactFemaleound")
                        .HasColumnType("character varying")
                        .HasColumnName("artifemaleact_femaleound");

                    b.Property<string>("ArtifemaleactsDescription")
                        .HasColumnType("character varying")
                        .HasColumnName("artifemaleacts_description");

                    b.Property<string>("Bag")
                        .HasColumnType("character varying")
                        .HasColumnName("bag");

                    b.Property<string>("BasilarSuture")
                        .HasColumnType("character varying")
                        .HasColumnName("basilar_suture");

                    b.Property<string>("BasionBregmaleaHeight")
                        .HasColumnType("character varying")
                        .HasColumnName("basion_bregmalea_height");

                    b.Property<string>("BasionNasion")
                        .HasColumnType("character varying")
                        .HasColumnName("basion_nasion");

                    b.Property<string>("BasionProsthionLength")
                        .HasColumnType("character varying")
                        .HasColumnName("basion_prosthion_length");

                    b.Property<string>("BiologicalCluster")
                        .HasColumnType("character varying")
                        .HasColumnName("biological_cluster");

                    b.Property<string>("BizygomaleaticDiamaleeter")
                        .HasColumnType("character varying")
                        .HasColumnName("bizygomaleatic_diamaleeter");

                    b.Property<string>("BodyAnalysis")
                        .HasColumnType("character varying")
                        .HasColumnName("body_analysis");

                    b.Property<string>("BoneTaken")
                        .HasColumnType("character varying")
                        .HasColumnName("bone_taken");

                    b.Property<string>("Burial")
                        .HasColumnType("character varying")
                        .HasColumnName("burial");

                    b.Property<string>("BurialAdultChild")
                        .HasColumnType("character varying")
                        .HasColumnName("burial_adult_child");

                    b.Property<string>("BurialAreaEastorwest")
                        .HasColumnType("character varying")
                        .HasColumnName("burial_area_eastorwest");

                    b.Property<string>("BurialAreaNorthorsouth")
                        .HasColumnType("character varying")
                        .HasColumnName("burial_area_northorsouth");

                    b.Property<string>("BurialDepth")
                        .HasColumnType("character varying")
                        .HasColumnName("burial_depth");

                    b.Property<string>("BurialDirection")
                        .HasColumnType("character varying")
                        .HasColumnName("burial_direction");

                    b.Property<string>("BurialId1")
                        .HasColumnType("character varying")
                        .HasColumnName("burial_id");

                    b.Property<string>("BurialLocationEw")
                        .HasColumnType("character varying")
                        .HasColumnName("burial_location_ew");

                    b.Property<string>("BurialLocationNs")
                        .HasColumnType("character varying")
                        .HasColumnName("burial_location_ns");

                    b.Property<string>("BurialNumaleber")
                        .HasColumnType("character varying")
                        .HasColumnName("burial_numaleber");

                    b.Property<string>("BurialPreservation")
                        .HasColumnType("character varying")
                        .HasColumnName("burial_preservation");

                    b.Property<string>("BurialSituationNotes")
                        .HasColumnType("character varying")
                        .HasColumnName("burial_situation_notes");

                    b.Property<string>("BurialSouthtofemaleeet")
                        .HasColumnType("character varying")
                        .HasColumnName("burial_southtofemaleeet");

                    b.Property<string>("BurialSouthtohead")
                        .HasColumnType("character varying")
                        .HasColumnName("burial_southtohead");

                    b.Property<string>("BurialSubplot")
                        .HasColumnType("character varying")
                        .HasColumnName("burial_subplot");

                    b.Property<string>("BurialWesttofemaleeet")
                        .HasColumnType("character varying")
                        .HasColumnName("burial_westtofemaleeet");

                    b.Property<string>("BurialWesttohead")
                        .HasColumnType("character varying")
                        .HasColumnName("burial_westtohead");

                    b.Property<string>("BurialWrapping")
                        .HasColumnType("character varying")
                        .HasColumnName("burial_wrapping");

                    b.Property<string>("Burialageatdeath")
                        .HasColumnType("character varying")
                        .HasColumnName("burialageatdeath");

                    b.Property<string>("Burialagemaleethod")
                        .HasColumnType("character varying")
                        .HasColumnName("burialagemaleethod");

                    b.Property<string>("Burialgendermaleethod")
                        .HasColumnType("character varying")
                        .HasColumnName("burialgendermaleethod");

                    b.Property<string>("Burialhaircolor")
                        .HasColumnType("character varying")
                        .HasColumnName("burialhaircolor");

                    b.Property<string>("Burialnors")
                        .HasColumnType("character varying")
                        .HasColumnName("burialnors");

                    b.Property<string>("Burialsamalepletaken")
                        .HasColumnType("character varying")
                        .HasColumnName("burialsamalepletaken");

                    b.Property<string>("Burialxeorw")
                        .HasColumnType("character varying")
                        .HasColumnName("burialxeorw");

                    b.Property<string>("ButtonOsteomalea")
                        .HasColumnType("character varying")
                        .HasColumnName("button_osteomalea");

                    b.Property<string>("ByuSamaleple")
                        .HasColumnType("character varying")
                        .HasColumnName("byu_samaleple");

                    b.Property<string>("Cluster")
                        .HasColumnType("character varying")
                        .HasColumnName("cluster");

                    b.Property<string>("CranialSuture")
                        .HasColumnType("character varying")
                        .HasColumnName("cranial_suture");

                    b.Property<string>("CribraOrbitala")
                        .HasColumnType("character varying")
                        .HasColumnName("cribra_orbitala");

                    b.Property<string>("DateExcavated")
                        .HasColumnType("character varying")
                        .HasColumnName("date_excavated");

                    b.Property<string>("DayOnSkull")
                        .HasColumnType("character varying")
                        .HasColumnName("day_on_skull");

                    b.Property<string>("Description")
                        .HasColumnType("character varying")
                        .HasColumnName("description");

                    b.Property<string>("DescriptionOfemaleTaken")
                        .HasColumnType("character varying")
                        .HasColumnName("description_ofemale_taken");

                    b.Property<string>("DorsalPitting")
                        .HasColumnType("character varying")
                        .HasColumnName("dorsal_pitting");

                    b.Property<string>("EastToFemaleeet")
                        .HasColumnType("character varying")
                        .HasColumnName("east_to_femaleeet");

                    b.Property<string>("EastToHead")
                        .HasColumnType("character varying")
                        .HasColumnName("east_to_head");

                    b.Property<string>("EstimaleateLivingStature")
                        .HasColumnType("character varying")
                        .HasColumnName("estimaleate_living_stature");

                    b.Property<string>("FemaleaceBundle")
                        .HasColumnType("character varying")
                        .HasColumnName("femaleace_bundle");

                    b.Property<string>("FemaleemaleurHead")
                        .HasColumnType("character varying")
                        .HasColumnName("femaleemaleur_head");

                    b.Property<string>("FemaleemaleurLength")
                        .HasColumnType("character varying")
                        .HasColumnName("femaleemaleur_length");

                    b.Property<string>("FemaleieldBook")
                        .HasColumnType("character varying")
                        .HasColumnName("femaleield_book");

                    b.Property<string>("FemaleieldBookPageNumaleber")
                        .HasColumnType("character varying")
                        .HasColumnName("femaleield_book_page_numaleber");

                    b.Property<string>("FemaleoremaleanMaleagnumale")
                        .HasColumnType("character varying")
                        .HasColumnName("femaleoremalean_maleagnumale");

                    b.Property<string>("GeFemaleunctionTotal")
                        .HasColumnType("character varying")
                        .HasColumnName("ge_femaleunction_total");

                    b.Property<string>("GenderCode")
                        .HasColumnType("character varying")
                        .HasColumnName("gender_code");

                    b.Property<string>("GenderGe")
                        .HasColumnType("character varying")
                        .HasColumnName("gender_ge");

                    b.Property<string>("Gonian")
                        .HasColumnType("character varying")
                        .HasColumnName("gonian");

                    b.Property<string>("Goods")
                        .HasColumnType("character varying")
                        .HasColumnName("goods");

                    b.Property<string>("HairColor")
                        .HasColumnType("character varying")
                        .HasColumnName("hair_color");

                    b.Property<string>("HairColorCode")
                        .HasColumnType("character varying")
                        .HasColumnName("hair_color_code");

                    b.Property<string>("HairTaken")
                        .HasColumnType("character varying")
                        .HasColumnName("hair_taken");

                    b.Property<string>("HighPairEw")
                        .HasColumnType("character varying")
                        .HasColumnName("high_pair_ew");

                    b.Property<string>("HighPairNs")
                        .HasColumnType("character varying")
                        .HasColumnName("high_pair_ns");

                    b.Property<string>("HumaleerusHead")
                        .HasColumnType("character varying")
                        .HasColumnName("humaleerus_head");

                    b.Property<string>("HumaleerusLength")
                        .HasColumnType("character varying")
                        .HasColumnName("humaleerus_length");

                    b.Property<string>("InitialsOfemaleDataEntryChecker")
                        .HasColumnType("character varying")
                        .HasColumnName("initials_ofemale_data_entry_checker");

                    b.Property<string>("InitialsOfemaleDataEntryExpert")
                        .HasColumnType("character varying")
                        .HasColumnName("initials_ofemale_data_entry_expert");

                    b.Property<string>("InterorbitalBreadth")
                        .HasColumnType("character varying")
                        .HasColumnName("interorbital_breadth");

                    b.Property<string>("Length")
                        .HasColumnType("character varying")
                        .HasColumnName("length");

                    b.Property<string>("LengthMale")
                        .HasColumnType("character varying")
                        .HasColumnName("length_male");

                    b.Property<string>("LinearHypoplasiaEnamaleel")
                        .HasColumnType("character varying")
                        .HasColumnName("linear_hypoplasia_enamaleel");

                    b.Property<string>("LowPairEw")
                        .HasColumnType("character varying")
                        .HasColumnName("low_pair_ew");

                    b.Property<string>("LowPairNs")
                        .HasColumnType("character varying")
                        .HasColumnName("low_pair_ns");

                    b.Property<string>("MaleaximaleumaleCranialBreadth")
                        .HasColumnType("character varying")
                        .HasColumnName("maleaximaleumale_cranial_breadth");

                    b.Property<string>("MaleaximaleumaleCranialLength")
                        .HasColumnType("character varying")
                        .HasColumnName("maleaximaleumale_cranial_length");

                    b.Property<string>("MaleaximaleumaleNasalBreadth")
                        .HasColumnType("character varying")
                        .HasColumnName("maleaximaleumale_nasal_breadth");

                    b.Property<string>("MaleedialIpRamaleus")
                        .HasColumnType("character varying")
                        .HasColumnName("maleedial_ip_ramaleus");

                    b.Property<string>("MaleetopicSuture")
                        .HasColumnType("character varying")
                        .HasColumnName("maleetopic_suture");

                    b.Property<string>("MaleonthExcavated")
                        .HasColumnType("character varying")
                        .HasColumnName("maleonth_excavated");

                    b.Property<string>("MaleonthOnSkull")
                        .HasColumnType("character varying")
                        .HasColumnName("maleonth_on_skull");

                    b.Property<string>("NasionProsthion")
                        .HasColumnType("character varying")
                        .HasColumnName("nasion_prosthion");

                    b.Property<string>("NuchalCrest")
                        .HasColumnType("character varying")
                        .HasColumnName("nuchal_crest");

                    b.Property<string>("OrbitEdge")
                        .HasColumnType("character varying")
                        .HasColumnName("orbit_edge");

                    b.Property<string>("OsteologyNotes")
                        .HasColumnType("character varying")
                        .HasColumnName("osteology_notes");

                    b.Property<string>("OsteologyUnknownComalemaleent")
                        .HasColumnType("character varying")
                        .HasColumnName("osteology_unknown_comalemaleent");

                    b.Property<string>("Osteophytosis")
                        .HasColumnType("character varying")
                        .HasColumnName("osteophytosis");

                    b.Property<string>("ParietalBossing")
                        .HasColumnType("character varying")
                        .HasColumnName("parietal_bossing");

                    b.Property<string>("PathologyAnomalealies")
                        .HasColumnType("character varying")
                        .HasColumnName("pathology_anomalealies");

                    b.Property<string>("PoroticHyperostosis")
                        .HasColumnType("character varying")
                        .HasColumnName("porotic_hyperostosis");

                    b.Property<string>("PoroticHyperostosisLocations")
                        .HasColumnType("character varying")
                        .HasColumnName("porotic_hyperostosis_locations");

                    b.Property<string>("PostcraniaAtMaleagazine")
                        .HasColumnType("character varying")
                        .HasColumnName("postcrania_at_maleagazine");

                    b.Property<string>("PostcraniaTraumalea")
                        .HasColumnType("character varying")
                        .HasColumnName("postcrania_traumalea");

                    b.Property<string>("PreaurSulcus")
                        .HasColumnType("character varying")
                        .HasColumnName("preaur_sulcus");

                    b.Property<string>("PreservationIndex")
                        .HasColumnType("character varying")
                        .HasColumnName("preservation_index");

                    b.Property<string>("PreviouslySamalepled")
                        .HasColumnType("character varying")
                        .HasColumnName("previously_samalepled");

                    b.Property<string>("PubicBone")
                        .HasColumnType("character varying")
                        .HasColumnName("pubic_bone");

                    b.Property<string>("PubicSymalephysis")
                        .HasColumnType("character varying")
                        .HasColumnName("pubic_symalephysis");

                    b.Property<string>("Rack")
                        .HasColumnType("character varying")
                        .HasColumnName("rack");

                    b.Property<string>("RackAndShelfemale")
                        .HasColumnType("character varying")
                        .HasColumnName("rack_and_shelfemale");

                    b.Property<string>("Robust")
                        .HasColumnType("character varying")
                        .HasColumnName("robust");

                    b.Property<string>("SamalepleNumaleber")
                        .HasColumnType("character varying")
                        .HasColumnName("samaleple_numaleber");

                    b.Property<string>("SciaticNotch")
                        .HasColumnType("character varying")
                        .HasColumnName("sciatic_notch");

                    b.Property<string>("SkullAtMaleagazine")
                        .HasColumnType("character varying")
                        .HasColumnName("skull_at_maleagazine");

                    b.Property<string>("SkullTraumalea")
                        .HasColumnType("character varying")
                        .HasColumnName("skull_traumalea");

                    b.Property<string>("SofemaletTissueTaken")
                        .HasColumnType("character varying")
                        .HasColumnName("sofemalet_tissue_taken");

                    b.Property<string>("Square")
                        .HasColumnType("character varying")
                        .HasColumnName("square");

                    b.Property<string>("SubpubicAngle")
                        .HasColumnType("character varying")
                        .HasColumnName("subpubic_angle");

                    b.Property<string>("SupraorbitalRidges")
                        .HasColumnType("character varying")
                        .HasColumnName("supraorbital_ridges");

                    b.Property<string>("TemaleporalMaleandibularJointOsteoarthritis")
                        .HasColumnType("character varying")
                        .HasColumnName("temaleporal_maleandibular_joint_osteoarthritis");

                    b.Property<string>("TextileTaken")
                        .HasColumnType("character varying")
                        .HasColumnName("textile_taken");

                    b.Property<string>("TibiaLength")
                        .HasColumnType("character varying")
                        .HasColumnName("tibia_length");

                    b.Property<string>("ToBeConfemaleirmaleed")
                        .HasColumnType("character varying")
                        .HasColumnName("to_be_confemaleirmaleed");

                    b.Property<string>("Tomaleb")
                        .HasColumnType("character varying")
                        .HasColumnName("tomaleb");

                    b.Property<string>("ToothAttrition")
                        .HasColumnType("character varying")
                        .HasColumnName("tooth_attrition");

                    b.Property<string>("ToothEruption")
                        .HasColumnType("character varying")
                        .HasColumnName("tooth_eruption");

                    b.Property<string>("ToothTaken")
                        .HasColumnType("character varying")
                        .HasColumnName("tooth_taken");

                    b.Property<string>("VentralArc")
                        .HasColumnType("character varying")
                        .HasColumnName("ventral_arc");

                    b.Property<int?>("YearExcav")
                        .HasColumnType("integer")
                        .HasColumnName("year_excav");

                    b.Property<string>("YearOnSkull")
                        .HasColumnType("character varying")
                        .HasColumnName("year_on_skull");

                    b.Property<string>("ZygomaleaticCrest")
                        .HasColumnType("character varying")
                        .HasColumnName("zygomaleatic_crest");

                    b.HasKey("Burialid")
                        .HasName("official_pkey");

                    b.ToTable("official");
                });
#pragma warning restore 612, 618
        }
    }
}
