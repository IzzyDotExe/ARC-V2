﻿// <auto-generated />
using System;
using Arc.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ARC.Migrations
{
    [DbContext(typeof(ArcDbContext))]
    [Migration("20230408134552_ArcV2-1.1")]
    partial class ArcV211
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0-preview.2.23128.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Arc.Schema.Appeal", b =>
                {
                    b.Property<long>("AppealId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("AppealId"));

                    b.Property<DateTime>("NextAppeal")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long>("UserSnowflake")
                        .HasColumnType("bigint");

                    b.HasKey("AppealId");

                    b.ToTable("Appeals");
                });

            modelBuilder.Entity("Arc.Schema.GuildConfig", b =>
                {
                    b.Property<int>("ConfigId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ConfigId"));

                    b.Property<long>("ConfigGuildSnowflake")
                        .HasColumnType("bigint");

                    b.Property<string>("ConfigKey")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ConfigValue")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("ConfigId");

                    b.ToTable("GuildConfigs");
                });

            modelBuilder.Entity("Arc.Schema.Modmail", b =>
                {
                    b.Property<long>("ModmailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("ModmailId"));

                    b.Property<long>("ChannelSnowflake")
                        .HasColumnType("bigint");

                    b.Property<long>("UserSnowflake")
                        .HasColumnType("bigint");

                    b.Property<long>("WebhookSnowflake")
                        .HasColumnType("bigint");

                    b.HasKey("ModmailId");

                    b.ToTable("Modmails");
                });

            modelBuilder.Entity("Arc.Schema.UserNote", b =>
                {
                    b.Property<long>("NoteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("NoteId"));

                    b.Property<long>("AuthorSnowflake")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("DateAdded")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long>("GuildSnowflake")
                        .HasColumnType("bigint");

                    b.Property<string>("Note")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<long>("UserSnowflake")
                        .HasColumnType("bigint");

                    b.HasKey("NoteId");

                    b.ToTable("UserNotes");
                });
#pragma warning restore 612, 618
        }
    }
}
