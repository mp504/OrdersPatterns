using OrdersPatterns.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersPatterns.Objects
{

    public class Ship: ITransport
    {
        public string DestinationLocation { get; set; }
        public string SenderLocation { get; set; }

        public Ship()
        {
            

        }

        public void deliever(string destinationLocation, string senderLocation, Pizza pizza)
        {
            Console.WriteLine($"delievering {pizza.ToString()} From Location {senderLocation} To Location {destinationLocation}");
        }
    }
}
