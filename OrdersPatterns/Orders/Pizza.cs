using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersPatterns.Orders
{
    public class Pizza: IPizzaPrototype
    {
        public string PlanePizza {  get; set; }
        public string Cheese {  get; set; }
        public string Sauce {  get; set; }
        public string Toppings {  get; set; }

        public Pizza() { }
        public Pizza(Pizza other)
        {
            PlanePizza = other.PlanePizza;
            Cheese = other.Cheese;
            Sauce = other.Sauce;
            Toppings = other.Toppings;
        }

        public override string ToString()
        {
            return $"The Order is {PlanePizza}, {Cheese}, {Sauce}, {Toppings}";
        }

        public Pizza clone()
        {

            return new Pizza(this);
        }
    }
}
