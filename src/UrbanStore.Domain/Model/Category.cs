using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UrbanStore.Domain.Entities;
using UrbanStore.Domain.Validations;

namespace UrbanStore.Domain.Model
{
    public sealed class Category : EntityBase
    {
        public string Description { get; private set; }
        public bool IsActive { get; private set; } = true;

        public Category(string description, bool isActive)
        {
            ValidateAndSetValues(description, isActive);
        }
        private void ValidateAndSetValues(string description, bool isActive)
        {
            ValidateDescription(description);

            Description = description;
            IsActive = isActive;
        }
        private void ValidateDescription(string description)
        {
            if (string.IsNullOrEmpty(description))
                DomainExceptionValidation.ExceptionHandler(true, "Invalid description. Description is required!");
            if (description.Length > 20)
                DomainExceptionValidation.ExceptionHandler(true, "Too long description.");
        }
    }
}
