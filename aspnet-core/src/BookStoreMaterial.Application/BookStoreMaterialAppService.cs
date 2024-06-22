using System;
using System.Collections.Generic;
using System.Text;
using BookStoreMaterial.Localization;
using Volo.Abp.Application.Services;

namespace BookStoreMaterial;

/* Inherit your application services from this class.
 */
public abstract class BookStoreMaterialAppService : ApplicationService
{
    protected BookStoreMaterialAppService()
    {
        LocalizationResource = typeof(BookStoreMaterialResource);
    }
}
