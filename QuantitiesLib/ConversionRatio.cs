using System;
using System.Collections.Generic;
using System.Text;

namespace QuantitiesLib
{
    public class ConversionRatio
    {
        public int ConversionRatioId { get; set; }
        public Unit FromUnit { get; set; }
        public Unit ToUnit { get; set; }
        public decimal Ratio { get; set; }
    }
}
