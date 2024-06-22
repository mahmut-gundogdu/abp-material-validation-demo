using Volo.Abp.Modularity;

namespace BookStoreMaterial;

public abstract class BookStoreMaterialApplicationTestBase<TStartupModule> : BookStoreMaterialTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
