using curso_c_.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace curso_c_.API.Infrastruture;

public class ClientHubDbContext : DbContext
{
    public DbSet<Client> Client {  get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=C:\\Users\\Allyson Eduardo\\db_client.db");

    }
}
