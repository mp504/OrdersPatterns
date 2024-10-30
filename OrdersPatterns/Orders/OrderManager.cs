using OrdersPatterns.DeliveryMethod;
using OrdersPatterns.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersPatterns.Orders
{
    public class OrderManager
    {
        private static OrderManager _instance;
        private static readonly object _locker = new object();


        private OrderManager() { }
        public static OrderManager Instance
        {
            get
            {
                lock (_locker)
                {
                    if (_instance == null)
                    {
                        _instance = new OrderManager();

                    }
                    return _instance;
                }
            }
        }


        public void deliever(string destination, string source, Pizza pizza, string transportation) 
        {
            // checking ...
            ITransport transport = DelieveryFactory.DelieveryMethod(transportation);

            transport.deliever(destination, source, pizza);

        }

    }
}
