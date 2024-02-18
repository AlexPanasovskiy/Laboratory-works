using Lab1Patterns.FactoryMethod.Domain;

namespace Lab1Patterns.FactoryMethod.Factories
{
    internal class FrenchFriesMenuFactory : MenuFactory
    {
        private readonly string _description;
        private readonly decimal _price;

        public FrenchFriesMenuFactory(string description, decimal price)
        {
            _description = description;
            _price = price;
        }

        public override IMenu GetMenu()
        {
            FrenchFriesMenu frenchFriesMenu = new(_price)
            {
                Description = _description
            };

            return frenchFriesMenu;
        }
    }
}
