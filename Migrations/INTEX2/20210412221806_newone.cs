using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace MummyMadness.Migrations.INTEX2
{
    public partial class newone : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "official_pkey",
                table: "official");

            migrationBuilder.AddPrimaryKey(
                name: "official_edited_pkey",
                table: "official",
                column: "burialid");

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    UserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: true),
                    SecurityStamp = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    LockoutEnd = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "biosamples",
                columns: table => new
                {
                    burialid = table.Column<int>(type: "integer", nullable: false),
                    rack = table.Column<int>(type: "integer", nullable: true),
                    bag = table.Column<string>(type: "character varying", nullable: true),
                    low1 = table.Column<int>(type: "integer", nullable: true),
                    high1 = table.Column<int>(type: "integer", nullable: true),
                    n_s = table.Column<string>(type: "character varying", nullable: true),
                    low2 = table.Column<int>(type: "integer", nullable: true),
                    high2 = table.Column<int>(type: "integer", nullable: true),
                    e_w = table.Column<string>(type: "character varying", nullable: true),
                    area = table.Column<string>(type: "character varying", nullable: true),
                    burial = table.Column<string>(type: "character varying", nullable: true),
                    cluster_ = table.Column<string>(type: "character varying", nullable: true),
                    date_ = table.Column<string>(type: "character varying", nullable: true),
                    previously_sampled = table.Column<string>(type: "character varying", nullable: true),
                    notes = table.Column<string>(type: "character varying", nullable: true),
                    initials = table.Column<string>(type: "character varying", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("biosamples_pkey", x => x.burialid);
                });

            migrationBuilder.CreateTable(
                name: "c14data",
                columns: table => new
                {
                    burialid = table.Column<int>(type: "integer", nullable: false),
                    burial_id = table.Column<string>(type: "character varying", nullable: true),
                    rack = table.Column<int>(type: "integer", nullable: true),
                    n_s = table.Column<int>(type: "integer", nullable: true),
                    n = table.Column<string>(type: "character varying", nullable: true),
                    e_w = table.Column<string>(type: "character varying", nullable: true),
                    e = table.Column<string>(type: "character varying", nullable: true),
                    square = table.Column<string>(type: "character varying", nullable: true),
                    area = table.Column<int>(type: "integer", nullable: true),
                    burial = table.Column<int>(type: "integer", nullable: true),
                    tube = table.Column<int>(type: "integer", nullable: true),
                    description = table.Column<string>(type: "character varying", nullable: true),
                    size_ml = table.Column<int>(type: "integer", nullable: true),
                    foci = table.Column<int>(type: "integer", nullable: true),
                    c14_sample_2017 = table.Column<int>(type: "integer", nullable: true),
                    location = table.Column<string>(type: "character varying", nullable: true),
                    question = table.Column<string>(type: "character varying", nullable: true),
                    conventional_14c_age_bp = table.Column<string>(type: "character varying", nullable: true),
                    fourteenc_calendar_date = table.Column<string>(type: "character varying", nullable: true),
                    calibrated_95_calendar_date_max = table.Column<int>(type: "integer", nullable: true),
                    calibrated_95_calendar_date_min = table.Column<int>(type: "integer", nullable: true),
                    calibrated_95_calendar_date_span = table.Column<int>(type: "integer", nullable: true),
                    calibrated_95_calendar_date_avg = table.Column<string>(type: "character varying", nullable: true),
                    category = table.Column<string>(type: "character varying", nullable: true),
                    notes = table.Column<string>(type: "character varying", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("c14data_pkey", x => x.burialid);
                });

            migrationBuilder.CreateTable(
                name: "cranial",
                columns: table => new
                {
                    burialid = table.Column<int>(type: "integer", nullable: false),
                    sample_number = table.Column<int>(type: "integer", nullable: true),
                    maximum_cranial_length = table.Column<string>(type: "character varying", nullable: true),
                    maximum_cranial_breadth = table.Column<string>(type: "character varying", nullable: true),
                    basion_bregma_height = table.Column<string>(type: "character varying", nullable: true),
                    basion_nasion = table.Column<string>(type: "character varying", nullable: true),
                    basion_prosthion_length = table.Column<string>(type: "character varying", nullable: true),
                    bizygomatic_diameter = table.Column<string>(type: "character varying", nullable: true),
                    nasion_prosthion = table.Column<string>(type: "character varying", nullable: true),
                    maximum_nasal_breadth = table.Column<string>(type: "character varying", nullable: true),
                    interorbital_breadth = table.Column<string>(type: "character varying", nullable: true),
                    burial_positioning_north_number = table.Column<int>(type: "integer", nullable: true),
                    burial_positioning_south_number = table.Column<int>(type: "integer", nullable: true),
                    burial_positioning_northsouth_direction = table.Column<string>(type: "character varying", nullable: true),
                    burial_positioning_east_number = table.Column<int>(type: "integer", nullable: true),
                    burial_positioning_west_number = table.Column<int>(type: "integer", nullable: true),
                    burial_positioning_eastwest_direction = table.Column<string>(type: "character varying", nullable: true),
                    burial_number = table.Column<int>(type: "integer", nullable: true),
                    burial_depth = table.Column<string>(type: "character varying", nullable: true),
                    burial_subplot_direction = table.Column<string>(type: "character varying", nullable: true),
                    burial_artifact_description = table.Column<string>(type: "character varying", nullable: true),
                    buriedwithartifacts = table.Column<string>(type: "character varying", nullable: true),
                    gilesgender = table.Column<string>(type: "character varying", nullable: true),
                    bodygender = table.Column<string>(type: "character varying", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("cranial_pkey", x => x.burialid);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RoleId = table.Column<string>(type: "text", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<string>(type: "text", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    ProviderKey = table.Column<string>(type: "text", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "text", nullable: true),
                    UserId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "text", nullable: false),
                    RoleId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "text", nullable: false),
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Value = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "biosamples");

            migrationBuilder.DropTable(
                name: "c14data");

            migrationBuilder.DropTable(
                name: "cranial");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropPrimaryKey(
                name: "official_edited_pkey",
                table: "official");

            migrationBuilder.AddPrimaryKey(
                name: "official_pkey",
                table: "official",
                column: "burialid");
        }
    }
}
