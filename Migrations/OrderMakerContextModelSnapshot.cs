﻿/*
    OrderMaker - http://ordermaker.org
    Copyright(c) 2019 Oleg Bruev. All rights reserved.

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.If not, see https://www.gnu.org/licenses/.
*/

using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Mtd.OrderMaker.Web.Data;

namespace Mtd.OrderMaker.Web.Migrations
{
    [DbContext(typeof(OrderMakerContext))]
    partial class OrderMakerContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Mtd.OrderMaker.Web.Data.MtdFilter", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("int(11)");

                    b.Property<string>("IdUser")
                        .IsRequired()
                        .HasColumnName("idUser")
                        .HasColumnType("varchar(36)");

                    b.Property<string>("MtdForm")
                        .IsRequired()
                        .HasColumnName("mtd_form")
                        .HasColumnType("varchar(36)");

                    b.Property<int>("Page")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("page")
                        .HasColumnType("int(11)")
                        .HasDefaultValueSql("'1'");

                    b.Property<int>("PageSize")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("page_size")
                        .HasColumnType("int(11)")
                        .HasDefaultValueSql("'10'");

                    b.Property<string>("SearchNumber")
                        .IsRequired()
                        .HasColumnName("searchNumber")
                        .HasColumnType("varchar(45)");

                    b.Property<string>("SearchText")
                        .IsRequired()
                        .HasColumnName("searchText")
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique()
                        .HasName("id_UNIQUE");

                    b.HasIndex("IdUser")
                        .HasName("IX_INDEX_USER");

                    b.HasIndex("MtdForm")
                        .HasName("mtd_filter_mtd_form_idx");

                    b.ToTable("mtd_filter");
                });

            modelBuilder.Entity("Mtd.OrderMaker.Web.Data.MtdFilterColumn", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("int(11)");

                    b.Property<int>("MtdFilter")
                        .HasColumnName("mtd_filter")
                        .HasColumnType("int(11)");

                    b.Property<string>("MtdFormPartField")
                        .IsRequired()
                        .HasColumnName("mtd_form_part_field")
                        .HasColumnType("varchar(36)");

                    b.Property<int>("Sequence")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("sequence")
                        .HasColumnType("int(11)")
                        .HasDefaultValueSql("'0'");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique()
                        .HasName("id_UNIQUE");

                    b.HasIndex("MtdFilter")
                        .HasName("mtd_filter_column_idx");

                    b.HasIndex("MtdFormPartField")
                        .HasName("mtd_roster_field_idx");

                    b.ToTable("mtd_filter_column");
                });

            modelBuilder.Entity("Mtd.OrderMaker.Web.Data.MtdFilterField", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("bigint(20)");

                    b.Property<int>("MtdFilter")
                        .HasColumnName("mtd_filter")
                        .HasColumnType("int(11)");

                    b.Property<string>("MtdFormPartField")
                        .IsRequired()
                        .HasColumnName("mtd_form_part_field")
                        .HasColumnType("varchar(36)");

                    b.Property<int>("MtdTerm")
                        .HasColumnName("mtd_term")
                        .HasColumnType("int(11)");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnName("value")
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique()
                        .HasName("id_UNIQUE");

                    b.HasIndex("MtdFilter")
                        .HasName("mtd_filter_idx");

                    b.HasIndex("MtdFormPartField")
                        .HasName("mtd_filter_field_mtd_form_field_idx");

                    b.HasIndex("MtdTerm")
                        .HasName("mtd_filter_field_term_idx");

                    b.ToTable("mtd_filter_field");
                });

            modelBuilder.Entity("Mtd.OrderMaker.Web.Data.MtdForm", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("varchar(36)");

                    b.Property<sbyte>("Active")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("active")
                        .HasColumnType("tinyint(4)")
                        .HasDefaultValueSql("'1'");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnName("description")
                        .HasColumnType("varchar(512)");

                    b.Property<string>("MtdGroup")
                        .IsRequired()
                        .HasColumnName("mtd_group")
                        .HasColumnType("varchar(36)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("name")
                        .HasColumnType("varchar(120)");

                    b.Property<string>("Parent");

                    b.Property<int>("Sequence")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("sequence")
                        .HasColumnType("int(11)")
                        .HasDefaultValueSql("'0'");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique()
                        .HasName("id_UNIQUE");

                    b.HasIndex("MtdGroup")
                        .HasName("fk_form_grooup_idx");

                    b.HasIndex("Parent");

                    b.ToTable("mtd_form");
                });

            modelBuilder.Entity("Mtd.OrderMaker.Web.Data.MtdFormDesk", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnName("id")
                        .HasColumnType("varchar(36)");

                    b.Property<string>("ColorBack")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnName("color_back")
                        .HasColumnType("varchar(45)")
                        .HasDefaultValueSql("'gray'");

                    b.Property<string>("ColorFont")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnName("color_font")
                        .HasColumnType("varchar(45)")
                        .HasDefaultValueSql("'white'");

                    b.Property<byte[]>("Image")
                        .IsRequired()
                        .HasColumnName("image")
                        .HasColumnType("mediumblob");

                    b.Property<int>("ImageSize")
                        .HasColumnName("image_size")
                        .HasColumnType("int(11)");

                    b.Property<string>("ImageType")
                        .IsRequired()
                        .HasColumnName("image_type")
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique()
                        .HasName("id_UNIQUE");

                    b.ToTable("mtd_form_desk");
                });

            modelBuilder.Entity("Mtd.OrderMaker.Web.Data.MtdFormHeader", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnName("id")
                        .HasColumnType("varchar(36)");

                    b.Property<byte[]>("Image")
                        .IsRequired()
                        .HasColumnName("image")
                        .HasColumnType("mediumblob");

                    b.Property<int>("ImageSize")
                        .HasColumnName("image_size")
                        .HasColumnType("int(11)");

                    b.Property<string>("ImageType")
                        .IsRequired()
                        .HasColumnName("image_type")
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique()
                        .HasName("id_UNIQUE");

                    b.ToTable("mtd_form_header");
                });

            modelBuilder.Entity("Mtd.OrderMaker.Web.Data.MtdFormList", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnName("id")
                        .HasColumnType("varchar(36)");

                    b.Property<string>("MtdForm")
                        .IsRequired()
                        .HasColumnName("mtd_form")
                        .HasColumnType("varchar(36)");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique()
                        .HasName("id_UNIQUE");

                    b.HasIndex("MtdForm")
                        .HasName("fk_list_form_idx");

                    b.ToTable("mtd_form_list");
                });

            modelBuilder.Entity("Mtd.OrderMaker.Web.Data.MtdFormPart", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("varchar(36)");

                    b.Property<sbyte>("Active")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("active")
                        .HasColumnType("tinyint(4)")
                        .HasDefaultValueSql("'1'");

                    b.Property<sbyte>("Child")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("child")
                        .HasColumnType("tinyint(4)")
                        .HasDefaultValueSql("'0'");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnName("description")
                        .HasColumnType("varchar(512)");

                    b.Property<string>("MtdForm")
                        .IsRequired()
                        .HasColumnName("mtd_form")
                        .HasColumnType("varchar(36)");

                    b.Property<int>("MtdSysStyle")
                        .HasColumnName("mtd_sys_style")
                        .HasColumnType("int(11)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("name")
                        .HasColumnType("varchar(120)");

                    b.Property<int>("Sequence")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("sequence")
                        .HasColumnType("int(11)")
                        .HasDefaultValueSql("'0'");

                    b.Property<sbyte>("Title")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("title")
                        .HasColumnType("tinyint(4)")
                        .HasDefaultValueSql("'1'");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique()
                        .HasName("id_UNIQUE");

                    b.HasIndex("MtdForm")
                        .HasName("fk_mtd_form_part_mtd_form1_idx");

                    b.HasIndex("MtdSysStyle")
                        .HasName("fk_mtd_form_part_mtd_sys_style1_idx");

                    b.ToTable("mtd_form_part");
                });

            modelBuilder.Entity("Mtd.OrderMaker.Web.Data.MtdFormPartField", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("varchar(36)");

                    b.Property<sbyte>("Active")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("active")
                        .HasColumnType("tinyint(4)")
                        .HasDefaultValueSql("'1'");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnName("description")
                        .HasColumnType("varchar(512)");

                    b.Property<string>("MtdFormPart")
                        .IsRequired()
                        .HasColumnName("mtd_form_part")
                        .HasColumnType("varchar(36)");

                    b.Property<int>("MtdSysType")
                        .HasColumnName("mtd_sys_type")
                        .HasColumnType("int(11)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("name")
                        .HasColumnType("varchar(120)");

                    b.Property<sbyte>("Required")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("required")
                        .HasColumnType("tinyint(4)")
                        .HasDefaultValueSql("'0'");

                    b.Property<int>("Sequence")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("sequence")
                        .HasColumnType("int(11)")
                        .HasDefaultValueSql("'0'");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique()
                        .HasName("id_UNIQUE");

                    b.HasIndex("MtdFormPart")
                        .HasName("fk_mtd_form_part_field_mtd_form_part1_idx");

                    b.HasIndex("MtdSysType")
                        .HasName("fk_mtd_form_part_field_mtd_sys_type1_idx");

                    b.ToTable("mtd_form_part_field");
                });

            modelBuilder.Entity("Mtd.OrderMaker.Web.Data.MtdFormPartHeader", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnName("id")
                        .HasColumnType("varchar(36)");

                    b.Property<byte[]>("Image")
                        .IsRequired()
                        .HasColumnName("image")
                        .HasColumnType("mediumblob");

                    b.Property<int>("ImageSize")
                        .HasColumnName("image_size")
                        .HasColumnType("int(11)");

                    b.Property<string>("ImageType")
                        .IsRequired()
                        .HasColumnName("image_type")
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique()
                        .HasName("id_UNIQUE");

                    b.ToTable("mtd_form_part_header");
                });

            modelBuilder.Entity("Mtd.OrderMaker.Web.Data.MtdGroupForm", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("varchar(36)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnName("description")
                        .HasColumnType("varchar(512)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("name")
                        .HasColumnType("varchar(120)");

                    b.Property<string>("Parent")
                        .IsRequired()
                        .HasColumnName("parent")
                        .HasColumnType("varchar(36)");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique()
                        .HasName("id_UNIQUE");

                    b.HasIndex("Parent")
                        .HasName("fk_group_themself_idx");

                    b.ToTable("mtd_group_form");
                });

            modelBuilder.Entity("Mtd.OrderMaker.Web.Data.MtdStore", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("varchar(36)");

                    b.Property<sbyte>("Active")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("active")
                        .HasColumnType("tinyint(4)")
                        .HasDefaultValueSql("'0'");

                    b.Property<string>("MtdForm")
                        .IsRequired()
                        .HasColumnName("mtd_form")
                        .HasColumnType("varchar(36)");

                    b.Property<string>("Parent");

                    b.Property<int>("Sequence")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("sequence")
                        .HasColumnType("int(11)")
                        .HasDefaultValueSql("'0'");

                    b.Property<DateTime>("Timecr")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("timecr")
                        .HasColumnType("timestamp")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique()
                        .HasName("id_UNIQUE");

                    b.HasIndex("MtdForm")
                        .HasName("fk_mtd_store_mtd_form1_idx");

                    b.HasIndex("Parent");

                    b.HasIndex("Timecr")
                        .HasName("IX_TIMECR");

                    b.HasIndex("MtdForm", "Sequence")
                        .IsUnique()
                        .HasName("Seq_Unique");

                    b.ToTable("mtd_store");
                });

            modelBuilder.Entity("Mtd.OrderMaker.Web.Data.MtdStoreLink", b =>
                {
                    b.Property<long>("Id")
                        .HasColumnName("id")
                        .HasColumnType("bigint(20)");

                    b.Property<string>("MtdStore")
                        .IsRequired()
                        .HasColumnName("mtd_store")
                        .HasColumnType("varchar(36)");

                    b.Property<string>("Register")
                        .IsRequired()
                        .HasColumnType("varchar(768)");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique()
                        .HasName("id_UNIQUE");

                    b.HasIndex("MtdStore")
                        .HasName("fk_mtd_store_link_mtd_store1_idx");

                    b.HasIndex("MtdStore", "Id")
                        .IsUnique()
                        .HasName("ix_unique");

                    b.ToTable("mtd_store_link");
                });

            modelBuilder.Entity("Mtd.OrderMaker.Web.Data.MtdStoreStack", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("bigint(20)");

                    b.Property<string>("MtdFormPartField")
                        .IsRequired()
                        .HasColumnName("mtd_form_part_field")
                        .HasColumnType("varchar(36)");

                    b.Property<string>("MtdStore")
                        .IsRequired()
                        .HasColumnName("mtd_store")
                        .HasColumnType("varchar(36)");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique()
                        .HasName("id_UNIQUE");

                    b.HasIndex("MtdFormPartField")
                        .HasName("fk_mtd_store_stack_mtd_form_part_field1_idx");

                    b.HasIndex("MtdStore")
                        .HasName("fk_mtd_store_stack_mtd_store_idx");

                    b.HasIndex("MtdStore", "MtdFormPartField")
                        .IsUnique()
                        .HasName("IX_UNIQUE");

                    b.ToTable("mtd_store_stack");
                });

            modelBuilder.Entity("Mtd.OrderMaker.Web.Data.MtdStoreStackDate", b =>
                {
                    b.Property<long>("Id")
                        .HasColumnName("id")
                        .HasColumnType("bigint(20)");

                    b.Property<DateTime>("Register")
                        .HasColumnName("register")
                        .HasColumnType("datetime");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique()
                        .HasName("id_UNIQUE");

                    b.HasIndex("Register")
                        .HasName("IX_DATESTACK");

                    b.ToTable("mtd_store_stack_date");
                });

            modelBuilder.Entity("Mtd.OrderMaker.Web.Data.MtdStoreStackDecimal", b =>
                {
                    b.Property<long>("Id")
                        .HasColumnName("id")
                        .HasColumnType("bigint(20)");

                    b.Property<decimal>("Register")
                        .HasColumnName("register")
                        .HasColumnType("decimal(20,2)");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique()
                        .HasName("id_UNIQUE");

                    b.HasIndex("Register")
                        .HasName("IX_DECIMALREGISTER");

                    b.ToTable("mtd_store_stack_decimal");
                });

            modelBuilder.Entity("Mtd.OrderMaker.Web.Data.MtdStoreStackFile", b =>
                {
                    b.Property<long>("Id")
                        .HasColumnName("id")
                        .HasColumnType("bigint(20)");

                    b.Property<string>("FileName")
                        .IsRequired()
                        .HasColumnName("file_name")
                        .HasColumnType("varchar(256)");

                    b.Property<int>("FileSize")
                        .HasColumnName("file_size")
                        .HasColumnType("int(11)");

                    b.Property<string>("FileType")
                        .IsRequired()
                        .HasColumnName("file_type")
                        .HasColumnType("varchar(256)");

                    b.Property<byte[]>("Register")
                        .IsRequired()
                        .HasColumnName("register")
                        .HasColumnType("mediumblob");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique()
                        .HasName("id_UNIQUE");

                    b.ToTable("mtd_store_stack_file");
                });

            modelBuilder.Entity("Mtd.OrderMaker.Web.Data.MtdStoreStackInt", b =>
                {
                    b.Property<long>("Id")
                        .HasColumnName("id")
                        .HasColumnType("bigint(20)");

                    b.Property<int>("Register")
                        .HasColumnName("register")
                        .HasColumnType("int(11)");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique()
                        .HasName("id_UNIQUE");

                    b.HasIndex("Register")
                        .HasName("IX_INTSTACK");

                    b.ToTable("mtd_store_stack_int");
                });

            modelBuilder.Entity("Mtd.OrderMaker.Web.Data.MtdStoreStackText", b =>
                {
                    b.Property<long>("Id")
                        .HasColumnName("id")
                        .HasColumnType("bigint(20)");

                    b.Property<string>("Register")
                        .IsRequired()
                        .HasColumnName("register")
                        .HasColumnType("varchar(768)");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique()
                        .HasName("category_id_UNIQUE");

                    b.HasIndex("Register")
                        .HasName("IX_REGISTER_TEXT");

                    b.ToTable("mtd_store_stack_text");
                });

            modelBuilder.Entity("Mtd.OrderMaker.Web.Data.MtdSysStyle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("int(11)");

                    b.Property<sbyte>("Active")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("active")
                        .HasColumnType("tinyint(4)")
                        .HasDefaultValueSql("'1'");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnName("description")
                        .HasColumnType("varchar(512)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("name")
                        .HasColumnType("varchar(120)");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique()
                        .HasName("id_UNIQUE");

                    b.ToTable("mtd_sys_style");
                });

            modelBuilder.Entity("Mtd.OrderMaker.Web.Data.MtdSysTerm", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("int(11)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("name")
                        .HasColumnType("varchar(45)");

                    b.Property<string>("Sign")
                        .IsRequired()
                        .HasColumnName("sign")
                        .HasColumnType("varchar(45)");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique()
                        .HasName("id_UNIQUE");

                    b.ToTable("mtd_sys_term");
                });

            modelBuilder.Entity("Mtd.OrderMaker.Web.Data.MtdSysType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("int(11)");

                    b.Property<sbyte>("Active")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("active")
                        .HasColumnType("tinyint(4)")
                        .HasDefaultValueSql("'1'");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnName("description")
                        .HasColumnType("varchar(512)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("name")
                        .HasColumnType("varchar(120)");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique()
                        .HasName("id_UNIQUE");

                    b.ToTable("mtd_sys_type");
                });

            modelBuilder.Entity("Mtd.OrderMaker.Web.Data.MtdFilter", b =>
                {
                    b.HasOne("Mtd.OrderMaker.Web.Data.MtdForm", "MtdFormNavigation")
                        .WithMany("MtdFilter")
                        .HasForeignKey("MtdForm")
                        .HasConstraintName("mtd_filter_mtd_form")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Mtd.OrderMaker.Web.Data.MtdFilterColumn", b =>
                {
                    b.HasOne("Mtd.OrderMaker.Web.Data.MtdFilter", "MtdFilterNavigation")
                        .WithMany("MtdFilterColumn")
                        .HasForeignKey("MtdFilter")
                        .HasConstraintName("mtd_filter_column_mtd_field")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Mtd.OrderMaker.Web.Data.MtdFormPartField", "MtdFormPartFieldNavigation")
                        .WithMany("MtdFilterColumn")
                        .HasForeignKey("MtdFormPartField")
                        .HasConstraintName("mtd_roster_field")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Mtd.OrderMaker.Web.Data.MtdFilterField", b =>
                {
                    b.HasOne("Mtd.OrderMaker.Web.Data.MtdFilter", "MtdFilterNavigation")
                        .WithMany("MtdFilterField")
                        .HasForeignKey("MtdFilter")
                        .HasConstraintName("mtd_filter_field_mtd_field")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Mtd.OrderMaker.Web.Data.MtdFormPartField", "MtdFormPartFieldNavigation")
                        .WithMany("MtdFilterField")
                        .HasForeignKey("MtdFormPartField")
                        .HasConstraintName("mtd_filter_field_mtd_form_field")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Mtd.OrderMaker.Web.Data.MtdSysTerm", "MtdTermNavigation")
                        .WithMany("MtdFilterField")
                        .HasForeignKey("MtdTerm")
                        .HasConstraintName("mtd_filter_field_mtd_term")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Mtd.OrderMaker.Web.Data.MtdForm", b =>
                {
                    b.HasOne("Mtd.OrderMaker.Web.Data.MtdGroupForm", "MtdGroupNavigation")
                        .WithMany("MtdForm")
                        .HasForeignKey("MtdGroup")
                        .HasConstraintName("fk_form_grooup")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Mtd.OrderMaker.Web.Data.MtdForm", "ParentNavigation")
                        .WithMany("InverseParentNavigation")
                        .HasForeignKey("Parent")
                        .HasConstraintName("fk_form_parent")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Mtd.OrderMaker.Web.Data.MtdFormDesk", b =>
                {
                    b.HasOne("Mtd.OrderMaker.Web.Data.MtdForm", "IdNavigation")
                        .WithOne("MtdFormDesk")
                        .HasForeignKey("Mtd.OrderMaker.Web.Data.MtdFormDesk", "Id")
                        .HasConstraintName("fk_mtd_form_des_mtd_from")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Mtd.OrderMaker.Web.Data.MtdFormHeader", b =>
                {
                    b.HasOne("Mtd.OrderMaker.Web.Data.MtdForm", "IdNavigation")
                        .WithOne("MtdFormHeader")
                        .HasForeignKey("Mtd.OrderMaker.Web.Data.MtdFormHeader", "Id")
                        .HasConstraintName("fk_image_form")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Mtd.OrderMaker.Web.Data.MtdFormList", b =>
                {
                    b.HasOne("Mtd.OrderMaker.Web.Data.MtdFormPartField", "IdNavigation")
                        .WithOne("MtdFormList")
                        .HasForeignKey("Mtd.OrderMaker.Web.Data.MtdFormList", "Id")
                        .HasConstraintName("fk_list_field")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Mtd.OrderMaker.Web.Data.MtdForm", "MtdFormNavigation")
                        .WithMany("MtdFormList")
                        .HasForeignKey("MtdForm")
                        .HasConstraintName("fk_list_form")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Mtd.OrderMaker.Web.Data.MtdFormPart", b =>
                {
                    b.HasOne("Mtd.OrderMaker.Web.Data.MtdForm", "MtdFormNavigation")
                        .WithMany("MtdFormPart")
                        .HasForeignKey("MtdForm")
                        .HasConstraintName("fk_mtd_form_part_mtd_form1")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Mtd.OrderMaker.Web.Data.MtdSysStyle", "MtdSysStyleNavigation")
                        .WithMany("MtdFormPart")
                        .HasForeignKey("MtdSysStyle")
                        .HasConstraintName("fk_mtd_form_part_mtd_sys_style1")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Mtd.OrderMaker.Web.Data.MtdFormPartField", b =>
                {
                    b.HasOne("Mtd.OrderMaker.Web.Data.MtdFormPart", "MtdFormPartNavigation")
                        .WithMany("MtdFormPartField")
                        .HasForeignKey("MtdFormPart")
                        .HasConstraintName("fk_mtd_form_part_field_mtd_form_part1")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Mtd.OrderMaker.Web.Data.MtdSysType", "MtdSysTypeNavigation")
                        .WithMany("MtdFormPartField")
                        .HasForeignKey("MtdSysType")
                        .HasConstraintName("fk_mtd_form_part_field_mtd_sys_type1")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Mtd.OrderMaker.Web.Data.MtdFormPartHeader", b =>
                {
                    b.HasOne("Mtd.OrderMaker.Web.Data.MtdFormPart", "IdNavigation")
                        .WithOne("MtdFormPartHeader")
                        .HasForeignKey("Mtd.OrderMaker.Web.Data.MtdFormPartHeader", "Id")
                        .HasConstraintName("fk_image_form_part")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Mtd.OrderMaker.Web.Data.MtdStore", b =>
                {
                    b.HasOne("Mtd.OrderMaker.Web.Data.MtdForm", "MtdFormNavigation")
                        .WithMany("MtdStore")
                        .HasForeignKey("MtdForm")
                        .HasConstraintName("fk_mtd_store_mtd_form1")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Mtd.OrderMaker.Web.Data.MtdStore", "ParentNavigation")
                        .WithMany("InverseParentNavigation")
                        .HasForeignKey("Parent")
                        .HasConstraintName("fk_mtd_store_parent")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Mtd.OrderMaker.Web.Data.MtdStoreLink", b =>
                {
                    b.HasOne("Mtd.OrderMaker.Web.Data.MtdStoreStack", "IdNavigation")
                        .WithOne("MtdStoreLink")
                        .HasForeignKey("Mtd.OrderMaker.Web.Data.MtdStoreLink", "Id")
                        .HasConstraintName("fk_mtd_store_link_mtd_store_stack")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Mtd.OrderMaker.Web.Data.MtdStore", "MtdStoreNavigation")
                        .WithMany("MtdStoreLink")
                        .HasForeignKey("MtdStore")
                        .HasConstraintName("fk_mtd_store_link_mtd_store1")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Mtd.OrderMaker.Web.Data.MtdStoreStack", b =>
                {
                    b.HasOne("Mtd.OrderMaker.Web.Data.MtdFormPartField", "MtdFormPartFieldNavigation")
                        .WithMany("MtdStoreStack")
                        .HasForeignKey("MtdFormPartField")
                        .HasConstraintName("fk_mtd_store_stack_mtd_form_part_field1")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Mtd.OrderMaker.Web.Data.MtdStore", "MtdStoreNavigation")
                        .WithMany("MtdStoreStack")
                        .HasForeignKey("MtdStore")
                        .HasConstraintName("fk_mtd_store_stack_mtd_store")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Mtd.OrderMaker.Web.Data.MtdStoreStackDate", b =>
                {
                    b.HasOne("Mtd.OrderMaker.Web.Data.MtdStoreStack", "IdNavigation")
                        .WithOne("MtdStoreStackDate")
                        .HasForeignKey("Mtd.OrderMaker.Web.Data.MtdStoreStackDate", "Id")
                        .HasConstraintName("fk_date_stack")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Mtd.OrderMaker.Web.Data.MtdStoreStackDecimal", b =>
                {
                    b.HasOne("Mtd.OrderMaker.Web.Data.MtdStoreStack", "IdNavigation")
                        .WithOne("MtdStoreStackDecimal")
                        .HasForeignKey("Mtd.OrderMaker.Web.Data.MtdStoreStackDecimal", "Id")
                        .HasConstraintName("fk_decimal_stack")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Mtd.OrderMaker.Web.Data.MtdStoreStackFile", b =>
                {
                    b.HasOne("Mtd.OrderMaker.Web.Data.MtdStoreStack", "IdNavigation")
                        .WithOne("MtdStoreStackFile")
                        .HasForeignKey("Mtd.OrderMaker.Web.Data.MtdStoreStackFile", "Id")
                        .HasConstraintName("fk_file_stack")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Mtd.OrderMaker.Web.Data.MtdStoreStackInt", b =>
                {
                    b.HasOne("Mtd.OrderMaker.Web.Data.MtdStoreStack", "IdNavigation")
                        .WithOne("MtdStoreStackInt")
                        .HasForeignKey("Mtd.OrderMaker.Web.Data.MtdStoreStackInt", "Id")
                        .HasConstraintName("fk_int_stack")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Mtd.OrderMaker.Web.Data.MtdStoreStackText", b =>
                {
                    b.HasOne("Mtd.OrderMaker.Web.Data.MtdStoreStack", "IdNavigation")
                        .WithOne("MtdStoreStackText")
                        .HasForeignKey("Mtd.OrderMaker.Web.Data.MtdStoreStackText", "Id")
                        .HasConstraintName("fk_text_stack")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
