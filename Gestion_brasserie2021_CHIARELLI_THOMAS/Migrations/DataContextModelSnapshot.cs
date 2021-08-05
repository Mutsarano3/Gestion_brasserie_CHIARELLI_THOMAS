﻿// <auto-generated />
using Gestion_brasserie2021_CHIARELLI_THOMAS.DataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Gestion_brasserie2021_CHIARELLI_THOMAS.Migrations
{
    [DbContext(typeof(DataContext.DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.8")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Gestion_brasserie2021_CHIARELLI_THOMAS.Models.Beer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Alchool")
                        .HasColumnType("float");

                    b.Property<int>("IdBrewer")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("IdBrewer");

                    b.ToTable("Beers");
                });

            modelBuilder.Entity("Gestion_brasserie2021_CHIARELLI_THOMAS.Models.Brewer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Breweries");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Test"
                        });
                });

            modelBuilder.Entity("Gestion_brasserie2021_CHIARELLI_THOMAS.Models.Wholesaler", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("Id");

                    b.ToTable("Wholesalers");
                });

            modelBuilder.Entity("Gestion_brasserie2021_CHIARELLI_THOMAS.Models.Beer", b =>
                {
                    b.HasOne("Gestion_brasserie2021_CHIARELLI_THOMAS.Models.Brewer", "Brewer")
                        .WithMany()
                        .HasForeignKey("IdBrewer")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Brewer");
                });
#pragma warning restore 612, 618
        }
    }
}
