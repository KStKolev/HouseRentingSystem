using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HouseRentingSystem.Data.Migrations
{
    public partial class housesseed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1c00c289-3daf-4e58-b667-84ac811ca63f", "AQAAAAEAACcQAAAAEIEjzsrIPz/sZOLGhee7C3CqUsJGxkw1lJayeTlYLInYhSIQc93IoHLvxyCU/uekkA==", "7dffed71-8169-4634-a177-ef757253b5cd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "66a1f686-d06b-4a79-b744-c81ca8ea7471", "AQAAAAEAACcQAAAAEB8Z79LOLVI5vWTm5icmlXzwI9E/eJJaYwC9VdTG3QtV0RX4/tIQ1vBry4+IGSt88Q==", "e703c79d-2eb0-4ee6-9277-3a819b0e2924" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Address", "AgentId", "CategoryId", "Description", "ImageUrl", "PricePerMonth", "RenterId", "Title" },
                values: new object[,]
                {
                    { 1, "North London, UK (near the border)", 1, 3, "A big house for your whole family. Don't miss to buy a house with three bedrooms.", "https://www.luxury-architecture.net/wp-content/uploads/2017/12/1513217889-7597-FAIRWAYS-010.jpg", 2100.00m, "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e", "Big House Marina" },
                    { 2, "Near the Sea Garden in Burgas, Bulgaria", 1, 1, "It has the best comfort you will ever ask for. With two bedrooms, it is great for your family.", "https://cf.bstatic.com/xdata/images/hotel/max1024x768/179489660.jpg?k=2029f6d9589b49c95dcc9503a265e292c2cdfcb5277487a0050397c3f8dd545a&o=&hp=1", 1200.00m, null, "Family House Comfort" },
                    { 3, "Boyana Neighbourhood, Sofia, Bulgaria", 1, 2, "This luxurious house is everything you will need. It is just excellent.", "https://i.pinimg.com/originals/a6/f5/85/a6f5850a77633c56e4e4ac4f867e3c00.jpg", 2000.00m, null, "Grand House" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Houses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Houses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Houses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "335cf284-e56f-4984-b883-89954c123d86", "AQAAAAEAACcQAAAAEOqxIimIS6YmlcOyJyNxBhODn8ICtceh3J6Sx0oF8xgBbTRhovnIsGZnqJnI/C564w==", "dd2c9f72-e7d4-4fc0-9b56-169c3c5c3fa7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "75e40a84-3b27-4f7f-8753-d75626ba6451", "AQAAAAEAACcQAAAAEA2asGHCfLazzTLwhbTvSVsPbD/Fdg/GH0WS74ImXU6V16ALjoWAv3HDon7dupODYQ==", "c0f98f1e-dabb-49b4-b776-0c9a759c6045" });
        }
    }
}
