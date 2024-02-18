using Lab1Patterns.FactoryMethod.Domain;

namespace Lab1Patterns.FactoryMethod.Factories
{
    internal class RollMenuFactory : MenuFactory
    {
        private readonly string _description;
        private readonly decimal _price;

        public RollMenuFactory(string description, decimal price)
        {
            _description = description;
            _price = price;
        }

        public override IMenu GetMenu()
        {
            RollMenu rollMenu = new(_price)
            {
                Description = _description
            };

            return rollMenu;
        }
    }
}
