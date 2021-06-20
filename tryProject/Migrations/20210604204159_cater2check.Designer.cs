﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using tryProject.Data;

namespace tryProject.Migrations
{
    [DbContext(typeof(tryProjectContext))]
    [Migration("20210604204159_cater2check")]
    partial class cater2check
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AssociationCatersTo", b =>
                {
                    b.Property<int>("AssociationsId")
                        .HasColumnType("int");

                    b.Property<int>("CatersToId")
                        .HasColumnType("int");

                    b.HasKey("AssociationsId", "CatersToId");

                    b.HasIndex("CatersToId");

                    b.ToTable("AssociationCatersTo");
                });

            modelBuilder.Entity("AssociationPurpose", b =>
                {
                    b.Property<int>("AssociationId")
                        .HasColumnType("int");

                    b.Property<int>("PurposesId")
                        .HasColumnType("int");

                    b.HasKey("AssociationId", "PurposesId");

                    b.HasIndex("PurposesId");

                    b.ToTable("AssociationPurpose");
                });

            modelBuilder.Entity("AssociationZone", b =>
                {
                    b.Property<int>("AssociationId")
                        .HasColumnType("int");

                    b.Property<int>("ZonesId")
                        .HasColumnType("int");

                    b.HasKey("AssociationId", "ZonesId");

                    b.HasIndex("ZonesId");

                    b.ToTable("AssociationZone");
                });

            modelBuilder.Entity("tryProject.Models.Association", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Email")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Website")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Association");
                });

            modelBuilder.Entity("tryProject.Models.CatersTo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CatersTo");
                });

            modelBuilder.Entity("tryProject.Models.CommunityWorks", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AssociationId")
                        .HasColumnType("int");

                    b.Property<string>("Decscription")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("WorkOrGiveId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AssociationId");

                    b.HasIndex("WorkOrGiveId");

                    b.ToTable("CommunityWorks");
                });

            modelBuilder.Entity("tryProject.Models.Manager", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AssociationId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AssociationId")
                        .IsUnique();

                    b.ToTable("Manager");
                });

            modelBuilder.Entity("tryProject.Models.MoneyDonation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AssociationId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PurposeId")
                        .HasColumnType("int");

                    b.Property<int>("RaisedSoFar")
                        .HasColumnType("int");

                    b.Property<int>("Sum")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AssociationId");

                    b.HasIndex("PurposeId");

                    b.ToTable("MoneyDonation");
                });

            modelBuilder.Entity("tryProject.Models.Purpose", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Purpose");
                });

            modelBuilder.Entity("tryProject.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<bool>("Volunteer")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("tryProject.Models.WorkOrGive", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("WorkOrGive");
                });

            modelBuilder.Entity("tryProject.Models.Zone", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Zone");
                });

            modelBuilder.Entity("AssociationCatersTo", b =>
                {
                    b.HasOne("tryProject.Models.Association", null)
                        .WithMany()
                        .HasForeignKey("AssociationsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("tryProject.Models.CatersTo", null)
                        .WithMany()
                        .HasForeignKey("CatersToId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AssociationPurpose", b =>
                {
                    b.HasOne("tryProject.Models.Association", null)
                        .WithMany()
                        .HasForeignKey("AssociationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("tryProject.Models.Purpose", null)
                        .WithMany()
                        .HasForeignKey("PurposesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AssociationZone", b =>
                {
                    b.HasOne("tryProject.Models.Association", null)
                        .WithMany()
                        .HasForeignKey("AssociationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("tryProject.Models.Zone", null)
                        .WithMany()
                        .HasForeignKey("ZonesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("tryProject.Models.CommunityWorks", b =>
                {
                    b.HasOne("tryProject.Models.Association", "Association")
                        .WithMany("CommunityWorks")
                        .HasForeignKey("AssociationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("tryProject.Models.WorkOrGive", "WorkOrGive")
                        .WithMany("CommunityWorks")
                        .HasForeignKey("WorkOrGiveId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Association");

                    b.Navigation("WorkOrGive");
                });

            modelBuilder.Entity("tryProject.Models.Manager", b =>
                {
                    b.HasOne("tryProject.Models.Association", "Association")
                        .WithOne("Manager")
                        .HasForeignKey("tryProject.Models.Manager", "AssociationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Association");
                });

            modelBuilder.Entity("tryProject.Models.MoneyDonation", b =>
                {
                    b.HasOne("tryProject.Models.Association", "Association")
                        .WithMany()
                        .HasForeignKey("AssociationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("tryProject.Models.Purpose", "Purpose")
                        .WithMany("MoneyDonation")
                        .HasForeignKey("PurposeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Association");

                    b.Navigation("Purpose");
                });

            modelBuilder.Entity("tryProject.Models.Association", b =>
                {
                    b.Navigation("CommunityWorks");

                    b.Navigation("Manager");
                });

            modelBuilder.Entity("tryProject.Models.Purpose", b =>
                {
                    b.Navigation("MoneyDonation");
                });

            modelBuilder.Entity("tryProject.Models.WorkOrGive", b =>
                {
                    b.Navigation("CommunityWorks");
                });
#pragma warning restore 612, 618
        }
    }
}
