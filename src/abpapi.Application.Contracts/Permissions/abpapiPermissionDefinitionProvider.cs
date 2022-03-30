using abpapi.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace abpapi.Permissions;

public class abpapiPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(abpapiPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(abpapiPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<abpapiResource>(name);
    }
}
