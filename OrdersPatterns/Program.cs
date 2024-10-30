using OrdersPatterns.DeliveryMethod;
using OrdersPatterns.Objects;
using OrdersPatterns.Orders;
using System.Security.Cryptography.X509Certificates;


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



        OrderManager orderManager = OrderManager.Instance;

       
        OrderManager orderManager1 = OrderManager.Instance;
        orderManager.deliever("alrimal", "albaik", pizza, "truck");
        orderManager1.deliever("house", "mac", pizza1, "truck");
    }


}
