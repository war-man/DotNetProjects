﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Sample.DataContext;

namespace Sample.Migrations
{
    [DbContext(typeof(DataDbContext))]
    [Migration("20210416023952_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Sample.Entitys.Archives", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime")
                        .HasComment("创建时间");

                    b.Property<string>("No")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<Guid>("StudentId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("StudentId")
                        .IsUnique();

                    b.ToTable("Archives");

                    b
                        .HasComment("档案表");

                    b.HasData(
                        new
                        {
                            Id = new Guid("4abb3198-87fd-a81f-41a1-40dfb58f47e7"),
                            CreateTime = new DateTime(2021, 4, 16, 10, 39, 51, 322, DateTimeKind.Local).AddTicks(1096),
                            No = "A0001",
                            StudentId = new Guid("2fa2c303-ca6e-8a08-8693-b8a7352d9c95")
                        },
                        new
                        {
                            Id = new Guid("5c496296-e9f1-80ee-1b94-5bbcbd706c49"),
                            CreateTime = new DateTime(2021, 4, 16, 10, 39, 51, 328, DateTimeKind.Local).AddTicks(629),
                            No = "A0002",
                            StudentId = new Guid("590b2674-0d2d-9c2c-57f1-2813c04bdc69")
                        });
                });

            modelBuilder.Entity("Sample.Entitys.Class", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Class");

                    b
                        .HasComment("班级表");

                    b.HasData(
                        new
                        {
                            Id = new Guid("4b501cb3-d168-4cc0-b375-48fb33f318a4"),
                            Name = "计算机一班"
                        },
                        new
                        {
                            Id = new Guid("a715b654-c721-fe03-428a-eecc71f91fd1"),
                            Name = "计算机二班"
                        });
                });

            modelBuilder.Entity("Sample.Entitys.Courses", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Courses");

                    b
                        .HasComment("课程表");

                    b.HasData(
                        new
                        {
                            Id = new Guid("f078ef86-080b-2d04-5cf6-2681908d4cc9"),
                            Name = "C#高级编程"
                        },
                        new
                        {
                            Id = new Guid("a521b8b6-299a-284d-2cb6-07d8c558a244"),
                            Name = "Java高级编程"
                        },
                        new
                        {
                            Id = new Guid("ec094517-76b3-ab8a-f09b-e5e3c8f78516"),
                            Name = "MySQL操作手册"
                        },
                        new
                        {
                            Id = new Guid("8eee5b6d-bf73-6392-221c-14f20bb052c0"),
                            Name = "JavaScript入门到实践"
                        },
                        new
                        {
                            Id = new Guid("1f950006-aadd-23e8-de6b-88a95d8548b2"),
                            Name = "C++入门编程"
                        });
                });

            modelBuilder.Entity("Sample.Entitys.StudentCourses", b =>
                {
                    b.Property<Guid>("StudentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CourseId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("StudentId", "CourseId");

                    b.HasIndex("CourseId");

                    b.ToTable("StudentCourses");

                    b.HasData(
                        new
                        {
                            StudentId = new Guid("2fa2c303-ca6e-8a08-8693-b8a7352d9c95"),
                            CourseId = new Guid("f078ef86-080b-2d04-5cf6-2681908d4cc9")
                        },
                        new
                        {
                            StudentId = new Guid("2fa2c303-ca6e-8a08-8693-b8a7352d9c95"),
                            CourseId = new Guid("a521b8b6-299a-284d-2cb6-07d8c558a244")
                        },
                        new
                        {
                            StudentId = new Guid("590b2674-0d2d-9c2c-57f1-2813c04bdc69"),
                            CourseId = new Guid("a521b8b6-299a-284d-2cb6-07d8c558a244")
                        });
                });

            modelBuilder.Entity("Sample.Entitys.Students", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasComment("主键");

                    b.Property<Guid>("ArchiveId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ClassId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime")
                        .HasComment("学生生日");

                    b.Property<int>("Gender")
                        .HasColumnType("int")
                        .HasComment("学生性别");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)")
                        .HasComment("学生姓名");

                    b.Property<string>("No")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasComment("学生编号");

                    b.HasKey("Id");

                    b.HasIndex("ClassId");

                    b.ToTable("Students");

                    b
                        .HasComment("学生表");

                    b.HasData(
                        new
                        {
                            Id = new Guid("2fa2c303-ca6e-8a08-8693-b8a7352d9c95"),
                            ArchiveId = new Guid("4abb3198-87fd-a81f-41a1-40dfb58f47e7"),
                            ClassId = new Guid("4b501cb3-d168-4cc0-b375-48fb33f318a4"),
                            DateOfBirth = new DateTime(1993, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Gender = 1,
                            Name = "jack",
                            No = "0001"
                        },
                        new
                        {
                            Id = new Guid("590b2674-0d2d-9c2c-57f1-2813c04bdc69"),
                            ArchiveId = new Guid("5c496296-e9f1-80ee-1b94-5bbcbd706c49"),
                            ClassId = new Guid("a715b654-c721-fe03-428a-eecc71f91fd1"),
                            DateOfBirth = new DateTime(1995, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Gender = 2,
                            Name = "core",
                            No = "0002"
                        });
                });

            modelBuilder.Entity("Sample.Entitys.Archives", b =>
                {
                    b.HasOne("Sample.Entitys.Students", "Student")
                        .WithOne("Archive")
                        .HasForeignKey("Sample.Entitys.Archives", "StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Student");
                });

            modelBuilder.Entity("Sample.Entitys.StudentCourses", b =>
                {
                    b.HasOne("Sample.Entitys.Courses", "Course")
                        .WithMany("StudentCourses")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Sample.Entitys.Students", "Student")
                        .WithMany("StudentCourses")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("Sample.Entitys.Students", b =>
                {
                    b.HasOne("Sample.Entitys.Class", "Class")
                        .WithMany("Students")
                        .HasForeignKey("ClassId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Class");
                });

            modelBuilder.Entity("Sample.Entitys.Class", b =>
                {
                    b.Navigation("Students");
                });

            modelBuilder.Entity("Sample.Entitys.Courses", b =>
                {
                    b.Navigation("StudentCourses");
                });

            modelBuilder.Entity("Sample.Entitys.Students", b =>
                {
                    b.Navigation("Archive");

                    b.Navigation("StudentCourses");
                });
#pragma warning restore 612, 618
        }
    }
}
