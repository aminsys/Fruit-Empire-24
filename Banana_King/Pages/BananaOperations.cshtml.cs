using Banana_King.Models;
using Banana_King.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Banana_King.Pages
{
    public class BananaOperationsModel : PageModel
    {
        public List<Banana>? Bananas = new();

        [BindProperty]
        public Banana? NewBanana { get; set; } = new();

        public void OnGet()
        {
            Bananas = BananaService.GetAll();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            BananaService.Add(NewBanana);
            return RedirectToAction("Get");
        }

        public IActionResult OnPostDelete(int id)
        {
            BananaService.Delete(id);
            return RedirectToAction("Get");
        }
    }
}
