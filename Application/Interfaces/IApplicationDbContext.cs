using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Application.Interfaces;

public interface IApplicationDbContext
{
    public DbSet<Card> Cards { get; set; }
    public int SaveChanges();
}
