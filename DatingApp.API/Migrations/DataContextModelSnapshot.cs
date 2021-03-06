﻿// <auto-generated />
using DatingApp.API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DatingApp.API.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DatingApp.API.Models.DumpModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("DumpModel");

                    b.HasData(
                        new { Id = 1, Name = "Monaco" },
                        new { Id = 2, Name = "S. Georgia and S. Sandwich Isls." },
                        new { Id = 3, Name = "Malawi" },
                        new { Id = 4, Name = "Micronesia" },
                        new { Id = 5, Name = "Turkmenistan" },
                        new { Id = 6, Name = "Mexico" },
                        new { Id = 7, Name = "United Arab Emirates" },
                        new { Id = 8, Name = "France, Metropolitan" },
                        new { Id = 9, Name = "Namibia" },
                        new { Id = 10, Name = "New Zealand" },
                        new { Id = 11, Name = "Oman" },
                        new { Id = 12, Name = "Heard and McDonald Islands" },
                        new { Id = 13, Name = "Tuvalu" },
                        new { Id = 14, Name = "Germany" },
                        new { Id = 15, Name = "Australia" },
                        new { Id = 16, Name = "Sao Tome and Principe" },
                        new { Id = 17, Name = "Northern Mariana Islands" },
                        new { Id = 18, Name = "Czech Republic" },
                        new { Id = 19, Name = "Bhutan" },
                        new { Id = 20, Name = "Virgin Islands (US)" },
                        new { Id = 21, Name = "Gambia" },
                        new { Id = 22, Name = "Angola" },
                        new { Id = 23, Name = "South Africa" },
                        new { Id = 24, Name = "Puerto Rico" },
                        new { Id = 25, Name = "Ecuador" },
                        new { Id = 26, Name = "Saint Kitts and Nevis" },
                        new { Id = 27, Name = "Sierra Leone" },
                        new { Id = 28, Name = "Brunei Darussalam" },
                        new { Id = 29, Name = "Christmas Island" },
                        new { Id = 30, Name = "Vatican City State (Holy See)" },
                        new { Id = 31, Name = "Tokelau" },
                        new { Id = 32, Name = "Botswana" },
                        new { Id = 33, Name = "Trinidad and Tobago" },
                        new { Id = 34, Name = "Jordan" },
                        new { Id = 35, Name = "Bahamas" },
                        new { Id = 36, Name = "Qatar" },
                        new { Id = 37, Name = "Comoros" },
                        new { Id = 38, Name = "American Samoa" },
                        new { Id = 39, Name = "Solomon Islands" },
                        new { Id = 40, Name = "Bahrain" },
                        new { Id = 41, Name = "Venezuela" },
                        new { Id = 42, Name = "Slovenia" },
                        new { Id = 43, Name = "Burkina Faso" },
                        new { Id = 44, Name = "Montserrat" }
                    );
                });
#pragma warning restore 612, 618
        }
    }
}
