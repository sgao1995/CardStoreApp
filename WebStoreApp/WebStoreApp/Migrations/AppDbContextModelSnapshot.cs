using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using WebStoreApp.Models;

namespace WebStoreApp.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebStoreApp.Models.Card", b =>
                {
                    b.Property<int>("CardId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Attack");

                    b.Property<string>("Attribute");

                    b.Property<int>("CategoryId");

                    b.Property<int>("Defense");

                    b.Property<string>("Description");

                    b.Property<string>("EffectText");

                    b.Property<string>("ImgUrl");

                    b.Property<bool>("IsFeatured");

                    b.Property<bool>("IsInStock");

                    b.Property<int>("Level");

                    b.Property<string>("Name");

                    b.Property<decimal>("Price");

                    b.Property<string>("ThumbnailUrl");

                    b.Property<string>("Type");

                    b.HasKey("CardId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Cards");
                });

            modelBuilder.Entity("WebStoreApp.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CategoryName");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("WebStoreApp.Models.Review", b =>
                {
                    b.Property<int>("ReviewId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CardId");

                    b.Property<string>("Content");

                    b.Property<int>("Rating");

                    b.Property<DateTime>("ReviewDate");

                    b.Property<string>("ReviewerName");

                    b.HasKey("ReviewId");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("WebStoreApp.Models.Card", b =>
                {
                    b.HasOne("WebStoreApp.Models.Category", "Category")
                        .WithMany("Cards")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
