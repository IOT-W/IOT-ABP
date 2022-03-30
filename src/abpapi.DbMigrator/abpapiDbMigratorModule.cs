using abpapi.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace abpapi.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(abpapiEntityFrameworkCoreModule),
    typeof(abpapiApplicationContractsModule)
    )]
public class abpapiDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
