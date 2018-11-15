using DemoNotifications.Domain.Models;
using System.Collections.Generic;

namespace DemoNotifications.Repository
{
    public class InMemoryDatabaseContext
    {
        public ISet<Customer> Customers { get; } = new HashSet<Customer>();
    }
}
