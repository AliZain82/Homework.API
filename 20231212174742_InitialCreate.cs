using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Database_with_LINQ.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Faculty",
                columns: table => new
                {
                    fId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DepartmentId = table.Column<int>(type: "int", nullable: false),
                    Standing = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Faculty", x => x.fId);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    sid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    sname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Major = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Standing = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.sid);
                });

            migrationBuilder.CreateTable(
                name: "Classes",
                columns: table => new
                {
                    cId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RoomNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fId = table.Column<int>(type: "int", nullable: false),
                    FacultyfId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classes", x => x.cId);
                    table.ForeignKey(
                        name: "FK_Classes_Faculty_FacultyfId",
                        column: x => x.FacultyfId,
                        principalTable: "Faculty",
                        principalColumn: "fId");
                });

            migrationBuilder.CreateTable(
                name: "Enrollments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cId = table.Column<int>(type: "int", nullable: false),
                    sId = table.Column<int>(type: "int", nullable: false),
                    ClasscId = table.Column<int>(type: "int", nullable: true),
                    Studentsid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enrollments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Enrollments_Classes_ClasscId",
                        column: x => x.ClasscId,
                        principalTable: "Classes",
                        principalColumn: "cId");
                    table.ForeignKey(
                        name: "FK_Enrollments_Students_Studentsid",
                        column: x => x.Studentsid,
                        principalTable: "Students",
                        principalColumn: "sid");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Classes_FacultyfId",
                table: "Classes",
                column: "FacultyfId");

            migrationBuilder.CreateIndex(
                name: "IX_Enrollments_ClasscId",
                table: "Enrollments",
                column: "ClasscId");

            migrationBuilder.CreateIndex(
                name: "IX_Enrollments_Studentsid",
                table: "Enrollments",
                column: "Studentsid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Enrollments");

            migrationBuilder.DropTable(
                name: "Classes");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Faculty");
        }
    }
}
