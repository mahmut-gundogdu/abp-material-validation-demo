using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using BookStoreMaterial.Data;
using Volo.Abp.DependencyInjection;

namespace BookStoreMaterial.EntityFrameworkCore;

public class EntityFrameworkCoreBookStoreMaterialDbSchemaMigrator
    : IBookStoreMaterialDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreBookStoreMaterialDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolve the BookStoreMaterialDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<BookStoreMaterialDbContext>()
            .Database
            .MigrateAsync();
    }
}
