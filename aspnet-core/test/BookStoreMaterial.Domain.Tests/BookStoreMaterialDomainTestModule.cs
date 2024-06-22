using Volo.Abp.Modularity;

namespace BookStoreMaterial;

[DependsOn(
    typeof(BookStoreMaterialDomainModule),
    typeof(BookStoreMaterialTestBaseModule)
)]
public class BookStoreMaterialDomainTestModule : AbpModule
{

}
