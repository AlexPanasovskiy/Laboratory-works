using Lab1Patterns.FactoryMethod.Domain;

namespace Lab1Patterns.FactoryMethod.Factories
{
    internal class CarbonatedDrinkMenuFactory : MenuFactory
    {
        private readonly string _description;
        private readonly decimal _price;

        public CarbonatedDrinkMenuFactory(string description, decimal price)
        {
            _description = description;
            _price = price;
        }

        public override IMenu GetMenu()
        {
            CarbonatedDrinkMenu carbonatedDrinkMenu = new(_price)
            {
                Description = _description
            };

            return carbonatedDrinkMenu;
        }
    }
}
