using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Patterns.Strategy
{
    internal class McDonalds : IRestaurant
    {
        void IRestaurant.Visit()
        {
            Console.WriteLine(" visited the McDonalds restaurant.");
        }
    }
}
