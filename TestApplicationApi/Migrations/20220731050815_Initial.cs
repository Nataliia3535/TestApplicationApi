using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestApplicationApi.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contact",
                columns: table => new
                {
                    email = table.Column<string>(type: "text", nullable: false),
                    contact_firstname = table.Column<string>(type: "text", nullable: false),
                    contact_lastname = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contact", x => x.email);
                });

            migrationBuilder.CreateTable(
                name: "Acounts",
                columns: table => new
                {
                    accountName = table.Column<string>(type: "text", nullable: false),
                    Contactemail = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Acounts", x => x.accountName);
                    table.ForeignKey(
                        name: "FK_Acounts_Contact_Contactemail",
                        column: x => x.Contactemail,
                        principalTable: "Contact",
                        principalColumn: "email",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Incident",
                columns: table => new
                {
                    incident_name = table.Column<string>(type: "text", nullable: false),
                    incident_description = table.Column<string>(type: "text", nullable: false),
                    AcountaccountName = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Incident", x => x.incident_name);
                    table.ForeignKey(
                        name: "FK_Incident_Acounts_AcountaccountName",
                        column: x => x.AcountaccountName,
                        principalTable: "Acounts",
                        principalColumn: "accountName");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Acounts_Contactemail",
                table: "Acounts",
                column: "Contactemail");

            migrationBuilder.CreateIndex(
                name: "IX_Incident_AcountaccountName",
                table: "Incident",
                column: "AcountaccountName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Incident");

            migrationBuilder.DropTable(
                name: "Acounts");

            migrationBuilder.DropTable(
                name: "Contact");
        }
    }
}
