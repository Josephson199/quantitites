using System;

namespace QuantitiesLib
{
    public class Quantity
    {
        public int QuantityId { get; set; }
        public Quantity(Unit unit, decimal amount)
        {
            this.Unit = unit;
            this.Amount = amount;
        }

        public decimal Amount { get; set; }
        public Unit Unit { get; set; }

    }
}
