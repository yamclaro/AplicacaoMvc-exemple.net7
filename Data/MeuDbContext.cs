using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AplicacaoMvc_exemple.Models;

namespace AplicacaoMvc_exemple.Data
{
    public class MeuDbContext : DbContext
    {
        public MeuDbContext (DbContextOptions<MeuDbContext> options)
            : base(options)
        {
        }

        public DbSet<AplicacaoMvc_exemple.Models.Filme> Filme { get; set; } = default!;
    }
}
