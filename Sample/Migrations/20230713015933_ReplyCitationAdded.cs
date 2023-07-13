using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sample.Migrations
{
    /// <inheritdoc />
    public partial class ReplyCitationAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LeadCitationReplies_Campaigns_CampaignsId",
                table: "LeadCitationReplies");

            migrationBuilder.DropForeignKey(
                name: "FK_LeadCitationReplies_LeadCitation_CitationId",
                table: "LeadCitationReplies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LeadCitationReplies",
                table: "LeadCitationReplies");

            migrationBuilder.DropIndex(
                name: "IX_LeadCitationReplies_CitationId",
                table: "LeadCitationReplies");

            migrationBuilder.DropColumn(
                name: "CitationId",
                table: "LeadCitationReplies");

            migrationBuilder.RenameTable(
                name: "LeadCitationReplies",
                newName: "LeadReplyCitation");

            migrationBuilder.RenameIndex(
                name: "IX_LeadCitationReplies_CampaignsId",
                table: "LeadReplyCitation",
                newName: "IX_LeadReplyCitation_CampaignsId");

            migrationBuilder.AddColumn<int>(
                name: "LeadCitationid",
                table: "LeadReplyCitation",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_LeadReplyCitation",
                table: "LeadReplyCitation",
                column: "id");

            migrationBuilder.CreateIndex(
                name: "IX_LeadReplyCitation_LeadCitationid",
                table: "LeadReplyCitation",
                column: "LeadCitationid");

            migrationBuilder.AddForeignKey(
                name: "FK_LeadReplyCitation_Campaigns_CampaignsId",
                table: "LeadReplyCitation",
                column: "CampaignsId",
                principalTable: "Campaigns",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_LeadReplyCitation_LeadCitation_LeadCitationid",
                table: "LeadReplyCitation",
                column: "LeadCitationid",
                principalTable: "LeadCitation",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LeadReplyCitation_Campaigns_CampaignsId",
                table: "LeadReplyCitation");

            migrationBuilder.DropForeignKey(
                name: "FK_LeadReplyCitation_LeadCitation_LeadCitationid",
                table: "LeadReplyCitation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LeadReplyCitation",
                table: "LeadReplyCitation");

            migrationBuilder.DropIndex(
                name: "IX_LeadReplyCitation_LeadCitationid",
                table: "LeadReplyCitation");

            migrationBuilder.DropColumn(
                name: "LeadCitationid",
                table: "LeadReplyCitation");

            migrationBuilder.RenameTable(
                name: "LeadReplyCitation",
                newName: "LeadCitationReplies");

            migrationBuilder.RenameIndex(
                name: "IX_LeadReplyCitation_CampaignsId",
                table: "LeadCitationReplies",
                newName: "IX_LeadCitationReplies_CampaignsId");

            migrationBuilder.AddColumn<int>(
                name: "CitationId",
                table: "LeadCitationReplies",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_LeadCitationReplies",
                table: "LeadCitationReplies",
                column: "id");

            migrationBuilder.CreateIndex(
                name: "IX_LeadCitationReplies_CitationId",
                table: "LeadCitationReplies",
                column: "CitationId");

            migrationBuilder.AddForeignKey(
                name: "FK_LeadCitationReplies_Campaigns_CampaignsId",
                table: "LeadCitationReplies",
                column: "CampaignsId",
                principalTable: "Campaigns",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_LeadCitationReplies_LeadCitation_CitationId",
                table: "LeadCitationReplies",
                column: "CitationId",
                principalTable: "LeadCitation",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
