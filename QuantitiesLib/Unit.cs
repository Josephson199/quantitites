using System;
using System.Collections.Generic;
using System.Text;

namespace QuantitiesLib
{
    public class Unit
    {
        public int UnitId { get; set; }
        public Unit()
        {

        }
        public Unit(string name)
        {
            this.Name = name;
        }
        public string Name { get; set; }
    }
}
