using DemoNotifications.Domain.Models;
using System;
using System.Threading.Tasks;

namespace DemoNotifications.Domain.Contracts
{
    public interface ICustomerRepository
    {
        Task Save(Customer customer);
        Task<Customer> Find(Guid id);
    }
}