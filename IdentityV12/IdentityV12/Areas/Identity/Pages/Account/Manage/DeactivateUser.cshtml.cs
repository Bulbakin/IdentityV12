using IdentityV12.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using IdentityV12.Data;
using System.Collections.Generic;

namespace IdentityV12.Areas.Identity.Pages.Account.Manage
{
    public class DeactivateUser : PageModel
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
       

        public DeactivateUser(
           UserManager<ApplicationUser> userManager,
           SignInManager<ApplicationUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;          
        }

        public async Task<IActionResult> DeactivateAccount()
        {

            var user = await _userManager.FindByEmailAsync("11@11.11");
            var roleResult = await _userManager.RemoveFromRoleAsync(user, "Admin");
            
            var roleResult2 = await _userManager.RemoveFromRoleAsync(user, "Member");

            //await _signInManager.SignOutAsync();
            return Page();
        }
    }
}
