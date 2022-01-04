using System.Linq;
using FinalUygulama.Data;

namespace FinalUygulama.Models
{
    public class EFHaberRepository : IHaberRepository
    {
        private FinalUygulamaContext context;

        public EFHaberRepository(FinalUygulamaContext ctx)
        {
            context = ctx;
        }

        public IQueryable<Haber> Habers => context.Haber;

        public void CreateHaber(Haber h)
        {
            context.Add(h);
            context.SaveChanges();
        }

        public void DeleteHaber(Haber h)
        {
            context.Remove(h);
            context.SaveChanges();
        }

        public void SaveHaber(Haber h)
        {
            context.SaveChanges();
        }
    }
}
