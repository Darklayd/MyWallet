using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class setForingKey : Migration
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
                name: "FK_Cash_TypesMonies_TypeMoneyId",
                table: "Cash");

            migrationBuilder.AlterColumn<int>(
                name: "TypeMoneyId",
                table: "Cash",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "WalletId",
                table: "Cards",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BankId",
                table: "Cards",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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
                name: "FK_Cash_TypesMonies_TypeMoneyId",
                table: "Cash",
                column: "TypeMoneyId",
                principalTable: "TypesMonies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cards_Banks_BankId",
                table: "Cards");

            migrationBuilder.DropForeignKey(
                name: "FK_Cards_Wallets_WalletId",
                table: "Cards");

            migrationBuilder.DropForeignKey(
                name: "FK_Cash_TypesMonies_TypeMoneyId",
                table: "Cash");

            migrationBuilder.AlterColumn<int>(
                name: "TypeMoneyId",
                table: "Cash",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "WalletId",
                table: "Cards",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "BankId",
                table: "Cards",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Cards_Banks_BankId",
                table: "Cards",
                column: "BankId",
                principalTable: "Banks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Cards_Wallets_WalletId",
                table: "Cards",
                column: "WalletId",
                principalTable: "Wallets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Cash_TypesMonies_TypeMoneyId",
                table: "Cash",
                column: "TypeMoneyId",
                principalTable: "TypesMonies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
