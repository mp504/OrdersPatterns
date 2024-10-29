using OrdersPatterns.DeliveryMethod;
using OrdersPatterns.Objects;
using OrdersPatterns.Orders;


public class Program
{

    public static void Main(string[] args)
    {
        Pizza pizza = new Pizza();
        PizzaBuilder pizzaBuilder = new PizzaBuilder(pizza);

        pizzaBuilder.PlanePizza();
        pizzaBuilder.AddCheese();
        
       Pizza pizza1 = pizza.clone();

       PizzaBuilder pizzaBuilder1 = new PizzaBuilder(pizza1);
        

        pizzaBuilder1.AddToppings();
        pizzaBuilder1.AddSauce();

        Console.WriteLine(pizza.ToString());
        Console.WriteLine(pizza1.ToString());
        Console.WriteLine();
            


        ITransport truck = DelieveryFactory.DelieveryMethod("plane");

        truck.deliever("House", "Restaurant", pizza);
        truck.deliever("House", "Restaurant", pizza1);

    }


}
