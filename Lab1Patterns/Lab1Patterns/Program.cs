using Lab1Patterns.FactoryMethod.Domain;
using Lab1Patterns.FactoryMethod.Factories;
using Lab1Patterns.Strategy;

namespace Lab1Patterns
{
    class Program
    {
        static void Main()
        {
            try
            {
                #region Strategy

                Console.Write("Enter your name: ");
                string? clientName = Console.ReadLine();
                Console.WriteLine();

                Client client = new Client(clientName);

                Console.WriteLine("Please select a fast food restaurant: \n\t1. KFC \n\t2. Burger King \n\t3. McDonalds\n");
                Console.Write("Your choice: ");
                int clientChoice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                switch (clientChoice)
                {
                    case 1:
                        client.SetRestaurant(new KFC());
                        client.ChooseRestaurant();
                        break;
                    case 2:
                        client.SetRestaurant(new BurgerKing());
                        client.ChooseRestaurant();
                        break;
                    case 3:
                        client.SetRestaurant(new McDonalds());
                        client.ChooseRestaurant();
                        break;
                    default:
                        client.ChooseRestaurant();
                        break;
                }
                #endregion

                #region FactoryMethod
                Console.WriteLine("\nSelect a product from the menu: \n\ta. Burger \n\tb. Roll \n\tc. Wings \n\td. French fries \n\te. Carbonated drink\n");
                Console.Write("Your choice: ");

                string choiceProduct = Console.ReadLine();

                MenuFactory menuFactory = GetFactory(choiceProduct);

                IMenu menu = menuFactory.GetMenu();

                Console.WriteLine($"\nThe product you have chosen: \n" +
                    $"\tName: \t\t{menu.Name}\n" +
                    $"\tDescription: \t{menu.Description}\n" +
                    $"\tPrice: \t\t{menu.GetPrice()}\n");
                #endregion
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("An unexpected error occurred.");
                Console.ForegroundColor = ConsoleColor.White;
            }

            Console.ReadLine();
        }

        private static MenuFactory GetFactory(string choiceProduct) =>
            choiceProduct.ToLower() switch
            {
                "a" => new BurgerMenuFactory("burger with cutlet and salad", 200),
                "b" => new RollMenuFactory("juicy chicken fillet in crispy breading", 250),
                "c" => new WingsMenuFactory("chicken wings in crispy breading with hot spices", 150),
                "d" => new FrenchFriesMenuFactory("large potato slices with a deliciously crispy crust", 95),
                "e" => new CarbonatedDrinkMenuFactory("favorite drink that goes perfectly with crispy chicken", 80),
                _ => null
            };
    }
}