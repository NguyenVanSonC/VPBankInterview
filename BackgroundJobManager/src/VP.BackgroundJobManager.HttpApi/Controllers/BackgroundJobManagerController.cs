using VP.BackgroundJobManager.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace VP.BackgroundJobManager.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class BackgroundJobManagerController : AbpControllerBase
{
    protected BackgroundJobManagerController()
    {
        LocalizationResource = typeof(BackgroundJobManagerResource);
    }
}
