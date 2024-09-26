using CounterApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CounterApp.Pages
{
    public class IndexModel : PageModel
    {
       // public Counter Counter { get; set; } = new Counter();

        public void OnGet()
        {
            Counter.Value=0;
            // Initialize or fetch the counter value if needed
        }

        public IActionResult OnPost()
        {
            // Increment the counter
            Counter.Value++;
            return Page();
        }
    }
}


 