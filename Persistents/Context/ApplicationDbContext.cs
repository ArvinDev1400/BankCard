using Application.Interfaces;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistents.Context;

public class ApplicationDbContext : DbContext, IApplicationDbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=.;Database=BankCard;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True");
    }

    public DbSet<Card> Cards { get; set; }
}
