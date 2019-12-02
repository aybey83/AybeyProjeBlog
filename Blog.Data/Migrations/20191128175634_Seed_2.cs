﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Blog.Data.Migrations
{
    public partial class Seed_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "Users",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2019, 11, 28, 17, 56, 33, 806, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2019, 11, 28, 17, 56, 33, 808, DateTimeKind.Utc));

            migrationBuilder.InsertData(
                table: "Nationality",
                columns: new[] { "Id", "Code", "CreateDate", "Deleted", "Name" },
                values: new object[] { 1, "tr", new DateTime(2019, 11, 28, 17, 56, 33, 808, DateTimeKind.Utc), false, "Türkiye" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "BirthDate", "Code", "CreateDate", "Deleted", "Email", "Gender", "Name", "NationalityId", "Password", "Surname", "Username" },
                values: new object[] { 1, new DateTime(1983, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2019, 11, 28, 17, 56, 33, 808, DateTimeKind.Utc), false, "aybey83@gmail.com", 1, "Aybey", 1, "12345678", "Bayazıt", "aybey83" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Nationality",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "Code",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2019, 11, 28, 17, 41, 37, 183, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2019, 11, 28, 17, 41, 37, 184, DateTimeKind.Utc));
        }
    }
}
