using DataLib;
using Microsoft.EntityFrameworkCore;
using QuantitiesLib;
using System;
using Xunit;

namespace QuantitiesIntegrationTests
{
    public class QuantityTests
    {
        [Fact]
        public void USDtoSEK()
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            optionsBuilder.UseInMemoryDatabase();
            var context = new ApplicationDbContext(optionsBuilder.Options);

            var USD = new Unit("USD");
            var SEK = new Unit("SEK");

            context.ConversionRatios.Add(
                new ConversionRatio
                {
                    FromUnit = USD,
                    ToUnit = SEK,
                    Ratio = 8.50M
                });

            context.SaveChanges();

            UnitConverter unitConverter = new UnitConverter(
                new DbConversionRateRepository(context)
            );

            var quantityInUSD = new Quantity(USD, 100M);
            var quantityInSEK = unitConverter.Convert(quantityInUSD, SEK);

            Assert.Equal(850M, quantityInSEK.Amount);
        }
    }
}
