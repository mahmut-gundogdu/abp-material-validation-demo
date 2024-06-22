using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace BookStoreMaterial;

[Dependency(ReplaceServices = true)]
public class BookStoreMaterialBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "BookStoreMaterial";
}
