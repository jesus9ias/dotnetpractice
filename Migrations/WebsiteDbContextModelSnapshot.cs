using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using dotnetpractice;

namespace dotnetpractice.Migrations
{
    [DbContext(typeof(WebsiteDbContext))]
    partial class WebsiteDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.0-rtm-21431");

            modelBuilder.Entity("dotnetpractice.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Category");

                    b.Property<DateTime>("CreatedTime");

                    b.Property<string>("Description")
                        .HasColumnName("Description")
                        .HasColumnType("text");

                    b.Property<string>("Image");

                    b.Property<int>("Inventory");

                    b.Property<string>("Name")
                        .HasAnnotation("MaxLength", 100);

                    b.Property<double>("Price");

                    b.Property<DateTime>("UpdatedTime");

                    b.HasKey("Id");

                    b.ToTable("Products");
                });
        }
    }
}
