using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using VP.BackgroundJobManager.Data;
using Volo.Abp.DependencyInjection;

namespace VP.BackgroundJobManager.EntityFrameworkCore;

public class EntityFrameworkCoreBackgroundJobManagerDbSchemaMigrator
    : IBackgroundJobManagerDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreBackgroundJobManagerDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the BackgroundJobManagerDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<BackgroundJobManagerDbContext>()
            .Database
            .MigrateAsync();
    }
}
