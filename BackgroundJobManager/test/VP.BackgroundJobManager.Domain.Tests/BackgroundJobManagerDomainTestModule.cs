using VP.BackgroundJobManager.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace VP.BackgroundJobManager;

[DependsOn(
    typeof(BackgroundJobManagerEntityFrameworkCoreTestModule)
    )]
public class BackgroundJobManagerDomainTestModule : AbpModule
{

}
