using VP.BackgroundJobManager.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace VP.BackgroundJobManager.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class BackgroundJobManagerPageModel : AbpPageModel
{
    protected BackgroundJobManagerPageModel()
    {
        LocalizationResourceType = typeof(BackgroundJobManagerResource);
    }
}
