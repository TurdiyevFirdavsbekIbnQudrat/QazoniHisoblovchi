using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;
using QazoniHisoblovchi.Application.Abstract;
using QazoniHisoblovchi.Domain.Entities;

namespace QazoniHisoblovchi.Infrastructure
{
    public class QazoHisoblovchiDbContext : DbContext, IQazoHisoblovchiDbContext
    {
        public QazoHisoblovchiDbContext(DbContextOptions<QazoHisoblovchiDbContext> options) : base(options)
        {
            var databaseCreator = Database.GetService<IDatabaseCreator>() as RelationalDatabaseCreator;
            if (databaseCreator != null)
            {
                if (!databaseCreator.CanConnect()) databaseCreator.CreateAsync();
                if (!databaseCreator.HasTables()) databaseCreator.CreateTablesAsync();
            }

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
        async ValueTask<int> IQazoHisoblovchiDbContext.SaveChangesAsync(CancellationToken cancellationToken)
        {
            return await base.SaveChangesAsync(cancellationToken);
        }
        public DbSet<Foydalanuvchilar> foydalanuvchilar { get; set; }
        public DbSet<QazoNamozlar> qazoNamozlar { get; set; }
    }
}
