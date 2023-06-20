using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_1
{
    public class Clients : AirConditionerFactory
    {
        public string ClientName { get; set; }
        public string ClientLastName { get; set; }
        public string Address { get; set; }
        public Order Order { get; set; }
        public int TotalSumOfOrders { get; set; }

        public Clients(string name, string lastName, string address, Order order, int totalSumOfOrders) 
        { 
            ClientName = name;
            ClientLastName = lastName;
            Address = address;
            Order = order;
            TotalSumOfOrders = totalSumOfOrders;

        }
    }
}
