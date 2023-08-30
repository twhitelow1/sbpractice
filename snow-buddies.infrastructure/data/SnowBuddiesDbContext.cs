using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using snow_buddies.domain.Entities;

namespace snow_buddies.infrastructure.data
{
    public class SnowBuddiesDbContext : DbContext
    {
        public SnowBuddiesDbContext(DbContextOptions<SnowBuddiesDbContext> options) : base(options)
        {
            
        }

        public DbSet<User> Users { get; set; }

    }
}