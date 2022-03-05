using Volo.Abp.Modularity;

namespace VP.BackgroundJobManager;

[DependsOn(
    typeof(BackgroundJobManagerApplicationModule),
    typeof(BackgroundJobManagerDomainTestModule)
    )]
public class BackgroundJobManagerApplicationTestModule : AbpModule
{

}
