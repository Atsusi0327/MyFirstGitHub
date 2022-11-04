using isRock.Web.Core.Razor;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LinebotDemo.Pages
{
    public class GetDemoModel : PageModel
    {
        public void OnGet()
        {
        }
        [PageMethod]
        public static String GotoCs (String txt)
        {
            return txt;
        }
    }
}
