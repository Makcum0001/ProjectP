using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using ProjectP.DataAccess.Interfaces;

namespace ProjectP.DataAccess.Extensions;

public static class Extensions
{
    public static IServiceCollection AddDataAccess(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddScoped<IMembersEventRepository, MembersEventRepository>();
        serviceCollection.AddDbContext<AppContext>(x =>
        {
            x.UseNpgsql(connectionString: "Host=localhost;Database=ProjectP;Username=postgres;Password=11111111");
        });
        return serviceCollection;
    }    
}
