﻿using Microsoft.AspNetCore.Mvc;
using FinalUygulama.Models;


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
