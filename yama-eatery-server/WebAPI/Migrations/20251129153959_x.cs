using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class x : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Membership",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MembershipStatus = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Rank = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    MemberScore = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Membership", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Position",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    HourlyWage = table.Column<decimal>(type: "numeric(10,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Position", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Table",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Floor = table.Column<int>(type: "int", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModificationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletionDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Table", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Voucher",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    ExpiredDate = table.Column<DateOnly>(type: "date", nullable: false),
                    ReducedPercent = table.Column<int>(type: "int", nullable: false),
                    MaxReducing = table.Column<decimal>(type: "numeric(10,2)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModificationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletionDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Voucher", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SubCategory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubCategory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubCategory_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Image = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Birthday = table.Column<DateOnly>(type: "date", nullable: true),
                    Phone = table.Column<string>(type: "char(10)", maxLength: 10, nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    MembershipId = table.Column<int>(type: "int", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModificationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletionDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                    table.ForeignKey(
                        name: "FK_User_Membership_MembershipId",
                        column: x => x.MembershipId,
                        principalTable: "Membership",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Image = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Birthday = table.Column<DateOnly>(type: "date", nullable: true),
                    Phone = table.Column<string>(type: "char(10)", maxLength: 10, nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    PositionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employee_Position_PositionId",
                        column: x => x.PositionId,
                        principalTable: "Position",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Price = table.Column<decimal>(type: "numeric(10,2)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    StockQuantity = table.Column<int>(type: "int", nullable: false),
                    SubCategoryId = table.Column<int>(type: "int", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModificationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletionDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Product_SubCategory_SubCategoryId",
                        column: x => x.SubCategoryId,
                        principalTable: "SubCategory",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Contact",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Title = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Message = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    IsIgnored = table.Column<bool>(type: "bit", nullable: false),
                    Respond = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contact", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contact_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UserVoucher",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    VoucherId = table.Column<int>(type: "int", nullable: false),
                    IsUsed = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserVoucher", x => new { x.UserId, x.VoucherId });
                    table.ForeignKey(
                        name: "FK_UserVoucher_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserVoucher_Voucher_VoucherId",
                        column: x => x.VoucherId,
                        principalTable: "Voucher",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Attendance",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateOnly>(type: "date", nullable: false),
                    CheckInTime = table.Column<TimeOnly>(type: "time", nullable: false),
                    CheckOutTime = table.Column<TimeOnly>(type: "time", nullable: false),
                    WorkHours = table.Column<decimal>(type: "numeric(10,2)", nullable: false),
                    LateArrival = table.Column<bool>(type: "bit", nullable: false),
                    EarlyLeave = table.Column<bool>(type: "bit", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attendance", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Attendance_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Booking",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Phone = table.Column<string>(type: "char(10)", maxLength: 10, nullable: true),
                    Note = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    TotalPayment = table.Column<decimal>(type: "numeric(10,2)", nullable: false),
                    DepositPrice = table.Column<decimal>(type: "numeric(10,2)", nullable: false),
                    RemainPayment = table.Column<decimal>(type: "numeric(10,2)", nullable: false),
                    BookingDate = table.Column<DateOnly>(type: "date", nullable: false),
                    DayPart = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    BookingStatus = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    NewPaymentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    TableId = table.Column<int>(type: "int", nullable: true),
                    EmployeeId = table.Column<int>(type: "int", nullable: true),
                    VoucherId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Booking", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Booking_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Booking_Table_TableId",
                        column: x => x.TableId,
                        principalTable: "Table",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Booking_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Booking_Voucher_VoucherId",
                        column: x => x.VoucherId,
                        principalTable: "Voucher",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Salary",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Deductions = table.Column<decimal>(type: "numeric(10,2)", nullable: false),
                    NetSalary = table.Column<decimal>(type: "numeric(10,2)", nullable: false),
                    PayDay = table.Column<DateOnly>(type: "date", nullable: true),
                    EmployeeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Salary", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Salary_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "FeedbackProduct",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Rating = table.Column<decimal>(type: "numeric(10,2)", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModificationDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeedbackProduct", x => new { x.UserId, x.ProductId });
                    table.ForeignKey(
                        name: "FK_FeedbackProduct_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FeedbackProduct_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BookingDetail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookingId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    CookingStatus = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "numeric(10,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookingDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BookingDetail_Booking_BookingId",
                        column: x => x.BookingId,
                        principalTable: "Booking",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookingDetail_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Starters" },
                    { 2, "Main" },
                    { 3, "Beverages" },
                    { 4, "Desserts" }
                });

            migrationBuilder.InsertData(
                table: "Membership",
                columns: new[] { "Id", "MemberScore", "MembershipStatus", "Rank" },
                values: new object[,]
                {
                    { 1, 100, "Requesting", "Silver" },
                    { 2, 200, "Inactive", "Gold" },
                    { 3, 300, "Active", "Platinum" },
                    { 4, 400, "Requesting", "Member" },
                    { 5, 500, "Inactive", "Silver" },
                    { 6, 600, "Active", "Gold" },
                    { 7, 700, "Requesting", "Platinum" },
                    { 8, 800, "Inactive", "Member" },
                    { 9, 900, "Active", "Silver" },
                    { 10, 1000, "Requesting", "Gold" }
                });

            migrationBuilder.InsertData(
                table: "Position",
                columns: new[] { "Id", "HourlyWage", "Name" },
                values: new object[,]
                {
                    { 1, 15m, "Staff" },
                    { 2, 50m, "Manager" }
                });

            migrationBuilder.InsertData(
                table: "Table",
                columns: new[] { "Id", "CreationDate", "DeletionDate", "Floor", "Image", "IsDeleted", "ModificationDate", "Type" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 11, 24, 22, 39, 53, 733, DateTimeKind.Local).AddTicks(7976), null, 1, "[\"https://via.placeholder.com/300?text=Table\\u002B1\"]", false, new DateTime(2025, 11, 27, 22, 39, 53, 733, DateTimeKind.Local).AddTicks(7993), "Small" },
                    { 2, new DateTime(2025, 11, 19, 22, 39, 53, 733, DateTimeKind.Local).AddTicks(8023), null, 1, "[\"https://via.placeholder.com/300?text=Table\\u002B2\"]", false, new DateTime(2025, 11, 25, 22, 39, 53, 733, DateTimeKind.Local).AddTicks(8024), "Big" },
                    { 3, new DateTime(2025, 11, 14, 22, 39, 53, 733, DateTimeKind.Local).AddTicks(8029), null, 1, "[\"https://via.placeholder.com/300?text=Table\\u002B3\"]", false, new DateTime(2025, 11, 23, 22, 39, 53, 733, DateTimeKind.Local).AddTicks(8030), "Round" },
                    { 4, new DateTime(2025, 11, 9, 22, 39, 53, 733, DateTimeKind.Local).AddTicks(8035), null, 2, "[\"https://via.placeholder.com/300?text=Table\\u002B4\"]", false, new DateTime(2025, 11, 21, 22, 39, 53, 733, DateTimeKind.Local).AddTicks(8036), "Private" },
                    { 5, new DateTime(2025, 11, 4, 22, 39, 53, 733, DateTimeKind.Local).AddTicks(8039), null, 2, "[\"https://via.placeholder.com/300?text=Table\\u002B5\"]", false, new DateTime(2025, 11, 19, 22, 39, 53, 733, DateTimeKind.Local).AddTicks(8040), "Small" },
                    { 6, new DateTime(2025, 10, 30, 22, 39, 53, 733, DateTimeKind.Local).AddTicks(8045), null, 2, "[\"https://via.placeholder.com/300?text=Table\\u002B6\"]", false, new DateTime(2025, 11, 17, 22, 39, 53, 733, DateTimeKind.Local).AddTicks(8046), "Big" },
                    { 7, new DateTime(2025, 10, 25, 22, 39, 53, 733, DateTimeKind.Local).AddTicks(8123), null, 3, "[\"https://via.placeholder.com/300?text=Table\\u002B7\"]", false, new DateTime(2025, 11, 15, 22, 39, 53, 733, DateTimeKind.Local).AddTicks(8124), "Round" },
                    { 8, new DateTime(2025, 10, 20, 22, 39, 53, 733, DateTimeKind.Local).AddTicks(8127), null, 3, "[\"https://via.placeholder.com/300?text=Table\\u002B8\"]", false, new DateTime(2025, 11, 13, 22, 39, 53, 733, DateTimeKind.Local).AddTicks(8128), "Private" },
                    { 9, new DateTime(2025, 10, 15, 22, 39, 53, 733, DateTimeKind.Local).AddTicks(8132), null, 3, "[\"https://via.placeholder.com/300?text=Table\\u002B9\"]", false, new DateTime(2025, 11, 11, 22, 39, 53, 733, DateTimeKind.Local).AddTicks(8133), "Small" },
                    { 10, new DateTime(2025, 10, 10, 22, 39, 53, 733, DateTimeKind.Local).AddTicks(8141), null, 4, "[\"https://via.placeholder.com/300?text=Table\\u002B10\"]", false, new DateTime(2025, 11, 9, 22, 39, 53, 733, DateTimeKind.Local).AddTicks(8142), "Big" }
                });

            migrationBuilder.InsertData(
                table: "Voucher",
                columns: new[] { "Id", "CreationDate", "DeletionDate", "Description", "ExpiredDate", "Image", "IsDeleted", "MaxReducing", "ModificationDate", "Name", "Quantity", "ReducedPercent" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 11, 26, 22, 39, 55, 950, DateTimeKind.Local).AddTicks(2720), null, "Get 5% discount on your order up to $10 max reduction", new DateOnly(2026, 1, 8), "https://via.placeholder.com/300?text=Voucher1", false, 10m, new DateTime(2025, 11, 28, 22, 39, 55, 950, DateTimeKind.Local).AddTicks(2721), "Voucher 5% OFF", 95, 5 },
                    { 2, new DateTime(2025, 11, 23, 22, 39, 55, 950, DateTimeKind.Local).AddTicks(2729), null, "Get 10% discount on your order up to $20 max reduction", new DateOnly(2026, 1, 18), "https://via.placeholder.com/300?text=Voucher2", false, 20m, new DateTime(2025, 11, 27, 22, 39, 55, 950, DateTimeKind.Local).AddTicks(2730), "Voucher 10% OFF", 90, 10 },
                    { 3, new DateTime(2025, 11, 20, 22, 39, 55, 950, DateTimeKind.Local).AddTicks(2734), null, "Get 15% discount on your order up to $30 max reduction", new DateOnly(2026, 1, 28), "https://via.placeholder.com/300?text=Voucher3", false, 30m, new DateTime(2025, 11, 26, 22, 39, 55, 950, DateTimeKind.Local).AddTicks(2734), "Voucher 15% OFF", 85, 15 },
                    { 4, new DateTime(2025, 11, 17, 22, 39, 55, 950, DateTimeKind.Local).AddTicks(2738), null, "Get 20% discount on your order up to $40 max reduction", new DateOnly(2026, 2, 7), "https://via.placeholder.com/300?text=Voucher4", false, 40m, new DateTime(2025, 11, 25, 22, 39, 55, 950, DateTimeKind.Local).AddTicks(2739), "Voucher 20% OFF", 80, 20 },
                    { 5, new DateTime(2025, 11, 14, 22, 39, 55, 950, DateTimeKind.Local).AddTicks(2847), null, "Get 25% discount on your order up to $50 max reduction", new DateOnly(2026, 2, 17), "https://via.placeholder.com/300?text=Voucher5", false, 50m, new DateTime(2025, 11, 24, 22, 39, 55, 950, DateTimeKind.Local).AddTicks(2848), "Voucher 25% OFF", 75, 25 },
                    { 6, new DateTime(2025, 11, 11, 22, 39, 55, 950, DateTimeKind.Local).AddTicks(2857), null, "Get 30% discount on your order up to $60 max reduction", new DateOnly(2026, 2, 27), "https://via.placeholder.com/300?text=Voucher6", false, 60m, new DateTime(2025, 11, 23, 22, 39, 55, 950, DateTimeKind.Local).AddTicks(2857), "Voucher 30% OFF", 70, 30 },
                    { 7, new DateTime(2025, 11, 8, 22, 39, 55, 950, DateTimeKind.Local).AddTicks(2862), null, "Get 35% discount on your order up to $70 max reduction", new DateOnly(2026, 3, 9), "https://via.placeholder.com/300?text=Voucher7", false, 70m, new DateTime(2025, 11, 22, 22, 39, 55, 950, DateTimeKind.Local).AddTicks(2862), "Voucher 35% OFF", 65, 35 },
                    { 8, new DateTime(2025, 11, 5, 22, 39, 55, 950, DateTimeKind.Local).AddTicks(2866), null, "Get 40% discount on your order up to $80 max reduction", new DateOnly(2026, 3, 19), "https://via.placeholder.com/300?text=Voucher8", false, 80m, new DateTime(2025, 11, 21, 22, 39, 55, 950, DateTimeKind.Local).AddTicks(2867), "Voucher 40% OFF", 60, 40 },
                    { 9, new DateTime(2025, 11, 2, 22, 39, 55, 950, DateTimeKind.Local).AddTicks(2871), null, "Get 45% discount on your order up to $90 max reduction", new DateOnly(2026, 3, 29), "https://via.placeholder.com/300?text=Voucher9", false, 90m, new DateTime(2025, 11, 20, 22, 39, 55, 950, DateTimeKind.Local).AddTicks(2871), "Voucher 45% OFF", 55, 45 },
                    { 10, new DateTime(2025, 10, 30, 22, 39, 55, 950, DateTimeKind.Local).AddTicks(2996), null, "Get 50% discount on your order up to $100 max reduction", new DateOnly(2026, 4, 8), "https://via.placeholder.com/300?text=Voucher10", false, 100m, new DateTime(2025, 11, 19, 22, 39, 55, 950, DateTimeKind.Local).AddTicks(2996), "Voucher 50% OFF", 50, 50 }
                });

            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "Id", "Birthday", "Email", "Gender", "Image", "Name", "Password", "Phone", "PositionId" },
                values: new object[,]
                {
                    { 1, new DateOnly(1986, 2, 2), "employee1@yama.com", "Female", "https://via.placeholder.com/150?text=Employee1", "Employee 1", "$2a$11$Nk7IcZrid44CUHqi8C2R1.5uo10obyUdAEvlSQz20FmlOtvBaMDia", "0800000001", 2 },
                    { 2, new DateOnly(1987, 3, 3), "employee2@yama.com", "Male", "https://via.placeholder.com/150?text=Employee2", "Employee 2", "$2a$11$gEnWwmyzM0LG/EaNIz3NkesSE1OuGYu7KuviE6YSQglJeCiOGcBea", "0800000002", 1 },
                    { 3, new DateOnly(1988, 4, 4), "employee3@yama.com", "Female", "https://via.placeholder.com/150?text=Employee3", "Employee 3", "$2a$11$vMcC5KiSiQrJVR47ytTXh.a.gVoIKF1V80jLO5/d52.f1wxsyHhmu", "0800000003", 2 },
                    { 4, new DateOnly(1989, 5, 5), "employee4@yama.com", "Male", "https://via.placeholder.com/150?text=Employee4", "Employee 4", "$2a$11$/puLolSECvxPSUrP2nr6tu0znjDHGyBt9zY8Ec4iAkm6OgB6JKrV2", "0800000004", 1 },
                    { 5, new DateOnly(1990, 6, 6), "employee5@yama.com", "Female", "https://via.placeholder.com/150?text=Employee5", "Employee 5", "$2a$11$NxwMe9FQCDvOInSKHmOIL.zVm81cPOKHV0MaKpOrWz0nI8/YFiirS", "0800000005", 2 },
                    { 6, new DateOnly(1991, 7, 7), "employee6@yama.com", "Male", "https://via.placeholder.com/150?text=Employee6", "Employee 6", "$2a$11$d/AHtK4jTsaP/v9d72JHCOBKJg6D1mOcnvjWcBTBaaz0Qu2Qh536G", "0800000006", 1 },
                    { 7, new DateOnly(1992, 8, 8), "employee7@yama.com", "Female", "https://via.placeholder.com/150?text=Employee7", "Employee 7", "$2a$11$JHTEj4YVg16bpZjx5KWYs.is1wN6t5Ylk6nUEtSPPdPhKyCK7fGCi", "0800000007", 2 },
                    { 8, new DateOnly(1993, 9, 9), "employee8@yama.com", "Male", "https://via.placeholder.com/150?text=Employee8", "Employee 8", "$2a$11$g5.TX5x.rYzQDwK2vu8DpOGSYUuhFAnrge8z3FPmhFRPDGHSmRU9.", "0800000008", 1 },
                    { 9, new DateOnly(1994, 10, 10), "employee9@yama.com", "Female", "https://via.placeholder.com/150?text=Employee9", "Employee 9", "$2a$11$APwgNudghSR1wdfLWhQ0r.25.KpZx7j9wox7TPMa80TA8K8f669fO", "0800000009", 2 },
                    { 10, new DateOnly(1995, 11, 11), "employee10@yama.com", "Male", "https://via.placeholder.com/150?text=Employee10", "Employee 10", "$2a$11$D61e78te7WOPIaF6.u9w2u7kmtyOzQDMelFTH/Bd2htjCxwCY6n7W", "0800000010", 1 }
                });

            migrationBuilder.InsertData(
                table: "SubCategory",
                columns: new[] { "Id", "CategoryId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Spring Rolls" },
                    { 2, 1, "Salads" },
                    { 3, 2, "Noodles" },
                    { 4, 2, "Rice Dishes" },
                    { 5, 2, "Grilled" },
                    { 6, 3, "Soft Drinks" },
                    { 7, 3, "Alcoholic" },
                    { 8, 3, "Coffee & Tea" },
                    { 9, 4, "Traditional Desserts" },
                    { 10, 4, "Ice Cream" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Birthday", "CreationDate", "DeletionDate", "Email", "Gender", "Image", "IsDeleted", "MembershipId", "ModificationDate", "Name", "Password", "Phone" },
                values: new object[,]
                {
                    { 1, new DateOnly(1991, 2, 2), new DateTime(2025, 11, 19, 22, 39, 53, 981, DateTimeKind.Local).AddTicks(5143), null, "user1@yama.com", "Female", "https://via.placeholder.com/150?text=User1", false, 1, new DateTime(2025, 11, 24, 22, 39, 53, 981, DateTimeKind.Local).AddTicks(5154), "User 1", "$2a$11$zW51B8Xg4wRCAMQz40dVAOUoZbRX2waGHBTgFDIExZU2KNpBXn13S", "0900000001" },
                    { 2, new DateOnly(1992, 3, 3), new DateTime(2025, 11, 9, 22, 39, 54, 218, DateTimeKind.Local).AddTicks(1556), null, "user2@yama.com", "Male", "https://via.placeholder.com/150?text=User2", false, 2, new DateTime(2025, 11, 19, 22, 39, 54, 218, DateTimeKind.Local).AddTicks(1564), "User 2", "$2a$11$bDIbIHDIsDrk2o4zEyV0HuCvv4z3uDA3HEchSPGw6iCuUPOMCcYCW", "0900000002" },
                    { 3, new DateOnly(1993, 4, 4), new DateTime(2025, 10, 30, 22, 39, 54, 434, DateTimeKind.Local).AddTicks(3729), null, "user3@yama.com", "Female", "https://via.placeholder.com/150?text=User3", false, 3, new DateTime(2025, 11, 14, 22, 39, 54, 434, DateTimeKind.Local).AddTicks(3752), "User 3", "$2a$11$8FC/GtQjGB/XTvQIPoG4SeTxrbGqGu4w6JEZgD1hPEEqkc4zb67DO", "0900000003" },
                    { 4, new DateOnly(1994, 5, 5), new DateTime(2025, 10, 20, 22, 39, 54, 653, DateTimeKind.Local).AddTicks(2768), null, "user4@yama.com", "Male", "https://via.placeholder.com/150?text=User4", false, 4, new DateTime(2025, 11, 9, 22, 39, 54, 653, DateTimeKind.Local).AddTicks(2777), "User 4", "$2a$11$AYTYU6V1id4wceDO9pR9.uxXqG9pwVdvRkKKYeA0i4SxBIHob4enu", "0900000004" },
                    { 5, new DateOnly(1995, 6, 6), new DateTime(2025, 10, 10, 22, 39, 54, 872, DateTimeKind.Local).AddTicks(5979), null, "user5@yama.com", "Female", "https://via.placeholder.com/150?text=User5", false, 5, new DateTime(2025, 11, 4, 22, 39, 54, 872, DateTimeKind.Local).AddTicks(5989), "User 5", "$2a$11$vq2Wsk8r9fKZIvCTQrsgte1MdQVqj01JVY8SICHdSLrqA17LYFRfa", "0900000005" },
                    { 6, new DateOnly(1996, 7, 7), new DateTime(2025, 9, 30, 22, 39, 55, 88, DateTimeKind.Local).AddTicks(7048), null, "user6@yama.com", "Male", "https://via.placeholder.com/150?text=User6", false, 6, new DateTime(2025, 10, 30, 22, 39, 55, 88, DateTimeKind.Local).AddTicks(7060), "User 6", "$2a$11$.XTHTCixJrpJ1FLEr1WpeOV4Y/uyrw8PRJXPWDdIw05dYDPhqgsqi", "0900000006" },
                    { 7, new DateOnly(1997, 8, 8), new DateTime(2025, 9, 20, 22, 39, 55, 310, DateTimeKind.Local).AddTicks(2307), null, "user7@yama.com", "Female", "https://via.placeholder.com/150?text=User7", false, 7, new DateTime(2025, 10, 25, 22, 39, 55, 310, DateTimeKind.Local).AddTicks(2321), "User 7", "$2a$11$N95QCVdn9ymEzVQyzTqon.dTC21s3k2BDPQkswe56RWJz7CLWlch.", "0900000007" },
                    { 8, new DateOnly(1998, 9, 9), new DateTime(2025, 9, 10, 22, 39, 55, 529, DateTimeKind.Local).AddTicks(4687), null, "user8@yama.com", "Male", "https://via.placeholder.com/150?text=User8", false, 8, new DateTime(2025, 10, 20, 22, 39, 55, 529, DateTimeKind.Local).AddTicks(4704), "User 8", "$2a$11$hPKLVvRUvfQF0K8HyPdCPeqqdUZDEGN0igXovSAvUyILcx5I/3lUm", "0900000008" },
                    { 9, new DateOnly(1999, 10, 10), new DateTime(2025, 8, 31, 22, 39, 55, 751, DateTimeKind.Local).AddTicks(9539), null, "user9@yama.com", "Female", "https://via.placeholder.com/150?text=User9", false, 9, new DateTime(2025, 10, 15, 22, 39, 55, 751, DateTimeKind.Local).AddTicks(9549), "User 9", "$2a$11$LjmavFIREgZOq6G9lbuTVecR0EKgADiKw3Kq9Amk5pj5OzD1jb69W", "0900000009" },
                    { 10, new DateOnly(1990, 11, 11), new DateTime(2025, 8, 21, 22, 39, 55, 950, DateTimeKind.Local).AddTicks(94), null, "user10@yama.com", "Male", "https://via.placeholder.com/150?text=User10", false, 10, new DateTime(2025, 10, 10, 22, 39, 55, 950, DateTimeKind.Local).AddTicks(103), "User 10", "$2a$11$5mVb3IAF1j23Wo2y.GFCxuNTjBsAp.1DtF7wtCHvVSsPC6vh3o/3y", "0900000010" }
                });

            migrationBuilder.InsertData(
                table: "Attendance",
                columns: new[] { "Id", "CheckInTime", "CheckOutTime", "Date", "EarlyLeave", "EmployeeId", "LateArrival", "WorkHours" },
                values: new object[,]
                {
                    { 1, new TimeOnly(9, 0, 0), new TimeOnly(18, 0, 0), new DateOnly(2025, 11, 28), false, 1, false, 9m },
                    { 2, new TimeOnly(8, 0, 0), new TimeOnly(17, 0, 0), new DateOnly(2025, 11, 27), false, 2, false, 9m },
                    { 3, new TimeOnly(9, 0, 0), new TimeOnly(18, 0, 0), new DateOnly(2025, 11, 26), false, 3, false, 9m },
                    { 4, new TimeOnly(8, 0, 0), new TimeOnly(17, 0, 0), new DateOnly(2025, 11, 25), false, 4, false, 9m },
                    { 5, new TimeOnly(9, 0, 0), new TimeOnly(18, 0, 0), new DateOnly(2025, 11, 24), false, 5, true, 9m },
                    { 6, new TimeOnly(8, 0, 0), new TimeOnly(17, 0, 0), new DateOnly(2025, 11, 23), false, 6, false, 9m },
                    { 7, new TimeOnly(9, 0, 0), new TimeOnly(18, 0, 0), new DateOnly(2025, 11, 22), true, 7, false, 9m },
                    { 8, new TimeOnly(8, 0, 0), new TimeOnly(17, 0, 0), new DateOnly(2025, 11, 21), false, 8, false, 9m },
                    { 9, new TimeOnly(9, 0, 0), new TimeOnly(18, 0, 0), new DateOnly(2025, 11, 20), false, 9, false, 9m },
                    { 10, new TimeOnly(8, 0, 0), new TimeOnly(17, 0, 0), new DateOnly(2025, 11, 19), false, 10, true, 9m }
                });

            migrationBuilder.InsertData(
                table: "Booking",
                columns: new[] { "Id", "BookingDate", "BookingStatus", "CustomerName", "DayPart", "DepositPrice", "EmployeeId", "NewPaymentDate", "Note", "Phone", "RemainPayment", "TableId", "TotalPayment", "UserId", "VoucherId" },
                values: new object[,]
                {
                    { new Guid("10000000-0000-0000-0000-000000000001"), new DateOnly(2025, 11, 30), "Completed", "Customer 1", "Afternoon", 45m, null, new DateTime(2025, 11, 28, 22, 39, 58, 214, DateTimeKind.Local).AddTicks(9989), "Booking note 1", "0900000001", 105m, 1, 150m, 1, null },
                    { new Guid("10000000-0000-0000-0000-000000000002"), new DateOnly(2025, 12, 1), "Undeposited", "Customer 2", "Evening", 60m, null, new DateTime(2025, 11, 27, 22, 39, 58, 215, DateTimeKind.Local).AddTicks(2), "Booking note 2", "0900000002", 140m, 2, 200m, 2, null },
                    { new Guid("10000000-0000-0000-0000-000000000003"), new DateOnly(2025, 12, 2), "Booking", "Customer 3", "Morning", 75m, null, new DateTime(2025, 11, 26, 22, 39, 58, 215, DateTimeKind.Local).AddTicks(7), "Booking note 3", "0900000003", 175m, 3, 250m, 3, null },
                    { new Guid("10000000-0000-0000-0000-000000000004"), new DateOnly(2025, 12, 3), "Completed", "Customer 4", "Afternoon", 90m, null, new DateTime(2025, 11, 25, 22, 39, 58, 215, DateTimeKind.Local).AddTicks(11), "Booking note 4", "0900000004", 210m, 4, 300m, 4, null },
                    { new Guid("10000000-0000-0000-0000-000000000005"), new DateOnly(2025, 12, 4), "Undeposited", "Customer 5", "Evening", 105m, null, new DateTime(2025, 11, 24, 22, 39, 58, 215, DateTimeKind.Local).AddTicks(20), "Booking note 5", "0900000005", 245m, 5, 350m, 5, null },
                    { new Guid("10000000-0000-0000-0000-000000000006"), new DateOnly(2025, 12, 5), "Booking", "Customer 6", "Morning", 120m, null, new DateTime(2025, 11, 23, 22, 39, 58, 215, DateTimeKind.Local).AddTicks(27), "Booking note 6", "0900000006", 280m, 6, 400m, 6, null },
                    { new Guid("10000000-0000-0000-0000-000000000007"), new DateOnly(2025, 12, 6), "Completed", "Customer 7", "Afternoon", 135m, null, new DateTime(2025, 11, 22, 22, 39, 58, 215, DateTimeKind.Local).AddTicks(32), "Booking note 7", "0900000007", 315m, 7, 450m, 7, null },
                    { new Guid("10000000-0000-0000-0000-000000000008"), new DateOnly(2025, 12, 7), "Undeposited", "Customer 8", "Evening", 150m, null, new DateTime(2025, 11, 21, 22, 39, 58, 215, DateTimeKind.Local).AddTicks(36), "Booking note 8", "0900000008", 350m, 8, 500m, 8, null },
                    { new Guid("10000000-0000-0000-0000-000000000009"), new DateOnly(2025, 12, 8), "Booking", "Customer 9", "Morning", 165m, null, new DateTime(2025, 11, 20, 22, 39, 58, 215, DateTimeKind.Local).AddTicks(40), "Booking note 9", "0900000009", 385m, 9, 550m, 9, null },
                    { new Guid("10000000-0000-0000-0000-000000000010"), new DateOnly(2025, 12, 9), "Completed", "Customer 10", "Afternoon", 180m, null, new DateTime(2025, 11, 19, 22, 39, 58, 215, DateTimeKind.Local).AddTicks(46), "Booking note 10", "0900000010", 420m, 10, 600m, 10, null }
                });

            migrationBuilder.InsertData(
                table: "Contact",
                columns: new[] { "Id", "CreationDate", "FullName", "IsIgnored", "Message", "Respond", "Title", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 11, 27, 22, 39, 58, 214, DateTimeKind.Local).AddTicks(9499), "Contact User 1", false, "I have a question about your restaurant services. Can you help me with booking information?", null, "Inquiry 1: Question about services", 1 },
                    { 2, new DateTime(2025, 11, 25, 22, 39, 58, 214, DateTimeKind.Local).AddTicks(9506), "Contact User 2", false, "I have a question about your restaurant services. Can you help me with booking information?", "Thank you for your inquiry. We will get back to you soon.", "Inquiry 2: Question about services", 2 },
                    { 3, new DateTime(2025, 11, 23, 22, 39, 58, 214, DateTimeKind.Local).AddTicks(9509), "Contact User 3", true, "I have a question about your restaurant services. Can you help me with booking information?", null, "Inquiry 3: Question about services", 3 },
                    { 4, new DateTime(2025, 11, 21, 22, 39, 58, 214, DateTimeKind.Local).AddTicks(9512), "Contact User 4", false, "I have a question about your restaurant services. Can you help me with booking information?", "Thank you for your inquiry. We will get back to you soon.", "Inquiry 4: Question about services", 4 },
                    { 5, new DateTime(2025, 11, 19, 22, 39, 58, 214, DateTimeKind.Local).AddTicks(9514), "Contact User 5", false, "I have a question about your restaurant services. Can you help me with booking information?", null, "Inquiry 5: Question about services", 5 },
                    { 6, new DateTime(2025, 11, 17, 22, 39, 58, 214, DateTimeKind.Local).AddTicks(9517), "Contact User 6", true, "I have a question about your restaurant services. Can you help me with booking information?", "Thank you for your inquiry. We will get back to you soon.", "Inquiry 6: Question about services", 6 },
                    { 7, new DateTime(2025, 11, 15, 22, 39, 58, 214, DateTimeKind.Local).AddTicks(9520), "Contact User 7", false, "I have a question about your restaurant services. Can you help me with booking information?", null, "Inquiry 7: Question about services", 7 },
                    { 8, new DateTime(2025, 11, 13, 22, 39, 58, 214, DateTimeKind.Local).AddTicks(9523), "Contact User 8", false, "I have a question about your restaurant services. Can you help me with booking information?", "Thank you for your inquiry. We will get back to you soon.", "Inquiry 8: Question about services", 8 },
                    { 9, new DateTime(2025, 11, 11, 22, 39, 58, 214, DateTimeKind.Local).AddTicks(9525), "Contact User 9", true, "I have a question about your restaurant services. Can you help me with booking information?", null, "Inquiry 9: Question about services", 9 },
                    { 10, new DateTime(2025, 11, 9, 22, 39, 58, 214, DateTimeKind.Local).AddTicks(9579), "Contact User 10", false, "I have a question about your restaurant services. Can you help me with booking information?", "Thank you for your inquiry. We will get back to you soon.", "Inquiry 10: Question about services", 10 }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CreationDate", "DeletionDate", "Description", "Image", "IsDeleted", "ModificationDate", "Name", "Price", "StockQuantity", "SubCategoryId" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 10, 30, 22, 39, 58, 214, DateTimeKind.Local).AddTicks(8795), null, "Crispy Vietnamese spring rolls with fresh vegetables", "[\"https://via.placeholder.com/300?text=Spring\\u002BRolls\"]", false, new DateTime(2025, 10, 30, 22, 39, 58, 214, DateTimeKind.Local).AddTicks(8803), "Spring Rolls", 8.99m, 50, 1 },
                    { 2, new DateTime(2025, 11, 1, 22, 39, 58, 214, DateTimeKind.Local).AddTicks(8809), null, "Traditional Vietnamese beef noodle soup", "[\"https://via.placeholder.com/300?text=Pho\\u002BBo\"]", false, new DateTime(2025, 11, 1, 22, 39, 58, 214, DateTimeKind.Local).AddTicks(8810), "Pho Bo", 12.99m, 100, 3 },
                    { 3, new DateTime(2025, 11, 4, 22, 39, 58, 214, DateTimeKind.Local).AddTicks(8814), null, "Sweet mango with sticky rice and coconut milk", "[\"https://via.placeholder.com/300?text=Mango\\u002BRice\"]", false, new DateTime(2025, 11, 4, 22, 39, 58, 214, DateTimeKind.Local).AddTicks(8815), "Mango Sticky Rice", 6.99m, 30, 9 },
                    { 4, new DateTime(2025, 11, 9, 22, 39, 58, 214, DateTimeKind.Local).AddTicks(8818), null, "Mixed greens with house dressing", "[\"https://via.placeholder.com/300?text=Salad\"]", false, new DateTime(2025, 11, 9, 22, 39, 58, 214, DateTimeKind.Local).AddTicks(8818), "Fresh Garden Salad", 7.5m, 40, 2 },
                    { 5, new DateTime(2025, 11, 11, 22, 39, 58, 214, DateTimeKind.Local).AddTicks(8821), null, "Spicy and sour Thai soup with shrimp", "[\"https://via.placeholder.com/300?text=Tom\\u002BYum\"]", false, new DateTime(2025, 11, 11, 22, 39, 58, 214, DateTimeKind.Local).AddTicks(8822), "Tom Yum Soup", 9.99m, 60, 1 },
                    { 6, new DateTime(2025, 11, 14, 22, 39, 58, 214, DateTimeKind.Local).AddTicks(8824), null, "Classic Coca Cola soft drink", "[\"https://via.placeholder.com/300?text=Coca\\u002BCola\"]", false, new DateTime(2025, 11, 14, 22, 39, 58, 214, DateTimeKind.Local).AddTicks(8825), "Coca Cola", 2.5m, 200, 6 },
                    { 7, new DateTime(2025, 11, 17, 22, 39, 58, 214, DateTimeKind.Local).AddTicks(8828), null, "Premium red wine selection", "[\"https://via.placeholder.com/300?text=Red\\u002BWine\"]", false, new DateTime(2025, 11, 17, 22, 39, 58, 214, DateTimeKind.Local).AddTicks(8829), "Red Wine", 35m, 25, 7 },
                    { 8, new DateTime(2025, 11, 19, 22, 39, 58, 214, DateTimeKind.Local).AddTicks(8831), null, "Strong Vietnamese drip coffee with condensed milk", "[\"https://via.placeholder.com/300?text=Vietnamese\\u002BCoffee\"]", false, new DateTime(2025, 11, 19, 22, 39, 58, 214, DateTimeKind.Local).AddTicks(8832), "Vietnamese Coffee", 4.5m, 80, 8 },
                    { 9, new DateTime(2025, 11, 21, 22, 39, 58, 214, DateTimeKind.Local).AddTicks(8834), null, "Freshly squeezed orange juice", "[\"https://via.placeholder.com/300?text=Orange\\u002BJuice\"]", false, new DateTime(2025, 11, 21, 22, 39, 58, 214, DateTimeKind.Local).AddTicks(8835), "Orange Juice", 5m, 70, 6 },
                    { 10, new DateTime(2025, 11, 24, 22, 39, 58, 214, DateTimeKind.Local).AddTicks(8837), null, "Creamy mango smoothie with yogurt", "[\"https://via.placeholder.com/300?text=Mango\\u002BSmoothie\"]", false, new DateTime(2025, 11, 24, 22, 39, 58, 214, DateTimeKind.Local).AddTicks(8838), "Mango Smoothie", 6.5m, 55, 10 }
                });

            migrationBuilder.InsertData(
                table: "Salary",
                columns: new[] { "Id", "Deductions", "EmployeeId", "NetSalary", "PayDay" },
                values: new object[,]
                {
                    { 1, 120m, 1, 1080m, null },
                    { 2, 140m, 2, 1260m, new DateOnly(2025, 11, 19) },
                    { 3, 160m, 3, 1440m, null },
                    { 4, 180m, 4, 1620m, new DateOnly(2025, 11, 9) },
                    { 5, 200m, 5, 1800m, null },
                    { 6, 220m, 6, 1980m, new DateOnly(2025, 10, 30) },
                    { 7, 240m, 7, 2160m, null },
                    { 8, 260m, 8, 2340m, new DateOnly(2025, 10, 20) },
                    { 9, 280m, 9, 2520m, null },
                    { 10, 300m, 10, 2700m, new DateOnly(2025, 10, 10) }
                });

            migrationBuilder.InsertData(
                table: "UserVoucher",
                columns: new[] { "UserId", "VoucherId", "IsUsed" },
                values: new object[,]
                {
                    { 1, 1, false },
                    { 2, 2, false },
                    { 3, 3, true },
                    { 4, 4, false },
                    { 5, 5, false },
                    { 6, 6, true },
                    { 7, 7, false },
                    { 8, 8, false },
                    { 9, 9, true },
                    { 10, 10, false }
                });

            migrationBuilder.InsertData(
                table: "BookingDetail",
                columns: new[] { "Id", "BookingId", "CookingStatus", "ProductId", "Quantity", "UnitPrice" },
                values: new object[,]
                {
                    { 1, new Guid("10000000-0000-0000-0000-000000000001"), "Cooked", 1, 2, 15m },
                    { 2, new Guid("10000000-0000-0000-0000-000000000002"), "InTrouble", 2, 3, 20m },
                    { 3, new Guid("10000000-0000-0000-0000-000000000003"), "InCooking", 3, 4, 25m },
                    { 4, new Guid("10000000-0000-0000-0000-000000000004"), "Cooked", 4, 5, 30m },
                    { 5, new Guid("10000000-0000-0000-0000-000000000005"), "InTrouble", 5, 1, 35m },
                    { 6, new Guid("10000000-0000-0000-0000-000000000006"), "InCooking", 6, 2, 40m },
                    { 7, new Guid("10000000-0000-0000-0000-000000000007"), "Cooked", 7, 3, 45m },
                    { 8, new Guid("10000000-0000-0000-0000-000000000008"), "InTrouble", 8, 4, 50m },
                    { 9, new Guid("10000000-0000-0000-0000-000000000009"), "InCooking", 9, 5, 55m },
                    { 10, new Guid("10000000-0000-0000-0000-000000000010"), "Cooked", 10, 1, 60m }
                });

            migrationBuilder.InsertData(
                table: "FeedbackProduct",
                columns: new[] { "ProductId", "UserId", "CreationDate", "Message", "ModificationDate", "Rating" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2025, 11, 26, 22, 39, 58, 215, DateTimeKind.Local).AddTicks(586), "Great product! I really enjoyed this item. Would definitely order again.", null, 4m },
                    { 2, 2, new DateTime(2025, 11, 23, 22, 39, 58, 215, DateTimeKind.Local).AddTicks(592), "Great product! I really enjoyed this item. Would definitely order again.", null, 5m },
                    { 3, 3, new DateTime(2025, 11, 20, 22, 39, 58, 215, DateTimeKind.Local).AddTicks(593), "Great product! I really enjoyed this item. Would definitely order again.", null, 3m },
                    { 4, 4, new DateTime(2025, 11, 17, 22, 39, 58, 215, DateTimeKind.Local).AddTicks(595), "Great product! I really enjoyed this item. Would definitely order again.", null, 4m },
                    { 5, 5, new DateTime(2025, 11, 14, 22, 39, 58, 215, DateTimeKind.Local).AddTicks(666), "Great product! I really enjoyed this item. Would definitely order again.", null, 5m },
                    { 6, 6, new DateTime(2025, 11, 11, 22, 39, 58, 215, DateTimeKind.Local).AddTicks(669), "Great product! I really enjoyed this item. Would definitely order again.", null, 3m },
                    { 7, 7, new DateTime(2025, 11, 8, 22, 39, 58, 215, DateTimeKind.Local).AddTicks(670), "Great product! I really enjoyed this item. Would definitely order again.", null, 4m },
                    { 8, 8, new DateTime(2025, 11, 5, 22, 39, 58, 215, DateTimeKind.Local).AddTicks(672), "Great product! I really enjoyed this item. Would definitely order again.", null, 5m },
                    { 9, 9, new DateTime(2025, 11, 2, 22, 39, 58, 215, DateTimeKind.Local).AddTicks(673), "Great product! I really enjoyed this item. Would definitely order again.", null, 3m },
                    { 10, 10, new DateTime(2025, 10, 30, 22, 39, 58, 215, DateTimeKind.Local).AddTicks(676), "Great product! I really enjoyed this item. Would definitely order again.", null, 4m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Attendance_EmployeeId",
                table: "Attendance",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Booking_EmployeeId",
                table: "Booking",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Booking_TableId",
                table: "Booking",
                column: "TableId");

            migrationBuilder.CreateIndex(
                name: "IX_Booking_UserId",
                table: "Booking",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Booking_VoucherId",
                table: "Booking",
                column: "VoucherId");

            migrationBuilder.CreateIndex(
                name: "IX_BookingDetail_BookingId",
                table: "BookingDetail",
                column: "BookingId");

            migrationBuilder.CreateIndex(
                name: "IX_BookingDetail_ProductId",
                table: "BookingDetail",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Contact_UserId",
                table: "Contact",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_PositionId",
                table: "Employee",
                column: "PositionId");

            migrationBuilder.CreateIndex(
                name: "IX_FeedbackProduct_ProductId",
                table: "FeedbackProduct",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_SubCategoryId",
                table: "Product",
                column: "SubCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Salary_EmployeeId",
                table: "Salary",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_SubCategory_CategoryId",
                table: "SubCategory",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_User_MembershipId",
                table: "User",
                column: "MembershipId");

            migrationBuilder.CreateIndex(
                name: "IX_UserVoucher_VoucherId",
                table: "UserVoucher",
                column: "VoucherId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Attendance");

            migrationBuilder.DropTable(
                name: "BookingDetail");

            migrationBuilder.DropTable(
                name: "Contact");

            migrationBuilder.DropTable(
                name: "FeedbackProduct");

            migrationBuilder.DropTable(
                name: "Salary");

            migrationBuilder.DropTable(
                name: "UserVoucher");

            migrationBuilder.DropTable(
                name: "Booking");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "Table");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Voucher");

            migrationBuilder.DropTable(
                name: "SubCategory");

            migrationBuilder.DropTable(
                name: "Position");

            migrationBuilder.DropTable(
                name: "Membership");

            migrationBuilder.DropTable(
                name: "Category");
        }
    }
}
