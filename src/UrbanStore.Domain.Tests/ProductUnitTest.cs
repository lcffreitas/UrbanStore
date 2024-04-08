using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using UrbanStore.Domain.Model;
using UrbanStore.Domain.Validations;

namespace UrbanStore.Domain.Tests
{
    public class ProductUnitTest
    {
        // Name test
        [Fact]
        public void WhenName_IsEmptyOrNullDomain_ShouldReturnDomainException()
        {
            Action product = () => new Product("", "testDescription", 1, 1, "testImage", Guid.NewGuid(), Guid.NewGuid());

            product.Should().Throw<DomainExceptionValidation>()
            .WithMessage("Invalid name. Name is required!");

        }
        [Fact]
        public void WhenName_LenghtMoreThanDomain_ShouldReturnDomainException()
        {
            Action product = () => new Product("ProductNameButNowThisNameIsLongerThanThirtyCharacters", "testDescription", 1, 1, "testImage", Guid.NewGuid(), Guid.NewGuid());

            product.Should().Throw<DomainExceptionValidation>()
            .WithMessage("Too long name.");
        }
        // Description test
        [Fact]
        public void WhenDescription_IsEmptyOrNullDomain_ShouldReturnDomainException()
        {
            Action product = () => new Product("testName", "", 1, 1, "testImage", Guid.NewGuid(), Guid.NewGuid());

            product.Should().Throw<DomainExceptionValidation>()
            .WithMessage("Invalid description. Description is required!");
        }
        [Fact]
        public void WhenDescription_LenghtMoreThanDomain_ShouldReturnDomainException()
        {
            Action product = () => new Product("testName", "", 1, 1, "testImage", Guid.NewGuid(), Guid.NewGuid());

            product.Should().Throw<DomainExceptionValidation>()
            .WithMessage("Too long description.");
        }
        // Price test
        [Fact]
        public void WhenPrice_IsLessOrEqualZeroDomain_ShouldReturnDomainException()
        {
            Action product = () => new Product("testName", "testDescription", 0, 1, "testImage", Guid.NewGuid(), Guid.NewGuid());

            product.Should().Throw<DomainExceptionValidation>()
            .WithMessage("Invalid Price. Price must be greater than zero!");
        }
        // Stock test
        [Fact]
        public void WhenStock_IsLessThanZeroDomain_ShouldReturnDomainException()
        {
            Action product = () => new Product("testName", "testDescription", 1, -1, "testImage", Guid.NewGuid(), Guid.NewGuid());

            product.Should().Throw<DomainExceptionValidation>()
            .WithMessage("Invalid Stock. Stock must be greater than or equal to zero!");
        }
        // Image test
        [Fact]
        public void WhenImage_IsEmptyOrNullDomain_ShouldReturnDomainException()
        {
            Action product = () => new Product("testName", "testDescription", 1, 1, "", Guid.NewGuid(), Guid.NewGuid());

            product.Should().Throw<DomainExceptionValidation>()
            .WithMessage("Invalid Image. Image is required!");
        }
        // BrandId test
        [Fact]
        public void WhenBrandId_IsEmptyOrNullDomain_ShouldReturnDomainException()
        {
            Action product = () => new Product("testName", "testDescription", 1, 1, "testImage", Guid.Empty, Guid.NewGuid());

            product.Should().Throw<DomainExceptionValidation>()
            .WithMessage("Invalid Brand. Brand is required!");
        }
        // CategoryId test
        [Fact]
        public void WhenCategoryId_IsEmptyOrNullDomain_ShouldReturnDomainException()
        {
            Action product = () => new Product("testName", "testDescription", 1, 1, "testImage", Guid.NewGuid(), Guid.Empty);

            product.Should().Throw<DomainExceptionValidation>()
            .WithMessage("Invalid Category. Category is required!");
        }
    }
}
