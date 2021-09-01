using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer();
            customer.Id = 1;
            customer.Name = "John";

            var order = new Order();
            customer.Orders.Add(order);

            System.Console.WriteLine(customer.Name);
            System.Console.WriteLine(customer.Id);
        }
    }
}
