using BookStoreMaterial.Samples;
using Xunit;

namespace BookStoreMaterial.EntityFrameworkCore.Domains;

[Collection(BookStoreMaterialTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<BookStoreMaterialEntityFrameworkCoreTestModule>
{

}
