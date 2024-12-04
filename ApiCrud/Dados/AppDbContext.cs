namespace ApiCrud.Dados

{
    using Microsoft.EntityFrameworkCore;
    using Estudantes;
    using Microsoft.AspNetCore.Hosting.Server;

    public class AppDbContext : DbContext 
    {

        private DbSet<Estudante> Estudantes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = localhost; Database = bdteste; User Id = root; Password = root@123;");
            base.OnConfiguring(optionsBuilder);
        }

    }
}
