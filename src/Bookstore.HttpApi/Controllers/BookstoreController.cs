using Bookstore.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Bookstore.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class BookstoreController : AbpController
    {
        protected BookstoreController()
        {
            LocalizationResource = typeof(BookstoreResource);
        }
    }
}