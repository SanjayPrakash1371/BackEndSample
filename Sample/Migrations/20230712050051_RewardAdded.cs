using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sample.Migrations
{
    /// <inheritdoc />
    public partial class RewardAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Roles_Employees_empId1",
                table: "Roles");

            migrationBuilder.DropIndex(
                name: "IX_Roles_empId1",
                table: "Roles");

            migrationBuilder.DropColumn(
                name: "empId1",
                table: "Roles");

            migrationBuilder.AddColumn<int>(
                name: "campaignsId",
                table: "PeerToPeer",
                type: "int",
                nullable: true);

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
                name: "Campaigns",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Start = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    End = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    rewardId = table.Column<int>(type: "int", nullable: false),
                    typesid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Campaigns", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Campaigns_RewardsTypes_typesid",
                        column: x => x.typesid,
                        principalTable: "RewardsTypes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PeerToPeer_campaignsId",
                table: "PeerToPeer",
                column: "campaignsId");

            migrationBuilder.CreateIndex(
                name: "IX_Campaigns_typesid",
                table: "Campaigns",
                column: "typesid");

            migrationBuilder.AddForeignKey(
                name: "FK_PeerToPeer_Campaigns_campaignsId",
                table: "PeerToPeer",
                column: "campaignsId",
                principalTable: "Campaigns",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PeerToPeer_Campaigns_campaignsId",
                table: "PeerToPeer");

            migrationBuilder.DropTable(
                name: "Campaigns");

            migrationBuilder.DropTable(
                name: "RewardsTypes");

            migrationBuilder.DropIndex(
                name: "IX_PeerToPeer_campaignsId",
                table: "PeerToPeer");

            migrationBuilder.DropColumn(
                name: "campaignsId",
                table: "PeerToPeer");

            migrationBuilder.AddColumn<int>(
                name: "empId1",
                table: "Roles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Roles_empId1",
                table: "Roles",
                column: "empId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Roles_Employees_empId1",
                table: "Roles",
                column: "empId1",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
