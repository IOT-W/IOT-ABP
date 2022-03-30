using Volo.Abp.Settings;

namespace abpapi.Settings;

public class abpapiSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(abpapiSettings.MySetting1));
    }
}
