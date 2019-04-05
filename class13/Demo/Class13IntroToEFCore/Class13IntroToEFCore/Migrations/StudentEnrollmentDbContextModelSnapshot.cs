﻿// <auto-generated />
using Class13IntroToEFCore.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Class13IntroToEFCore.Migrations
{
    [DbContext(typeof(StudentEnrollmentDbContext))]
    partial class StudentEnrollmentDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Class13IntroToEFCore.Models.Course", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.Property<decimal>("Price");

                    b.Property<int>("Tech");

                    b.HasKey("ID");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("Class13IntroToEFCore.Models.CourseEnrollments", b =>
                {
                    b.Property<int>("CourseID");

                    b.Property<int>("StudentID");

                    b.HasKey("CourseID", "StudentID");

                    b.HasIndex("StudentID");

                    b.ToTable("CourseEnrollments");
                });

            modelBuilder.Entity("Class13IntroToEFCore.Models.Student", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.HasKey("ID");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("Class13IntroToEFCore.Models.Transcript", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CourseID");

                    b.Property<int>("Grade");

                    b.Property<bool>("Pass");

                    b.Property<int>("StudentID");

                    b.HasKey("ID");

                    b.HasIndex("CourseID");

                    b.HasIndex("StudentID");

                    b.ToTable("Transcripts");
                });

            modelBuilder.Entity("Class13IntroToEFCore.Models.CourseEnrollments", b =>
                {
                    b.HasOne("Class13IntroToEFCore.Models.Course", "Course")
                        .WithMany("Enrollments")
                        .HasForeignKey("CourseID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Class13IntroToEFCore.Models.Student", "Student")
                        .WithMany("Enrollments")
                        .HasForeignKey("StudentID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Class13IntroToEFCore.Models.Transcript", b =>
                {
                    b.HasOne("Class13IntroToEFCore.Models.Course", "Course")
                        .WithMany("Transcripts")
                        .HasForeignKey("CourseID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Class13IntroToEFCore.Models.Student", "Student")
                        .WithMany("Transcripts")
                        .HasForeignKey("StudentID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}