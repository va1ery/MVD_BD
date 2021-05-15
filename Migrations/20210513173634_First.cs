using Microsoft.EntityFrameworkCore.Migrations;

namespace MVD_BD.Migrations
{
    public partial class First : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Виды_преступлений",
                columns: table => new
                {
                    Код_вида_преступления = table.Column<int>(type: "INT", nullable: false),
                    Наименование = table.Column<int>(type: "INT", nullable: false),
                    Статья = table.Column<int>(type: "INT", nullable: false),
                    Наказание = table.Column<int>(type: "INT", nullable: false),
                    Срок = table.Column<int>(type: "INT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Виды_преступлений", x => x.Код_вида_преступления);
                });

            migrationBuilder.CreateTable(
                name: "Должности",
                columns: table => new
                {
                    код_должности = table.Column<int>(type: "INT", nullable: false),
                    Наименование_должности = table.Column<int>(type: "INT", nullable: false),
                    Оклад = table.Column<int>(type: "INT", nullable: false),
                    Обязанности = table.Column<int>(type: "INT", nullable: false),
                    Требования = table.Column<int>(type: "INT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Должности", x => x.код_должности);
                });

            migrationBuilder.CreateTable(
                name: "Звания",
                columns: table => new
                {
                    Код_звания = table.Column<int>(type: "INT", nullable: false),
                    Наименование = table.Column<int>(type: "INT", nullable: false),
                    Надбавка = table.Column<int>(type: "INT", nullable: false),
                    Обязанности = table.Column<int>(type: "INT", nullable: false),
                    Требования = table.Column<int>(type: "INT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Звания", x => x.Код_звания);
                });

            migrationBuilder.CreateTable(
                name: "Пострадавшие",
                columns: table => new
                {
                    Код_пострадавшего = table.Column<int>(type: "INT", nullable: false),
                    ФИО = table.Column<int>(type: "INT", nullable: false),
                    Дата_рождения = table.Column<int>(type: "INT", nullable: false),
                    Пол = table.Column<int>(type: "INT", nullable: false),
                    адес = table.Column<int>(type: "INT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Пострадавшие", x => x.Код_пострадавшего);
                });

            migrationBuilder.CreateTable(
                name: "Сотрудники",
                columns: table => new
                {
                    Код_сотрудника = table.Column<int>(type: "INT", nullable: false),
                    ФИО = table.Column<int>(type: "INT", nullable: false),
                    Возраст = table.Column<int>(type: "INT", nullable: false),
                    Адрес = table.Column<int>(type: "INT", nullable: false),
                    Телефон = table.Column<int>(type: "INT", nullable: false),
                    Паспортные_данные = table.Column<int>(type: "INT", nullable: false),
                    Пол = table.Column<int>(type: "INT", nullable: false),
                    код_должности = table.Column<int>(type: "INT", nullable: false),
                    Код_звания = table.Column<int>(type: "INT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Сотрудники", x => x.Код_сотрудника);
                    table.ForeignKey(
                        name: "FK_Сотрудники_Должности_код_должности",
                        column: x => x.код_должности,
                        principalTable: "Должности",
                        principalColumn: "код_должности",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Сотрудники_Звания_Код_звания",
                        column: x => x.Код_звания,
                        principalTable: "Звания",
                        principalColumn: "Код_звания",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Преступники",
                columns: table => new
                {
                    Номер_дела = table.Column<int>(type: "INT", nullable: false),
                    ФИО = table.Column<int>(type: "INT", nullable: false),
                    Дата_рождения = table.Column<int>(type: "INT", nullable: false),
                    Пол = table.Column<int>(type: "INT", nullable: false),
                    Адрес = table.Column<int>(type: "INT", nullable: false),
                    Состояние = table.Column<int>(type: "INT", nullable: false),
                    Код_вида_преступления = table.Column<int>(type: "INT", nullable: false),
                    Код_пострадавшего = table.Column<int>(type: "INT", nullable: false),
                    Код_сотрудника = table.Column<int>(type: "INT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Преступники", x => x.Номер_дела);
                    table.ForeignKey(
                        name: "FK_Преступники_Виды_преступлений_Код_вида_преступления",
                        column: x => x.Код_вида_преступления,
                        principalTable: "Виды_преступлений",
                        principalColumn: "Код_вида_преступления",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Преступники_Сотрудники_Код_сотрудника",
                        column: x => x.Код_сотрудника,
                        principalTable: "Сотрудники",
                        principalColumn: "Код_сотрудника",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Виды_преступлений_Наименование",
                table: "Виды_преступлений",
                column: "Наименование",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Виды_преступлений_Статья",
                table: "Виды_преступлений",
                column: "Статья",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Звания_Наименование",
                table: "Звания",
                column: "Наименование",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Преступники_Код_вида_преступления",
                table: "Преступники",
                column: "Код_вида_преступления");

            migrationBuilder.CreateIndex(
                name: "IX_Преступники_Код_сотрудника",
                table: "Преступники",
                column: "Код_сотрудника");

            migrationBuilder.CreateIndex(
                name: "IX_Сотрудники_код_должности",
                table: "Сотрудники",
                column: "код_должности",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Сотрудники_Код_звания",
                table: "Сотрудники",
                column: "Код_звания",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Сотрудники_Паспортные_данные",
                table: "Сотрудники",
                column: "Паспортные_данные",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Сотрудники_Телефон",
                table: "Сотрудники",
                column: "Телефон",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Пострадавшие");

            migrationBuilder.DropTable(
                name: "Преступники");

            migrationBuilder.DropTable(
                name: "Виды_преступлений");

            migrationBuilder.DropTable(
                name: "Сотрудники");

            migrationBuilder.DropTable(
                name: "Должности");

            migrationBuilder.DropTable(
                name: "Звания");
        }
    }
}
