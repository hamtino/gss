using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication1.models;

namespace WebApplication1.Data
{
    public class WebApplication1Context : DbContext
    {
        public WebApplication1Context (DbContextOptions<WebApplication1Context> options)
            : base(options)
        {
        }

        public DbSet<WebApplication1.models.cliente> cliente { get; set; }

        public DbSet<WebApplication1.models.alquiler> alquiler { get; set; }

        public DbSet<WebApplication1.models.carro> carro { get; set; }

        public DbSet<WebApplication1.models.pagos> pagos { get; set; }
    }
}
