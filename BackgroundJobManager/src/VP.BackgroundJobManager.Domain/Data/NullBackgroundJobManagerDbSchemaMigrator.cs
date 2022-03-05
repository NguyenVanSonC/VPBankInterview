using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace VP.BackgroundJobManager.Data;

/* This is used if database provider does't define
 * IBackgroundJobManagerDbSchemaMigrator implementation.
 */
public class NullBackgroundJobManagerDbSchemaMigrator : IBackgroundJobManagerDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
