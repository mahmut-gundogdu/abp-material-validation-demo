using Xunit;

namespace BookStoreMaterial.EntityFrameworkCore;

[CollectionDefinition(BookStoreMaterialTestConsts.CollectionDefinitionName)]
public class BookStoreMaterialEntityFrameworkCoreCollection : ICollectionFixture<BookStoreMaterialEntityFrameworkCoreFixture>
{

}
