using Microsoft.AspNetCore.Mvc;
using FinalUygulama.Data;
using System.Linq;
using System.Threading.Tasks;

namespace FinalUygulama.Components
{
    public class WhatsNewsViewComponent : ViewComponent
    {
        private readonly FinalUygulamaContext _context;
        public WhatsNewsViewComponent(FinalUygulamaContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var sorgu = (from haber in _context.Haber                        
                        select haber);

            return await Task.FromResult((IViewComponentResult)View("Default", sorgu));
        }
    }
}
