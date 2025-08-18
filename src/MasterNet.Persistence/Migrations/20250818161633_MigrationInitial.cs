using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MasterNet.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class MigrationInitial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "cursos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Titulo = table.Column<string>(type: "TEXT", nullable: true),
                    Descricao = table.Column<string>(type: "TEXT", nullable: true),
                    DataPublicacao = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cursos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "instrutores",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Nome = table.Column<string>(type: "TEXT", nullable: true),
                    Sobrenome = table.Column<string>(type: "TEXT", nullable: true),
                    GrauAcademico = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_instrutores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "precos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Nome = table.Column<string>(type: "VARCHAR", maxLength: 250, nullable: true),
                    PrecoAtual = table.Column<decimal>(type: "TEXT", precision: 10, scale: 2, nullable: false),
                    PrecoPromocional = table.Column<decimal>(type: "TEXT", precision: 10, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_precos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "imagens",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Url = table.Column<string>(type: "TEXT", nullable: true),
                    CursoId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_imagens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_imagens_cursos_CursoId",
                        column: x => x.CursoId,
                        principalTable: "cursos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "qualificacoes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Aluno = table.Column<string>(type: "TEXT", nullable: true),
                    Ponto = table.Column<int>(type: "INTEGER", nullable: false),
                    Comentario = table.Column<string>(type: "TEXT", nullable: true),
                    CursoId = table.Column<Guid>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_qualificacoes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_qualificacoes_cursos_CursoId",
                        column: x => x.CursoId,
                        principalTable: "cursos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "curso_instrutores",
                columns: table => new
                {
                    IntrutorId = table.Column<Guid>(type: "TEXT", nullable: false),
                    CursoId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_curso_instrutores", x => new { x.CursoId, x.IntrutorId });
                    table.ForeignKey(
                        name: "FK_curso_instrutores_cursos_CursoId",
                        column: x => x.CursoId,
                        principalTable: "cursos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_curso_instrutores_instrutores_IntrutorId",
                        column: x => x.IntrutorId,
                        principalTable: "instrutores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "curso_precos",
                columns: table => new
                {
                    PrecoId = table.Column<Guid>(type: "TEXT", nullable: false),
                    CursoId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_curso_precos", x => new { x.CursoId, x.PrecoId });
                    table.ForeignKey(
                        name: "FK_curso_precos_cursos_CursoId",
                        column: x => x.CursoId,
                        principalTable: "cursos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_curso_precos_precos_PrecoId",
                        column: x => x.PrecoId,
                        principalTable: "precos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_curso_instrutores_IntrutorId",
                table: "curso_instrutores",
                column: "IntrutorId");

            migrationBuilder.CreateIndex(
                name: "IX_curso_precos_PrecoId",
                table: "curso_precos",
                column: "PrecoId");

            migrationBuilder.CreateIndex(
                name: "IX_imagens_CursoId",
                table: "imagens",
                column: "CursoId");

            migrationBuilder.CreateIndex(
                name: "IX_qualificacoes_CursoId",
                table: "qualificacoes",
                column: "CursoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "curso_instrutores");

            migrationBuilder.DropTable(
                name: "curso_precos");

            migrationBuilder.DropTable(
                name: "imagens");

            migrationBuilder.DropTable(
                name: "qualificacoes");

            migrationBuilder.DropTable(
                name: "instrutores");

            migrationBuilder.DropTable(
                name: "precos");

            migrationBuilder.DropTable(
                name: "cursos");
        }
    }
}
