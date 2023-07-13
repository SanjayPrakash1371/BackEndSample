using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sample.Migrations
{
    /// <inheritdoc />
    public partial class ReplyChanges3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LeadRewards_LeadCitation_LeadCitationid",
                table: "LeadRewards");

            migrationBuilder.AlterColumn<int>(
                name: "LeadCitationid",
                table: "LeadRewards",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "replierId",
                table: "LeadReplyCitation",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "nominatorId",
                table: "LeadReplyCitation",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_LeadRewards_LeadCitation_LeadCitationid",
                table: "LeadRewards",
                column: "LeadCitationid",
                principalTable: "LeadCitation",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LeadRewards_LeadCitation_LeadCitationid",
                table: "LeadRewards");

            migrationBuilder.AlterColumn<int>(
                name: "LeadCitationid",
                table: "LeadRewards",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "replierId",
                table: "LeadReplyCitation",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "nominatorId",
                table: "LeadReplyCitation",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddForeignKey(
                name: "FK_LeadRewards_LeadCitation_LeadCitationid",
                table: "LeadRewards",
                column: "LeadCitationid",
                principalTable: "LeadCitation",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
