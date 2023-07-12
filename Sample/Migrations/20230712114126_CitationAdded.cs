using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sample.Migrations
{
    /// <inheritdoc />
    public partial class CitationAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    empId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Designation = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LeadCitation",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nominatorId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    citation = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeadCitation", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "RewardsTypes",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RewardTypes = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RewardsTypes", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    empId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    roles = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PeerToPeerResults",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nomainatedEmpId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nomainaterId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    citation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    employeeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PeerToPeerResults", x => x.id);
                    table.ForeignKey(
                        name: "FK_PeerToPeerResults_Employees_employeeId",
                        column: x => x.employeeId,
                        principalTable: "Employees",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Campaigns",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Start = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    End = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    rewardId = table.Column<int>(type: "int", nullable: false),
                    typesid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Campaigns", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Campaigns_RewardsTypes_typesid",
                        column: x => x.typesid,
                        principalTable: "RewardsTypes",
                        principalColumn: "id");
                });

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
                    campname = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                name: "PeerToPeer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nominatorId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    awardCategory = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    month = table.Column<int>(type: "int", nullable: true),
                    citation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    empId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    campId = table.Column<int>(type: "int", nullable: false),
                    employeeId = table.Column<int>(type: "int", nullable: true),
                    campaignsId = table.Column<int>(type: "int", nullable: true),
                    Resultsid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PeerToPeer", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PeerToPeer_Campaigns_campaignsId",
                        column: x => x.campaignsId,
                        principalTable: "Campaigns",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PeerToPeer_Employees_employeeId",
                        column: x => x.employeeId,
                        principalTable: "Employees",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PeerToPeer_PeerToPeerResults_Resultsid",
                        column: x => x.Resultsid,
                        principalTable: "PeerToPeerResults",
                        principalColumn: "id");
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
                name: "IX_Campaigns_typesid",
                table: "Campaigns",
                column: "typesid");

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

            migrationBuilder.CreateIndex(
                name: "IX_PeerToPeer_campaignsId",
                table: "PeerToPeer",
                column: "campaignsId");

            migrationBuilder.CreateIndex(
                name: "IX_PeerToPeer_employeeId",
                table: "PeerToPeer",
                column: "employeeId");

            migrationBuilder.CreateIndex(
                name: "IX_PeerToPeer_Resultsid",
                table: "PeerToPeer",
                column: "Resultsid");

            migrationBuilder.CreateIndex(
                name: "IX_PeerToPeerResults_employeeId",
                table: "PeerToPeerResults",
                column: "employeeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LeadCitation");

            migrationBuilder.DropTable(
                name: "LeadRewards");

            migrationBuilder.DropTable(
                name: "PeerToPeer");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "LeadRewardResults");

            migrationBuilder.DropTable(
                name: "PeerToPeerResults");

            migrationBuilder.DropTable(
                name: "Campaigns");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "RewardsTypes");
        }
    }
}
