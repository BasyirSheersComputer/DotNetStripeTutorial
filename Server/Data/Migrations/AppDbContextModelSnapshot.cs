﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Server.Data;

#nullable disable

namespace Server.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.14");

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
                            Id = "70360b2c-a6ff-48e2-9a2d-b8c28cce18c8",
                            Description = "Product 1 description. This is an amazing product with a price-quality balance you won't find anywhere ele.",
                            ImageUrl = "https://picsum.photos/id/1/500",
                            Price = 1000L,
                            Title = "Product 1"
                        },
                        new
                        {
                            Id = "913adfc2-accb-4eec-b233-e51c59c38778",
                            Description = "Product 2 description. This is an amazing product with a price-quality balance you won't find anywhere ele.",
                            ImageUrl = "https://picsum.photos/id/2/500",
                            Price = 2000L,
                            Title = "Product 2"
                        },
                        new
                        {
                            Id = "77ea3b16-7c1d-4d2c-afc7-286512c5fbd2",
                            Description = "Product 3 description. This is an amazing product with a price-quality balance you won't find anywhere ele.",
                            ImageUrl = "https://picsum.photos/id/3/500",
                            Price = 3000L,
                            Title = "Product 3"
                        },
                        new
                        {
                            Id = "a46bcf9a-5128-470d-a8d1-b0366516c2f9",
                            Description = "Product 4 description. This is an amazing product with a price-quality balance you won't find anywhere ele.",
                            ImageUrl = "https://picsum.photos/id/4/500",
                            Price = 4000L,
                            Title = "Product 4"
                        },
                        new
                        {
                            Id = "12893f38-0835-4ddc-9754-18c425f9d210",
                            Description = "Product 5 description. This is an amazing product with a price-quality balance you won't find anywhere ele.",
                            ImageUrl = "https://picsum.photos/id/5/500",
                            Price = 5000L,
                            Title = "Product 5"
                        },
                        new
                        {
                            Id = "6a3b6e44-fd4f-4ef4-bc60-bb7f6f2a289b",
                            Description = "Product 6 description. This is an amazing product with a price-quality balance you won't find anywhere ele.",
                            ImageUrl = "https://picsum.photos/id/6/500",
                            Price = 6000L,
                            Title = "Product 6"
                        },
                        new
                        {
                            Id = "0f5a8566-36e3-4823-b697-c555f192c2ff",
                            Description = "Product 7 description. This is an amazing product with a price-quality balance you won't find anywhere ele.",
                            ImageUrl = "https://picsum.photos/id/7/500",
                            Price = 7000L,
                            Title = "Product 7"
                        },
                        new
                        {
                            Id = "76eb7521-2bd5-4804-a177-a68d9c5cf4cc",
                            Description = "Product 8 description. This is an amazing product with a price-quality balance you won't find anywhere ele.",
                            ImageUrl = "https://picsum.photos/id/8/500",
                            Price = 8000L,
                            Title = "Product 8"
                        },
                        new
                        {
                            Id = "0cf1b792-7267-4c7b-a3e9-10929fc5377b",
                            Description = "Product 9 description. This is an amazing product with a price-quality balance you won't find anywhere ele.",
                            ImageUrl = "https://picsum.photos/id/9/500",
                            Price = 9000L,
                            Title = "Product 9"
                        },
                        new
                        {
                            Id = "86817db7-5f73-4a4d-a43c-d5e6833f3737",
                            Description = "Product 10 description. This is an amazing product with a price-quality balance you won't find anywhere ele.",
                            ImageUrl = "https://picsum.photos/id/10/500",
                            Price = 10000L,
                            Title = "Product 10"
                        },
                        new
                        {
                            Id = "46fc594b-9ed0-408d-bd81-5501ed514630",
                            Description = "Product 11 description. This is an amazing product with a price-quality balance you won't find anywhere ele.",
                            ImageUrl = "https://picsum.photos/id/11/500",
                            Price = 11000L,
                            Title = "Product 11"
                        },
                        new
                        {
                            Id = "5910c6f9-2897-42d7-9ea6-95a9f1c93175",
                            Description = "Product 12 description. This is an amazing product with a price-quality balance you won't find anywhere ele.",
                            ImageUrl = "https://picsum.photos/id/12/500",
                            Price = 12000L,
                            Title = "Product 12"
                        },
                        new
                        {
                            Id = "55ab7bb5-9701-4c5d-a335-37e165b9aa8e",
                            Description = "Product 13 description. This is an amazing product with a price-quality balance you won't find anywhere ele.",
                            ImageUrl = "https://picsum.photos/id/13/500",
                            Price = 13000L,
                            Title = "Product 13"
                        },
                        new
                        {
                            Id = "a4a6cdd3-bdf4-4151-b478-b846e89611d1",
                            Description = "Product 14 description. This is an amazing product with a price-quality balance you won't find anywhere ele.",
                            ImageUrl = "https://picsum.photos/id/14/500",
                            Price = 14000L,
                            Title = "Product 14"
                        },
                        new
                        {
                            Id = "f0bc4a12-5021-4416-a5ce-ca9a8ecc6dd4",
                            Description = "Product 15 description. This is an amazing product with a price-quality balance you won't find anywhere ele.",
                            ImageUrl = "https://picsum.photos/id/15/500",
                            Price = 15000L,
                            Title = "Product 15"
                        },
                        new
                        {
                            Id = "fca0db30-f4e7-4222-9e21-3b86dcec2844",
                            Description = "Product 16 description. This is an amazing product with a price-quality balance you won't find anywhere ele.",
                            ImageUrl = "https://picsum.photos/id/16/500",
                            Price = 16000L,
                            Title = "Product 16"
                        },
                        new
                        {
                            Id = "143be449-205b-4dd2-9baa-5961c6934a3c",
                            Description = "Product 17 description. This is an amazing product with a price-quality balance you won't find anywhere ele.",
                            ImageUrl = "https://picsum.photos/id/17/500",
                            Price = 17000L,
                            Title = "Product 17"
                        },
                        new
                        {
                            Id = "61328052-d8b7-462a-9585-2daa1bb9c90b",
                            Description = "Product 18 description. This is an amazing product with a price-quality balance you won't find anywhere ele.",
                            ImageUrl = "https://picsum.photos/id/18/500",
                            Price = 18000L,
                            Title = "Product 18"
                        },
                        new
                        {
                            Id = "a309dd19-f1a6-42bb-94fe-55974e90f412",
                            Description = "Product 19 description. This is an amazing product with a price-quality balance you won't find anywhere ele.",
                            ImageUrl = "https://picsum.photos/id/19/500",
                            Price = 19000L,
                            Title = "Product 19"
                        },
                        new
                        {
                            Id = "f4d89154-438b-4ad9-88d7-f08a778070e6",
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
