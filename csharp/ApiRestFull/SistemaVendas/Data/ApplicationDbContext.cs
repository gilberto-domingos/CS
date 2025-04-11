using Microsoft.EntityFrameworkCore;
using SistemaVendas.Entities;

namespace SistemaVendas.Data;

public class ApiDbContext : DbContext
{
    public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
    {
    }

    public DbSet<Produto> Produtos { get; set; }
}