using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Checkpoint.Migrations
{
    /// <inheritdoc />
    public partial class AdicionarEntidadeFornecedores : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Fornecedores",
                columns: table => new
                {
                    idFornecedor = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    nrCEP = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    dsEndereco = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Estado = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Cidade = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fornecedores", x => x.idFornecedor);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Fornecedores");
        }
    }
}
