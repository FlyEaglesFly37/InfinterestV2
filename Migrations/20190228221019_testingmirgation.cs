using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infinterest.Migrations
{
    public partial class testingmirgation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_events_brokers_BrokerId",
                table: "events");

            migrationBuilder.DropForeignKey(
                name: "FK_events_EventVendors_EventVendorsId",
                table: "events");

            migrationBuilder.DropForeignKey(
                name: "FK_listings_brokers_BrokerId",
                table: "listings");

            migrationBuilder.DropForeignKey(
                name: "FK_users_EventVendors_EventVendorsId",
                table: "users");

            migrationBuilder.DropForeignKey(
                name: "FK_users_EventVendors_EventVendorsId1",
                table: "users");

            migrationBuilder.DropTable(
                name: "brokers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EventVendors",
                table: "EventVendors");

            migrationBuilder.DropColumn(
                name: "VendorId",
                table: "users");

            migrationBuilder.RenameTable(
                name: "EventVendors",
                newName: "eventvendors");

            migrationBuilder.RenameColumn(
                name: "BrokerId",
                table: "events",
                newName: "BrokerUserId");

            migrationBuilder.RenameIndex(
                name: "IX_events_BrokerId",
                table: "events",
                newName: "IX_events_BrokerUserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_eventvendors",
                table: "eventvendors",
                column: "EventVendorsId");

            migrationBuilder.AddForeignKey(
                name: "FK_events_users_BrokerUserId",
                table: "events",
                column: "BrokerUserId",
                principalTable: "users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_events_eventvendors_EventVendorsId",
                table: "events",
                column: "EventVendorsId",
                principalTable: "eventvendors",
                principalColumn: "EventVendorsId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_listings_users_BrokerId",
                table: "listings",
                column: "BrokerId",
                principalTable: "users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_users_eventvendors_EventVendorsId",
                table: "users",
                column: "EventVendorsId",
                principalTable: "eventvendors",
                principalColumn: "EventVendorsId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_users_eventvendors_EventVendorsId1",
                table: "users",
                column: "EventVendorsId1",
                principalTable: "eventvendors",
                principalColumn: "EventVendorsId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_events_users_BrokerUserId",
                table: "events");

            migrationBuilder.DropForeignKey(
                name: "FK_events_eventvendors_EventVendorsId",
                table: "events");

            migrationBuilder.DropForeignKey(
                name: "FK_listings_users_BrokerId",
                table: "listings");

            migrationBuilder.DropForeignKey(
                name: "FK_users_eventvendors_EventVendorsId",
                table: "users");

            migrationBuilder.DropForeignKey(
                name: "FK_users_eventvendors_EventVendorsId1",
                table: "users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_eventvendors",
                table: "eventvendors");

            migrationBuilder.RenameTable(
                name: "eventvendors",
                newName: "EventVendors");

            migrationBuilder.RenameColumn(
                name: "BrokerUserId",
                table: "events",
                newName: "BrokerId");

            migrationBuilder.RenameIndex(
                name: "IX_events_BrokerUserId",
                table: "events",
                newName: "IX_events_BrokerId");

            migrationBuilder.AddColumn<int>(
                name: "VendorId",
                table: "users",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_EventVendors",
                table: "EventVendors",
                column: "EventVendorsId");

            migrationBuilder.CreateTable(
                name: "brokers",
                columns: table => new
                {
                    BrokerId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UpdatedAt = table.Column<DateTime>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_brokers", x => x.BrokerId);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_events_brokers_BrokerId",
                table: "events",
                column: "BrokerId",
                principalTable: "brokers",
                principalColumn: "BrokerId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_events_EventVendors_EventVendorsId",
                table: "events",
                column: "EventVendorsId",
                principalTable: "EventVendors",
                principalColumn: "EventVendorsId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_listings_brokers_BrokerId",
                table: "listings",
                column: "BrokerId",
                principalTable: "brokers",
                principalColumn: "BrokerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_users_EventVendors_EventVendorsId",
                table: "users",
                column: "EventVendorsId",
                principalTable: "EventVendors",
                principalColumn: "EventVendorsId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_users_EventVendors_EventVendorsId1",
                table: "users",
                column: "EventVendorsId1",
                principalTable: "EventVendors",
                principalColumn: "EventVendorsId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
