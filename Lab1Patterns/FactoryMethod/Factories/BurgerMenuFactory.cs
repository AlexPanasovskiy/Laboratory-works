using Lab1Patterns.FactoryMethod.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Patterns.FactoryMethod.Factories
{
    internal class BurgerMenuFactory : MenuFactory
    {
        private readonly string _description;
        private readonly decimal _price;

        public BurgerMenuFactory(string description, decimal price)
        {
            _description = description;
            _price = price; 
        }

        public override IMenu GetMenu()
        {
            BurgerMenu burgerMenu = new(_price)
            {
                Description = _description
            };

            return burgerMenu;
        }
    }
}
