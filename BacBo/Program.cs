using BacBo.Services;
using Microsoft.Extensions.DependencyInjection;

namespace BacBo;

internal static class Program
{
    [STAThread]
    static void Main()
    {
        var services = new ServiceCollection();
        ConfigureServices(services);

        using (var serviceProvider = services.BuildServiceProvider())
        {
            ApplicationConfiguration.Initialize();
            var form = serviceProvider.GetRequiredService<Form1>();
            Application.Run(form);
        }
    }

    private static void ConfigureServices(IServiceCollection services)
    {
        services.AddSingleton<IBacBoService,BacBoService>();
        services.AddTransient<Form1>();
    }
}