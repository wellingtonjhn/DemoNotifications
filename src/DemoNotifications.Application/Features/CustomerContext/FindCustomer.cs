using DemoNotifications.Domain.Models;
using MediatR;
using System;

namespace DemoNotifications.Application.Features.CustomerContext
{
    public class FindCustomer : IRequest<Customer>
    {
        public Guid Id { get; }

        public FindCustomer(Guid id)
        {
            Id = id;
        }
    }
}