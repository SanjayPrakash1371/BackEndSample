using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sample.Migrations
{
    /// <inheritdoc />
    public partial class ReplyChanges4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LeadReplyCitation_LeadCitation_LeadCitationid",
                table: "LeadReplyCitation");

            migrationBuilder.RenameColumn(
                name: "LeadCitationid",
                table: "LeadReplyCitation",
                newName: "leadCitationid");

            migrationBuilder.RenameIndex(
                name: "IX_LeadReplyCitation_LeadCitationid",
                table: "LeadReplyCitation",
                newName: "IX_LeadReplyCitation_leadCitationid");

            migrationBuilder.AddForeignKey(
                name: "FK_LeadReplyCitation_LeadCitation_leadCitationid",
                table: "LeadReplyCitation",
                column: "leadCitationid",
                principalTable: "LeadCitation",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LeadReplyCitation_LeadCitation_leadCitationid",
                table: "LeadReplyCitation");

            migrationBuilder.RenameColumn(
                name: "leadCitationid",
                table: "LeadReplyCitation",
                newName: "LeadCitationid");

            migrationBuilder.RenameIndex(
                name: "IX_LeadReplyCitation_leadCitationid",
                table: "LeadReplyCitation",
                newName: "IX_LeadReplyCitation_LeadCitationid");

            migrationBuilder.AddForeignKey(
                name: "FK_LeadReplyCitation_LeadCitation_LeadCitationid",
                table: "LeadReplyCitation",
                column: "LeadCitationid",
                principalTable: "LeadCitation",
                principalColumn: "id");
        }
    }
}
