﻿// <auto-generated />
using System;
using EntityFrameworkStartingPoint.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EntityFrameworkStartingPoint.Migrations
{
    [DbContext(typeof(SuperheroesContext))]
    [Migration("20190516193856_InitialMirgration8")]
    partial class InitialMirgration8
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EntityFrameworkStartingPoint.Controllers.ResponseObjects.SuperHero", b =>
                {
                    b.Property<int>("SuperheroId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Abilities")
                        .HasMaxLength(50);

                    b.Property<int?>("AgeAtOrigin");

                    b.Property<bool>("IsAlien");

                    b.Property<string>("OriginStory")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("SecretIdentity")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("SuperheroName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int>("UniverseId");

                    b.Property<int>("YearOfAppearance");

                    b.HasKey("SuperheroId");

                    b.HasIndex("UniverseId");

                    b.ToTable("Heros");
                });

            modelBuilder.Entity("EntityFrameworkStartingPoint.Controllers.ResponseObjects.Universe", b =>
                {
                    b.Property<int>("UniverseId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ParentCompany")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("UniverseName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("UniverseId");

                    b.ToTable("Universes");
                });

            modelBuilder.Entity("EntityFrameworkStartingPoint.Controllers.ResponseObjects.SuperHero", b =>
                {
                    b.HasOne("EntityFrameworkStartingPoint.Controllers.ResponseObjects.Universe", "universe")
                        .WithMany()
                        .HasForeignKey("UniverseId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
