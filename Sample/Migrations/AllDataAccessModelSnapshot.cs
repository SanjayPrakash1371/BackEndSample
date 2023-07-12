﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Sample.DbConnect;

#nullable disable

namespace Sample.Migrations
{
    [DbContext(typeof(AllDataAccess))]
    partial class AllDataAccessModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Sample.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Designation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("empId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("Sample.Models.OtherRewards.LeadCitation", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("citation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nominatorId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("LeadCitation");
                });

            modelBuilder.Entity("Sample.Models.OtherRewards.LeadCitationReplies", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int?>("CampaignsId")
                        .HasColumnType("int");

                    b.Property<int>("CitationId")
                        .HasColumnType("int");

                    b.Property<string>("Replycitation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("campId")
                        .HasColumnType("int");

                    b.Property<int>("nominatorId")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("CampaignsId");

                    b.HasIndex("CitationId");

                    b.ToTable("LeadCitationReplies");
                });

            modelBuilder.Entity("Sample.Models.OtherRewards.LeadRewardResults", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int?>("CampaignsId")
                        .HasColumnType("int");

                    b.Property<string>("awardType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("campId")
                        .HasColumnType("int");

                    b.Property<string>("campname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("employeeId")
                        .HasColumnType("int");

                    b.Property<string>("nominatedEmpId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nominatorId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("rewardId")
                        .HasColumnType("int");

                    b.Property<int>("stars")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("CampaignsId");

                    b.HasIndex("employeeId");

                    b.ToTable("LeadRewardResults");
                });

            modelBuilder.Entity("Sample.Models.OtherRewards.LeadRewards", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("CampaignsId")
                        .HasColumnType("int");

                    b.Property<int>("LeadCitationid")
                        .HasColumnType("int");

                    b.Property<int>("LeadRewardResultsid")
                        .HasColumnType("int");

                    b.Property<string>("awardCategory")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("campId")
                        .HasColumnType("int");

                    b.Property<int?>("employeeId")
                        .HasColumnType("int");

                    b.Property<int>("month")
                        .HasColumnType("int");

                    b.Property<string>("nominatedEmpId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nominatorId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("rewardId")
                        .HasColumnType("int");

                    b.Property<int>("stars")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("CampaignsId");

                    b.HasIndex("LeadCitationid");

                    b.HasIndex("LeadRewardResultsid");

                    b.HasIndex("employeeId");

                    b.ToTable("LeadRewards");
                });

            modelBuilder.Entity("Sample.Models.P2P.PeerToPeer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("Resultsid")
                        .HasColumnType("int");

                    b.Property<string>("awardCategory")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("campId")
                        .HasColumnType("int");

                    b.Property<int?>("campaignsId")
                        .HasColumnType("int");

                    b.Property<string>("citation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("empId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("employeeId")
                        .HasColumnType("int");

                    b.Property<int?>("month")
                        .HasColumnType("int");

                    b.Property<string>("nominatorId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Resultsid");

                    b.HasIndex("campaignsId");

                    b.HasIndex("employeeId");

                    b.ToTable("PeerToPeer");
                });

            modelBuilder.Entity("Sample.Models.P2P.PeerToPeerResults", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("citation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("employeeId")
                        .HasColumnType("int");

                    b.Property<string>("nomainatedEmpId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nomainaterId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("employeeId");

                    b.ToTable("PeerToPeerResults");
                });

            modelBuilder.Entity("Sample.Models.Rewards.Campaigns", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("End")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Start")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("rewardId")
                        .HasColumnType("int");

                    b.Property<int?>("typesid")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("typesid");

                    b.ToTable("Campaigns");
                });

            modelBuilder.Entity("Sample.Models.Rewards.RewardsTypes", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("RewardTypes")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("RewardsTypes");
                });

            modelBuilder.Entity("Sample.Models.Roles", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("empId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("roles")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("Sample.Models.OtherRewards.LeadCitationReplies", b =>
                {
                    b.HasOne("Sample.Models.Rewards.Campaigns", "Campaigns")
                        .WithMany()
                        .HasForeignKey("CampaignsId");

                    b.HasOne("Sample.Models.OtherRewards.LeadCitation", "leadCitation")
                        .WithMany("replies")
                        .HasForeignKey("CitationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Campaigns");

                    b.Navigation("leadCitation");
                });

            modelBuilder.Entity("Sample.Models.OtherRewards.LeadRewardResults", b =>
                {
                    b.HasOne("Sample.Models.Rewards.Campaigns", "Campaigns")
                        .WithMany()
                        .HasForeignKey("CampaignsId");

                    b.HasOne("Sample.Models.Employee", "employee")
                        .WithMany()
                        .HasForeignKey("employeeId");

                    b.Navigation("Campaigns");

                    b.Navigation("employee");
                });

            modelBuilder.Entity("Sample.Models.OtherRewards.LeadRewards", b =>
                {
                    b.HasOne("Sample.Models.Rewards.Campaigns", "Campaigns")
                        .WithMany()
                        .HasForeignKey("CampaignsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Sample.Models.OtherRewards.LeadCitation", "LeadCitation")
                        .WithMany()
                        .HasForeignKey("LeadCitationid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Sample.Models.OtherRewards.LeadRewardResults", "LeadRewardResults")
                        .WithMany()
                        .HasForeignKey("LeadRewardResultsid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Sample.Models.Employee", "employee")
                        .WithMany()
                        .HasForeignKey("employeeId");

                    b.Navigation("Campaigns");

                    b.Navigation("LeadCitation");

                    b.Navigation("LeadRewardResults");

                    b.Navigation("employee");
                });

            modelBuilder.Entity("Sample.Models.P2P.PeerToPeer", b =>
                {
                    b.HasOne("Sample.Models.P2P.PeerToPeerResults", "Results")
                        .WithMany()
                        .HasForeignKey("Resultsid");

                    b.HasOne("Sample.Models.Rewards.Campaigns", "campaigns")
                        .WithMany()
                        .HasForeignKey("campaignsId");

                    b.HasOne("Sample.Models.Employee", "employee")
                        .WithMany()
                        .HasForeignKey("employeeId");

                    b.Navigation("Results");

                    b.Navigation("campaigns");

                    b.Navigation("employee");
                });

            modelBuilder.Entity("Sample.Models.P2P.PeerToPeerResults", b =>
                {
                    b.HasOne("Sample.Models.Employee", "employee")
                        .WithMany()
                        .HasForeignKey("employeeId");

                    b.Navigation("employee");
                });

            modelBuilder.Entity("Sample.Models.Rewards.Campaigns", b =>
                {
                    b.HasOne("Sample.Models.Rewards.RewardsTypes", "types")
                        .WithMany()
                        .HasForeignKey("typesid");

                    b.Navigation("types");
                });

            modelBuilder.Entity("Sample.Models.OtherRewards.LeadCitation", b =>
                {
                    b.Navigation("replies");
                });
#pragma warning restore 612, 618
        }
    }
}
