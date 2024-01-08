using Banana_King.Models;
using Banana_King.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Banana_King.Pages
{
    public class IndexModel : PageModel
    {
        public List<Banana> bananas = new();

        [BindProperty]
        public Banana NewBanana { get; set; } = new();

        public void OnGet()
        {
            bananas = BananaService.GetAll();
        }
    }
}
