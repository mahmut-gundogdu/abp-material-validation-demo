using Volo.Abp.Modularity;

namespace BookStoreMaterial;

[DependsOn(
    typeof(BookStoreMaterialApplicationModule),
    typeof(BookStoreMaterialDomainTestModule)
)]
public class BookStoreMaterialApplicationTestModule : AbpModule
{

}
