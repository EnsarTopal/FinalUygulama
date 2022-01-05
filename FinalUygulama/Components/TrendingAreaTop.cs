using Microsoft.AspNetCore.Mvc;
using FinalUygulama.Data;
using System.Linq;
using System.Threading.Tasks;

namespace FinalUygulama.Components
{
    public class TrendingAreaTop : ViewComponent
    {
        private readonly FinalUygulamaContext _context;
        public TrendingAreaTop(FinalUygulamaContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var sorgu = (from haber in _context.Haber
                         orderby haber.HaberID descending
                         select haber).Take(1);

            return await Task.FromResult((IViewComponentResult)View("Default", sorgu));
        }
    }
}
