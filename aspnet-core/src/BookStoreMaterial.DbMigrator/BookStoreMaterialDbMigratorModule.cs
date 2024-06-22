using BookStoreMaterial.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace BookStoreMaterial.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(BookStoreMaterialEntityFrameworkCoreModule),
    typeof(BookStoreMaterialApplicationContractsModule)
    )]
public class BookStoreMaterialDbMigratorModule : AbpModule
{
}
