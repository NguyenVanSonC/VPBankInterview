using System.Threading.Tasks;

namespace VP.BackgroundJobManager.Data;

public interface IBackgroundJobManagerDbSchemaMigrator
{
    Task MigrateAsync();
}
