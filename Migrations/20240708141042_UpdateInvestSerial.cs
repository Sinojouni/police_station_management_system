using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WinFormsApp1.Migrations
{
    /// <inheritdoc />
    public partial class UpdateInvestSerial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ImageAndFP",
                columns: table => new
                {
                    serial = table.Column<int>(type: "int", nullable: false),
                    serpers = table.Column<int>(type: "int", nullable: false),
                    faceright = table.Column<byte[]>(type: "image", nullable: true),
                    facefront = table.Column<byte[]>(type: "image", nullable: true),
                    faceleft = table.Column<byte[]>(type: "image", nullable: true),
                    fpright = table.Column<byte[]>(type: "image", nullable: true),
                    fpleft = table.Column<byte[]>(type: "image", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__ImageAnd__C87A60D5C4BE05D5", x => new { x.serial, x.serpers });
                });

            migrationBuilder.CreateTable(
                name: "ImageFace",
                columns: table => new
                {
                    SERIAL = table.Column<int>(type: "int", nullable: false),
                    SERPERS = table.Column<int>(type: "int", nullable: false),
                    faceright = table.Column<byte[]>(type: "image", nullable: true),
                    facefront = table.Column<byte[]>(type: "image", nullable: true),
                    faceleft = table.Column<byte[]>(type: "image", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__ImageFac__52B352DE3D04902C", x => new { x.SERIAL, x.SERPERS });
                });

            migrationBuilder.CreateTable(
                name: "ImageFP",
                columns: table => new
                {
                    SERIAL = table.Column<int>(type: "int", nullable: false),
                    SERPERS = table.Column<int>(type: "int", nullable: false),
                    fpright = table.Column<byte[]>(type: "image", nullable: true),
                    fpleft = table.Column<byte[]>(type: "image", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__ImageFP__52B352DE842C54E2", x => new { x.SERIAL, x.SERPERS });
                });

            migrationBuilder.CreateTable(
                name: "INVEST",
                columns: table => new
                {
                    SERIAL = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DFILE = table.Column<DateOnly>(type: "date", nullable: false),
                    DMAHDAR = table.Column<DateOnly>(type: "date", nullable: false),
                    CRIME = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    MADBOUT = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true),
                    RESUME = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true),
                    REM = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__INVEST__1CE6D4E6353FDDFC", x => x.SERIAL);
                });

            migrationBuilder.CreateTable(
                name: "invpersons",
                columns: table => new
                {
                    SERIAL = table.Column<int>(type: "int", nullable: false),
                    SERPERS = table.Column<int>(type: "int", nullable: false),
                    FNAME = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LNAME = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    FATHER = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    MOTHER = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NATION = table.Column<int>(type: "int", nullable: true),
                    REG = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    PBIRTH = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DBIRTH = table.Column<int>(type: "int", nullable: true),
                    RESID = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    ADRS = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ATTR = table.Column<int>(type: "int", nullable: true),
                    EXST = table.Column<int>(type: "int", nullable: true),
                    ARCH = table.Column<int>(type: "int", nullable: true),
                    Nickname = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Occupation = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Idnum = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Mobileno = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Status = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__invperso__52B352DEC229374F", x => new { x.SERIAL, x.SERPERS });
                });

            migrationBuilder.CreateTable(
                name: "nations",
                columns: table => new
                {
                    CODE = table.Column<int>(type: "int", nullable: false),
                    ALABEL = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LLABEL = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    FNAME = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    TYPE = table.Column<int>(type: "int", nullable: false),
                    GRP = table.Column<int>(type: "int", nullable: false),
                    LNG = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__nations__AA1D437898E5A570", x => x.CODE);
                });

            migrationBuilder.CreateTable(
                name: "vehicles",
                columns: table => new
                {
                    vid = table.Column<int>(type: "int", nullable: false),
                    serialNB = table.Column<int>(type: "int", nullable: true),
                    ActualNB = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CodeDESC = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    PRODDATE = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Chassis = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Motor = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    dateaquisition = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    PreMiseCirc = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ColorDesc = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Brand = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Model = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    UtilisDesc = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    lastname = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    NoRegProp = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Address = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CityID = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DistrictID = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    GovernateID = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    MotherName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    TelProp = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    AgeProp = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    BirthPlace = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    HORSSERVICE = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__vehicles__DDB00C7DCC21BDC6", x => x.vid);
                });

            migrationBuilder.CreateTable(
                name: "Village",
                columns: table => new
                {
                    CODE = table.Column<int>(type: "int", nullable: false),
                    LABEL = table.Column<string>(type: "nchar(200)", fixedLength: true, maxLength: 200, nullable: true),
                    STAT = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Village__AA1D43782D41583B", x => x.CODE);
                });

            migrationBuilder.CreateTable(
                name: "worldkey",
                columns: table => new
                {
                    CODE = table.Column<int>(type: "int", nullable: false),
                    LABEL = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LINKCODE = table.Column<int>(type: "int", nullable: true),
                    OFFICE = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__worldkey__AA1D4378B6B2B618", x => x.CODE);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ImageAndFP");

            migrationBuilder.DropTable(
                name: "ImageFace");

            migrationBuilder.DropTable(
                name: "ImageFP");

            migrationBuilder.DropTable(
                name: "INVEST");

            migrationBuilder.DropTable(
                name: "invpersons");

            migrationBuilder.DropTable(
                name: "nations");

            migrationBuilder.DropTable(
                name: "vehicles");

            migrationBuilder.DropTable(
                name: "Village");

            migrationBuilder.DropTable(
                name: "worldkey");
        }
    }
}
