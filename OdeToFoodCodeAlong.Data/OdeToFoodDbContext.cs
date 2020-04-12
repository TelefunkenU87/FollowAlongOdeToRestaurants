using Microsoft.EntityFrameworkCore;
using OdeToFoodCodeAlong.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace OdeToFoodCodeAlong.Data
{
    public class OdeToFoodDbContext : DbContext
    {
        public OdeToFoodDbContext(DbContextOptions<OdeToFoodDbContext> options) : base(options)
        {

        }
        
        public DbSet<Restaurant> Restaurants { get; set; }
    }
}
