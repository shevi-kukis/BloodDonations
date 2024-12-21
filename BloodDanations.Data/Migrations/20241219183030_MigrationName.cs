using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BloodDanations.Data.Migrations
{
    public partial class MigrationName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "bloodDoses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdDonor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    bloodType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsChecked = table.Column<bool>(type: "bit", nullable: false),
                    IsTaken = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bloodDoses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CompatibilityChecks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdPatient = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumNeedDose = table.Column<int>(type: "int", nullable: false),
                    IdBloodeDose = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompatibilityChecks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Donor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstNameDonor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastNameDonor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdDonor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    sex = table.Column<int>(type: "int", nullable: true),
                    Origin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    healthFund = table.Column<int>(type: "int", nullable: true),
                    EmailDonor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressDonor = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Donor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstNameEmployee = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastNameEmployee = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmailEmployee = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployeeId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    employeeRank = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstNamePatient = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastNamePatient = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdPatient = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    sex = table.Column<int>(type: "int", nullable: false),
                    Origin = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    healthFund = table.Column<int>(type: "int", nullable: false),
                    AddressPatient = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    levelOfUrgency = table.Column<int>(type: "int", nullable: false),
                    bloodType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdEmployee = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "bloodDoses");

            migrationBuilder.DropTable(
                name: "CompatibilityChecks");

            migrationBuilder.DropTable(
                name: "Donor");

            migrationBuilder.DropTable(
                name: "employees");

            migrationBuilder.DropTable(
                name: "Patients");
        }
    }
}
