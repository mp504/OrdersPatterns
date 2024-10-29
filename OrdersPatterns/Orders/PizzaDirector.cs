using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersPatterns.Orders
{
    public class PizzaDirector
    {
        private IPizzaBuilder _builder;

        public PizzaDirector(IPizzaBuilder builder)
        {
            _builder = builder;
        }


        public void pizzaCheese()
        {
            _builder.PlanePizza();
            _builder.AddCheese();

        }

        public void pizzaCheeseSauce()
        {
            _builder.PlanePizza();
            _builder.AddCheese();
            _builder.AddSauce();

        }
        public void pizzaCheeseSauceToppings()
        {
            _builder.PlanePizza();
            _builder.AddCheese();
            _builder.AddSauce();
            _builder.AddToppings();

        }
    }
}
