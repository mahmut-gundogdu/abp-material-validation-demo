using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace BookStoreMaterial.Data;

/* This is used if database provider does't define
 * IBookStoreMaterialDbSchemaMigrator implementation.
 */
public class NullBookStoreMaterialDbSchemaMigrator : IBookStoreMaterialDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
