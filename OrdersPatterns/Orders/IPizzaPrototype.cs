using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersPatterns.Orders
{
    internal interface IPizzaPrototype
    {
        public Pizza clone();
    }
}
