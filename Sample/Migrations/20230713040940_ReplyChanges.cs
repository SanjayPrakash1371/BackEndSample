using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sample.Migrations
{
    /// <inheritdoc />
    public partial class ReplyChanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "replierId",
                table: "LeadReplyCitation",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CampaignsId",
                table: "LeadCitation",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_LeadCitation_CampaignsId",
                table: "LeadCitation",
                column: "CampaignsId");

            migrationBuilder.AddForeignKey(
                name: "FK_LeadCitation_Campaigns_CampaignsId",
                table: "LeadCitation",
                column: "CampaignsId",
                principalTable: "Campaigns",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LeadCitation_Campaigns_CampaignsId",
                table: "LeadCitation");

            migrationBuilder.DropIndex(
                name: "IX_LeadCitation_CampaignsId",
                table: "LeadCitation");

            migrationBuilder.DropColumn(
                name: "replierId",
                table: "LeadReplyCitation");

            migrationBuilder.DropColumn(
                name: "CampaignsId",
                table: "LeadCitation");
        }
    }
}
