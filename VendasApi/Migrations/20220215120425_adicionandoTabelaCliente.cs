using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace FilmesApi.Migrations
{
    public partial class adicionandoTabelaCliente : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
              name: "Clientes",
              columns: table => new
              {
                  id = table.Column<int>(type: "int", nullable: false)
                      .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                  nomeCliente = table.Column<string>(type: "text", nullable: true),
                  sobrenomeCliente = table.Column<string>(type: "text", nullable: true),
                  Cpf = table.Column<string>(type: "text", nullable: true),
                  dataNascimento = table.Column<string>(type: "text", nullable: true)

              },
              constraints: table =>
              {
                  table.PrimaryKey("PK_vendas", x => x.id);
              });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
