using Microsoft.EntityFrameworkCore.Migrations;

namespace ResidenceManagement.Infrastructure.Migrations
{
    public partial class mig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ResidentType",
                table: "UserResidences");

            migrationBuilder.AddColumn<int>(
                name: "ResidentTypeId",
                table: "UserResidences",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ResidentType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Type = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResidentType", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d67a0325-5c8c-4a5a-ae0b-c82e2ca7df0e", "AQAAAAEAACcQAAAAEAVcM5ISPnaCmK6Ju6a+nuwipjC330fmCHghK6JLOVQUhcPHaCIw7HnPysh3v6LYpQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c25bdf9e-7d25-4906-9c1e-59737efa0fb2", "AQAAAAEAACcQAAAAEII5AgoMwPoxauXB7w38q5VHt0eqaBvWQsR2+tzw5olB3GfXyLtfFRb8ayWaXP95Qw==" });

            migrationBuilder.CreateIndex(
                name: "IX_UserResidences_ResidentTypeId",
                table: "UserResidences",
                column: "ResidentTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserResidences_ResidentType_ResidentTypeId",
                table: "UserResidences",
                column: "ResidentTypeId",
                principalTable: "ResidentType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserResidences_ResidentType_ResidentTypeId",
                table: "UserResidences");

            migrationBuilder.DropTable(
                name: "ResidentType");

            migrationBuilder.DropIndex(
                name: "IX_UserResidences_ResidentTypeId",
                table: "UserResidences");

            migrationBuilder.DropColumn(
                name: "ResidentTypeId",
                table: "UserResidences");

            migrationBuilder.AddColumn<int>(
                name: "ResidentType",
                table: "UserResidences",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "12c12dea-59a7-4926-ac37-38c821280370", "AQAAAAEAACcQAAAAEPPIecdD4mr6P77J/SJ8jbv5Jn2b2Lp1i/RY2vMyu3G6fPaTRTHsFL0/5ry6/rwbQA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3897d75e-fcee-4cc4-9c94-02782ccdc2e2", "AQAAAAEAACcQAAAAEJ2Q4W84DzdTbYG6/6lrThltdoKIQeB2bl/9LPb/5QQ3UbBS8lcEKWTvD5E2aL0adA==" });
        }
    }
}
