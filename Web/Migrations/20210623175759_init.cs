using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "KhachHang",
                columns: table => new
                {
                    MaKH = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ho = table.Column<string>(maxLength: 20, nullable: true),
                    Ten = table.Column<string>(maxLength: 100, nullable: true),
                    NgSinh = table.Column<DateTime>(nullable: false),
                    SoNha = table.Column<string>(maxLength: 20, nullable: true),
                    Duong = table.Column<string>(maxLength: 100, nullable: true),
                    Phuong = table.Column<string>(maxLength: 100, nullable: true),
                    Quan = table.Column<string>(maxLength: 50, nullable: true),
                    Tpho = table.Column<string>(maxLength: 50, nullable: true),
                    DienThoai = table.Column<string>(maxLength: 12, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhachHang", x => x.MaKH);
                });

            migrationBuilder.CreateTable(
                name: "SanPham",
                columns: table => new
                {
                    MaSP = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenSP = table.Column<string>(maxLength: 255, nullable: true),
                    SoLuongTon = table.Column<int>(nullable: false),
                    Mota = table.Column<string>(maxLength: 255, nullable: true),
                    Gia = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SanPham", x => x.MaSP);
                });

            migrationBuilder.CreateTable(
                name: "HoaDon",
                columns: table => new
                {
                    MaHD = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaKH = table.Column<int>(nullable: false),
                    NgayLap = table.Column<DateTime>(nullable: false),
                    TongTien = table.Column<decimal>(type: "money", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDon", x => x.MaHD);
                    table.ForeignKey(
                        name: "FK_HoaDon_KhachHang_MaKH",
                        column: x => x.MaKH,
                        principalTable: "KhachHang",
                        principalColumn: "MaKH",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CT_HoaDon",
                columns: table => new
                {
                    MaSP = table.Column<int>(nullable: false),
                    MaHD = table.Column<int>(nullable: false),
                    SoLuong = table.Column<int>(nullable: false),
                    GiaBan = table.Column<decimal>(type: "money", nullable: false),
                    GiaGiam = table.Column<decimal>(type: "money", nullable: false),
                    ThanhTien = table.Column<decimal>(type: "money", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CT_HoaDon", x => new { x.MaSP, x.MaHD });
                    table.ForeignKey(
                        name: "FK_CT_HoaDon_HoaDon_MaHD",
                        column: x => x.MaHD,
                        principalTable: "HoaDon",
                        principalColumn: "MaHD",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CT_HoaDon_SanPham_MaSP",
                        column: x => x.MaSP,
                        principalTable: "SanPham",
                        principalColumn: "MaSP",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CT_HoaDon_MaHD",
                table: "CT_HoaDon",
                column: "MaHD");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_MaKH",
                table: "HoaDon",
                column: "MaKH");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CT_HoaDon");

            migrationBuilder.DropTable(
                name: "HoaDon");

            migrationBuilder.DropTable(
                name: "SanPham");

            migrationBuilder.DropTable(
                name: "KhachHang");
        }
    }
}
