using Banana_King.Models;
using Banana_King.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Banana_King.Pages
{
    [Authorize]
    public class BananaOperationsModel : PageModel
    {
        public bool IsAdmin => HttpContext.User.HasClaim("IsAdmin", bool.TrueString);

        public List<Banana>? Bananas = new();

        [BindProperty]
        public Banana? NewBanana { get; set; } = new();

        public void OnGet()
        {
            Bananas = BananaService.GetAll();
        }

        public IActionResult OnPost()
        {
            if (!IsAdmin) return Forbid();

            if (!ModelState.IsValid)
            {
                return Page();
            }

            BananaService.Add(NewBanana);
            return RedirectToAction("Get");
        }

        public IActionResult OnPostDelete(int id)
        {
            if (!IsAdmin) return Forbid();
            BananaService.Delete(id);
            return RedirectToAction("Get");
        }
    }
}
