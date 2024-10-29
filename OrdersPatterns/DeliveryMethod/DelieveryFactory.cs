using OrdersPatterns.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersPatterns.DeliveryMethod
{
    public static class DelieveryFactory
    {

        public static ITransport DelieveryMethod(string delieveryMethod)
        {
            switch (delieveryMethod.ToLower())
            {
                case "truck":
                    return new Truck();
                    break;
                case "ship":
                    return new Ship();
                    break;
                case "plane":
                    return new Plane();
                    break;
                default:
                    throw new ArgumentException("Unsupported Delievery Type");

            }
        }
    }
}
