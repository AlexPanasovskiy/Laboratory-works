using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Patterns.Strategy
{
    internal class BurgerKing : IRestaurant
    {
        void IRestaurant.Visit()
        {
            Console.WriteLine(" visited the Burger King restaurant.");
        }
    }
}
