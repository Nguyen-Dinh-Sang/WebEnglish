using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CleanArchitecture.Data.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NguoiDung",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenNguoiDung = table.Column<string>(nullable: true),
                    TaiKhoan = table.Column<string>(nullable: true),
                    MatKhau = table.Column<string>(nullable: true),
                    NgayTao = table.Column<DateTime>(nullable: true),
                    SoDienThoai = table.Column<string>(nullable: true),
                    Gmail = table.Column<string>(nullable: true),
                    VaiTro = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NguoiDung", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NguoiDung");
        }
    }
}
