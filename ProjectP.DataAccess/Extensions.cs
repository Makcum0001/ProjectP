using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace ProjectP.DataAccess;

public static class Extensions
{
    public static IServiceCollection AddDataAccess(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddDbContext<AppContext>(x =>
        {
            x.UseNpgsql(connectionString: "Host=localhost;Database=ProjectP;Username=postgres;Password=11111111");
        });
        return serviceCollection;
    }    
}
