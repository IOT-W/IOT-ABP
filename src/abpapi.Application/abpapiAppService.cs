using System;
using System.Collections.Generic;
using System.Text;
using abpapi.Localization;
using Volo.Abp.Application.Services;

namespace abpapi;

/* Inherit your application services from this class.
 */
public abstract class abpapiAppService : ApplicationService
{
    protected abpapiAppService()
    {
        LocalizationResource = typeof(abpapiResource);
    }
}
