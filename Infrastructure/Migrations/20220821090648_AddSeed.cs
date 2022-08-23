using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class AddSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Privat24" });

            migrationBuilder.InsertData(
                table: "TypesMonies",
                columns: new[] { "Id", "FullName", "Name" },
                values: new object[,]
                {
                    { 33, "Євро", "EUR" },
                    { 34, "Злотий", "PLN" },
                    { 35, "Алжирський динар", "DZD" },
                    { 36, "Така", "BDT" },
                    { 37, "Вірменський драм", "AMD" },
                    { 38, "Домініканське песо", "DOP" },
                    { 39, "Іранський ріал", "IRR" },
                    { 40, "Іракський динар", "IQD" },
                    { 41, "Сом", "KGS" },
                    { 42, "Ліванський фунт", "LBP" },
                    { 43, "Лівійський динар", "LYD" },
                    { 44, "Малайзійський ринггіт", "MYR" },
                    { 45, "Марокканський дирхам", "MAD" },
                    { 32, "Болгарський лев", "BGN" },
                    { 46, "Пакистанська рупія", "PKR" },
                    { 48, "Донг", "VND" },
                    { 49, "Бат", "THB" },
                    { 50, "Дирхам ОАЕ", "AED" },
                    { 51, "Туніський динар", "TND" },
                    { 52, "Узбецький сум", "UZS" },
                    { 53, "Новий тайванський долар", "TWD" },
                    { 54, "Туркменський новий манат", "TMT" },
                    { 55, "Сербський динар", "RSD" },
                    { 56, "Сомоні", "TJS" },
                    { 57, "Ларі", "GEL" },
                    { 58, "Бразильський реал", "BRL" },
                    { 59, "Золото", "XAU" },
                    { 60, "Срібло", "XAG" },
                    { 47, "Саудівський ріял", "SAR" },
                    { 61, "Платина", "XPT" },
                    { 31, "СПЗ (спеціальні права запозичення)", "XDR" },
                    { 29, "Румунський лей", "RON" },
                    { 1, "Австралійський долар", "AUD" },
                    { 2, "Канадський долар", "CAD" },
                    { 3, "Юань Женьміньбі", "CNY" },
                    { 4, "Куна", "HRK" },
                    { 5, "Чеська крона", "CZK" },
                    { 6, "Данська крона", "DKK" },
                    { 7, "Гонконгівський долар", "HKD" },
                    { 8, "Форинт", "HUF" },
                    { 9, "Індійська рупія", "INR" }
                });

            migrationBuilder.InsertData(
                table: "TypesMonies",
                columns: new[] { "Id", "FullName", "Name" },
                values: new object[,]
                {
                    { 10, "Рупія", "IDR" },
                    { 11, "Новий ізраїльський шекель", "ILS" },
                    { 12, "Єна", "JPY" },
                    { 13, "Теньге", "KZT" },
                    { 30, "Турецька ліра", "TRY" },
                    { 14, "Вона", "KRW" },
                    { 16, "Молдовський лей", "MDL" },
                    { 17, "Новозеландський долар", "NZD" },
                    { 18, "Норвезька крона", "NOK" },
                    { 19, "Російський рубль", "RUB" },
                    { 20, "Сінгапурський долар", "SGD" },
                    { 21, "Ренд", "ZAR" },
                    { 22, "Шведська крона", "SEK" },
                    { 23, "Швейцарський франк", "CHF" },
                    { 24, "Єгипетський фунт", "EGP" },
                    { 25, "Фунт стерлінгів", "GBP" },
                    { 26, "Долар США", "USD" },
                    { 27, "Білоруський рубль", "BYN" },
                    { 28, "Азербайджанський манат", "AZN" },
                    { 15, "Мексиканське песо", "MXN" },
                    { 62, "Паладій", "XPD" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Banks",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 62);
        }
    }
}
