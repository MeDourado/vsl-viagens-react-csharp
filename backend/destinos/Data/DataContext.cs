using destinos.Model;
using Microsoft.EntityFrameworkCore;

namespace destinos.Data
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {


        }

        public DbSet<Destino> Destinos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Destino>().HasData(

        new Destino { Id = 1, Nome = "Salvador", Url = "https://img.freepik.com/free-photo/long-shot-bahia-nautico-museum-salvdor-brazil-cloudy-blue-skies_181624-19965.jpg?w=740&t=st=1704910800~exp=1704911400~hmac=7b29602f804eadf85c1aa194c8341e031793c80a230b94d2d8992be685d65e4b", Preco = 799.99M },
        new Destino { Id = 2, Nome = "São Paulo", Url = "https://img.freepik.com/free-photo/complex-aerial-view-city_23-2148975280.jpg?w=740&t=st=1704910907~exp=1704911507~hmac=759676c01827d187c2d6fe90e7705c2888519d0cd26587d49d56c30ad9618e60", Preco = 899.99M },
        new Destino { Id = 3, Nome = "Rio de Janeiro", Url = "https://img.freepik.com/free-photo/landscape-rio-de-janeiro-surrounded-by-sea-blue-sky-brazil_181624-17265.jpg?w=740&t=st=1704910969~exp=1704911569~hmac=b0a3bd03158cbf1952e175bc97642dd8c54ba8d13061b02f5e51f6b7bba203ca", Preco = 999.99M },
        new Destino { Id = 4, Nome = "Paraiba", Url = "https://img.freepik.com/free-photo/morning-light-sonoran-desert-scottsdale-arizona_181624-48339.jpg?w=740&t=st=1704911051~exp=1704911651~hmac=de860a086becd28ab0fcedb8363da480cd1957e7411171d7c84d5931f372a527", Preco = 699.99M },
        new Destino { Id = 5, Nome = "Porto Seco", Url = "https://img.freepik.com/free-photo/beautiful-view-white-cliff-stairs-known-as-scala-dei-turchi-realmonte-sicily-italy_181624-40412.jpg?w=740&t=st=1704912399~exp=1704912999~hmac=c02b0a41d1169319946c99071811da719094eee64bc5c2cd51d4cc287416b298", Preco = 1099.99M },
        new Destino { Id = 6, Nome = "Santos", Url = "https://img.freepik.com/free-photo/boat-goes-blue-sea-deep-blue-sky_1304-4974.jpg?w=740&t=st=1704911307~exp=1704911907~hmac=6ff0da3b8d1709d42ac2f694c7e80956d9384ec7ac01ba0d44b697c6e3a38fd9", Preco = 759.99M }


    );

        }
    }
}