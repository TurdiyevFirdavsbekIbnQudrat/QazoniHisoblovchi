using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using QazoniHisoblovchi.Application.Abstract;

namespace QazoniHisoblovchi.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            string connectionsString = "Server=DESKTOP-HUHB6EP;Database=QazolarDb;Trusted_Connection=True;TrustServerCertificate=True;";
            services.AddDbContext<IQazoHisoblovchiDbContext, QazoHisoblovchiDbContext>(options =>
            options.UseSqlServer(connectionsString, providerOptions => providerOptions.EnableRetryOnFailure())
            );
            return services;
        }
    }
}
