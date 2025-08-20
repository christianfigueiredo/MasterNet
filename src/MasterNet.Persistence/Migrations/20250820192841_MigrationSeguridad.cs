using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MasterNet.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class MigrationSeguridad : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("0db141f4-4ab4-49c2-a5c5-062d7af11749"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("2e214b2a-53bd-4b0d-b2a8-af7c7749bced"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("4336fa2f-881f-4cd6-9978-20de51391c24"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("4df7f581-08b2-400a-9fd7-7e9e89e15f97"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("53fbabc1-ed61-4254-a4ca-088081591b14"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("6375ecf7-288b-48d2-91c6-17d2a8758763"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("7245da36-cd04-4ea9-8cb2-a8f69b709837"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("84e3ab0e-8ffa-459f-b9f5-d739851b821d"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("c337ec9c-bb26-45f6-b24c-910e3d16083e"));

            migrationBuilder.DeleteData(
                table: "instrutores",
                keyColumn: "Id",
                keyValue: new Guid("0f5fd279-a62d-40ec-9f3f-2c1e238be30d"));

            migrationBuilder.DeleteData(
                table: "instrutores",
                keyColumn: "Id",
                keyValue: new Guid("3cce326d-ccb9-45ad-a03d-20d4f81b99a0"));

            migrationBuilder.DeleteData(
                table: "instrutores",
                keyColumn: "Id",
                keyValue: new Guid("82ca525a-b114-4f1a-a7b5-57020eef0812"));

            migrationBuilder.DeleteData(
                table: "instrutores",
                keyColumn: "Id",
                keyValue: new Guid("8b1dc99a-1b2b-4140-a7c8-e412a9584f7f"));

            migrationBuilder.DeleteData(
                table: "instrutores",
                keyColumn: "Id",
                keyValue: new Guid("9250454c-2abc-470b-a946-c3b7f2a30ee2"));

            migrationBuilder.DeleteData(
                table: "instrutores",
                keyColumn: "Id",
                keyValue: new Guid("b554bd34-1248-4487-a245-cb6c959b4416"));

            migrationBuilder.DeleteData(
                table: "instrutores",
                keyColumn: "Id",
                keyValue: new Guid("b954de9d-b002-402f-9a74-a10a58d603f8"));

            migrationBuilder.DeleteData(
                table: "instrutores",
                keyColumn: "Id",
                keyValue: new Guid("d973b9e1-7f4e-446c-b35b-5161265692d6"));

            migrationBuilder.DeleteData(
                table: "instrutores",
                keyColumn: "Id",
                keyValue: new Guid("e08567f2-d347-483d-8ce4-fc094e344573"));

            migrationBuilder.DeleteData(
                table: "instrutores",
                keyColumn: "Id",
                keyValue: new Guid("e496b157-33ee-438a-8970-3855509e82db"));

            migrationBuilder.DeleteData(
                table: "precos",
                keyColumn: "Id",
                keyValue: new Guid("9c2a8add-1cc4-48c5-b346-a500de025570"));

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    NomeCompleto = table.Column<string>(type: "TEXT", nullable: true),
                    Profissao = table.Column<string>(type: "TEXT", nullable: true),
                    UserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    PasswordHash = table.Column<string>(type: "TEXT", nullable: true),
                    SecurityStamp = table.Column<string>(type: "TEXT", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "TEXT", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RoleId = table.Column<string>(type: "TEXT", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
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
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
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
                    LoginProvider = table.Column<string>(type: "TEXT", nullable: false),
                    ProviderKey = table.Column<string>(type: "TEXT", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "TEXT", nullable: true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false)
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
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    RoleId = table.Column<string>(type: "TEXT", nullable: false)
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
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    LoginProvider = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Value = table.Column<string>(type: "TEXT", nullable: true)
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "03559a60-c67f-40f9-9969-ec3010fb250c", null, "ADMIN", "ADMIN" },
                    { "fb7d73c9-72b2-4a0a-ab60-0b8da3868827", null, "CLIENT", "CLIENT" }
                });

            migrationBuilder.InsertData(
                table: "cursos",
                columns: new[] { "Id", "DataPublicacao", "Descricao", "Titulo" },
                values: new object[,]
                {
                    { new Guid("2b606231-d9f3-4bcd-b9fb-dd1dc8441044"), new DateTime(2025, 8, 20, 19, 28, 41, 232, DateTimeKind.Utc).AddTicks(3853), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Tasty Fresh Salad" },
                    { new Guid("34921daf-5ca7-4f2d-ae35-68f32b6b23ca"), new DateTime(2025, 8, 20, 19, 28, 41, 232, DateTimeKind.Utc).AddTicks(3928), "The Football Is Good For Training And Recreational Purposes", "Unbranded Concrete Bike" },
                    { new Guid("588ac2a9-e2c0-4730-829e-14ea4ed39425"), new DateTime(2025, 8, 20, 19, 28, 41, 232, DateTimeKind.Utc).AddTicks(3911), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Gorgeous Wooden Chair" },
                    { new Guid("65132b3a-7d3c-4917-ace7-ac7906dca572"), new DateTime(2025, 8, 20, 19, 28, 41, 232, DateTimeKind.Utc).AddTicks(3888), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Fantastic Fresh Mouse" },
                    { new Guid("806456c6-61d0-4819-a189-0a5fb775e56a"), new DateTime(2025, 8, 20, 19, 28, 41, 232, DateTimeKind.Utc).AddTicks(3939), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Incredible Metal Computer" },
                    { new Guid("8ed4d03d-1453-4ee5-8534-9c68b9fc98c3"), new DateTime(2025, 8, 20, 19, 28, 41, 232, DateTimeKind.Utc).AddTicks(3901), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Intelligent Metal Computer" },
                    { new Guid("b4e122b0-9a5d-4330-8a58-5f5677197bfa"), new DateTime(2025, 8, 20, 19, 28, 41, 232, DateTimeKind.Utc).AddTicks(3949), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Awesome Wooden Cheese" },
                    { new Guid("cc50adfc-e274-407f-bdd9-90c0e1ca8f98"), new DateTime(2025, 8, 20, 19, 28, 41, 232, DateTimeKind.Utc).AddTicks(3968), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Licensed Steel Mouse" },
                    { new Guid("e8323f20-3738-491f-b69b-4734b749f82f"), new DateTime(2025, 8, 20, 19, 28, 41, 232, DateTimeKind.Utc).AddTicks(3958), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Awesome Frozen Fish" }
                });

            migrationBuilder.InsertData(
                table: "instrutores",
                columns: new[] { "Id", "GrauAcademico", "Nome", "Sobrenome" },
                values: new object[,]
                {
                    { new Guid("161e0839-1c66-4bb3-b0ad-4a576558cd72"), "Dynamic Branding Officer", "Hilton Grimes", "Roob" },
                    { new Guid("1f36f829-4fba-45c3-9b66-991e3bca6270"), "Internal Integration Director", "Jaylon Konopelski", "Grady" },
                    { new Guid("3c2871d6-c279-4741-ab93-b2981a6043d4"), "Internal Identity Strategist", "Jared Nienow", "Sauer" },
                    { new Guid("3ef44bf6-476e-47e6-b6f6-c1ee0352e8bd"), "Senior Tactics Consultant", "Izabella Johnson", "Romaguera" },
                    { new Guid("812d496a-bebf-419d-9fa4-537624ef516f"), "International Paradigm Supervisor", "Lilian Ryan", "Schuster" },
                    { new Guid("910a3eee-7da8-4207-9643-2730e88aa4e5"), "Regional Applications Assistant", "Curt Lowe", "Emmerich" },
                    { new Guid("a5ee2e97-50c0-49a0-8cbe-623b5fbb7de9"), "Product Marketing Supervisor", "Annie Muller", "Walter" },
                    { new Guid("af6a018b-e47b-4fe9-80d0-39696317aabc"), "District Accountability Administrator", "Lelah O'Kon", "Bartell" },
                    { new Guid("c584228e-91b6-4bc2-8b55-d9bbe32336a3"), "Legacy Solutions Producer", "Kristina Kozey", "Marvin" },
                    { new Guid("f1b4af2c-4e87-4a85-bb65-643d1960f0a7"), "District Implementation Producer", "Candelario Reichert", "Cole" }
                });

            migrationBuilder.InsertData(
                table: "precos",
                columns: new[] { "Id", "Nome", "PrecoAtual", "PrecoPromocional" },
                values: new object[] { new Guid("e936d68a-8109-436c-ad44-f29bfbc601ec"), "Preco Padrao", 10.0m, 8.0m });

            migrationBuilder.InsertData(
                table: "AspNetRoleClaims",
                columns: new[] { "Id", "ClaimType", "ClaimValue", "RoleId" },
                values: new object[,]
                {
                    { 1, "POLICIES", "CURSO_READ", "03559a60-c67f-40f9-9969-ec3010fb250c" },
                    { 2, "POLICIES", "CURSO_UPDATE", "03559a60-c67f-40f9-9969-ec3010fb250c" },
                    { 3, "POLICIES", "CURSO_READ", "03559a60-c67f-40f9-9969-ec3010fb250c" },
                    { 4, "POLICIES", "CURSO_DELETE", "03559a60-c67f-40f9-9969-ec3010fb250c" },
                    { 5, "POLICIES", "INSTRUTOR_CREATE", "03559a60-c67f-40f9-9969-ec3010fb250c" },
                    { 6, "POLICIES", "INSTRUTOR_READ", "03559a60-c67f-40f9-9969-ec3010fb250c" },
                    { 7, "POLICIES", "INSTRUTOR_UPDATE", "03559a60-c67f-40f9-9969-ec3010fb250c" },
                    { 8, "POLICIES", "COMENTARIO_READ", "03559a60-c67f-40f9-9969-ec3010fb250c" },
                    { 9, "POLICIES", "COMENTARIO_DELETE", "03559a60-c67f-40f9-9969-ec3010fb250c" },
                    { 10, "POLICIES", "COMENTARIO_CREATE", "03559a60-c67f-40f9-9969-ec3010fb250c" },
                    { 11, "POLICIES", "CURSO_READ", "fb7d73c9-72b2-4a0a-ab60-0b8da3868827" },
                    { 12, "POLICIES", "INSTRUTOR_READ", "fb7d73c9-72b2-4a0a-ab60-0b8da3868827" },
                    { 13, "POLICIES", "COMENTARIO_READ", "fb7d73c9-72b2-4a0a-ab60-0b8da3868827" },
                    { 14, "POLICIES", "COMENTARIO_CREATE", "fb7d73c9-72b2-4a0a-ab60-0b8da3868827" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

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
                unique: true);
        }

        /// <inheritdoc />
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
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("2b606231-d9f3-4bcd-b9fb-dd1dc8441044"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("34921daf-5ca7-4f2d-ae35-68f32b6b23ca"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("588ac2a9-e2c0-4730-829e-14ea4ed39425"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("65132b3a-7d3c-4917-ace7-ac7906dca572"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("806456c6-61d0-4819-a189-0a5fb775e56a"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("8ed4d03d-1453-4ee5-8534-9c68b9fc98c3"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("b4e122b0-9a5d-4330-8a58-5f5677197bfa"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("cc50adfc-e274-407f-bdd9-90c0e1ca8f98"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("e8323f20-3738-491f-b69b-4734b749f82f"));

            migrationBuilder.DeleteData(
                table: "instrutores",
                keyColumn: "Id",
                keyValue: new Guid("161e0839-1c66-4bb3-b0ad-4a576558cd72"));

            migrationBuilder.DeleteData(
                table: "instrutores",
                keyColumn: "Id",
                keyValue: new Guid("1f36f829-4fba-45c3-9b66-991e3bca6270"));

            migrationBuilder.DeleteData(
                table: "instrutores",
                keyColumn: "Id",
                keyValue: new Guid("3c2871d6-c279-4741-ab93-b2981a6043d4"));

            migrationBuilder.DeleteData(
                table: "instrutores",
                keyColumn: "Id",
                keyValue: new Guid("3ef44bf6-476e-47e6-b6f6-c1ee0352e8bd"));

            migrationBuilder.DeleteData(
                table: "instrutores",
                keyColumn: "Id",
                keyValue: new Guid("812d496a-bebf-419d-9fa4-537624ef516f"));

            migrationBuilder.DeleteData(
                table: "instrutores",
                keyColumn: "Id",
                keyValue: new Guid("910a3eee-7da8-4207-9643-2730e88aa4e5"));

            migrationBuilder.DeleteData(
                table: "instrutores",
                keyColumn: "Id",
                keyValue: new Guid("a5ee2e97-50c0-49a0-8cbe-623b5fbb7de9"));

            migrationBuilder.DeleteData(
                table: "instrutores",
                keyColumn: "Id",
                keyValue: new Guid("af6a018b-e47b-4fe9-80d0-39696317aabc"));

            migrationBuilder.DeleteData(
                table: "instrutores",
                keyColumn: "Id",
                keyValue: new Guid("c584228e-91b6-4bc2-8b55-d9bbe32336a3"));

            migrationBuilder.DeleteData(
                table: "instrutores",
                keyColumn: "Id",
                keyValue: new Guid("f1b4af2c-4e87-4a85-bb65-643d1960f0a7"));

            migrationBuilder.DeleteData(
                table: "precos",
                keyColumn: "Id",
                keyValue: new Guid("e936d68a-8109-436c-ad44-f29bfbc601ec"));

            migrationBuilder.InsertData(
                table: "cursos",
                columns: new[] { "Id", "DataPublicacao", "Descricao", "Titulo" },
                values: new object[,]
                {
                    { new Guid("0db141f4-4ab4-49c2-a5c5-062d7af11749"), new DateTime(2025, 8, 18, 16, 16, 32, 775, DateTimeKind.Utc).AddTicks(7007), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Unbranded Cotton Tuna" },
                    { new Guid("2e214b2a-53bd-4b0d-b2a8-af7c7749bced"), new DateTime(2025, 8, 18, 16, 16, 32, 775, DateTimeKind.Utc).AddTicks(7042), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Rustic Fresh Chips" },
                    { new Guid("4336fa2f-881f-4cd6-9978-20de51391c24"), new DateTime(2025, 8, 18, 16, 16, 32, 775, DateTimeKind.Utc).AddTicks(7083), "The Football Is Good For Training And Recreational Purposes", "Unbranded Plastic Cheese" },
                    { new Guid("4df7f581-08b2-400a-9fd7-7e9e89e15f97"), new DateTime(2025, 8, 18, 16, 16, 32, 775, DateTimeKind.Utc).AddTicks(7075), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Generic Fresh Tuna" },
                    { new Guid("53fbabc1-ed61-4254-a4ca-088081591b14"), new DateTime(2025, 8, 18, 16, 16, 32, 775, DateTimeKind.Utc).AddTicks(7091), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Unbranded Frozen Table" },
                    { new Guid("6375ecf7-288b-48d2-91c6-17d2a8758763"), new DateTime(2025, 8, 18, 16, 16, 32, 775, DateTimeKind.Utc).AddTicks(7051), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Rustic Metal Keyboard" },
                    { new Guid("7245da36-cd04-4ea9-8cb2-a8f69b709837"), new DateTime(2025, 8, 18, 16, 16, 32, 775, DateTimeKind.Utc).AddTicks(7034), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Tasty Rubber Computer" },
                    { new Guid("84e3ab0e-8ffa-459f-b9f5-d739851b821d"), new DateTime(2025, 8, 18, 16, 16, 32, 775, DateTimeKind.Utc).AddTicks(7025), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Small Cotton Salad" },
                    { new Guid("c337ec9c-bb26-45f6-b24c-910e3d16083e"), new DateTime(2025, 8, 18, 16, 16, 32, 775, DateTimeKind.Utc).AddTicks(7060), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Rustic Wooden Soap" }
                });

            migrationBuilder.InsertData(
                table: "instrutores",
                columns: new[] { "Id", "GrauAcademico", "Nome", "Sobrenome" },
                values: new object[,]
                {
                    { new Guid("0f5fd279-a62d-40ec-9f3f-2c1e238be30d"), "International Research Specialist", "Brando Carter", "Stracke" },
                    { new Guid("3cce326d-ccb9-45ad-a03d-20d4f81b99a0"), "Dynamic Accountability Developer", "Adolphus Dooley", "Larkin" },
                    { new Guid("82ca525a-b114-4f1a-a7b5-57020eef0812"), "Human Infrastructure Designer", "Markus Bruen", "Witting" },
                    { new Guid("8b1dc99a-1b2b-4140-a7c8-e412a9584f7f"), "National Identity Assistant", "Margot Nader", "Paucek" },
                    { new Guid("9250454c-2abc-470b-a946-c3b7f2a30ee2"), "Dynamic Interactions Consultant", "Vinnie Rodriguez", "Rempel" },
                    { new Guid("b554bd34-1248-4487-a245-cb6c959b4416"), "Global Division Assistant", "Sage West", "Hilpert" },
                    { new Guid("b954de9d-b002-402f-9a74-a10a58d603f8"), "District Data Assistant", "Laverna Rath", "Kohler" },
                    { new Guid("d973b9e1-7f4e-446c-b35b-5161265692d6"), "Lead Group Engineer", "Evert Ankunding", "Gutkowski" },
                    { new Guid("e08567f2-d347-483d-8ce4-fc094e344573"), "Dynamic Group Representative", "Audreanne Volkman", "Kovacek" },
                    { new Guid("e496b157-33ee-438a-8970-3855509e82db"), "Direct Paradigm Officer", "Alexandria Runolfsson", "Marquardt" }
                });

            migrationBuilder.InsertData(
                table: "precos",
                columns: new[] { "Id", "Nome", "PrecoAtual", "PrecoPromocional" },
                values: new object[] { new Guid("9c2a8add-1cc4-48c5-b346-a500de025570"), "Preco Padrao", 10.0m, 8.0m });
        }
    }
}
