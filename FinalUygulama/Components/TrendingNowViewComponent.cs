using Microsoft.AspNetCore.Mvc;
using FinalUygulama.Data;
using System.Linq;
using System.Threading.Tasks;

namespace FinalUygulama.Components
{
    public class TrendingNowViewComponent : ViewComponent
    {
        private readonly FinalUygulamaContext _context;
        public TrendingNowViewComponent(FinalUygulamaContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var sorgu = (from haber in _context.Haber
                         orderby haber.HaberID descending
                         select haber);

            return await Task.FromResult((IViewComponentResult)View("Default", sorgu));
        }
    }
}
