using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infinterest.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "brokers",
                columns: table => new
                {
                    CreatedAt = table.Column<DateTime>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UpdatedAt = table.Column<DateTime>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn),
                    BrokerId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_brokers", x => x.BrokerId);
                });

            migrationBuilder.CreateTable(
                name: "EventVendors",
                columns: table => new
                {
                    CreatedAt = table.Column<DateTime>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UpdatedAt = table.Column<DateTime>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn),
                    EventVendorsId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventVendors", x => x.EventVendorsId);
                });

            migrationBuilder.CreateTable(
                name: "listings",
                columns: table => new
                {
                    CreatedAt = table.Column<DateTime>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UpdatedAt = table.Column<DateTime>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn),
                    ListingId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    MLSNumber = table.Column<string>(nullable: true),
                    MLSLink = table.Column<string>(nullable: true),
                    AreaOfHouseToFeature = table.Column<string>(nullable: true),
                    Price = table.Column<int>(nullable: false),
                    Zip = table.Column<int>(nullable: false),
                    ImgUrl = table.Column<string>(nullable: true),
                    BrokerId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_listings", x => x.ListingId);
                    table.ForeignKey(
                        name: "FK_listings_brokers_BrokerId",
                        column: x => x.BrokerId,
                        principalTable: "brokers",
                        principalColumn: "BrokerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    CreatedAt = table.Column<DateTime>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UpdatedAt = table.Column<DateTime>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn),
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserType = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Contact = table.Column<string>(nullable: true),
                    Bio = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    ImgUrl = table.Column<string>(nullable: true),
                    AffiliateCode = table.Column<int>(nullable: false),
                    CustomID = table.Column<string>(nullable: true),
                    Company = table.Column<string>(nullable: true),
                    Website = table.Column<string>(nullable: true),
                    Discriminator = table.Column<string>(nullable: false),
                    VendorId = table.Column<int>(nullable: true),
                    AreaOfHouse = table.Column<string>(nullable: true),
                    BusinessCategory = table.Column<string>(nullable: true),
                    EventVendorsId = table.Column<int>(nullable: true),
                    EventVendorsId1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_users_EventVendors_EventVendorsId",
                        column: x => x.EventVendorsId,
                        principalTable: "EventVendors",
                        principalColumn: "EventVendorsId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_users_EventVendors_EventVendorsId1",
                        column: x => x.EventVendorsId1,
                        principalTable: "EventVendors",
                        principalColumn: "EventVendorsId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "events",
                columns: table => new
                {
                    CreatedAt = table.Column<DateTime>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UpdatedAt = table.Column<DateTime>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn),
                    EventId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ListingId = table.Column<int>(nullable: false),
                    OpenHouseDate = table.Column<DateTime>(nullable: false),
                    EventVendorsId = table.Column<int>(nullable: true),
                    BrokerId = table.Column<int>(nullable: true),
                    VendorUserId = table.Column<int>(nullable: true),
                    VendorUserId1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_events", x => x.EventId);
                    table.ForeignKey(
                        name: "FK_events_brokers_BrokerId",
                        column: x => x.BrokerId,
                        principalTable: "brokers",
                        principalColumn: "BrokerId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_events_EventVendors_EventVendorsId",
                        column: x => x.EventVendorsId,
                        principalTable: "EventVendors",
                        principalColumn: "EventVendorsId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_events_listings_ListingId",
                        column: x => x.ListingId,
                        principalTable: "listings",
                        principalColumn: "ListingId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_events_users_VendorUserId",
                        column: x => x.VendorUserId,
                        principalTable: "users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_events_users_VendorUserId1",
                        column: x => x.VendorUserId1,
                        principalTable: "users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_events_BrokerId",
                table: "events",
                column: "BrokerId");

            migrationBuilder.CreateIndex(
                name: "IX_events_EventVendorsId",
                table: "events",
                column: "EventVendorsId");

            migrationBuilder.CreateIndex(
                name: "IX_events_ListingId",
                table: "events",
                column: "ListingId");

            migrationBuilder.CreateIndex(
                name: "IX_events_VendorUserId",
                table: "events",
                column: "VendorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_events_VendorUserId1",
                table: "events",
                column: "VendorUserId1");

            migrationBuilder.CreateIndex(
                name: "IX_listings_BrokerId",
                table: "listings",
                column: "BrokerId");

            migrationBuilder.CreateIndex(
                name: "IX_users_EventVendorsId",
                table: "users",
                column: "EventVendorsId");

            migrationBuilder.CreateIndex(
                name: "IX_users_EventVendorsId1",
                table: "users",
                column: "EventVendorsId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "events");

            migrationBuilder.DropTable(
                name: "listings");

            migrationBuilder.DropTable(
                name: "users");

            migrationBuilder.DropTable(
                name: "brokers");

            migrationBuilder.DropTable(
                name: "EventVendors");
        }
    }
}
