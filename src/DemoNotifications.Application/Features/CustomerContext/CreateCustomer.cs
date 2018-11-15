using MediatR;
using System;

namespace DemoNotifications.Application.Features.CustomerContext
{
    public class CreateCustomer : IRequest<Guid>
    {
        public string Name { get; }
        public string Email { get; }

        public CreateCustomer(string name, string email)
        {
            Name = name;
            Email = email;
        }
    }
}