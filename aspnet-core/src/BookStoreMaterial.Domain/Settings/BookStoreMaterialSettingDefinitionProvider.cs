using Volo.Abp.Settings;

namespace BookStoreMaterial.Settings;

public class BookStoreMaterialSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(BookStoreMaterialSettings.MySetting1));
    }
}
