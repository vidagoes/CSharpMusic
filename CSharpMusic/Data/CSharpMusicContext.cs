using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CSharpMusic.Models;

namespace CSharpMusic.Data
{
    public class CSharpMusicContext : DbContext
    {
        public CSharpMusicContext (DbContextOptions<CSharpMusicContext> options)
            : base(options)
        {
        }

        public DbSet<CSharpMusic.Models.Marca> Marca { get; set; } = default!;
        public DbSet<CSharpMusic.Models.Produto> Produto { get; set; } = default!;
    }
}
