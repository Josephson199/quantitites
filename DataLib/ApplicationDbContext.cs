using Microsoft.EntityFrameworkCore;
using QuantitiesLib;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLib
{
    public class ApplicationDbContext : DbContext
    {
        private DbContextOptions<ApplicationDbContext> options;

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            this.options = options;
        }

        public DbSet<ConversionRatio> ConversionRatios { get; set; }
        public DbSet<Unit> Units { get; set; }
    }
}
