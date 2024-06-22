using BookStoreMaterial.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace BookStoreMaterial.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class BookStoreMaterialController : AbpControllerBase
{
    protected BookStoreMaterialController()
    {
        LocalizationResource = typeof(BookStoreMaterialResource);
    }
}
