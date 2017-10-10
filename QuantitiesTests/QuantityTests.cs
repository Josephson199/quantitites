using QuantitiesLib;
using System;
using Xunit;

namespace QuantitiesTests
{
    public class QuantityTests
    {
        [Fact]
        public void Kgtog()
        {
            Unit kg = new Unit("Kg");
            Unit gram = new Unit("g");
            Quantity quantity = new Quantity(kg, 117M);
            UnitConverter sut = new UnitConverter(new FakeConversionRatioRepository());
            Quantity result = sut.Convert(quantity, gram);
            Assert.Equal(117000M, result.Amount);
        }
        [Fact]
        public void USDtoSEK()
        {
            Unit usd = new Unit("USD");
            Unit sek = new Unit("SEK");
            Quantity quantity = new Quantity(sek, 100M);
            UnitConverter sut = new UnitConverter(new FakeConversionRatioRepository());
            Quantity result = sut.Convert(quantity, sek);
            Assert.Equal(15M, result.Amount);
        }
    }
}
