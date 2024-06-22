using System.Threading.Tasks;

namespace BookStoreMaterial.Data;

public interface IBookStoreMaterialDbSchemaMigrator
{
    Task MigrateAsync();
}
