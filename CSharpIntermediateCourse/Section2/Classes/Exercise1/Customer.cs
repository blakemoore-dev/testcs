using System.Collections.Generic;

namespace Exercise1
{
    public class Customer
    {
        public int Id;
        public string Name;
        public List<Order> Orders;

        public Customer()
        {
            Orders = new List<Order>();
        }
        // for reference only. cluttered code***    public Customer(int id)
        // for reference only. cluttered code***        : this()
        // for reference only. cluttered code***    {
        // for reference only. cluttered code***        this.Id = id;
        // for reference only. cluttered code***    }
        // for reference only. cluttered code***    public Customer(int id, string name)
        // for reference only. cluttered code***        : this(id)
        // for reference only. cluttered code***    {
        // for reference only. cluttered code***        this.Id = id;
        // for reference only. cluttered code***        this.Name = name;
        // for reference only. cluttered code***    }
    }
}
