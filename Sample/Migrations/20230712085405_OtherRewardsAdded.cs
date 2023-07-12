using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sample.Migrations
{
    /// <inheritdoc />
    public partial class OtherRewardsAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Campaigns_RewardsTypes_typesid",
                table: "Campaigns");

            migrationBuilder.AlterColumn<int>(
                name: "typesid",
                table: "Campaigns",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateTable(
                name: "LeadRewardResults",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    rewardId = table.Column<int>(type: "int", nullable: false),
                    campId = table.Column<int>(type: "int", nullable: false),
                    nominatorId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    nominatedEmpId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    awardType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    stars = table.Column<int>(type: "int", nullable: false),
                    employeeId = table.Column<int>(type: "int", nullable: true),
                    CampaignsId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeadRewardResults", x => x.id);
                    table.ForeignKey(
                        name: "FK_LeadRewardResults_Campaigns_CampaignsId",
                        column: x => x.CampaignsId,
                        principalTable: "Campaigns",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_LeadRewardResults_Employees_employeeId",
                        column: x => x.employeeId,
                        principalTable: "Employees",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "LeadRewards",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    rewardId = table.Column<int>(type: "int", nullable: false),
                    campId = table.Column<int>(type: "int", nullable: false),
                    nominatorId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    nominatedEmpId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    awardCategory = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    stars = table.Column<int>(type: "int", nullable: false),
                    month = table.Column<int>(type: "int", nullable: false),
                    employeeId = table.Column<int>(type: "int", nullable: true),
                    CampaignsId = table.Column<int>(type: "int", nullable: false),
                    LeadRewardResultsid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeadRewards", x => x.id);
                    table.ForeignKey(
                        name: "FK_LeadRewards_Campaigns_CampaignsId",
                        column: x => x.CampaignsId,
                        principalTable: "Campaigns",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LeadRewards_Employees_employeeId",
                        column: x => x.employeeId,
                        principalTable: "Employees",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_LeadRewards_LeadRewardResults_LeadRewardResultsid",
                        column: x => x.LeadRewardResultsid,
                        principalTable: "LeadRewardResults",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LeadRewardResults_CampaignsId",
                table: "LeadRewardResults",
                column: "CampaignsId");

            migrationBuilder.CreateIndex(
                name: "IX_LeadRewardResults_employeeId",
                table: "LeadRewardResults",
                column: "employeeId");

            migrationBuilder.CreateIndex(
                name: "IX_LeadRewards_CampaignsId",
                table: "LeadRewards",
                column: "CampaignsId");

            migrationBuilder.CreateIndex(
                name: "IX_LeadRewards_employeeId",
                table: "LeadRewards",
                column: "employeeId");

            migrationBuilder.CreateIndex(
                name: "IX_LeadRewards_LeadRewardResultsid",
                table: "LeadRewards",
                column: "LeadRewardResultsid");

            migrationBuilder.AddForeignKey(
                name: "FK_Campaigns_RewardsTypes_typesid",
                table: "Campaigns",
                column: "typesid",
                principalTable: "RewardsTypes",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Campaigns_RewardsTypes_typesid",
                table: "Campaigns");

            migrationBuilder.DropTable(
                name: "LeadRewards");

            migrationBuilder.DropTable(
                name: "LeadRewardResults");

            migrationBuilder.AlterColumn<int>(
                name: "typesid",
                table: "Campaigns",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Campaigns_RewardsTypes_typesid",
                table: "Campaigns",
                column: "typesid",
                principalTable: "RewardsTypes",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
