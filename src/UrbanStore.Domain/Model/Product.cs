using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UrbanStore.Domain.Entities;
using UrbanStore.Domain.Validations;

namespace UrbanStore.Domain.Model
{
    public sealed class Product : EntityBase
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public decimal Price { get; private set; }
        public int Stock { get; private set; }
        public string Image { get; private set; }
        public bool IsActive { get; private set; } = true;
        public Guid BrandId { get; private set; }
        public Guid CategoryId { get; private set; }

        public Product(string name, string description, decimal price, int stock, string image, Guid brandId, Guid categoryId)
        {
            ValidateName(name);
            ValidateDescription(description);
            ValidatePrice(price);
            ValidateStock(stock);
            ValidateImage(image);
            ValidateBrandId(brandId);
            ValidateCategoryId(categoryId);

            Name = name;
            Description = description;
            Price = price;
            Stock = stock;
            Image = image;
            BrandId = brandId;
            CategoryId = categoryId;
        }
        private void ValidateName(string name)
        {
            if (string.IsNullOrEmpty(name))
                DomainExceptionValidation.ExceptionHandler(true, "Invalid name. Name is required!");
            if (name.Length > 30)
                DomainExceptionValidation.ExceptionHandler(true, "Too long name.");
        }
        private void ValidateDescription(string description)
        {
            if (string.IsNullOrEmpty(description))
                DomainExceptionValidation.ExceptionHandler(true, "Invalid description. Description is required!");
            if (description.Length > 500)
                DomainExceptionValidation.ExceptionHandler(true, "Too long description.");
        }
        private void ValidatePrice(decimal price)
        {
            DomainExceptionValidation.ExceptionHandler(price <= 0, "Invalid Price. Price must be greater than zero!");
        }
        private void ValidateStock(int stock)
        {
            DomainExceptionValidation.ExceptionHandler(stock < 0, "Invalid Stock. Stock must be greater than or equal to zero!");
        }
        private void ValidateImage(string image)
        {
            DomainExceptionValidation.ExceptionHandler(string.IsNullOrEmpty(image), "Invalid Image. Image is required!");
        }
        private void ValidateBrandId(Guid brandId)
        {
            DomainExceptionValidation.ExceptionHandler(brandId == null, "Invalid Brand. Brand is required!");
        }
        private void ValidateCategoryId(Guid categoryId)
        {
            DomainExceptionValidation.ExceptionHandler(categoryId == null, "Invalid Category. Category is required!");
        }
    }
}
