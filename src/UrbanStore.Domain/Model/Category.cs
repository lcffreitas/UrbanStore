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
            DomainExceptionValidation.ExceptionHandler(string.IsNullOrEmpty(description),"Invalid Description. Description is required!");
            DomainExceptionValidation.ExceptionHandler(description.Length > 20, "Too long description.");
        }
    }
}
