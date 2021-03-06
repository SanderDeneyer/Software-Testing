// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Recipe_API.Data;

namespace Recipe_API.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210603154705_testData")]
    partial class testData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Recipe_API.Models.Categories", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Soepen"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Vegetarisch"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Voorgerecht"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Hoofdgerecht"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Dessert"
                        });
                });

            modelBuilder.Entity("Recipe_API.Models.Ingredient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Quantity")
                        .HasColumnType("float");

                    b.Property<int>("RecipeId")
                        .HasColumnType("int");

                    b.Property<string>("Unit")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Ingredients");
                });

            modelBuilder.Entity("Recipe_API.Models.Recipes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("Dificulty")
                        .HasColumnType("int");

                    b.Property<int>("Time")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Recipes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Dificulty = 0,
                            Time = 45,
                            Title = "Scampi soupje"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 2,
                            Dificulty = 2,
                            Time = 60,
                            Title = "Pasta Diablo"
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 2,
                            Dificulty = 2,
                            Time = 60,
                            Title = "Pasta Test"
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 2,
                            Dificulty = 2,
                            Time = 60,
                            Title = "Pasta Test2"
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 2,
                            Dificulty = 2,
                            Time = 60,
                            Title = "Pasta Test3"
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 3,
                            Dificulty = 1,
                            Time = 15,
                            Title = "Framboze ijsje"
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 1,
                            Dificulty = 1,
                            Time = 35,
                            Title = "Pasta 1"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
