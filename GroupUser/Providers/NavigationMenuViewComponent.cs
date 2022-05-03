using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Web;

namespace GroupUser.Providers
{
    public class NavigationMenuViewComponent : ViewComponent
    {
        private readonly IAccountDataAccessService _accountdataAccess;

        public NavigationMenuViewComponent(IAccountDataAccessService dataAccessService)
        {
            _accountdataAccess = dataAccessService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var items = await _accountdataAccess.GetMenuItemsAsync(HttpContext.User);

            return View(items);
        }
    }
}