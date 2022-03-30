using System.Threading.Tasks;

namespace abpapi.Data;

public interface IabpapiDbSchemaMigrator
{
    Task MigrateAsync();
}
