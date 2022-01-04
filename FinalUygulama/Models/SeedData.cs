using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using FinalUygulama.Data;
using System;
using System.Linq;

namespace FinalUygulama.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new FinalUygulamaContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<FinalUygulamaContext>>()))
            {
                // Look for any movies.
                if (context.Haber.Any())
                {
                    return;   // DB has been seeded
                }


                context.Haber.AddRange(
                                    new Haber
                                    {
                                        HaberBaslik = "Haber başlık",
                                        HaberAciklama = "Haber açıklama",
                                        HaberDetay = "Haber detay",
                                        Kategori="Spor",
                                        HaberTarihi = "28.12.2021"
                                    },
                                    new Haber
                                    {
                                        HaberBaslik = "Haber deneme",
                                        HaberAciklama = "Haber deneme",
                                        HaberDetay = "Haber deneme",
                                        Kategori="Gündem",
                                        HaberTarihi = "29.12.2021"
                                    }
                                );
                context.SaveChanges();
            }
        }
    }
}