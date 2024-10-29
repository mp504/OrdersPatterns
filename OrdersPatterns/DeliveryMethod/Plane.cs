using OrdersPatterns.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersPatterns.Objects
{
    public class Plane: ITransport
    {
        public string DestenationLocation { get; set; }
        public string SenderLocation { get; set; }

        public Plane()
        {
           
        }

        public void deliever(string destinationLocation, string senderLocation ,Pizza pizza)
        {
            Console.WriteLine($"delievering {pizza.ToString()} From Location {SenderLocation} To Location {DestenationLocation}");
        }


    }
}
