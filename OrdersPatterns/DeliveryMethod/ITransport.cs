using OrdersPatterns.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersPatterns.Objects
{
    public interface ITransport
    {
        public void deliever(string destinationLocation, string senderLocation, Pizza pizza);
    }
}
