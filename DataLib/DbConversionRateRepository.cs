using InterfacesLib;
using System;
using System.Collections.Generic;
using System.Text;
using QuantitiesLib;
using System.Linq;

namespace DataLib
{
    public class DbConversionRateRepository : IConversionRatioRepository
    {
        private ApplicationDbContext _context;
        public DbConversionRateRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public QuantitiesLib.ConversionRatio Get(Unit from, Unit to)
        {
            return _context
                .ConversionRatios
                .SingleOrDefault(r => r.FromUnit.Name == from.Name 
                    && r.ToUnit.Name == to.Name);
        }
    }
}
