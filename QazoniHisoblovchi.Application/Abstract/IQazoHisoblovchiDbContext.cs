using Microsoft.EntityFrameworkCore;
using QazoniHisoblovchi.Domain.Entities;

namespace QazoniHisoblovchi.Application.Abstract
{
    public interface IQazoHisoblovchiDbContext
    {
        public ValueTask<int> SaveChangesAsync(CancellationToken cancellationToken = default);

        public DbSet<Foydalanuvchilar> foydalanuvchilar { get; set; }
        public DbSet<QazoNamozlar> qazoNamozlar { get; set; }
    }
}
