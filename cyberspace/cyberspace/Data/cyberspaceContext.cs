using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using cyberspace.Models;

namespace cyberspace.Data
{
    public class cyberspaceContext : DbContext
    {
        public cyberspaceContext (DbContextOptions<cyberspaceContext> options)
            : base(options)
        {
        }

        public DbSet<cyberspace.Models.ArtPost> ArtPost { get; set; } = default!;
    }
}
