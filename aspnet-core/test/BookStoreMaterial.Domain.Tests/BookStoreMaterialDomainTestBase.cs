using Volo.Abp.Modularity;

namespace BookStoreMaterial;

/* Inherit from this class for your domain layer tests. */
public abstract class BookStoreMaterialDomainTestBase<TStartupModule> : BookStoreMaterialTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
