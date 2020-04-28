namespace ExampleConsoleApp
{
    using System.IO;
    using System.Threading.Tasks;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;

    class Startup
    {
        static async Task Main(string[] args)
        {
            var serviceCollection = new ServiceCollection();
            
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", false)
                .AddJsonFile("appsettings.development.json", true);

            IConfiguration configuration = builder.Build();

            serviceCollection.AddScoped<IConfiguration>(_ => configuration);
            serviceCollection.AddScoped<SpotifyAuthentication>();
            serviceCollection.AddScoped<Program>();

            var serviceProvider = serviceCollection.BuildServiceProvider();

            var p = serviceProvider.GetRequiredService<Program>();
            await p.Run();
        }
    }
}