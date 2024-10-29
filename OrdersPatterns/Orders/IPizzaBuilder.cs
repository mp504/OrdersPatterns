using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersPatterns.Orders
{
    public interface IPizzaBuilder
    {
        void PlanePizza();
        void AddCheese();
        void AddSauce();
        void AddToppings();
    }

}
