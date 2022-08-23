﻿// <auto-generated />
using System;
using Api.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220821131400_DeleteBank")]
    partial class DeleteBank
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Core.Entities.CardEntity.Card", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CVC2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CardTerm")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateAdded")
                        .HasColumnType("datetime2");

                    b.Property<string>("Logo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Number")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Cards");
                });

            modelBuilder.Entity("Core.Entities.CashEntity.Cash", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.Property<int>("TypeMoneyId")
                        .HasColumnType("int");

                    b.Property<int>("WalletId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TypeMoneyId");

                    b.HasIndex("WalletId");

                    b.ToTable("Cash");
                });

            modelBuilder.Entity("Core.Entities.TypesMoney.TypeMoney", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TypesMonies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FullName = "Австралійський долар",
                            Name = "AUD"
                        },
                        new
                        {
                            Id = 2,
                            FullName = "Канадський долар",
                            Name = "CAD"
                        },
                        new
                        {
                            Id = 3,
                            FullName = "Юань Женьміньбі",
                            Name = "CNY"
                        },
                        new
                        {
                            Id = 4,
                            FullName = "Куна",
                            Name = "HRK"
                        },
                        new
                        {
                            Id = 5,
                            FullName = "Чеська крона",
                            Name = "CZK"
                        },
                        new
                        {
                            Id = 6,
                            FullName = "Данська крона",
                            Name = "DKK"
                        },
                        new
                        {
                            Id = 7,
                            FullName = "Гонконгівський долар",
                            Name = "HKD"
                        },
                        new
                        {
                            Id = 8,
                            FullName = "Форинт",
                            Name = "HUF"
                        },
                        new
                        {
                            Id = 9,
                            FullName = "Індійська рупія",
                            Name = "INR"
                        },
                        new
                        {
                            Id = 10,
                            FullName = "Рупія",
                            Name = "IDR"
                        },
                        new
                        {
                            Id = 11,
                            FullName = "Новий ізраїльський шекель",
                            Name = "ILS"
                        },
                        new
                        {
                            Id = 12,
                            FullName = "Єна",
                            Name = "JPY"
                        },
                        new
                        {
                            Id = 13,
                            FullName = "Теньге",
                            Name = "KZT"
                        },
                        new
                        {
                            Id = 14,
                            FullName = "Вона",
                            Name = "KRW"
                        },
                        new
                        {
                            Id = 15,
                            FullName = "Мексиканське песо",
                            Name = "MXN"
                        },
                        new
                        {
                            Id = 16,
                            FullName = "Молдовський лей",
                            Name = "MDL"
                        },
                        new
                        {
                            Id = 17,
                            FullName = "Новозеландський долар",
                            Name = "NZD"
                        },
                        new
                        {
                            Id = 18,
                            FullName = "Норвезька крона",
                            Name = "NOK"
                        },
                        new
                        {
                            Id = 19,
                            FullName = "Російський рубль",
                            Name = "RUB"
                        },
                        new
                        {
                            Id = 20,
                            FullName = "Сінгапурський долар",
                            Name = "SGD"
                        },
                        new
                        {
                            Id = 21,
                            FullName = "Ренд",
                            Name = "ZAR"
                        },
                        new
                        {
                            Id = 22,
                            FullName = "Шведська крона",
                            Name = "SEK"
                        },
                        new
                        {
                            Id = 23,
                            FullName = "Швейцарський франк",
                            Name = "CHF"
                        },
                        new
                        {
                            Id = 24,
                            FullName = "Єгипетський фунт",
                            Name = "EGP"
                        },
                        new
                        {
                            Id = 25,
                            FullName = "Фунт стерлінгів",
                            Name = "GBP"
                        },
                        new
                        {
                            Id = 26,
                            FullName = "Долар США",
                            Name = "USD"
                        },
                        new
                        {
                            Id = 27,
                            FullName = "Білоруський рубль",
                            Name = "BYN"
                        },
                        new
                        {
                            Id = 28,
                            FullName = "Азербайджанський манат",
                            Name = "AZN"
                        },
                        new
                        {
                            Id = 29,
                            FullName = "Румунський лей",
                            Name = "RON"
                        },
                        new
                        {
                            Id = 30,
                            FullName = "Турецька ліра",
                            Name = "TRY"
                        },
                        new
                        {
                            Id = 31,
                            FullName = "СПЗ (спеціальні права запозичення)",
                            Name = "XDR"
                        },
                        new
                        {
                            Id = 32,
                            FullName = "Болгарський лев",
                            Name = "BGN"
                        },
                        new
                        {
                            Id = 33,
                            FullName = "Євро",
                            Name = "EUR"
                        },
                        new
                        {
                            Id = 34,
                            FullName = "Злотий",
                            Name = "PLN"
                        },
                        new
                        {
                            Id = 35,
                            FullName = "Алжирський динар",
                            Name = "DZD"
                        },
                        new
                        {
                            Id = 36,
                            FullName = "Така",
                            Name = "BDT"
                        },
                        new
                        {
                            Id = 37,
                            FullName = "Вірменський драм",
                            Name = "AMD"
                        },
                        new
                        {
                            Id = 38,
                            FullName = "Домініканське песо",
                            Name = "DOP"
                        },
                        new
                        {
                            Id = 39,
                            FullName = "Іранський ріал",
                            Name = "IRR"
                        },
                        new
                        {
                            Id = 40,
                            FullName = "Іракський динар",
                            Name = "IQD"
                        },
                        new
                        {
                            Id = 41,
                            FullName = "Сом",
                            Name = "KGS"
                        },
                        new
                        {
                            Id = 42,
                            FullName = "Ліванський фунт",
                            Name = "LBP"
                        },
                        new
                        {
                            Id = 43,
                            FullName = "Лівійський динар",
                            Name = "LYD"
                        },
                        new
                        {
                            Id = 44,
                            FullName = "Малайзійський ринггіт",
                            Name = "MYR"
                        },
                        new
                        {
                            Id = 45,
                            FullName = "Марокканський дирхам",
                            Name = "MAD"
                        },
                        new
                        {
                            Id = 46,
                            FullName = "Пакистанська рупія",
                            Name = "PKR"
                        },
                        new
                        {
                            Id = 47,
                            FullName = "Саудівський ріял",
                            Name = "SAR"
                        },
                        new
                        {
                            Id = 48,
                            FullName = "Донг",
                            Name = "VND"
                        },
                        new
                        {
                            Id = 49,
                            FullName = "Бат",
                            Name = "THB"
                        },
                        new
                        {
                            Id = 50,
                            FullName = "Дирхам ОАЕ",
                            Name = "AED"
                        },
                        new
                        {
                            Id = 51,
                            FullName = "Туніський динар",
                            Name = "TND"
                        },
                        new
                        {
                            Id = 52,
                            FullName = "Узбецький сум",
                            Name = "UZS"
                        },
                        new
                        {
                            Id = 53,
                            FullName = "Новий тайванський долар",
                            Name = "TWD"
                        },
                        new
                        {
                            Id = 54,
                            FullName = "Туркменський новий манат",
                            Name = "TMT"
                        },
                        new
                        {
                            Id = 55,
                            FullName = "Сербський динар",
                            Name = "RSD"
                        },
                        new
                        {
                            Id = 56,
                            FullName = "Сомоні",
                            Name = "TJS"
                        },
                        new
                        {
                            Id = 57,
                            FullName = "Ларі",
                            Name = "GEL"
                        },
                        new
                        {
                            Id = 58,
                            FullName = "Бразильський реал",
                            Name = "BRL"
                        },
                        new
                        {
                            Id = 59,
                            FullName = "Золото",
                            Name = "XAU"
                        },
                        new
                        {
                            Id = 60,
                            FullName = "Срібло",
                            Name = "XAG"
                        },
                        new
                        {
                            Id = 61,
                            FullName = "Платина",
                            Name = "XPT"
                        },
                        new
                        {
                            Id = 62,
                            FullName = "Паладій",
                            Name = "XPD"
                        });
                });

            modelBuilder.Entity("Core.Entities.WalletEntity.Wallet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Wallets");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Core.Entities.UserEntity.User", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<string>("AvatarImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("BirthDay")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("User");
                });

            modelBuilder.Entity("Core.Entities.CashEntity.Cash", b =>
                {
                    b.HasOne("Core.Entities.TypesMoney.TypeMoney", "TypeMoney")
                        .WithMany("Cash")
                        .HasForeignKey("TypeMoneyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.WalletEntity.Wallet", "Wallet")
                        .WithMany("Cash")
                        .HasForeignKey("WalletId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TypeMoney");

                    b.Navigation("Wallet");
                });

            modelBuilder.Entity("Core.Entities.WalletEntity.Wallet", b =>
                {
                    b.HasOne("Core.Entities.UserEntity.User", "User")
                        .WithMany("Wallets")
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Core.Entities.TypesMoney.TypeMoney", b =>
                {
                    b.Navigation("Cash");
                });

            modelBuilder.Entity("Core.Entities.WalletEntity.Wallet", b =>
                {
                    b.Navigation("Cash");
                });

            modelBuilder.Entity("Core.Entities.UserEntity.User", b =>
                {
                    b.Navigation("Wallets");
                });
#pragma warning restore 612, 618
        }
    }
}
