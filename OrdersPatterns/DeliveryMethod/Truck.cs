using OrdersPatterns.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersPatterns.Objects
{
    public class Truck: ITransport
    {
        public string DestenationLocation {  get; set; }
        public string SenderLocation {  get; set; }


        public Truck() 
        {
           

        }

        public void deliever(string destinationLocation, string senderLocation, Pizza pizza)
        {
            Console.WriteLine($"delievering {pizza.ToString()} From Location {senderLocation} To Location {destinationLocation} truck");
        }


    }
}
