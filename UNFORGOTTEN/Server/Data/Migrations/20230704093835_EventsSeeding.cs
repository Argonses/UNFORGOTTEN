using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace UNFORGOTTEN.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class EventsSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "Date", "Description", "ImageUrl", "Location", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 7, 6, 11, 38, 35, 787, DateTimeKind.Local).AddTicks(871), "Join our virtual book club where we read and discuss books in a relaxed and quiet environment.", "https://www.booksmith.com/sites/booksmith.com/files/SRP.jpg", "Online", "Quiet Book Club" },
                    { 2, new DateTime(2023, 7, 8, 11, 38, 35, 787, DateTimeKind.Local).AddTicks(922), "Grab your favorite snacks, cozy up on the couch, and enjoy a movie night designed for introverts.", "https://img.ehowcdn.com/375/cme-data/getty%2F654b900913884eb3bb30af5cdfa25c37.jpg", "Your Living Room", "Introvert's Movie Night" },
                    { 3, new DateTime(2023, 7, 10, 11, 38, 35, 787, DateTimeKind.Local).AddTicks(924), "Unleash your creativity in a peaceful setting and join our writing workshop for introverts.", "https://www.strathmore.org/media/twtlc1kp/creative-writing-workshop.jpg", "Quiet Café", "Creative Writing Workshop" },
                    { 4, new DateTime(2023, 7, 12, 11, 38, 35, 787, DateTimeKind.Local).AddTicks(926), "Embark on a peaceful nature walk designed for introverts to enjoy the beauty of the outdoors in solitude.", "https://i.redd.it/has7cip5ley31.jpg", "Tranquil Forest", "Nature Walk for Introverts" },
                    { 5, new DateTime(2023, 7, 14, 11, 38, 35, 787, DateTimeKind.Local).AddTicks(928), "Unleash your creativity and join our art workshop tailored for introverts to express themselves through art.", "https://www.artmajeur.com/medias/standard/b/h/bhdigitalart/artwork/10599379_time-to-introvert2.jpg", "Cozy Art Studio", "Introvert's Art Workshop" },
                    { 6, new DateTime(2023, 7, 16, 11, 38, 35, 787, DateTimeKind.Local).AddTicks(930), "Connect with fellow introverts in a relaxed and intimate setting to build meaningful connections.", "https://bizzabo.com/wp-content/uploads/2021/09/Networking-event-examples-Salesforce-min.png", "Quiet Café", "Introvert Networking Evening" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
