using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace abpapi.Data;

/* This is used if database provider does't define
 * IabpapiDbSchemaMigrator implementation.
 */
public class NullabpapiDbSchemaMigrator : IabpapiDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
