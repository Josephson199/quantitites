using InterfacesLib;
using System;
using System.Collections.Generic;
using System.Text;
using QuantitiesLib;
using System.Linq;

namespace QuantitiesTests
{
    public class FakeConversionRatioRepository : IConversionRatioRepository
    {
        private List<ConversionRatio> _ratios = new List<ConversionRatio>();
        public FakeConversionRatioRepository()
        {
            Unit kg = new Unit("Kg");
            Unit gram = new Unit("g");
            _ratios.Add(new ConversionRatio { FromUnit = kg, ToUnit = gram, Ratio=1000M });
            Unit SEK = new Unit("SEK");
            Unit USD = new Unit("USD");
            _ratios.Add(new ConversionRatio { FromUnit = SEK, ToUnit = USD, Ratio = 0.125M });
        }
        public ConversionRatio Get(Unit from, Unit to)
        {
            return _ratios.SingleOrDefault(r => r.FromUnit.Name == from.Name
                && r.ToUnit.Name == to.Name);
        }
    }
}
