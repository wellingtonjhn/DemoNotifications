using FluentValidation;
using FluentValidation.Results;
using System;
using System.Linq;

namespace DemoNotifications.Domain.Models
{
    public abstract class Entity
    {
        public Guid Id { get; protected set; }
        public bool Invalid => ValidationResult.Errors.Any();
        public bool Valid => !Invalid;
        public ValidationResult ValidationResult { get; private set; }

        public bool Validate<TModel>(TModel model, AbstractValidator<TModel> validator)
        {
            ValidationResult = validator.Validate(model);

            return ValidationResult.IsValid;
        }
    }
}