using Contracts.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Contracts.Infra.Data.Context
{
    public class DataContext : DbContext
    {
        public DataContext()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite(@"Data Source='C:\dev\sqlite\Contracts.db");

        protected override void OnModelCreating(ModelBuilder model)
        {
            model.Entity<PartInformation>()
                .Property(p => p.Cpf)
                .IsRequired()
                .HasMaxLength(11);
        }
    }
}
