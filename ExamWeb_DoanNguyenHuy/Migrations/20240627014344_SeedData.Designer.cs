﻿// <auto-generated />
using ExamWeb_DoanNguyenHuy.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ExamWeb_DoanNguyenHuy.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240627014344_SeedData")]
    partial class SeedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ExamWeb_DoanNguyenHuy.Models.Phim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DienVien")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("GiaVe")
                        .HasColumnType("float");

                    b.Property<int>("ThoiLuong")
                        .HasColumnType("int");

                    b.Property<bool>("TrongNuoc")
                        .HasColumnType("bit");

                    b.Property<string>("TuaDe")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("Id");

                    b.ToTable("Phims");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DienVien = "Huyền Lizzie, Mạnh Trường",
                            GiaVe = 150000.0,
                            ThoiLuong = 110,
                            TrongNuoc = true,
                            TuaDe = "Chúng ta của 8 năm sau"
                        },
                        new
                        {
                            Id = 2,
                            DienVien = "Sam Worthington",
                            GiaVe = 250000.0,
                            ThoiLuong = 161,
                            TrongNuoc = false,
                            TuaDe = "Avatar"
                        },
                        new
                        {
                            Id = 3,
                            DienVien = "Đình Tú, Anh Đào",
                            GiaVe = 160000.0,
                            ThoiLuong = 105,
                            TrongNuoc = true,
                            TuaDe = "Gặp em ngày nắng"
                        },
                        new
                        {
                            Id = 4,
                            DienVien = "Hoàng Thùy Linh, Nhan Phúc Vinh",
                            GiaVe = 120000.0,
                            ThoiLuong = 150,
                            TrongNuoc = true,
                            TuaDe = "Không ngại cưới"
                        },
                        new
                        {
                            Id = 5,
                            DienVien = "Đức Khuê, Nguyệt Hằng",
                            GiaVe = 130000.0,
                            ThoiLuong = 120,
                            TrongNuoc = true,
                            TuaDe = "Gia đình đại chiến"
                        },
                        new
                        {
                            Id = 6,
                            DienVien = "Arnold Schwarzenegger",
                            GiaVe = 210000.0,
                            ThoiLuong = 107,
                            TrongNuoc = false,
                            TuaDe = "Kẻ Huỷ Diệt "
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
