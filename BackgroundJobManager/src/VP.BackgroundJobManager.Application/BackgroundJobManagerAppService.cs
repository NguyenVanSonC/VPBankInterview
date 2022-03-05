using System;
using System.Collections.Generic;
using System.Text;
using VP.BackgroundJobManager.Localization;
using Volo.Abp.Application.Services;

namespace VP.BackgroundJobManager;

/* Inherit your application services from this class.
 */
public abstract class BackgroundJobManagerAppService : ApplicationService
{
    protected BackgroundJobManagerAppService()
    {
        LocalizationResource = typeof(BackgroundJobManagerResource);
    }
}
