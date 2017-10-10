using InterfacesLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuantitiesLib
{
    public class UnitConverter
    {
        private IConversionRatioRepository _rep;
        public UnitConverter(IConversionRatioRepository ratioRep)
        {
            _rep = ratioRep;
        }
        public Quantity Convert(Quantity from, Unit toUnit)
        {
            var conversionRatio = _rep.Get(from.Unit, toUnit);
            return new Quantity(toUnit, conversionRatio.Ratio * from.Amount);
        }
    }
}
