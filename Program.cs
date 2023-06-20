using System;

namespace Exercise_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AirConditionerFactory f = new AirConditionerFactory();
            Order order = new Order();
            Clients c = new Clients("Petko", "Petkov", "bul. Marica 3", order, 100);
        }
    }
}
