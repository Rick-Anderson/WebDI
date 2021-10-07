using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebDI.Pages
{
    public class PrivacyModel : PageModel
    {
        private readonly IService2 _myService;


        public PrivacyModel( IService2 myService)
        {
    
            _myService = myService;
        }

        public void OnGet()
        {
            _myService.WriteMessage("Privacy OnGet");
        }
    }
}