using VP.BackgroundJobManager.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace VP.BackgroundJobManager.Permissions;

public class BackgroundJobManagerPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(BackgroundJobManagerPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(BackgroundJobManagerPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<BackgroundJobManagerResource>(name);
    }
}
