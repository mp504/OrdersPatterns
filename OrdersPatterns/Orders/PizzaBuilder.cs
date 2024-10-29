using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersPatterns.Orders
{
    public class PizzaBuilder: IPizzaBuilder
    {
        private Pizza _pizza ;


        public PizzaBuilder(Pizza pizza)
        {
            _pizza = pizza;
        }

        public void PlanePizza()
        {
            _pizza.PlanePizza = "Plane pizza ";
        }

        public void AddCheese()
        {
            _pizza.Cheese = "Cheese";

        }

        public void AddSauce()
        {
            _pizza.Sauce = "Sauce";

        }

        public void AddToppings()
        {
            _pizza.Toppings = "Toppings";
        }

        
    }
}
