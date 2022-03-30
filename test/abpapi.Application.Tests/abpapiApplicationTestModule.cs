using Volo.Abp.Modularity;

namespace abpapi;

[DependsOn(
    typeof(abpapiApplicationModule),
    typeof(abpapiDomainTestModule)
    )]
public class abpapiApplicationTestModule : AbpModule
{

}
