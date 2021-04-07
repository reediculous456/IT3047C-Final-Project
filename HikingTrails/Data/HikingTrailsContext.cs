using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace HikingTrails.Data
{
    public class HikingTrailsContext : DbContext
    {
        public HikingTrailsContext (DbContextOptions<HikingTrailsContext> options)
            : base(options)
        {
        }

        public DbSet<HikingTrails.Models.User> User { get; set; }

        public DbSet<HikingTrails.Models.Trail> Trail { get; set; }
    }
}
