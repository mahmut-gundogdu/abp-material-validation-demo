using BookStoreMaterial.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace BookStoreMaterial.Permissions;

public class BookStoreMaterialPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(BookStoreMaterialPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(BookStoreMaterialPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<BookStoreMaterialResource>(name);
    }
}
