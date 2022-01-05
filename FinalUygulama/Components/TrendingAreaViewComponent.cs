using Microsoft.AspNetCore.Mvc;
using FinalUygulama.Data;
using System.Linq;
using System.Threading.Tasks;

namespace FinalUygulama.Components
{
    public class TrendingAreaViewComponent : ViewComponent
    {
        private readonly FinalUygulamaContext _context;
        public TrendingAreaViewComponent(FinalUygulamaContext context)
        {
            _context = context;            
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var sorgu = (from haber in _context.Haber
                         orderby haber.HaberID ascending
                         select haber).Take(3);

            return await Task.FromResult((IViewComponentResult)View("Default", sorgu));
        }
    }
}
