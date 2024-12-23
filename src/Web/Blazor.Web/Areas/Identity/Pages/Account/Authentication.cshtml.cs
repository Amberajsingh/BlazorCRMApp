using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Claims;
using Blazor.Web.Services;
using Microsoft.AspNetCore.Components;
using Shared.Lib.Dto;

namespace Blazor.Web.Areas.Identity.Pages.Account
{
    public class AuthenticationModel : PageModel
    {
        private IUserService _userService;
        public AuthenticationModel(IUserService userService)
        {
            _userService = userService;
        }

        [FromQuery(Name = "name")]
        public string Name { get; set; } = null!;

        [FromQuery(Name = "password")]
        public string Password { get; set; } = null!;

        public async Task<IActionResult> OnGet()
        {
            var loginModel = new LoginDto
            {
                UserName = Name,
                Password = Password,
                RememberMe = true
            };
            var result = await _userService.login(loginModel);
            if (result != null && result.IsSuccess)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.NameIdentifier,result.Data.UserId.ToString()),
                    new Claim(ClaimTypes.Name,result.Data.Name),
                    new Claim("Email", loginModel.UserName),
                    new Claim(ClaimTypes.Role,result.Data.Role)
                };

                var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var principal = new ClaimsPrincipal(identity);

                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);
                return Redirect("/");
            }
            return Redirect("/login");

        }
    }
}
