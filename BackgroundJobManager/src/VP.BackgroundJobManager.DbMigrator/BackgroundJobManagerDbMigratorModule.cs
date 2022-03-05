using VP.BackgroundJobManager.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace VP.BackgroundJobManager.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(BackgroundJobManagerEntityFrameworkCoreModule),
    typeof(BackgroundJobManagerApplicationContractsModule)
    )]
public class BackgroundJobManagerDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
