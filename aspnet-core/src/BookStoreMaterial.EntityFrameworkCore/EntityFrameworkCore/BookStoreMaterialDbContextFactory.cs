using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace BookStoreMaterial.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class BookStoreMaterialDbContextFactory : IDesignTimeDbContextFactory<BookStoreMaterialDbContext>
{
    public BookStoreMaterialDbContext CreateDbContext(string[] args)
    {
        BookStoreMaterialEfCoreEntityExtensionMappings.Configure();

        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<BookStoreMaterialDbContext>()
            .UseSqlite(configuration.GetConnectionString("Default"));

        return new BookStoreMaterialDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../BookStoreMaterial.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
