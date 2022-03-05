using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace VP.BackgroundJobManager.Web;

[Dependency(ReplaceServices = true)]
public class BackgroundJobManagerBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "BackgroundJobManager";
}
