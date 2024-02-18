using Lab1Patterns.FactoryMethod.Domain;

namespace Lab1Patterns.FactoryMethod.Factories
{
    internal class WingsMenuFactory : MenuFactory
    {
        private readonly string _description;
        private readonly decimal _price;

        public WingsMenuFactory(string description, decimal price)
        {
            _description = description;
            _price = price;
        }

        public override IMenu GetMenu()
        {
            WingsMenu wingsMenu = new(_price)
            {
                Description = _description
            };

            return wingsMenu;
        }
    }
}
