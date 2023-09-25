using BacBo.Database;
using BacBo.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace BacBo;

internal static class Program
{
    [STAThread]
    static void Main()
    {
        var services = new ServiceCollection();
        ConfigureServices(services);

        using (var dbContext = new BacBoContext())
        {
            dbContext.Database.Migrate();
        }

        using (var serviceProvider = services.BuildServiceProvider())
        {
            ApplicationConfiguration.Initialize();
            var form = serviceProvider.GetRequiredService<Form1>();
            Application.Run(form);
        }
    }

    private static void ConfigureServices(IServiceCollection services)
    {
        services.AddTransient<BacBoContextFactory>();
        services.AddTransient(provider =>
        {
            var factory = provider.GetRequiredService<BacBoContextFactory>();
            return factory.CreateDbContext();
        });
        
        services.AddSingleton<IBacBoService,BacBoService>();
        services.AddTransient<Form1>();
    }
}