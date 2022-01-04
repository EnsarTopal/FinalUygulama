using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FinalUygulama.Models;

namespace FinalUygulama.Data
{
    public class FinalUygulamaContext : DbContext
    {
        public FinalUygulamaContext (DbContextOptions<FinalUygulamaContext> options)
            : base(options)
        {
        }

        public DbSet<Haber> Haber { get; set; }
    }
}
