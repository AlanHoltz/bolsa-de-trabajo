using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebMVC.Migrations
{
    public partial class initialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Careers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Careers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Provinces",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Provinces", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Mail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    SignupDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProvinceId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cities_Provinces_ProvinceId",
                        column: x => x.ProvinceId,
                        principalTable: "Provinces",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Cv = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsAdmin = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Persons_Users_Id",
                        column: x => x.Id,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cuit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CityZipCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReferenceName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReferencePhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReferenceEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReferenceArea = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReferenceWorkingOnCompany = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CityId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Companies_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Companies_Users_Id",
                        column: x => x.Id,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "JobProfiles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmailReceptor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Capacity = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Position = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobProfiles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JobProfiles_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CareerJobProfile",
                columns: table => new
                {
                    CareersId = table.Column<int>(type: "int", nullable: false),
                    JobProfilesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CareerJobProfile", x => new { x.CareersId, x.JobProfilesId });
                    table.ForeignKey(
                        name: "FK_CareerJobProfile_Careers_CareersId",
                        column: x => x.CareersId,
                        principalTable: "Careers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CareerJobProfile_JobProfiles_JobProfilesId",
                        column: x => x.JobProfilesId,
                        principalTable: "JobProfiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Internships",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Agreement = table.Column<bool>(type: "bit", nullable: false),
                    Duration = table.Column<int>(type: "int", nullable: false),
                    Starting = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Internships", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Internships_JobProfiles_Id",
                        column: x => x.Id,
                        principalTable: "JobProfiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "JobProfilePerson",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JobProfilesId = table.Column<int>(type: "int", nullable: false),
                    PersonsId = table.Column<int>(type: "int", nullable: false),
                    Observations = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobProfilePerson", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JobProfilePerson_JobProfiles_JobProfilesId",
                        column: x => x.JobProfilesId,
                        principalTable: "JobProfiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JobProfilePerson_Persons_PersonsId",
                        column: x => x.PersonsId,
                        principalTable: "Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Relationships",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    WorkdayTime = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Relationships", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Relationships_JobProfiles_Id",
                        column: x => x.Id,
                        principalTable: "JobProfiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CareerJobProfile_JobProfilesId",
                table: "CareerJobProfile",
                column: "JobProfilesId");

            migrationBuilder.CreateIndex(
                name: "IX_Cities_ProvinceId",
                table: "Cities",
                column: "ProvinceId");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_CityId",
                table: "Companies",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_JobProfilePerson_JobProfilesId",
                table: "JobProfilePerson",
                column: "JobProfilesId");

            migrationBuilder.CreateIndex(
                name: "IX_JobProfilePerson_PersonsId",
                table: "JobProfilePerson",
                column: "PersonsId");

            migrationBuilder.CreateIndex(
                name: "IX_JobProfiles_CompanyId",
                table: "JobProfiles",
                column: "CompanyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CareerJobProfile");

            migrationBuilder.DropTable(
                name: "Internships");

            migrationBuilder.DropTable(
                name: "JobProfilePerson");

            migrationBuilder.DropTable(
                name: "Relationships");

            migrationBuilder.DropTable(
                name: "Careers");

            migrationBuilder.DropTable(
                name: "Persons");

            migrationBuilder.DropTable(
                name: "JobProfiles");

            migrationBuilder.DropTable(
                name: "Companies");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Provinces");
        }
    }
}
