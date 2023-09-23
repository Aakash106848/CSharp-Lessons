using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace NWindMVC.Models
{
    public class RepositoryCustomer
    {
        private NorthwindContext _context;
        public RepositoryCustomer(NorthwindContext context) 
        {
            _context = context;
        }
        public List<Customer> AllCustomers()
        {
            return _context.Customers.ToList();
        }
        public List<Customer> GetAllCustomerId()
        {
           List<Customer> result = new List<Customer>();

            foreach (Customer customer in _context.Customers)
            {

                result.Add(customer);

            }

            return result;
        }
        
        public Customer FindCustomerById(String id)
        {
            Customer customer = _context.Customers.Find(id);
            return customer;
        }
        public List<Order> GetCustomerOrders(string id)
        {
            List<Customer> orders = _context.Customers.Include(o => o.Orders).ToList();
            Customer customer = orders.FirstOrDefault(x => x.CustomerId == id);

            //Order order = _context.Orders.Find(id);
            return customer.Orders.ToList();
        }

    }
}
