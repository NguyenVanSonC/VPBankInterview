using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace VP.BackgroundJobManager.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class BackgroundJobManagerDbContextFactory : IDesignTimeDbContextFactory<BackgroundJobManagerDbContext>
{
    public BackgroundJobManagerDbContext CreateDbContext(string[] args)
    {
        BackgroundJobManagerEfCoreEntityExtensionMappings.Configure();

        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<BackgroundJobManagerDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));

        return new BackgroundJobManagerDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../VP.BackgroundJobManager.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
