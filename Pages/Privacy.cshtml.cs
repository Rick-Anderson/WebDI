using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebDI.Pages
{
    public class PrivacyModel : PageModel
    {
        private readonly IService2 _myService2;
        private readonly IService1 _myService1;


        public PrivacyModel(IService1 myService1, IService2 myService2)
        {
    
            _myService2 = myService2;
            _myService1 = myService1;
        }

        public void OnGet()
        {
            _myService1.WriteMessage("1st service: Privacy OnGet");
            _myService2.WriteMessage("Privacy OnGet");
        }
    }
}