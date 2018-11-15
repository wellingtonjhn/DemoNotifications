using FluentValidation;
using System;

namespace DemoNotifications.Domain.Models
{
    public class Customer : Entity
    {
        public string Name { get; }
        public string Email { get; }

        public Customer(string name, string email)
        {
            Id = Guid.NewGuid();
            Name = name;
            Email = email;

            Validate(this, new CustomerValidator());
        }
    }

    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(a => a.Email)
                .NotEmpty()
                .EmailAddress()
                .WithMessage("Invalid email");

            RuleFor(a => a.Name)
                .NotEmpty()
                .WithMessage("Name cannot be empty");
        }
    }
}