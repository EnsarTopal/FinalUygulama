using Microsoft.AspNetCore.Mvc;

namespace FinalUygulama.Components
{
    public class HeaderViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
