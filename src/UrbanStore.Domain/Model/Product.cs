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
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public string Image { get; set; }
        public bool IsActive { get; set; } = true;
        public Guid BrandId { get; set; }
        public Guid CategoryId { get; set; }

        public Product(string name, string description, decimal price, int stock, string image, Guid brandId, Guid categoryId)
        {
            ValidateAndSetValues(name, description, price, stock, image, brandId, categoryId);
        }
        private void ValidateAndSetValues(string name, string description, decimal price, int stock, string image, Guid brandId, Guid categoryId)
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
            DomainExceptionValidation.ExceptionHandler(string.IsNullOrEmpty(name), "Invalid Name. Name is required!");
        }
        private void ValidateDescription(string description)
        {
            DomainExceptionValidation.ExceptionHandler(string.IsNullOrEmpty(description), "Invalid Description. Description is required!");
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
            DomainExceptionValidation.ExceptionHandler(brandId == Guid.Empty, "Invalid Brand. Brand is required!");
        }
        private void ValidateCategoryId(Guid categoryId)
        {
            DomainExceptionValidation.ExceptionHandler(categoryId == Guid.Empty, "Invalid Category. Category is required!");
        }
    }
}
