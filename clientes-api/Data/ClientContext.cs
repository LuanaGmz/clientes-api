using clientes_api.Models;
using Microsoft.EntityFrameworkCore;

namespace clientes_api.Data;

public class ClientContext : DbContext
{
    public ClientContext(DbContextOptions<ClientContext> opts)
        : base(opts)
    {

    }

    public DbSet<Client> Clients { get; set; }
}
