﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Server.Data;

#nullable disable

namespace Server.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230219081610_FirstMigration")]
    partial class FirstMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.7");

            modelBuilder.Entity("Shared.Models.Product", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("TEXT");

                    b.Property<long>("Price")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = "5692c4c0-51ae-4407-a7c1-ff81ae753040",
                            Description = "Product 1 description. This is an amazing product with a price-quality balance you won't find anywhere ele.",
                            ImageUrl = "https://picsum.photos/id/1/500",
                            Price = 1000L,
                            Title = "Product 1"
                        },
                        new
                        {
                            Id = "75949e7e-aacc-4bda-84f0-aaac09300bfa",
                            Description = "Product 2 description. This is an amazing product with a price-quality balance you won't find anywhere ele.",
                            ImageUrl = "https://picsum.photos/id/2/500",
                            Price = 2000L,
                            Title = "Product 2"
                        },
                        new
                        {
                            Id = "13509d95-9af0-4bfa-9db8-a39eef026069",
                            Description = "Product 3 description. This is an amazing product with a price-quality balance you won't find anywhere ele.",
                            ImageUrl = "https://picsum.photos/id/3/500",
                            Price = 3000L,
                            Title = "Product 3"
                        },
                        new
                        {
                            Id = "0837a526-2e40-4b27-9dd3-cdaf8cbc6e95",
                            Description = "Product 4 description. This is an amazing product with a price-quality balance you won't find anywhere ele.",
                            ImageUrl = "https://picsum.photos/id/4/500",
                            Price = 4000L,
                            Title = "Product 4"
                        },
                        new
                        {
                            Id = "58973be6-cf95-4ad4-a386-3b220e34e839",
                            Description = "Product 5 description. This is an amazing product with a price-quality balance you won't find anywhere ele.",
                            ImageUrl = "https://picsum.photos/id/5/500",
                            Price = 5000L,
                            Title = "Product 5"
                        },
                        new
                        {
                            Id = "4266b6a2-d3fb-43c4-8dc0-5ddc6fb017f1",
                            Description = "Product 6 description. This is an amazing product with a price-quality balance you won't find anywhere ele.",
                            ImageUrl = "https://picsum.photos/id/6/500",
                            Price = 6000L,
                            Title = "Product 6"
                        },
                        new
                        {
                            Id = "d1c91508-ebd9-44e9-99e4-ba94cc249814",
                            Description = "Product 7 description. This is an amazing product with a price-quality balance you won't find anywhere ele.",
                            ImageUrl = "https://picsum.photos/id/7/500",
                            Price = 7000L,
                            Title = "Product 7"
                        },
                        new
                        {
                            Id = "5411f6b0-c9e9-4041-ab64-4dcb4d1a1a24",
                            Description = "Product 8 description. This is an amazing product with a price-quality balance you won't find anywhere ele.",
                            ImageUrl = "https://picsum.photos/id/8/500",
                            Price = 8000L,
                            Title = "Product 8"
                        },
                        new
                        {
                            Id = "ead264d6-9866-443f-adc5-863fe60a37c9",
                            Description = "Product 9 description. This is an amazing product with a price-quality balance you won't find anywhere ele.",
                            ImageUrl = "https://picsum.photos/id/9/500",
                            Price = 9000L,
                            Title = "Product 9"
                        },
                        new
                        {
                            Id = "4a51a910-ba40-4cdb-b870-4ec4ebab21cc",
                            Description = "Product 10 description. This is an amazing product with a price-quality balance you won't find anywhere ele.",
                            ImageUrl = "https://picsum.photos/id/10/500",
                            Price = 10000L,
                            Title = "Product 10"
                        },
                        new
                        {
                            Id = "2b6e6b3f-87f0-4cf0-8ec5-71bb9feca57a",
                            Description = "Product 11 description. This is an amazing product with a price-quality balance you won't find anywhere ele.",
                            ImageUrl = "https://picsum.photos/id/11/500",
                            Price = 11000L,
                            Title = "Product 11"
                        },
                        new
                        {
                            Id = "49656166-6998-487e-b6d2-b8944bf34f91",
                            Description = "Product 12 description. This is an amazing product with a price-quality balance you won't find anywhere ele.",
                            ImageUrl = "https://picsum.photos/id/12/500",
                            Price = 12000L,
                            Title = "Product 12"
                        },
                        new
                        {
                            Id = "93c16a7d-1413-4912-bd89-d4431bf64d61",
                            Description = "Product 13 description. This is an amazing product with a price-quality balance you won't find anywhere ele.",
                            ImageUrl = "https://picsum.photos/id/13/500",
                            Price = 13000L,
                            Title = "Product 13"
                        },
                        new
                        {
                            Id = "86f5935b-a6ef-4386-b28d-90252dada815",
                            Description = "Product 14 description. This is an amazing product with a price-quality balance you won't find anywhere ele.",
                            ImageUrl = "https://picsum.photos/id/14/500",
                            Price = 14000L,
                            Title = "Product 14"
                        },
                        new
                        {
                            Id = "6f095597-26c3-4531-9bde-d344df9ee465",
                            Description = "Product 15 description. This is an amazing product with a price-quality balance you won't find anywhere ele.",
                            ImageUrl = "https://picsum.photos/id/15/500",
                            Price = 15000L,
                            Title = "Product 15"
                        },
                        new
                        {
                            Id = "05131a62-a86a-4664-8d51-b8d5d65be128",
                            Description = "Product 16 description. This is an amazing product with a price-quality balance you won't find anywhere ele.",
                            ImageUrl = "https://picsum.photos/id/16/500",
                            Price = 16000L,
                            Title = "Product 16"
                        },
                        new
                        {
                            Id = "39c2c8a8-3444-40ad-9dad-2c0aabc4ad99",
                            Description = "Product 17 description. This is an amazing product with a price-quality balance you won't find anywhere ele.",
                            ImageUrl = "https://picsum.photos/id/17/500",
                            Price = 17000L,
                            Title = "Product 17"
                        },
                        new
                        {
                            Id = "93940761-d15c-4d78-8187-56ec0ece74b2",
                            Description = "Product 18 description. This is an amazing product with a price-quality balance you won't find anywhere ele.",
                            ImageUrl = "https://picsum.photos/id/18/500",
                            Price = 18000L,
                            Title = "Product 18"
                        },
                        new
                        {
                            Id = "2c529933-31a5-47f7-a6c5-7e25c2f56806",
                            Description = "Product 19 description. This is an amazing product with a price-quality balance you won't find anywhere ele.",
                            ImageUrl = "https://picsum.photos/id/19/500",
                            Price = 19000L,
                            Title = "Product 19"
                        },
                        new
                        {
                            Id = "f504e2ea-58d1-474d-ae89-57ef6b6777ff",
                            Description = "Product 20 description. This is an amazing product with a price-quality balance you won't find anywhere ele.",
                            ImageUrl = "https://picsum.photos/id/20/500",
                            Price = 20000L,
                            Title = "Product 20"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
