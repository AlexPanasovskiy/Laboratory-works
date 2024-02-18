using Lab1Patterns.FactoryMethod.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Patterns.FactoryMethod.Factories
{
    internal abstract class MenuFactory
    {
        public abstract IMenu GetMenu();
    }
}
