using Volo.Abp.Settings;

namespace VP.BackgroundJobManager.Settings;

public class BackgroundJobManagerSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(BackgroundJobManagerSettings.MySetting1));
    }
}
