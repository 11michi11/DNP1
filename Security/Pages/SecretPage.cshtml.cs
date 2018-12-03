using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Security.Pages
{
    [Authorize]
    public class SecretPageModel : PageModel
    {

       
        public void OnGet()
        {

        }
    }
}