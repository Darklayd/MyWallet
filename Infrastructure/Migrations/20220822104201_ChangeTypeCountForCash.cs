using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class ChangeTypeCountForCash : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Count",
                table: "Cash",
                type: "float",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FullName", "Name" },
                values: new object[] { "Гривня", "UAH" });

            migrationBuilder.UpdateData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FullName", "Name" },
                values: new object[] { "Австралійський долар", "AUD" });

            migrationBuilder.UpdateData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "FullName", "Name" },
                values: new object[] { "Канадський долар", "CAD" });

            migrationBuilder.UpdateData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "FullName", "Name" },
                values: new object[] { "Юань Женьміньбі", "CNY" });

            migrationBuilder.UpdateData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "FullName", "Name" },
                values: new object[] { "Куна", "HRK" });

            migrationBuilder.UpdateData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "FullName", "Name" },
                values: new object[] { "Чеська крона", "CZK" });

            migrationBuilder.UpdateData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "FullName", "Name" },
                values: new object[] { "Данська крона", "DKK" });

            migrationBuilder.UpdateData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "FullName", "Name" },
                values: new object[] { "Гонконгівський долар", "HKD" });

            migrationBuilder.UpdateData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "FullName", "Name" },
                values: new object[] { "Форинт", "HUF" });

            migrationBuilder.UpdateData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "FullName", "Name" },
                values: new object[] { "Індійська рупія", "INR" });

            migrationBuilder.UpdateData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "FullName", "Name" },
                values: new object[] { "Рупія", "IDR" });

            migrationBuilder.UpdateData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "FullName", "Name" },
                values: new object[] { "Новий ізраїльський шекель", "ILS" });

            migrationBuilder.UpdateData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "FullName", "Name" },
                values: new object[] { "Єна", "JPY" });

            migrationBuilder.UpdateData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "FullName", "Name" },
                values: new object[] { "Теньге", "KZT" });

            migrationBuilder.UpdateData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "FullName", "Name" },
                values: new object[] { "Вона", "KRW" });

            migrationBuilder.UpdateData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "FullName", "Name" },
                values: new object[] { "Мексиканське песо", "MXN" });

            migrationBuilder.UpdateData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "FullName", "Name" },
                values: new object[] { "Молдовський лей", "MDL" });

            migrationBuilder.UpdateData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "FullName", "Name" },
                values: new object[] { "Новозеландський долар", "NZD" });

            migrationBuilder.UpdateData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "FullName", "Name" },
                values: new object[] { "Норвезька крона", "NOK" });

            migrationBuilder.UpdateData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "FullName", "Name" },
                values: new object[] { "Російський рубль", "RUB" });

            migrationBuilder.UpdateData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "FullName", "Name" },
                values: new object[] { "Сінгапурський долар", "SGD" });

            migrationBuilder.UpdateData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "FullName", "Name" },
                values: new object[] { "Ренд", "ZAR" });

            migrationBuilder.UpdateData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "FullName", "Name" },
                values: new object[] { "Шведська крона", "SEK" });

            migrationBuilder.UpdateData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "FullName", "Name" },
                values: new object[] { "Швейцарський франк", "CHF" });

            migrationBuilder.UpdateData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "FullName", "Name" },
                values: new object[] { "Єгипетський фунт", "EGP" });

            migrationBuilder.UpdateData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "FullName", "Name" },
                values: new object[] { "Фунт стерлінгів", "GBP" });

            migrationBuilder.UpdateData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "FullName", "Name" },
                values: new object[] { "Долар США", "USD" });

            migrationBuilder.UpdateData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "FullName", "Name" },
                values: new object[] { "Білоруський рубль", "BYN" });

            migrationBuilder.UpdateData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "FullName", "Name" },
                values: new object[] { "Азербайджанський манат", "AZN" });

            migrationBuilder.UpdateData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "FullName", "Name" },
                values: new object[] { "Румунський лей", "RON" });

            migrationBuilder.UpdateData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "FullName", "Name" },
                values: new object[] { "Турецька ліра", "TRY" });

            migrationBuilder.UpdateData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "FullName", "Name" },
                values: new object[] { "СПЗ (спеціальні права запозичення)", "XDR" });

            migrationBuilder.UpdateData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "FullName", "Name" },
                values: new object[] { "Болгарський лев", "BGN" });

            migrationBuilder.UpdateData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "FullName", "Name" },
                values: new object[] { "Євро", "EUR" });

            migrationBuilder.UpdateData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "FullName", "Name" },
                values: new object[] { "Злотий", "PLN" });

            migrationBuilder.UpdateData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "FullName", "Name" },
                values: new object[] { "Алжирський динар", "DZD" });

            migrationBuilder.UpdateData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "FullName", "Name" },
                values: new object[] { "Така", "BDT" });

            migrationBuilder.UpdateData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "FullName", "Name" },
                values: new object[] { "Вірменський драм", "AMD" });

            migrationBuilder.UpdateData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "FullName", "Name" },
                values: new object[] { "Домініканське песо", "DOP" });

            migrationBuilder.UpdateData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "FullName", "Name" },
                values: new object[] { "Іранський ріал", "IRR" });

            migrationBuilder.UpdateData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "FullName", "Name" },
                values: new object[] { "Іракський динар", "IQD" });

            migrationBuilder.UpdateData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "FullName", "Name" },
                values: new object[] { "Сом", "KGS" });

            migrationBuilder.UpdateData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "FullName", "Name" },
                values: new object[] { "Ліванський фунт", "LBP" });

            migrationBuilder.UpdateData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "FullName", "Name" },
                values: new object[] { "Лівійський динар", "LYD" });

            migrationBuilder.UpdateData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "FullName", "Name" },
                values: new object[] { "Малайзійський ринггіт", "MYR" });

            migrationBuilder.UpdateData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "FullName", "Name" },
                values: new object[] { "Марокканський дирхам", "MAD" });

            migrationBuilder.UpdateData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "FullName", "Name" },
                values: new object[] { "Пакистанська рупія", "PKR" });

            migrationBuilder.UpdateData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "FullName", "Name" },
                values: new object[] { "Саудівський ріял", "SAR" });

            migrationBuilder.UpdateData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "FullName", "Name" },
                values: new object[] { "Донг", "VND" });

            migrationBuilder.UpdateData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "FullName", "Name" },
                values: new object[] { "Бат", "THB" });

            migrationBuilder.UpdateData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "FullName", "Name" },
                values: new object[] { "Дирхам ОАЕ", "AED" });

            migrationBuilder.UpdateData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "FullName", "Name" },
                values: new object[] { "Туніський динар", "TND" });

            migrationBuilder.UpdateData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "FullName", "Name" },
                values: new object[] { "Узбецький сум", "UZS" });

            migrationBuilder.UpdateData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "FullName", "Name" },
                values: new object[] { "Новий тайванський долар", "TWD" });

            migrationBuilder.UpdateData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "FullName", "Name" },
                values: new object[] { "Туркменський новий манат", "TMT" });

            migrationBuilder.UpdateData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "FullName", "Name" },
                values: new object[] { "Сербський динар", "RSD" });

            migrationBuilder.UpdateData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "FullName", "Name" },
                values: new object[] { "Сомоні", "TJS" });

            migrationBuilder.UpdateData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "FullName", "Name" },
                values: new object[] { "Ларі", "GEL" });

            migrationBuilder.UpdateData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "FullName", "Name" },
                values: new object[] { "Бразильський реал", "BRL" });

            migrationBuilder.UpdateData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "FullName", "Name" },
                values: new object[] { "Золото", "XAU" });

            migrationBuilder.UpdateData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "FullName", "Name" },
                values: new object[] { "Срібло", "XAG" });

            migrationBuilder.UpdateData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "FullName", "Name" },
                values: new object[] { "Платина", "XPT" });

            migrationBuilder.InsertData(
                table: "TypesMonies",
                columns: new[] { "Id", "FullName", "Name" },
                values: new object[] { 63, "Паладій", "XPD" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.AlterColumn<int>(
                name: "Count",
                table: "Cash",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.UpdateData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FullName", "Name" },
                values: new object[] { "Австралійський долар", "AUD" });

            migrationBuilder.UpdateData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FullName", "Name" },
                values: new object[] { "Канадський долар", "CAD" });

            migrationBuilder.UpdateData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "FullName", "Name" },
                values: new object[] { "Юань Женьміньбі", "CNY" });

            migrationBuilder.UpdateData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "FullName", "Name" },
                values: new object[] { "Куна", "HRK" });

            migrationBuilder.UpdateData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "FullName", "Name" },
                values: new object[] { "Чеська крона", "CZK" });

            migrationBuilder.UpdateData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "FullName", "Name" },
                values: new object[] { "Данська крона", "DKK" });

            migrationBuilder.UpdateData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "FullName", "Name" },
                values: new object[] { "Гонконгівський долар", "HKD" });

            migrationBuilder.UpdateData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "FullName", "Name" },
                values: new object[] { "Форинт", "HUF" });

            migrationBuilder.UpdateData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "FullName", "Name" },
                values: new object[] { "Індійська рупія", "INR" });

            migrationBuilder.UpdateData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "FullName", "Name" },
                values: new object[] { "Рупія", "IDR" });

            migrationBuilder.UpdateData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "FullName", "Name" },
                values: new object[] { "Новий ізраїльський шекель", "ILS" });

            migrationBuilder.UpdateData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "FullName", "Name" },
                values: new object[] { "Єна", "JPY" });

            migrationBuilder.UpdateData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "FullName", "Name" },
                values: new object[] { "Теньге", "KZT" });

            migrationBuilder.UpdateData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "FullName", "Name" },
                values: new object[] { "Вона", "KRW" });

            migrationBuilder.UpdateData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "FullName", "Name" },
                values: new object[] { "Мексиканське песо", "MXN" });

            migrationBuilder.UpdateData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "FullName", "Name" },
                values: new object[] { "Молдовський лей", "MDL" });

            migrationBuilder.UpdateData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "FullName", "Name" },
                values: new object[] { "Новозеландський долар", "NZD" });

            migrationBuilder.UpdateData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "FullName", "Name" },
                values: new object[] { "Норвезька крона", "NOK" });

            migrationBuilder.UpdateData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "FullName", "Name" },
                values: new object[] { "Російський рубль", "RUB" });

            migrationBuilder.UpdateData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "FullName", "Name" },
                values: new object[] { "Сінгапурський долар", "SGD" });

            migrationBuilder.UpdateData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "FullName", "Name" },
                values: new object[] { "Ренд", "ZAR" });

            migrationBuilder.UpdateData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "FullName", "Name" },
                values: new object[] { "Шведська крона", "SEK" });

            migrationBuilder.UpdateData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "FullName", "Name" },
                values: new object[] { "Швейцарський франк", "CHF" });

            migrationBuilder.UpdateData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "FullName", "Name" },
                values: new object[] { "Єгипетський фунт", "EGP" });

            migrationBuilder.UpdateData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "FullName", "Name" },
                values: new object[] { "Фунт стерлінгів", "GBP" });

            migrationBuilder.UpdateData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "FullName", "Name" },
                values: new object[] { "Долар США", "USD" });

            migrationBuilder.UpdateData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "FullName", "Name" },
                values: new object[] { "Білоруський рубль", "BYN" });

            migrationBuilder.UpdateData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "FullName", "Name" },
                values: new object[] { "Азербайджанський манат", "AZN" });

            migrationBuilder.UpdateData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "FullName", "Name" },
                values: new object[] { "Румунський лей", "RON" });

            migrationBuilder.UpdateData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "FullName", "Name" },
                values: new object[] { "Турецька ліра", "TRY" });

            migrationBuilder.UpdateData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "FullName", "Name" },
                values: new object[] { "СПЗ (спеціальні права запозичення)", "XDR" });

            migrationBuilder.UpdateData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "FullName", "Name" },
                values: new object[] { "Болгарський лев", "BGN" });

            migrationBuilder.UpdateData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "FullName", "Name" },
                values: new object[] { "Євро", "EUR" });

            migrationBuilder.UpdateData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "FullName", "Name" },
                values: new object[] { "Злотий", "PLN" });

            migrationBuilder.UpdateData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "FullName", "Name" },
                values: new object[] { "Алжирський динар", "DZD" });

            migrationBuilder.UpdateData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "FullName", "Name" },
                values: new object[] { "Така", "BDT" });

            migrationBuilder.UpdateData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "FullName", "Name" },
                values: new object[] { "Вірменський драм", "AMD" });

            migrationBuilder.UpdateData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "FullName", "Name" },
                values: new object[] { "Домініканське песо", "DOP" });

            migrationBuilder.UpdateData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "FullName", "Name" },
                values: new object[] { "Іранський ріал", "IRR" });

            migrationBuilder.UpdateData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "FullName", "Name" },
                values: new object[] { "Іракський динар", "IQD" });

            migrationBuilder.UpdateData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "FullName", "Name" },
                values: new object[] { "Сом", "KGS" });

            migrationBuilder.UpdateData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "FullName", "Name" },
                values: new object[] { "Ліванський фунт", "LBP" });

            migrationBuilder.UpdateData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "FullName", "Name" },
                values: new object[] { "Лівійський динар", "LYD" });

            migrationBuilder.UpdateData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "FullName", "Name" },
                values: new object[] { "Малайзійський ринггіт", "MYR" });

            migrationBuilder.UpdateData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "FullName", "Name" },
                values: new object[] { "Марокканський дирхам", "MAD" });

            migrationBuilder.UpdateData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "FullName", "Name" },
                values: new object[] { "Пакистанська рупія", "PKR" });

            migrationBuilder.UpdateData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "FullName", "Name" },
                values: new object[] { "Саудівський ріял", "SAR" });

            migrationBuilder.UpdateData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "FullName", "Name" },
                values: new object[] { "Донг", "VND" });

            migrationBuilder.UpdateData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "FullName", "Name" },
                values: new object[] { "Бат", "THB" });

            migrationBuilder.UpdateData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "FullName", "Name" },
                values: new object[] { "Дирхам ОАЕ", "AED" });

            migrationBuilder.UpdateData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "FullName", "Name" },
                values: new object[] { "Туніський динар", "TND" });

            migrationBuilder.UpdateData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "FullName", "Name" },
                values: new object[] { "Узбецький сум", "UZS" });

            migrationBuilder.UpdateData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "FullName", "Name" },
                values: new object[] { "Новий тайванський долар", "TWD" });

            migrationBuilder.UpdateData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "FullName", "Name" },
                values: new object[] { "Туркменський новий манат", "TMT" });

            migrationBuilder.UpdateData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "FullName", "Name" },
                values: new object[] { "Сербський динар", "RSD" });

            migrationBuilder.UpdateData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "FullName", "Name" },
                values: new object[] { "Сомоні", "TJS" });

            migrationBuilder.UpdateData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "FullName", "Name" },
                values: new object[] { "Ларі", "GEL" });

            migrationBuilder.UpdateData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "FullName", "Name" },
                values: new object[] { "Бразильський реал", "BRL" });

            migrationBuilder.UpdateData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "FullName", "Name" },
                values: new object[] { "Золото", "XAU" });

            migrationBuilder.UpdateData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "FullName", "Name" },
                values: new object[] { "Срібло", "XAG" });

            migrationBuilder.UpdateData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "FullName", "Name" },
                values: new object[] { "Платина", "XPT" });

            migrationBuilder.UpdateData(
                table: "TypesMonies",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "FullName", "Name" },
                values: new object[] { "Паладій", "XPD" });
        }
    }
}
