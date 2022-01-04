using Microsoft.AspNetCore.Mvc;
using FinalUygulama.Models;

namespace FinalUygulama.Components
{
    public class FooterViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
