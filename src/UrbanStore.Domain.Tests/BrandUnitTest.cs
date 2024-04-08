using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UrbanStore.Domain.Model;
using UrbanStore.Domain.Validations;

namespace UrbanStore.Domain.Tests
{
    public class BrandUnitTest
    {
        // Name test
        [Fact]
        public void WhenName_IsEmptyOrNullDomain_ShouldReturnDomainException()
        {
            Action brand = () => new Brand("","TestImage");

            brand.Should().Throw<DomainExceptionValidation>()
            .WithMessage("Invalid name. Name is required!");

        }

        [Fact]
        public void WhenName_LenghtMoreThanDomain_ShouldReturnDomainException()
        {
            Action brand = () => new Brand("BrandTestNameButNowThisNameIsLongerThanThirdyCharacters","TestImage");

            brand.Should().Throw<DomainExceptionValidation>()
            .WithMessage("Too long name.");
        }
        // Image test
        [Fact]
        public void WhenImage_IsEmptyOrNullDomain_ShouldReturnDomainException()
        {
            Action brand = () => new Brand("TestName","");

            brand.Should().Throw<DomainExceptionValidation>()
            .WithMessage("Invalid Image. Image is required!");
        }

    }
}