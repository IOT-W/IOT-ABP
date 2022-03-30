using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace abpapi.Web;

[Dependency(ReplaceServices = true)]
public class abpapiBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "abpapi";
}
