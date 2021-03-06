// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using models;

namespace FilmesApi.Migrations
{
    [DbContext(typeof(BancoContext))]
    [Migration("20220211105431_criandoTabelaVenda")]
    partial class criandoTabelaVenda
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.5");

            modelBuilder.Entity("models.produto", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("nomeProduto")
                        .HasColumnType("text");

                    b.Property<int>("quantidadeProduto")
                        .HasColumnType("int");

                    b.Property<decimal>("valorProduto")
                        .HasColumnType("decimal(18, 2)");

                    b.HasKey("id");

                    b.ToTable("Produtos");
                });

            modelBuilder.Entity("models.vendas", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<decimal>("ValorTotal")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<string>("nomeProduto")
                        .HasColumnType("text");

                    b.Property<int>("quantidadeComprada")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("vendas");
                });
#pragma warning restore 612, 618
        }
    }
}
