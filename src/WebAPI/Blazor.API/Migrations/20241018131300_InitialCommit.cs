using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blazor.API.Migrations
{
    /// <inheritdoc />
    public partial class InitialCommit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AdminCalendar",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(3000)", maxLength: 3000, nullable: false),
                    Location = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    IsSelectAll = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__AdminCal__3214EC07BA9CA427", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AlternateContactDetail",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContactNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LeadId = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Alternat__3214EC07419EB5D0", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Carrier",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    Logo = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
                    IsACA = table.Column<bool>(type: "bit", nullable: false),
                    ShowInAdminGraph = table.Column<bool>(type: "bit", nullable: true),
                    GraphSequenceNumber = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Carrier__3214EC0779CE1219", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CountryMaster",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CountryCode = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CountryMaster", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CurrencyMaster",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CurrencyCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    CurrencyDisplayName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Currency__3214EC0770D9B049", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DesignationMaster",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Colour = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DesignationMaster", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmailTemplate",
                columns: table => new
                {
                    Id = table.Column<short>(type: "smallint", nullable: false),
                    Subject = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__EmailTem__3214EC07F76C4063", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Enquiry",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IPAddress = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IsRead = table.Column<bool>(type: "bit", nullable: false),
                    ReadDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Enquiry__3214EC07A04CE267", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FlagMaster",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FlagName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    FlagColor = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsStatic = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsDatetime = table.Column<bool>(type: "bit", nullable: true),
                    IsOtpMobile = table.Column<bool>(type: "bit", nullable: true),
                    IsOtpEmail = table.Column<bool>(type: "bit", nullable: true),
                    IsHidden = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    SequenceId = table.Column<int>(type: "int", nullable: true),
                    VisibleToAll = table.Column<bool>(type: "bit", nullable: true),
                    IsAdditionalField = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FlagMaster", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LeadCategoryMaster",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LeadCategory = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeadCategoryMaster", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LeadQualityMaster",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LeadQuality = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeadQualityMaster", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LeadSourceMaster",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsStatic = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeadSourceMaster", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LeadStoreCart",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<long>(type: "bigint", nullable: true),
                    NumberOfLeads = table.Column<int>(name: "NumberOfLeads ", type: "int", nullable: true),
                    IsLeadUnder20Days = table.Column<byte>(type: "tinyint", nullable: true),
                    LeadTypeId = table.Column<int>(type: "int", nullable: true),
                    PerLeadPrice = table.Column<double>(type: "float", nullable: true),
                    TotalPrice = table.Column<double>(type: "float", nullable: true),
                    Tax = table.Column<double>(type: "float", nullable: true),
                    Discount = table.Column<double>(type: "float", nullable: true),
                    GrantTotal = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__LeadStor__3214EC07782B12B3", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LeadStoreLeadTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LeadDescription = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Lead1To249 = table.Column<double>(type: "float", nullable: false),
                    Lead250To999 = table.Column<double>(type: "float", nullable: false),
                    Lead1000To4999 = table.Column<double>(type: "float", nullable: false),
                    Lead5000To9999 = table.Column<double>(type: "float", nullable: false),
                    Lead10000To24999 = table.Column<double>(type: "float", nullable: false),
                    Lead25000Plus = table.Column<double>(type: "float", nullable: false),
                    NewLeadsPrice = table.Column<double>(type: "float", nullable: false),
                    LeadTypeIdForExcel = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__LeadStor__3214EC07E34DFAB9", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Menu",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    MainMenuId = table.Column<long>(type: "bigint", nullable: true),
                    SequenceId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Menu__3214EC07B3F86410", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MenuItem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MenuName = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    SubMenuName = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    MenuIcon = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    MenuUrl = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
                    IsActvie = table.Column<bool>(type: "bit", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    SubMenuIcon = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    MenuOrder = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuItems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PriorityMaster",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Color = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PriorityMaster", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserTimeZones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TimeZone = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DisplayOnSite = table.Column<byte>(type: "tinyint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__TimeZone__3214EC071A1AFF4D", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarrierId = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    MenuId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Product__3214EC07769913E7", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Product_Carrier_CarrierId",
                        column: x => x.CarrierId,
                        principalTable: "Carrier",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "StateMaster",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CountryID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StateMaster", x => x.ID);
                    table.ForeignKey(
                        name: "FK_StateMaster_CountryMaster",
                        column: x => x.CountryID,
                        principalTable: "CountryMaster",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "DesignationPermission",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DesignationPermissionId = table.Column<int>(type: "int", nullable: false),
                    DesignationId = table.Column<long>(type: "bigint", nullable: false),
                    CreationOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatorBy = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DesignationPermission", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DesignationPermission_DesignationPermission",
                        column: x => x.DesignationId,
                        principalTable: "DesignationMaster",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AdditionalFieldData",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FlagId = table.Column<long>(type: "bigint", nullable: false),
                    FieldName = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: false),
                    FieldType = table.Column<int>(type: "int", nullable: false),
                    Required = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "('0')"),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdateOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Addition__3214EC075D6ACCE9", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FlagMaster",
                        column: x => x.FlagId,
                        principalTable: "FlagMaster",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "LeadStoreOrderDetails",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<long>(type: "bigint", nullable: true),
                    CartId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    OrderNumber = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__LeadStor__3214EC0719F50B6E", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LeadStoreOrderDetails_LeadStoreCart_CartId",
                        column: x => x.CartId,
                        principalTable: "LeadStoreCart",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "LeadStoreFilter",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LeadTypeId = table.Column<int>(type: "int", nullable: true),
                    StateFilterId = table.Column<long>(type: "bigint", nullable: true),
                    ZipCodeFilterId = table.Column<long>(type: "bigint", nullable: true),
                    MinAge = table.Column<int>(type: "int", nullable: true),
                    MaxAge = table.Column<int>(type: "int", nullable: true),
                    LeadAge = table.Column<int>(type: "int", nullable: true),
                    PhoneNumberPreference = table.Column<byte>(type: "tinyint", nullable: true),
                    States = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__LeadStor__3214EC07DF6A314D", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LeadStoreFilter_LeadStoreLeadTypes_LeadTypeId",
                        column: x => x.LeadTypeId,
                        principalTable: "LeadStoreLeadTypes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UserLogin",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PasswordSalt = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    RoleType = table.Column<int>(type: "int", nullable: false),
                    IsVerifiedEmail = table.Column<bool>(type: "bit", nullable: false),
                    IsVerified = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    ForgetPasswordLink = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    ForgetPasswordExpirationDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    LastLoginDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    LastPasswordChangeDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLogin", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserLogin_Role",
                        column: x => x.RoleType,
                        principalTable: "Role",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Plan",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Plan__3214EC07531D2761", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Plan_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AdminLead",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Mobile = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    StateId = table.Column<int>(type: "int", nullable: true),
                    City = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    ZipCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    AgencyName = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    IsUser = table.Column<bool>(type: "bit", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__AdminLea__3214EC078FE49EDF", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Adminlead_StateMaster",
                        column: x => x.StateId,
                        principalTable: "StateMaster",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Agency",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Code = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    NPN = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Logo = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    ModifyDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    StateId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agency", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Agency_StateMaster_StateId",
                        column: x => x.StateId,
                        principalTable: "StateMaster",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "CityMaster",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    StateID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CityMaster", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CityMaster_StateMaster",
                        column: x => x.StateID,
                        principalTable: "StateMaster",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "AdminDocuments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FileName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FileExt = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FileType = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    FileDescription = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    AddedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserId = table.Column<long>(type: "bigint", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__AdminDoc__3214EC07184B8360", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AdminDocuments_UserLogin_AddedBy",
                        column: x => x.AddedBy,
                        principalTable: "UserLogin",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CultureMaster",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CurrencyCodeId = table.Column<int>(type: "int", nullable: false),
                    DateFormat = table.Column<int>(type: "int", nullable: false),
                    TimeFormat = table.Column<int>(type: "int", nullable: false),
                    Language = table.Column<int>(type: "int", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__CultureM__3214EC0712CD20F2", x => x.Id);
                    table.ForeignKey(
                        name: "FK__CultureMa__Curre__3F865F66",
                        column: x => x.CurrencyCodeId,
                        principalTable: "CurrencyMaster",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK__CultureMa__Modif__407A839F",
                        column: x => x.ModifiedBy,
                        principalTable: "UserLogin",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "LeadComment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LeadId = table.Column<int>(type: "int", nullable: false),
                    StatusType = table.Column<int>(type: "int", nullable: true),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AddedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__LeadComm__3214EC07D574C019", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LeadComment_UserLogin_AddedBy",
                        column: x => x.AddedBy,
                        principalTable: "UserLogin",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "LeadConversation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LeadId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AddedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__LeadConv__3214EC076824A4FA", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LeadConversation_UserLogin_AddedBy",
                        column: x => x.AddedBy,
                        principalTable: "UserLogin",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "LeadEvent",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LeadId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EventDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__LeadEven__3214EC074AA76B8C", x => x.Id);
                    table.ForeignKey(
                        name: "FK__LeadEvent__Creat__100C566E",
                        column: x => x.CreatedBy,
                        principalTable: "UserLogin",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK__LeadEvent__UserI__0F183235",
                        column: x => x.UserId,
                        principalTable: "UserLogin",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "LeadFile",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LeadId = table.Column<int>(type: "int", nullable: false),
                    FileName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FileExt = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FileType = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    AddedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__LeadFile__3214EC07F8284F53", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LeadFile_UserLogin_AddedBy",
                        column: x => x.AddedBy,
                        principalTable: "UserLogin",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "LeadStoreLog",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExcelPath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LogPath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AddedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FileName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__LeadStor__3214EC07841DB80E", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LeadStoreLog_UserLogin_AddedBy",
                        column: x => x.AddedBy,
                        principalTable: "UserLogin",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "StatePlan",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlanId = table.Column<long>(type: "bigint", nullable: false),
                    StateId = table.Column<int>(type: "int", nullable: false),
                    PlanType = table.Column<byte>(type: "tinyint", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__StatePla__3214EC071C84F4FA", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StatePlan_Plan_PlanId",
                        column: x => x.PlanId,
                        principalTable: "Plan",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_StatePlan_StateMaster_StateId",
                        column: x => x.StateId,
                        principalTable: "StateMaster",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "AdminLeadComment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdminLeadId = table.Column<int>(type: "int", nullable: false),
                    StatusType = table.Column<int>(type: "int", nullable: true),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AddedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__AdminLea__3214EC070D4955C3", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AdminLeadComment_AdminLead_AdminLeadId",
                        column: x => x.AdminLeadId,
                        principalTable: "AdminLead",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AdminLeadComment_UserLogin_AddedBy",
                        column: x => x.AddedBy,
                        principalTable: "UserLogin",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AdminLeadConversation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdminLeadId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AddedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__AdminLea__3214EC07C1183B7A", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AdminLeadConversation_AdminLead_LeadId",
                        column: x => x.AdminLeadId,
                        principalTable: "AdminLead",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AdminLeadConversation_UserLogin_AddedBy",
                        column: x => x.AddedBy,
                        principalTable: "UserLogin",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AdminLeadFile",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdminLeadId = table.Column<int>(type: "int", nullable: false),
                    FileName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FileExt = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FileType = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    AddedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__AdminLea__3214EC0780B7927A", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AdminLeadFile_AdminLead_AdminLeadId",
                        column: x => x.AdminLeadId,
                        principalTable: "AdminLead",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AdminLeadFile_UserLogin_AddedBy",
                        column: x => x.AddedBy,
                        principalTable: "UserLogin",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AdminLeadNote",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdminLeadId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__AdminLea__3214EC070E576B11", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AdminLeadNote_AdminLead_AdminLeadId",
                        column: x => x.AdminLeadId,
                        principalTable: "AdminLead",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AdminLeadNote_UserLogin_AddedBy",
                        column: x => x.AddedBy,
                        principalTable: "UserLogin",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AgencyAppointment",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AgencyId = table.Column<long>(type: "bigint", nullable: false),
                    StateId = table.Column<int>(type: "int", nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    FEIN = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    LineOfAuthority = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    LOACode = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    COcode = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Status = table.Column<byte>(type: "tinyint", nullable: true),
                    TerminationReason = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ReasonDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    RenewalDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__AgencyAp__3214EC07F1726F3E", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AgencyAppointment_Agency_AgencyId",
                        column: x => x.AgencyId,
                        principalTable: "Agency",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AgencyAppointment_StateMaster_StateId",
                        column: x => x.StateId,
                        principalTable: "StateMaster",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "AgencyLicense",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AgencyId = table.Column<long>(type: "bigint", nullable: false),
                    StateId = table.Column<int>(type: "int", nullable: false),
                    LicenseNo = table.Column<long>(type: "bigint", nullable: false),
                    DateIssue = table.Column<DateTime>(type: "datetime", nullable: false),
                    DateExpire = table.Column<DateTime>(type: "datetime", nullable: true),
                    Class = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    IsResidency = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__AgencyLi__3214EC0704597115", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AgencyLicense_Agency_AgencyId",
                        column: x => x.AgencyId,
                        principalTable: "Agency",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AgencyLicense_StateMaster_StateId",
                        column: x => x.StateId,
                        principalTable: "StateMaster",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "AgencyState",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AgencyId = table.Column<long>(type: "bigint", nullable: false),
                    StateId = table.Column<int>(type: "int", nullable: false),
                    SaleStatusType = table.Column<byte>(type: "tinyint", nullable: false),
                    LicenseNo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DateIssue = table.Column<DateTime>(type: "datetime", nullable: true),
                    DateExpire = table.Column<DateTime>(type: "datetime", nullable: true),
                    Class = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    ResidencyStatus = table.Column<byte>(type: "tinyint", nullable: true),
                    Status = table.Column<byte>(type: "tinyint", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime", nullable: false),
                    Modified = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__AgencySt__3214EC07DF81EAA3", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AgencyState_Agency_AgencyId",
                        column: x => x.AgencyId,
                        principalTable: "Agency",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AgencyState_StateMaster_StateId",
                        column: x => x.StateId,
                        principalTable: "StateMaster",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserLoginId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Mobile = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DOB = table.Column<DateTime>(type: "datetime", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Short_Url = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    Logo = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    TimeZoneId = table.Column<byte>(type: "tinyint", nullable: true),
                    CountryId = table.Column<int>(type: "int", nullable: true),
                    StateId = table.Column<int>(type: "int", nullable: true),
                    CityId = table.Column<int>(type: "int", nullable: true),
                    ZipCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DesignationId = table.Column<long>(type: "bigint", nullable: true),
                    Colour = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ParentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    BodyBackGroundColor = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    HeaderBackGroundColor = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NavigationBackGroundColor = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NavigationtextColor = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SubNavigationBGColor = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FooterBackGroundColor = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FooterTitleColor = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FooterTextColorH = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NavigationtextSize = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FooterTitleTextSize = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FacebookLink = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    TwitterLink = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    LinkedInLink = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    GooglePlusLink = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ProfilePic = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    LeadStoreFilterId = table.Column<long>(type: "bigint", nullable: true),
                    IsHealthNavigator = table.Column<byte>(type: "tinyint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Users__3214EC079F6CC205", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_CityMaster",
                        column: x => x.CityId,
                        principalTable: "CityMaster",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Users_Country",
                        column: x => x.CountryId,
                        principalTable: "CountryMaster",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Users_DesignationMaster",
                        column: x => x.DesignationId,
                        principalTable: "DesignationMaster",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Users_StateMaster_StateId",
                        column: x => x.StateId,
                        principalTable: "StateMaster",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Users_UserLogin",
                        column: x => x.ParentId,
                        principalTable: "UserLogin",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Users_UserLogin_UserLoginId",
                        column: x => x.UserLoginId,
                        principalTable: "UserLogin",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Leads",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MobileNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CountryId = table.Column<int>(type: "int", nullable: true),
                    StateId = table.Column<int>(type: "int", nullable: true),
                    CityId = table.Column<int>(type: "int", nullable: true),
                    ZipCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    GenderType = table.Column<byte>(type: "tinyint", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    isSold = table.Column<byte>(type: "tinyint", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    LogId = table.Column<long>(type: "bigint", nullable: true),
                    LeadsCartId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    OrderNumber = table.Column<string>(type: "nchar(12)", fixedLength: true, maxLength: 12, nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LeadSourceId = table.Column<long>(type: "bigint", nullable: false),
                    FlagId = table.Column<long>(type: "bigint", nullable: false),
                    PriorityId = table.Column<long>(type: "bigint", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    MobileOTP = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    EmailOTP = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    TempEmailOTP = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    EmailOTPTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    TempMobileOTP = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    MobileOTPTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    LeadAssignedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    LeadQualityId = table.Column<long>(type: "bigint", nullable: true),
                    LeadCategoryId = table.Column<long>(type: "bigint", nullable: true),
                    CRMType = table.Column<int>(type: "int", nullable: true),
                    LeadParentId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__LeadStor__3214EC07BAAD59DD", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Leads_CityMaster",
                        column: x => x.CityId,
                        principalTable: "CityMaster",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Leads_CountryMaster",
                        column: x => x.CountryId,
                        principalTable: "CountryMaster",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Leads_FlagMaster",
                        column: x => x.FlagId,
                        principalTable: "FlagMaster",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Leads_LeadSourceMaster",
                        column: x => x.LeadSourceId,
                        principalTable: "LeadSourceMaster",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Leads_LeadsLog_LogId",
                        column: x => x.LogId,
                        principalTable: "LeadStoreLog",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Leads_PriorityMaster",
                        column: x => x.PriorityId,
                        principalTable: "PriorityMaster",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Leads_StateMaster_StateId",
                        column: x => x.StateId,
                        principalTable: "StateMaster",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Leads_UserLogin",
                        column: x => x.UserId,
                        principalTable: "UserLogin",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK__Leads__LeadCateg__51A50FA1",
                        column: x => x.LeadCategoryId,
                        principalTable: "LeadCategoryMaster",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK__Leads__LeadQuali__529933DA",
                        column: x => x.LeadQualityId,
                        principalTable: "LeadQualityMaster",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AdminCalendarUsers",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdminCalendarId = table.Column<long>(type: "bigint", nullable: false),
                    UserId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__AdminCal__3214EC071BE00BA9", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AdminCalendarUsers_AdminCalendar_AdminCalendarId",
                        column: x => x.AdminCalendarId,
                        principalTable: "AdminCalendar",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AdminCalendarUsers_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AdminNotes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__AdminNot__3214EC07C9886EB7", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AdminNotes_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UserCalendar",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(3000)", maxLength: 3000, nullable: false),
                    Location = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__UserCal__3214EC079BE6D23D", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserCalendar_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UserCarrier",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    CarrierId = table.Column<long>(type: "bigint", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CarrierUserId = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__UserCar__3214EC07A2C78AB2", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserCarrier_Carrier_CarrierId",
                        column: x => x.CarrierId,
                        principalTable: "Carrier",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserCarrier_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UserOpportunity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: false),
                    MiddleName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MobileNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Address1 = table.Column<string>(type: "nvarchar(1500)", maxLength: 1500, nullable: false),
                    Address2 = table.Column<string>(type: "nvarchar(1500)", maxLength: 1500, nullable: false),
                    StateId = table.Column<int>(type: "int", nullable: true),
                    City = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ZipCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    GenderType = table.Column<byte>(type: "tinyint", nullable: true),
                    Height = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Weight = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: true),
                    OpportunityStatus = table.Column<byte>(type: "tinyint", nullable: true),
                    LeadStatus = table.Column<byte>(type: "tinyint", nullable: true),
                    Source = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MotherMaidenName = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: false),
                    DriverLicenseNumber = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Occupation = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__UserOpp__3214EC07C44A62BC", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserOpportunity_StateMaster_StateId",
                        column: x => x.StateId,
                        principalTable: "StateMaster",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_UserOpportunity_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UserProduct",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    CarrierId = table.Column<long>(type: "bigint", nullable: false),
                    ProductId = table.Column<long>(type: "bigint", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__UserPro__3214EC070E320F34", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserProduct_Carrier_CarrierId",
                        column: x => x.CarrierId,
                        principalTable: "Carrier",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserProduct_Product",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserProduct_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "LeadNote",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LeadId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__LeadNote__3214EC0781F49184", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LeadNote_Leads",
                        column: x => x.LeadId,
                        principalTable: "Leads",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_LeadNote_UserLogin_AddedBy",
                        column: x => x.AddedBy,
                        principalTable: "UserLogin",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "LeadsLog",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LeadId = table.Column<int>(type: "int", nullable: false),
                    Action = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FlagId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__LeadStor__3214EC07893EBD7C", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LeadsLog_Leads",
                        column: x => x.LeadId,
                        principalTable: "Leads",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_LeadsLog_UserLogin",
                        column: x => x.CreatedBy,
                        principalTable: "UserLogin",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_LeadsLog_UserLogin1",
                        column: x => x.ModifiedBy,
                        principalTable: "UserLogin",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK__LeadsLog__FlagId__416EA7D8",
                        column: x => x.FlagId,
                        principalTable: "FlagMaster",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "StatusUpdateMaster",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LeadId = table.Column<int>(type: "int", nullable: false),
                    FlagId = table.Column<long>(type: "bigint", nullable: false),
                    StatusUpdateRecords = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__StatusUp__3214EC07AFE3B139", x => x.Id);
                    table.ForeignKey(
                        name: "FK__StatusUpd__FlagI__679450C0",
                        column: x => x.FlagId,
                        principalTable: "FlagMaster",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK__StatusUpd__LeadI__66A02C87",
                        column: x => x.LeadId,
                        principalTable: "Leads",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AdditionalFieldData_FlagId",
                table: "AdditionalFieldData",
                column: "FlagId");

            migrationBuilder.CreateIndex(
                name: "IX_AdminCalendarUsers_AdminCalendarId",
                table: "AdminCalendarUsers",
                column: "AdminCalendarId");

            migrationBuilder.CreateIndex(
                name: "IX_AdminCalendarUsers_UserId",
                table: "AdminCalendarUsers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AdminDocuments_AddedBy",
                table: "AdminDocuments",
                column: "AddedBy");

            migrationBuilder.CreateIndex(
                name: "IX_AdminLead_StateId",
                table: "AdminLead",
                column: "StateId");

            migrationBuilder.CreateIndex(
                name: "IX_AdminLeadComment_AddedBy",
                table: "AdminLeadComment",
                column: "AddedBy");

            migrationBuilder.CreateIndex(
                name: "IX_AdminLeadComment_AdminLeadId",
                table: "AdminLeadComment",
                column: "AdminLeadId");

            migrationBuilder.CreateIndex(
                name: "IX_AdminLeadConversation_AddedBy",
                table: "AdminLeadConversation",
                column: "AddedBy");

            migrationBuilder.CreateIndex(
                name: "IX_AdminLeadConversation_AdminLeadId",
                table: "AdminLeadConversation",
                column: "AdminLeadId");

            migrationBuilder.CreateIndex(
                name: "IX_AdminLeadFile_AddedBy",
                table: "AdminLeadFile",
                column: "AddedBy");

            migrationBuilder.CreateIndex(
                name: "IX_AdminLeadFile_AdminLeadId",
                table: "AdminLeadFile",
                column: "AdminLeadId");

            migrationBuilder.CreateIndex(
                name: "IX_AdminLeadNote_AddedBy",
                table: "AdminLeadNote",
                column: "AddedBy");

            migrationBuilder.CreateIndex(
                name: "IX_AdminLeadNote_AdminLeadId",
                table: "AdminLeadNote",
                column: "AdminLeadId");

            migrationBuilder.CreateIndex(
                name: "IX_AdminNotes_UserId",
                table: "AdminNotes",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Agency_StateId",
                table: "Agency",
                column: "StateId");

            migrationBuilder.CreateIndex(
                name: "IX_AgencyAppointment_AgencyId",
                table: "AgencyAppointment",
                column: "AgencyId");

            migrationBuilder.CreateIndex(
                name: "IX_AgencyAppointment_StateId",
                table: "AgencyAppointment",
                column: "StateId");

            migrationBuilder.CreateIndex(
                name: "IX_AgencyLicense_AgencyId",
                table: "AgencyLicense",
                column: "AgencyId");

            migrationBuilder.CreateIndex(
                name: "IX_AgencyLicense_StateId",
                table: "AgencyLicense",
                column: "StateId");

            migrationBuilder.CreateIndex(
                name: "IX_AgencyState_AgencyId",
                table: "AgencyState",
                column: "AgencyId");

            migrationBuilder.CreateIndex(
                name: "IX_AgencyState_StateId",
                table: "AgencyState",
                column: "StateId");

            migrationBuilder.CreateIndex(
                name: "IX_CityMaster_StateID",
                table: "CityMaster",
                column: "StateID");

            migrationBuilder.CreateIndex(
                name: "IX_CultureMaster_CurrencyCodeId",
                table: "CultureMaster",
                column: "CurrencyCodeId");

            migrationBuilder.CreateIndex(
                name: "IX_CultureMaster_ModifiedBy",
                table: "CultureMaster",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_DesignationPermission_DesignationId",
                table: "DesignationPermission",
                column: "DesignationId");

            migrationBuilder.CreateIndex(
                name: "IX_LeadComment_AddedBy",
                table: "LeadComment",
                column: "AddedBy");

            migrationBuilder.CreateIndex(
                name: "IX_LeadConversation_AddedBy",
                table: "LeadConversation",
                column: "AddedBy");

            migrationBuilder.CreateIndex(
                name: "IX_LeadEvent_CreatedBy",
                table: "LeadEvent",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_LeadEvent_UserId",
                table: "LeadEvent",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_LeadFile_AddedBy",
                table: "LeadFile",
                column: "AddedBy");

            migrationBuilder.CreateIndex(
                name: "IX_LeadNote_AddedBy",
                table: "LeadNote",
                column: "AddedBy");

            migrationBuilder.CreateIndex(
                name: "IX_LeadNote_LeadId",
                table: "LeadNote",
                column: "LeadId");

            migrationBuilder.CreateIndex(
                name: "IX_Leads_CityId",
                table: "Leads",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Leads_CountryId",
                table: "Leads",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Leads_FlagId",
                table: "Leads",
                column: "FlagId");

            migrationBuilder.CreateIndex(
                name: "IX_Leads_LeadCategoryId",
                table: "Leads",
                column: "LeadCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Leads_LeadQualityId",
                table: "Leads",
                column: "LeadQualityId");

            migrationBuilder.CreateIndex(
                name: "IX_Leads_LeadSourceId",
                table: "Leads",
                column: "LeadSourceId");

            migrationBuilder.CreateIndex(
                name: "IX_Leads_LogId",
                table: "Leads",
                column: "LogId");

            migrationBuilder.CreateIndex(
                name: "IX_Leads_PriorityId",
                table: "Leads",
                column: "PriorityId");

            migrationBuilder.CreateIndex(
                name: "IX_Leads_StateId",
                table: "Leads",
                column: "StateId");

            migrationBuilder.CreateIndex(
                name: "IX_Leads_UserId",
                table: "Leads",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_LeadsLog_CreatedBy",
                table: "LeadsLog",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_LeadsLog_FlagId",
                table: "LeadsLog",
                column: "FlagId");

            migrationBuilder.CreateIndex(
                name: "IX_LeadsLog_LeadId",
                table: "LeadsLog",
                column: "LeadId");

            migrationBuilder.CreateIndex(
                name: "IX_LeadsLog_ModifiedBy",
                table: "LeadsLog",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_LeadStoreFilter_LeadTypeId",
                table: "LeadStoreFilter",
                column: "LeadTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_LeadStoreLog_AddedBy",
                table: "LeadStoreLog",
                column: "AddedBy");

            migrationBuilder.CreateIndex(
                name: "IX_LeadStoreOrderDetails_CartId",
                table: "LeadStoreOrderDetails",
                column: "CartId");

            migrationBuilder.CreateIndex(
                name: "IX_Plan_ProductId",
                table: "Plan",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_CarrierId",
                table: "Product",
                column: "CarrierId");

            migrationBuilder.CreateIndex(
                name: "IX_StateMaster_CountryID",
                table: "StateMaster",
                column: "CountryID");

            migrationBuilder.CreateIndex(
                name: "IX_StatePlan_PlanId",
                table: "StatePlan",
                column: "PlanId");

            migrationBuilder.CreateIndex(
                name: "IX_StatePlan_StateId",
                table: "StatePlan",
                column: "StateId");

            migrationBuilder.CreateIndex(
                name: "IX_StatusUpdateMaster_FlagId",
                table: "StatusUpdateMaster",
                column: "FlagId");

            migrationBuilder.CreateIndex(
                name: "IX_StatusUpdateMaster_LeadId",
                table: "StatusUpdateMaster",
                column: "LeadId");

            migrationBuilder.CreateIndex(
                name: "IX_UserCalendar_UserId",
                table: "UserCalendar",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserCarrier_CarrierId",
                table: "UserCarrier",
                column: "CarrierId");

            migrationBuilder.CreateIndex(
                name: "IX_UserCarrier_UserId",
                table: "UserCarrier",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserLogin_RoleType",
                table: "UserLogin",
                column: "RoleType");

            migrationBuilder.CreateIndex(
                name: "IX_UserOpportunity_StateId",
                table: "UserOpportunity",
                column: "StateId");

            migrationBuilder.CreateIndex(
                name: "IX_UserOpportunity_UserId",
                table: "UserOpportunity",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserProduct_CarrierId",
                table: "UserProduct",
                column: "CarrierId");

            migrationBuilder.CreateIndex(
                name: "IX_UserProduct_ProductId",
                table: "UserProduct",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_UserProduct_UserId",
                table: "UserProduct",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_CityId",
                table: "Users",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_CountryId",
                table: "Users",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_DesignationId",
                table: "Users",
                column: "DesignationId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_ParentId",
                table: "Users",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_StateId",
                table: "Users",
                column: "StateId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_UserLoginId",
                table: "Users",
                column: "UserLoginId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdditionalFieldData");

            migrationBuilder.DropTable(
                name: "AdminCalendarUsers");

            migrationBuilder.DropTable(
                name: "AdminDocuments");

            migrationBuilder.DropTable(
                name: "AdminLeadComment");

            migrationBuilder.DropTable(
                name: "AdminLeadConversation");

            migrationBuilder.DropTable(
                name: "AdminLeadFile");

            migrationBuilder.DropTable(
                name: "AdminLeadNote");

            migrationBuilder.DropTable(
                name: "AdminNotes");

            migrationBuilder.DropTable(
                name: "AgencyAppointment");

            migrationBuilder.DropTable(
                name: "AgencyLicense");

            migrationBuilder.DropTable(
                name: "AgencyState");

            migrationBuilder.DropTable(
                name: "AlternateContactDetail");

            migrationBuilder.DropTable(
                name: "CultureMaster");

            migrationBuilder.DropTable(
                name: "DesignationPermission");

            migrationBuilder.DropTable(
                name: "EmailTemplate");

            migrationBuilder.DropTable(
                name: "Enquiry");

            migrationBuilder.DropTable(
                name: "LeadComment");

            migrationBuilder.DropTable(
                name: "LeadConversation");

            migrationBuilder.DropTable(
                name: "LeadEvent");

            migrationBuilder.DropTable(
                name: "LeadFile");

            migrationBuilder.DropTable(
                name: "LeadNote");

            migrationBuilder.DropTable(
                name: "LeadsLog");

            migrationBuilder.DropTable(
                name: "LeadStoreFilter");

            migrationBuilder.DropTable(
                name: "LeadStoreOrderDetails");

            migrationBuilder.DropTable(
                name: "Menu");

            migrationBuilder.DropTable(
                name: "MenuItem");

            migrationBuilder.DropTable(
                name: "StatePlan");

            migrationBuilder.DropTable(
                name: "StatusUpdateMaster");

            migrationBuilder.DropTable(
                name: "UserCalendar");

            migrationBuilder.DropTable(
                name: "UserCarrier");

            migrationBuilder.DropTable(
                name: "UserOpportunity");

            migrationBuilder.DropTable(
                name: "UserProduct");

            migrationBuilder.DropTable(
                name: "UserTimeZones");

            migrationBuilder.DropTable(
                name: "AdminCalendar");

            migrationBuilder.DropTable(
                name: "AdminLead");

            migrationBuilder.DropTable(
                name: "Agency");

            migrationBuilder.DropTable(
                name: "CurrencyMaster");

            migrationBuilder.DropTable(
                name: "LeadStoreLeadTypes");

            migrationBuilder.DropTable(
                name: "LeadStoreCart");

            migrationBuilder.DropTable(
                name: "Plan");

            migrationBuilder.DropTable(
                name: "Leads");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "FlagMaster");

            migrationBuilder.DropTable(
                name: "LeadSourceMaster");

            migrationBuilder.DropTable(
                name: "LeadStoreLog");

            migrationBuilder.DropTable(
                name: "PriorityMaster");

            migrationBuilder.DropTable(
                name: "LeadCategoryMaster");

            migrationBuilder.DropTable(
                name: "LeadQualityMaster");

            migrationBuilder.DropTable(
                name: "CityMaster");

            migrationBuilder.DropTable(
                name: "DesignationMaster");

            migrationBuilder.DropTable(
                name: "Carrier");

            migrationBuilder.DropTable(
                name: "UserLogin");

            migrationBuilder.DropTable(
                name: "StateMaster");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "CountryMaster");
        }
    }
}
