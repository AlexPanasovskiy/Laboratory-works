using Lab1Patterns.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Patterns
{
    public class Client
    {
        private readonly string _name;
        private IRestaurant? _restaurant;

        public Client(string name)
        {
            _name = name;
        }

        public void SetRestaurant(IRestaurant restaurant)
        {
            _restaurant = restaurant;
        }

        public void ChooseRestaurant()
        {
            if (_restaurant is null)
            {
                Console.WriteLine($"{_name} did not select the restaurant. Please select it again.");
                return;
            }

            Console.Write($"{_name}");
            _restaurant.Visit();
        }
    }
}
