using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class DeleteBank : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cards_Banks_BankId",
                table: "Cards");

            migrationBuilder.DropForeignKey(
                name: "FK_Cards_Wallets_WalletId",
                table: "Cards");

            migrationBuilder.DropForeignKey(
                name: "FK_Cash_Wallets_WalletId",
                table: "Cash");

            migrationBuilder.DropTable(
                name: "Banks");

            migrationBuilder.DropIndex(
                name: "IX_Cards_BankId",
                table: "Cards");

            migrationBuilder.DropIndex(
                name: "IX_Cards_WalletId",
                table: "Cards");

            migrationBuilder.DropColumn(
                name: "BankId",
                table: "Cards");

            migrationBuilder.DropColumn(
                name: "WalletId",
                table: "Cards");

            migrationBuilder.AlterColumn<int>(
                name: "WalletId",
                table: "Cash",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Cash_Wallets_WalletId",
                table: "Cash",
                column: "WalletId",
                principalTable: "Wallets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cash_Wallets_WalletId",
                table: "Cash");

            migrationBuilder.AlterColumn<int>(
                name: "WalletId",
                table: "Cash",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "BankId",
                table: "Cards",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "WalletId",
                table: "Cards",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Banks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Banks", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Privat24" });

            migrationBuilder.CreateIndex(
                name: "IX_Cards_BankId",
                table: "Cards",
                column: "BankId");

            migrationBuilder.CreateIndex(
                name: "IX_Cards_WalletId",
                table: "Cards",
                column: "WalletId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cards_Banks_BankId",
                table: "Cards",
                column: "BankId",
                principalTable: "Banks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cards_Wallets_WalletId",
                table: "Cards",
                column: "WalletId",
                principalTable: "Wallets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cash_Wallets_WalletId",
                table: "Cash",
                column: "WalletId",
                principalTable: "Wallets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
