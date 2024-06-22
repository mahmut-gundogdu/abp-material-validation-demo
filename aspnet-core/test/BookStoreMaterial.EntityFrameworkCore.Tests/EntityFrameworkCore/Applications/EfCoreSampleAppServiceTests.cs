using BookStoreMaterial.Samples;
using Xunit;

namespace BookStoreMaterial.EntityFrameworkCore.Applications;

[Collection(BookStoreMaterialTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<BookStoreMaterialEntityFrameworkCoreTestModule>
{

}
