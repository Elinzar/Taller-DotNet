﻿// <auto-generated />
using Commercial_Office.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Commercial_Office.Migrations
{
    [DbContext(typeof(CommercialOfficeDbContext))]
    partial class CommercialOfficeDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Commercial_Office.Model.AttentionPlace", b =>
                {
                    b.Property<long>("AttentionPlaceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("PlaceId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("AttentionPlaceId"));

                    b.Property<bool>("IsAvailable")
                        .HasColumnType("bit")
                        .HasColumnName("State");

                    b.Property<long>("Number")
                        .HasColumnType("bigint")
                        .HasColumnName("place_number");

                    b.Property<string>("OfficeIdentificator")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("AttentionPlaceId");

                    b.HasIndex("OfficeIdentificator");

                    b.ToTable("AttentionPlaces");
                });

            modelBuilder.Entity("Commercial_Office.Model.Office", b =>
                {
                    b.Property<string>("Identificator")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Identificator");

                    b.ToTable("Offices");
                });

            modelBuilder.Entity("Commercial_Office.Model.AttentionPlace", b =>
                {
                    b.HasOne("Commercial_Office.Model.Office", null)
                        .WithMany("AttentionPlaceList")
                        .HasForeignKey("OfficeIdentificator");
                });

            modelBuilder.Entity("Commercial_Office.Model.Office", b =>
                {
                    b.Navigation("AttentionPlaceList");
                });
#pragma warning restore 612, 618
        }
    }
}