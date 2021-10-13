using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    static class TestDependency
    {

        public static IServiceProvider CreateServiceProvider(Action<ServiceCollection> serviceCollect)
        {
            DefaultServiceProviderFactory factory = new();
            ServiceCollection services = new();

            services.AddDbContext<Datalayer.AppContext>(option => option.UseInMemoryDatabase("Database"));
            serviceCollect(services);

            return factory.CreateServiceProvider(services);
        }

        public static void CreateDatabase(this IServiceProvider serviceProvider)
        {
            var context = serviceProvider.GetRequiredService<Datalayer.AppContext>();
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();
        }

    }
}
