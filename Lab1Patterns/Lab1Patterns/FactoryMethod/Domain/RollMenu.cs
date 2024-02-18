using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Patterns.FactoryMethod.Domain
{
    internal class RollMenu : IMenu
    {
        private readonly string _name;
        private readonly decimal _price;

        public RollMenu(decimal price)
        {
            _name = "Roll";
            _price = price;
        }

        public string Name => _name;

        public string Description { get; set; }

        public decimal GetPrice() => _price;
    }
}
