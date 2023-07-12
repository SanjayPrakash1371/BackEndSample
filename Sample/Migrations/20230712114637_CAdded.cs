using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sample.Migrations
{
    /// <inheritdoc />
    public partial class CAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LeadCitationid",
                table: "LeadRewards",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_LeadRewards_LeadCitationid",
                table: "LeadRewards",
                column: "LeadCitationid");

            migrationBuilder.AddForeignKey(
                name: "FK_LeadRewards_LeadCitation_LeadCitationid",
                table: "LeadRewards",
                column: "LeadCitationid",
                principalTable: "LeadCitation",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LeadRewards_LeadCitation_LeadCitationid",
                table: "LeadRewards");

            migrationBuilder.DropIndex(
                name: "IX_LeadRewards_LeadCitationid",
                table: "LeadRewards");

            migrationBuilder.DropColumn(
                name: "LeadCitationid",
                table: "LeadRewards");
        }
    }
}
