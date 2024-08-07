﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LanchesMac.Migrations
{
    /// <inheritdoc />
    public partial class CriandoContatos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
               name: "Contatos",
               columns: table => new
               {
                   ContatoId = table.Column<int>(type: "int", nullable: false)
                       .Annotation("SqlServer:Identity", "1, 1"),
                 NomeContato = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                   Contato = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
               },
               constraints: table =>
               {
                   table.PrimaryKey("PK_Categorias", x => x.ContatoId);
               });

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contatos");
        }
    }
}
