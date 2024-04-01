using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentAssertions;
using UrbanStore.Domain.Model;
using UrbanStore.Domain.Validations;

namespace UrbanStore.Domain.Tests
{
    public class BrandUnitTest
    {
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

    }
}