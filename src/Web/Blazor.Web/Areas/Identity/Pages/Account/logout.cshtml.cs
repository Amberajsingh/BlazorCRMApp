using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Claims;
using System.Xml.Linq;
using Microsoft.AspNetCore.Components;

namespace Blazor.Web.Areas.Identity.Pages.Account
{
    public class logoutModel : PageModel
    {
        public async Task<IActionResult> OnGet()
        {
            if (HttpContext != null && HttpContext.User.Identity.IsAuthenticated)
            {
                await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            }
            return Redirect("/");
        }
    }
}
