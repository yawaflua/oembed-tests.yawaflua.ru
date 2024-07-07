using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace OembedTests.MVC
{
    public class PayModel : PageModel
    {
        public string username { get; set; }
        public void OnGet(string username)
        {
            this.username = username;
        }
    }
}
