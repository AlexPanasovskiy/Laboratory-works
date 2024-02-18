using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Patterns.FactoryMethod.Domain
{
    internal interface IMenu
    {
        string Name { get; }
        string Description { get; set; }
        decimal GetPrice();
    }
}
