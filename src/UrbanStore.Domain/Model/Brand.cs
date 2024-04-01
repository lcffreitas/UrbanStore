using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UrbanStore.Domain.Entities;
using UrbanStore.Domain.Validations;

namespace UrbanStore.Domain.Model
{
    public sealed class Brand : EntityBase
    {
        public string Name { get; private set; }
        public string Image { get; private set; }

        public Brand(string name, string image)
        {
            ValidateAndSetValues(name, image);
        }
        private void ValidateAndSetValues(string name, string image)
        {
            ValidateName(name);
            ValidateImage(image);

            Name = name;
            Image = image;
        }
        public void ValidateName(string name)
        {
            if (string.IsNullOrEmpty(name))
                DomainExceptionValidation.ExceptionHandler(true, "Invalid name. Name is required!");
            if (name.Length > 30)
                DomainExceptionValidation.ExceptionHandler(true, "Too long name.");
        }
        public void ValidateImage(string image)
        {
            DomainExceptionValidation.ExceptionHandler(string.IsNullOrEmpty(image), "Invalid Image. Image is required!");
        }
    }
}