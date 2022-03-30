using abpapi.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace abpapi.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class abpapiPageModel : AbpPageModel
{
    protected abpapiPageModel()
    {
        LocalizationResourceType = typeof(abpapiResource);
    }
}
