using QuantitiesLib;
using System;

namespace InterfacesLib
{
    public interface IConversionRatioRepository
    {
        ConversionRatio Get(Unit from, Unit to);
    }
}
