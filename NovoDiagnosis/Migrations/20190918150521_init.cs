using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NovoDiagnosis.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    FullName = table.Column<string>(nullable: true),
                    StaffId = table.Column<string>(nullable: true),
                    Street = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Company",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Code = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Stateid = table.Column<long>(nullable: true),
                    Parentid = table.Column<long>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Website = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    Logoid = table.Column<int>(nullable: true),
                    SubscriptionStatus = table.Column<int>(nullable: true),
                    Plans = table.Column<string>(nullable: true),
                    AuthorizationStatus = table.Column<int>(nullable: true),
                    AuthorizationNote = table.Column<string>(nullable: true),
                    DisapprovalNote = table.Column<string>(nullable: true),
                    AuthorizedBy = table.Column<int>(nullable: true),
                    DisapprovedBy = table.Column<int>(nullable: true),
                    AuthorizedDate = table.Column<DateTime>(nullable: true),
                    DisapprovalDate = table.Column<DateTime>(nullable: true),
                    DeletionNote = table.Column<string>(nullable: true),
                    Guid = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true),
                    SubsidiaryId = table.Column<int>(nullable: true),
                    SiteId = table.Column<int>(nullable: true),
                    CompanyListPageId = table.Column<int>(nullable: true),
                    Status = table.Column<bool>(nullable: true),
                    LogoLink = table.Column<string>(nullable: true),
                    RegCode = table.Column<string>(nullable: true),
                    RegAgeLimit = table.Column<int>(nullable: true),
                    WeboperationMode = table.Column<bool>(nullable: true),
                    IsRenewal = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Company", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CompanyBenefit",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Companyid = table.Column<int>(nullable: true),
                    CompanyPlanid = table.Column<int>(nullable: true),
                    BenefitId = table.Column<int>(nullable: true),
                    BenefitLimit = table.Column<string>(nullable: true),
                    Guid = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true),
                    SiteId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyBenefit", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CompanyPlans",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Companyid = table.Column<int>(nullable: true),
                    Planid = table.Column<int>(nullable: true),
                    Planfriendlyname = table.Column<string>(nullable: true),
                    AnnualPremium = table.Column<decimal>(nullable: true),
                    Discountlump = table.Column<decimal>(nullable: true),
                    Discountperenrollee = table.Column<decimal>(nullable: true),
                    Createdby = table.Column<int>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    AuthorizationStatus = table.Column<int>(nullable: true),
                    AuthorizationNote = table.Column<string>(nullable: true),
                    AllowChildEnrollee = table.Column<bool>(nullable: true),
                    DisapprovalNote = table.Column<string>(nullable: true),
                    AuthorizedBy = table.Column<int>(nullable: true),
                    DisapprovedBy = table.Column<int>(nullable: true),
                    AuthorizedDate = table.Column<DateTime>(nullable: true),
                    DisapprovalDate = table.Column<DateTime>(nullable: true),
                    Status = table.Column<bool>(nullable: true),
                    Guid = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true),
                    SiteId = table.Column<int>(nullable: true),
                    MaxNoOfDependant = table.Column<int>(nullable: true),
                    ProviderConsession = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyPlans", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CompanySubsidiaries",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ParentcompanyId = table.Column<int>(nullable: true),
                    Subsidaryname = table.Column<string>(nullable: true),
                    Subsidaryprofile = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    Guid = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true),
                    SiteId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanySubsidiaries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Provider",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    StateId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Provider", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Staff",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CompanyId = table.Column<string>(nullable: true),
                    CompanySubsidiary = table.Column<int>(nullable: true),
                    StaffFullname = table.Column<string>(nullable: true),
                    StaffPlanid = table.Column<int>(nullable: true),
                    HasProfile = table.Column<bool>(nullable: true),
                    Profileid = table.Column<int>(nullable: true),
                    Createdby = table.Column<int>(nullable: true),
                    Guid = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true),
                    IsExpunged = table.Column<bool>(nullable: true),
                    StaffId = table.Column<string>(nullable: true),
                    NewStaffId = table.Column<int>(nullable: true),
                    StafflinkDate = table.Column<DateTime>(nullable: true),
                    StafflinkUser = table.Column<int>(nullable: true),
                    StaffJobId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staff", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "States",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_States", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    PasswordHash = table.Column<byte[]>(nullable: true),
                    PasswordSalt = table.Column<byte[]>(nullable: true),
                    CurrentEncryption = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: true),
                    LastLoginDate = table.Column<DateTime>(nullable: true),
                    LoginAttempts = table.Column<int>(nullable: true),
                    ResetPasswordGuid = table.Column<Guid>(nullable: true),
                    ResetPasswordExpiry = table.Column<DateTime>(nullable: true),
                    DisableNotifications = table.Column<bool>(nullable: true),
                    LastNotificationReadDate = table.Column<DateTime>(nullable: true),
                    Uiculture = table.Column<string>(nullable: true),
                    Mobilephone = table.Column<string>(nullable: true),
                    CugMobilephone = table.Column<string>(nullable: true),
                    Dob = table.Column<string>(nullable: true),
                    Guid = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CompanyBranch",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Statecode = table.Column<int>(nullable: true),
                    Branch = table.Column<string>(nullable: true),
                    Guid = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true),
                    CompanyId = table.Column<int>(nullable: true),
                    SiteId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyBranch", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CompanyBranch_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Enrollee",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Parentid = table.Column<int>(nullable: true),
                    Parentrelationship = table.Column<int>(nullable: true),
                    Policynumber = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    Surname = table.Column<string>(nullable: true),
                    Othernames = table.Column<string>(nullable: true),
                    Dob = table.Column<DateTime>(nullable: true),
                    Age = table.Column<int>(nullable: true),
                    Maritalstatus = table.Column<int>(nullable: true),
                    Occupation = table.Column<string>(nullable: true),
                    Sex = table.Column<int>(nullable: true),
                    Residentialaddress = table.Column<string>(nullable: true),
                    Stateid = table.Column<int>(nullable: true),
                    Lgaid = table.Column<int>(nullable: true),
                    Mobilenumber = table.Column<string>(nullable: true),
                    Emailaddress = table.Column<string>(nullable: true),
                    Sponsorshiptype = table.Column<int>(nullable: true),
                    Sponsorshiptypeothername = table.Column<string>(nullable: true),
                    Preexistingmedicalhistory = table.Column<string>(nullable: true),
                    Sponsorshiptypenote = table.Column<string>(nullable: true),
                    Companyid = table.Column<int>(nullable: true),
                    Subscriptionplanid = table.Column<int>(nullable: true),
                    Hasdependents = table.Column<bool>(nullable: true),
                    Specialidcardfield1 = table.Column<string>(nullable: true),
                    Specialidcardfield2 = table.Column<string>(nullable: true),
                    Specialidcardfield3 = table.Column<string>(nullable: true),
                    Staffprofileid = table.Column<int>(nullable: true),
                    Primaryprovider = table.Column<int>(nullable: true),
                    Status = table.Column<int>(nullable: true),
                    Hasactivesubscription = table.Column<bool>(nullable: true),
                    Isexpundged = table.Column<bool>(nullable: true),
                    ExpungeNote = table.Column<string>(nullable: true),
                    Expungedby = table.Column<int>(nullable: true),
                    Dateexpunged = table.Column<DateTime>(nullable: true),
                    Createdby = table.Column<int>(nullable: true),
                    Datereceived = table.Column<DateTime>(nullable: true),
                    Guid = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true),
                    EnrolleePassportId = table.Column<int>(nullable: true),
                    IdCardPrinted = table.Column<bool>(nullable: true),
                    RefPolicynumber = table.Column<string>(nullable: true),
                    HasRefPolicyNumber = table.Column<bool>(nullable: true),
                    Mobilenumber2 = table.Column<string>(nullable: true),
                    LastyearBirthdaymsgsent = table.Column<int>(nullable: true),
                    Bulkjobid = table.Column<int>(nullable: true),
                    Passphrase = table.Column<int>(nullable: true),
                    staffId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enrollee", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Enrollee_Staff_staffId",
                        column: x => x.staffId,
                        principalTable: "Staff",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DiagnosisDetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FullName = table.Column<string>(nullable: false),
                    StaffId = table.Column<string>(nullable: false),
                    Provider = table.Column<string>(nullable: false),
                    StateId = table.Column<int>(nullable: true),
                    Email = table.Column<string>(nullable: false),
                    PhoneNumber = table.Column<string>(nullable: false),
                    AppointmentDate = table.Column<string>(nullable: false),
                    AppointmentTime = table.Column<string>(nullable: false),
                    CompletedAnnualMedical = table.Column<bool>(nullable: false),
                    Approve = table.Column<bool>(nullable: false),
                    Reject = table.Column<bool>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    UpdatedOn = table.Column<DateTime>(nullable: false),
                    AuthorizationCode = table.Column<string>(nullable: true),
                    Recommendation = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    History = table.Column<string>(nullable: true),
                    PresentingComplain = table.Column<string>(nullable: true),
                    Diagnosis = table.Column<string>(nullable: true),
                    PlanTest = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiagnosisDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DiagnosisDetails_States_StateId",
                        column: x => x.StateId,
                        principalTable: "States",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyBranch_CompanyId",
                table: "CompanyBranch",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_DiagnosisDetails_StateId",
                table: "DiagnosisDetails",
                column: "StateId");

            migrationBuilder.CreateIndex(
                name: "IX_Enrollee_staffId",
                table: "Enrollee",
                column: "staffId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "CompanyBenefit");

            migrationBuilder.DropTable(
                name: "CompanyBranch");

            migrationBuilder.DropTable(
                name: "CompanyPlans");

            migrationBuilder.DropTable(
                name: "CompanySubsidiaries");

            migrationBuilder.DropTable(
                name: "DiagnosisDetails");

            migrationBuilder.DropTable(
                name: "Enrollee");

            migrationBuilder.DropTable(
                name: "Provider");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Company");

            migrationBuilder.DropTable(
                name: "States");

            migrationBuilder.DropTable(
                name: "Staff");
        }
    }
}
