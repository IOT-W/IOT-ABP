using abpapi.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace abpapi.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class abpapiController : AbpControllerBase
{
    protected abpapiController()
    {
        LocalizationResource = typeof(abpapiResource);
    }
}
