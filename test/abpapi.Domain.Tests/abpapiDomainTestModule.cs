using abpapi.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace abpapi;

[DependsOn(
    typeof(abpapiEntityFrameworkCoreTestModule)
    )]
public class abpapiDomainTestModule : AbpModule
{

}
